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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Cuda;
using System.Diagnostics;

namespace FaceDetect
{
    public partial class ViolaJonesFaceDetect : Form
    {
        public ViolaJonesFaceDetect()
        {
            InitializeComponent();
        }
        string filepath = string.Empty;
        public bool bvis = false;
        Bitmap originalimg;
        Stopwatch sw = new Stopwatch();
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                filepath = FileAssistance.OpenFile();
                FilePath.Text = filepath;
                Original.Image = Image.FromFile(filepath, true);
                originalimg = (Bitmap)Image.FromFile(filepath, true);
            }
            catch
            {
                MessageBox.Show("请导入文件！");
            }
        }

        private void FaceDetect_Click(object sender, EventArgs e)
        {
            sw.Reset();
            sw.Start();
            string str = filepath;//不能用中文路径，超级蛋疼！调了一小时以上才发现的
            Mat image = CvInvoke.Imread(str, LoadImageType.AnyColor);//Read the files as an 8-bit Bgr image  
            //Mat dst=new Mat();//空白输出图像
            long detectionTime;
            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();
            //双边滤波
            //src:输入图像
            //dst:输出图像
            //d:滤波模板半径
            //sigmaclor:颜色空间标准差
            //sigmaspace:坐标空间标准差
            //CvInvoke.BilateralFilter(image, dst, 15, 25 * 2.0, 25 / 2.0);

            //The cuda cascade classifier doesn't seem to be able to load "haarcascade_frontalface_default.xml" file in this release
            //disabling CUDA module for now
            bool tryUseCuda = false;
            bool tryUseOpenCL = true;


            Improved.Detect(
              image, "haarcascade_frontalface_default.xml",
              faces,
              tryUseCuda,
              tryUseOpenCL,
              out detectionTime);

            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 2);
            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(image, eye, new Bgr(Color.Blue).MCvScalar, 2);
            this.Detected.Image = image;
            
            sw.Stop();
           
            timeElpsed.Text = string.Empty;
            timeElpsed.Text = "运行时间：" + sw.Elapsed.ToString();
        }

        private void oriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileAssistance.SaveImg(this.Original);
        }

        private void detToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileAssistance.SaveImg(this.Detected);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                filepath = FileAssistance.OpenFile();
                FilePath.Text = filepath;
                Original.Image = Image.FromFile(filepath, true);
                originalimg = (Bitmap)Image.FromFile(filepath, true);
            }
            catch
            {
                MessageBox.Show("请导入文件！");
            }
        }
    }
}
