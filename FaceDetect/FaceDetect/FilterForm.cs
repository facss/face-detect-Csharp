using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu;
using Emgu.Util;
using AForge.Imaging.Filters;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace FaceDetect
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }
        private string curFileName;
        private System.Drawing.Bitmap curBitmap;
        Mat image;
        private void openbtn_Click(object sender, EventArgs e)
        {
        }

        private void BLbutton_Click(object sender, EventArgs e)
        {
            if (curBitmap != null)
            {
                double distantR = 0.06;
                //Bitmap newImage = new Bitmap(curBitmap.Width + 18, curBitmap.Height + 18);
                Matrix padImage = new Matrix(curBitmap.Height + 18, curBitmap.Width + 18);
                Matrix meshGrid = new Matrix(19, 19);
                Matrix weights = new Matrix(19, 19);

                Matrix gMatrix = new Matrix(curBitmap.Height, curBitmap.Width);
                Matrix imageBlock = new Matrix(19, 19);
                Rectangle rect = new Rectangle(0, 0, curBitmap.Width, curBitmap.Height);
                //Rectangle newRect=new Rectangle(0,0,newImage.Width,newImage.Height);
                System.Drawing.Imaging.BitmapData bmpData = curBitmap.LockBits(rect,
                    System.Drawing.Imaging.ImageLockMode.ReadWrite, curBitmap.PixelFormat);
                //System.Drawing.Imaging.BitmapData newData = newImage.LockBits(newRect,
                //    System.Drawing.Imaging.ImageLockMode.ReadWrite, newImage.PixelFormat);

                unsafe
                {
                    byte* ptr = (byte*)(bmpData.Scan0);

                    for (int i = 0; i < bmpData.Height; i++)
                    {
                        for (int j = 0; j < bmpData.Width; j++)
                        {
                            gMatrix[i, j] = (0.229 * ptr[2] + 0.587 * ptr[1] + 0.114 * ptr[0]) / 241;
                            ptr += 3;
                        }
                        ptr += bmpData.Stride - bmpData.Width * 3;
                    }

                    padImage = gMatrix.PadMatrix(9, 9);

                    ptr = (byte*)(bmpData.Scan0);

                    for (int i = 9; i < bmpData.Height + 9; i++)
                    {
                        for (int j = 9; j < bmpData.Width + 9; j++)
                        {
                            for (int k = 0; k < imageBlock.Row; k++)
                            {
                                for (int l = 0; l < imageBlock.Col; l++)
                                {
                                    imageBlock[k, l] = padImage[i - 9 + k, j - 9 + l];
                                    meshGrid[k, l] = Math.Exp(-(imageBlock[k, l] - padImage[i, j]) *
                                        (imageBlock[k, l] - imageBlock[9, 9]) / (distantR * distantR));
                                }
                            }
                            weights = imageBlock * meshGrid;
                            gMatrix[i - 9, j - 9] = (weights.SumOfMatrix()) / (meshGrid.SumOfMatrix());
                            ptr[0] = ptr[1] = ptr[2] = (byte)(gMatrix[i - 9, j - 9] * 255);
                            ptr += 3;
                        }
                        ptr += bmpData.Stride - bmpData.Width * 3;
                    }
                    curBitmap.UnlockBits(bmpData);

                    Invalidate();
                }
            }
        }

        private void BLbutton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (curFileName != null)
            {
                g.DrawImage(curBitmap, 100, 16, curBitmap.Width, curBitmap.Height);
            }
        }

        private void ToGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Mat im = new Mat();
            CvInvoke.CvtColor(image,im,Emgu.CV.CvEnum.ColorConversion.Bgr2Gray, 1);
            resultpic.Image = im;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.Filter = "All Image Files | *.bmp; *.gif; *.png; *.jpg; *.ico; *.tif; *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf|" +
                "Bitmap(*.bmp; *.jpg; *.png;...) | *.bmp; *.jpg; *.png; *.gif; *.tif; *.ico|" +
                "Vector Diagram(*.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf) | *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf";
            opnDlg.Title = "打开图像文件";
            opnDlg.ShowHelp = true;
            if (opnDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = opnDlg.FileName;
                try
                {
                    curBitmap = (Bitmap)Image.FromFile(curFileName);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Invalidate();
            originalpic.Image = curBitmap;
            image= CvInvoke.Imread(curFileName, LoadImageType.AnyColor);//Read the files as an 8-bit Bgr image 
        }
        private Threshold filter = new Threshold();
        private byte threshold = 128;
        private void GaussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subwindows sub = new Subwindows();
            sub.ShowDialog();

                Mat dst = new Mat();
                //高斯滤波
                //src:输入图像
                //dst:输出图像
                //Size(5,5)模板大小，为奇数
                //x方向方差
                //Y方向方差
                Size size = new Size(sub.size, sub.size);
                CvInvoke.GaussianBlur(image, dst, size, 0, 0);
               this.resultpic.Image = dst;
        }
        Mat dst = new Mat();//空白输出图像
        private void BLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subwindows sub = new Subwindows();
            sub.ShowDialog();

            CvInvoke.BilateralFilter(image, dst, sub.size, 25 * 2.0, 25 / 2.0);
            resultpic.Image =dst;
        }

        private void threshingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat im = new Mat();
            CvInvoke.CvtColor(image, im, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray, 1);
            Mat imbw = new Mat();
            CvInvoke.Threshold(im, imbw, 0, 255, Emgu.CV.CvEnum.ThresholdType.Binary|Emgu.CV.CvEnum.ThresholdType.Otsu);
            resultpic.Image = imbw;
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileAssistance.SaveImg(this.resultpic );
        }
    }
}
