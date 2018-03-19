using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDetect
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        KnowledgeFaceDetect staticFaceDetect = new KnowledgeFaceDetect();
        RealTimeFaceDetect realTimeFaceDetect = new RealTimeFaceDetect();
        SkinColorFaceDetect skinColorFaceDetect = new SkinColorFaceDetect();
        ViolaJonesFaceDetect violajonesFaceDetect = new ViolaJonesFaceDetect();
        ViolaJonesFaceDetect improvedFaceDetect = new ViolaJonesFaceDetect();
        private void StaticFaceDetectButton_Click(object sender, EventArgs e)
        {
            staticFaceDetect.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void RealTimeFaceDeteectButton_Click(object sender, EventArgs e)
        {
            realTimeFaceDetect.ShowDialog(); 
        }

        private void SkinColorFaceDetectButton_Click(object sender, EventArgs e)
        {
            skinColorFaceDetect.ShowDialog();
        }

        private void ViolaJonesFaceDetectButton_Click(object sender, EventArgs e)
        {
            violajonesFaceDetect.ShowDialog();
        }

        private void ImprovedFaceDetectButton_Click(object sender, EventArgs e)
        {
            improvedFaceDetect.ShowDialog();
        }

        private void imageprocessbtn_Click(object sender, EventArgs e)
        {
            FilterForm filter = new FilterForm();
            filter.ShowDialog();
        }
    }
}
