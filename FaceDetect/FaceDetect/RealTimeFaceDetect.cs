using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using Accord.Vision.Detection;
using Accord.Vision.Detection.Cascades;
using System.Timers;
using Accord.Imaging.Filters;
using Emgu.CV;


namespace FaceDetect
{
    public partial class RealTimeFaceDetect : Form
    {
        public RealTimeFaceDetect()
        {
            InitializeComponent();
        }
        //Capture cp ;
        private static System.Timers.Timer mytimer = new System.Timers.Timer();
        private bool isOpen = false;
        HaarCascade cascade = new FaceHaarCascade();
        private HaarObjectDetector detector;
        /// <summary>
        /// USB摄像头硬件Id集合
        /// </summary>
        private List<string> _cameraList = new List<string>();
        FilterInfoCollection _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        private Bitmap pic1=null;
        private System.Drawing.Image pic2=null;
        private void OpenOrCloseCam_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                this.videoSourcePlayer1.VideoSource = CameraAssistance.CameraConn(_videoDevices, this.CamerasCbx.SelectedIndex);
                this.videoSourcePlayer1.Start();
                isOpen = true;
                this.videoSourcePlayer1.BringToFront();
                OpenOrCloseCam.Text = "关闭摄像头";
            }
            else
            {
                this.videoSourcePlayer1.SignalToStop();
                this.videoSourcePlayer1.WaitForStop();
                isOpen = false;
                OpenOrCloseCam.Text = "打开摄像头";
            }
        }

        private void RealTimeFaceDetect_Load(object sender, EventArgs e)
        {
            detector = new HaarObjectDetector(cascade, 30);
            _cameraList = CameraAssistance.Enumerate();
            foreach (var item in _cameraList)
                this.CamerasCbx.Items.Add(item);
        }

        private void DetectBtn_Click(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                mytimer.Interval = 150;
                mytimer.Enabled = true;
                mytimer.Elapsed += new ElapsedEventHandler(mytimer_Elapsed);
                mytimer.AutoReset = true;
                isOpen = false;
                this.detectedFaceimg.BringToFront();
                DetectBtn.Text = "结束检测";
            }
            else
            {
                this.videoSourcePlayer1.BringToFront();
                this.detectedFaceimg.Image = null;
                mytimer.Enabled = false;
                isOpen =true;
                DetectBtn.Text = "开始检测";
            }
        }
        private void mytimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            pic1 = this.videoSourcePlayer1.GetCurrentVideoFrame();
            
            try
            {
                    Rectangle[] objects = detector.ProcessFrame(pic1);
                    if (objects.Length > 0)
                    {
                        RectanglesMarker marker = new RectanglesMarker(objects, Color.Black);
                        pic2 = marker.Apply(pic1);
                        this.detectedFaceimg.Image = pic2;
                    }
                    else
                    {
                        this.detectedFaceimg.Image = pic1;
                    }

            }
            catch
            {
                this.detectedFaceimg.Image = pic1;
            }
        }

        private void skincbx_CheckedChanged(object sender, EventArgs e)
        {
            ////双边滤波
            ////src:输入图像
            ////dst:输出图像
            ////d:滤波模板半径
            ////sigmaclor:颜色空间标准差
            ////sigmaspace:坐标空间标准差
           
        }
    }
}
