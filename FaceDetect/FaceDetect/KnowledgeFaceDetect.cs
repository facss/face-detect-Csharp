using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Imaging.Filters;
using Accord.Vision;
using Accord;
using System.Threading;
using System.Diagnostics;

namespace FaceDetect
{
    public partial class KnowledgeFaceDetect : Form
    {
        public KnowledgeFaceDetect()
        {
            InitializeComponent();
        }
        bool _forceVisible = true;
        string filepath = string.Empty;
        public bool bvis = false;
        Bitmap originalimg;
        Label labTitle = new Label();
        Stopwatch sw = new Stopwatch();//计时器

        private void OpenFileButton_Click(object sender, EventArgs e)
        {         try
            {
                filepath = FileAssistance.OpenFile();
                FilePath.Text = filepath;
                Original.Image = Image.FromFile(filepath, true);
                originalimg = (Bitmap)Image.FromFile(filepath, true);
                label2.Text = "原图";
                
            }
            catch
            {
                MessageBox.Show("请导入文件！");
            }
        }

        private void FaceDetect_Click(object sender, EventArgs e)
        {
            if (!sw.IsRunning)
            {
                sw.Reset();
                sw.Start();
            }
            Process.Image= Image.FromFile(filepath, true);
            if (bvis == false)
                bvis = true;
            else
                bvis = false;
            GridOn.GridPaint(bvis, (Bitmap)Process.Image);//绘制网格线
            label3.Text = "网络线划分";
            try {
                Bitmap gray_img = Knowledge.ToGray(originalimg);//将原图转化为灰度图
                Bitmap BW = Knowledge.Thresholding(gray_img);//利用大津法进行二值化处理
                Bitmap detectimg = Knowledge.FaceDetection(BW);//最后利用算法进行检测
                AForge.Imaging.BlobCounter blobCounter = new AForge.Imaging.BlobCounter(detectimg);
                Rectangle[] rects = blobCounter.GetObjectsRectangles();
                Rectangle[] outputrects = new Rectangle[rects.Count()];
                ////object count
                int minx = 100; int tmp = 0;
                int rectsCount = rects.Count();
                List<decimal> test = new List<decimal>();
                for (int c = 0; c < rectsCount; c++)
                {
                    int p = rects[c].Width * rects[c].Height;
                    decimal bl = (decimal)rects[c].Height / (decimal)rects[c].Width;

                    int maxx = (gray_img.Width * gray_img.Height) / 2;
                    if (p > minx && (double)bl < 1.8 && (double)bl > 0.8 && p < maxx)
                    {
                        test.Add(bl);
                        outputrects[tmp++] = rects[c];
                    }
                }
                RectanglesMarker marker = new RectanglesMarker(outputrects, Color.Red);
                this.Detected.Image = marker.Apply((Bitmap)Image.FromFile(filepath, true));
                label4.Text = "检测结果";
                ShowMsg("检测结束！");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid usage!");
            }

           if( sw.IsRunning)
            {
                sw.Stop();
                
                string str = sw.Elapsed.ToString();
                timeElpse.Text = string.Empty;
                timeElpse.Text = "运行时间：" + str;
            }         
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filepath = FileAssistance.OpenFile();
            FilePath.Text = filepath;
            Original.Image = Image.FromFile(filepath, true);
            originalimg = (Bitmap)Original.Image;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileAssistance.SaveImg(this.Original);
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileAssistance.SaveImg(this.Process);
        }
        private void detectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileAssistance.SaveImg(this.Detected);
        }
        void ShowMsg(string msg)
        {
            new Thread(() =>
            {
                TimeSpan ts = new TimeSpan(0, 0, 0, 1);
                for (int i = 30; i > 0; i--)
                {
                    // 如果强制不显示，则终止循环显示
                    if (_forceVisible)
                    {
                        _forceVisible = false;
                        return;
                    }
                    OperationLabelMethod(labTitle, msg + "\r\n" + i + "秒后关闭");
                    Thread.Sleep(ts);
                }
                OperationLabelMethod(labTitle, null);
            }).Start();
            //MessageBox.Show(msg);
        }
        delegate void OperationLabel(Label lab, string txt);
        /// <summary>
        /// 通过委托方法设置或隐藏Label
        /// </summary>
        /// <param name="lab"></param>
        /// <param name="txt"></param>
        void OperationLabelMethod(Label lab, string txt)
        {
            if (lab.InvokeRequired)
            {
                OperationLabel method = OperationLabelMethod;
                if (!this.IsDisposed)// 点保存，然后马上关闭窗体时，会导致this变成null了，所以这里要判断
                    Invoke(method, lab, txt);
            }
            else
            {
                if (string.IsNullOrEmpty(txt))
                {
                    lab.Text = string.Empty;
                    lab.Visible = false;
                }
                else
                {
                    lab.Text = txt;
                    lab.Visible = true;
                }
            }
        }
    }
}
