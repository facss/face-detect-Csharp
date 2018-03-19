using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Imaging.Filters;
using System.Diagnostics;

namespace FaceDetect
{
    public partial class SkinColorFaceDetect : Form
    {
        string filepath = string.Empty;
        public bool bvis = false;
        Bitmap originalimg;
        Stopwatch sw = new Stopwatch();
        public SkinColorFaceDetect()
        {
            InitializeComponent();
        }

        private void skinopenfile_Click(object sender, EventArgs e)
        {try
            {
                filepath = FileAssistance.OpenFile();
                skinfilepath.Text = filepath;
                Original.Image = Image.FromFile(filepath, true);
                originalimg = (Bitmap)Image.FromFile(filepath, true);
            }
            catch
            {
                MessageBox.Show("请导入文件！");
            }
        }

        private void skindetect_Click(object sender, EventArgs e)
        {
            sw.Reset();
            sw.Start();
            Bitmap img = (Bitmap)Image.FromFile(filepath, true);//将原图进行导入并进行格式转化
            Bitmap normalizedImg = YCbCr.Lightingconpensate(img);
            Bitmap skin = YCbCr.SkinDetect1(normalizedImg);//肤色检测
            Bitmap BWskin = Knowledge.Thresholding(skin);//图片二值化
            Bitmap gray_img = Knowledge.ToGray(img);
            AForge.Imaging.SusanCornersDetector scd = new AForge.Imaging.SusanCornersDetector();//susan检测子
                                                                                                //检测人眼部分

            AForge.Imaging.BlobCounter blobCounter = new AForge.Imaging.BlobCounter(BWskin);//对图片进行检测联通区域
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            Rectangle[] outputrects = new Rectangle[rects.Count()];
            ////object count
            int minx = 150; int tmp = 0;
            int rectsCount = rects.Count();
            List<decimal> test = new List<decimal>();
            for (int c = 0; c < rectsCount; c++)
            {
                int p = rects[c].Width * rects[c].Height;
                decimal bl = (decimal)rects[c].Height / (decimal)rects[c].Width;

                int maxx = (img.Width * img.Height) / 2;
                if (p > minx && (double)bl < 1.8 && (double)bl > 0.9 && p < maxx)
                {
                    test.Add(bl);
                    outputrects[tmp++] = rects[c];
                }
            }
            RectanglesMarker marker = new RectanglesMarker(outputrects, Color.Red);
            Process2.Image = img;
            Detected.Image= marker.Apply((Bitmap)Image.FromFile(filepath, true));
            sw.Stop();
            string str = sw.Elapsed.ToString();
            timeElpsed.Text = string.Empty;
            timeElpsed.Text = "运行时间：" + str;

        }

        private void normalieddetect_Click(object sender, EventArgs e)
        {
            Bitmap normalizedImg = YCbCr.Lightingconpensate((Bitmap)Image.FromFile(filepath));//利用图像基准白矫正
            Process1.Image = normalizedImg;//显示结果1

        }

        private void process1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileAssistance.SaveImg(this.Process1);
        }

        private void process2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileAssistance.SaveImg(this.Process2);
        }

        private void resultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileAssistance.SaveImg(this.Detected);
        }

        private void OriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileAssistance.SaveImg(this.Original);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            filepath = FileAssistance.OpenFile();
            skinfilepath.Text = filepath;
            Original.Image = Image.FromFile(filepath, true);
            originalimg = (Bitmap)Image.FromFile(filepath, true); }
            catch
            {
                MessageBox.Show("请导入文件!");
            }
        }
    }
}
