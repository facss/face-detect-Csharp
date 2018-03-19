namespace FaceDetect
{
    partial class RealTimeFaceDetect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.CamerasCbx = new System.Windows.Forms.ComboBox();
            this.OpenOrCloseCam = new System.Windows.Forms.Button();
            this.DetectBtn = new System.Windows.Forms.Button();
            this.detectedFaceimg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detectedFaceimg)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(62, 12);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(528, 337);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // CamerasCbx
            // 
            this.CamerasCbx.FormattingEnabled = true;
            this.CamerasCbx.Location = new System.Drawing.Point(138, 392);
            this.CamerasCbx.Name = "CamerasCbx";
            this.CamerasCbx.Size = new System.Drawing.Size(240, 20);
            this.CamerasCbx.TabIndex = 1;
            // 
            // OpenOrCloseCam
            // 
            this.OpenOrCloseCam.Location = new System.Drawing.Point(408, 390);
            this.OpenOrCloseCam.Name = "OpenOrCloseCam";
            this.OpenOrCloseCam.Size = new System.Drawing.Size(75, 23);
            this.OpenOrCloseCam.TabIndex = 2;
            this.OpenOrCloseCam.Text = "打开摄像头";
            this.OpenOrCloseCam.UseVisualStyleBackColor = true;
            this.OpenOrCloseCam.Click += new System.EventHandler(this.OpenOrCloseCam_Click);
            // 
            // DetectBtn
            // 
            this.DetectBtn.Location = new System.Drawing.Point(515, 390);
            this.DetectBtn.Name = "DetectBtn";
            this.DetectBtn.Size = new System.Drawing.Size(75, 23);
            this.DetectBtn.TabIndex = 3;
            this.DetectBtn.Text = "开始检测";
            this.DetectBtn.UseVisualStyleBackColor = true;
            this.DetectBtn.Click += new System.EventHandler(this.DetectBtn_Click);
            // 
            // detectedFaceimg
            // 
            this.detectedFaceimg.Location = new System.Drawing.Point(62, 12);
            this.detectedFaceimg.Name = "detectedFaceimg";
            this.detectedFaceimg.Size = new System.Drawing.Size(528, 337);
            this.detectedFaceimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.detectedFaceimg.TabIndex = 4;
            this.detectedFaceimg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择摄像头：";
            // 
            // RealTimeFaceDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detectedFaceimg);
            this.Controls.Add(this.DetectBtn);
            this.Controls.Add(this.OpenOrCloseCam);
            this.Controls.Add(this.CamerasCbx);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Name = "RealTimeFaceDetect";
            this.Text = "实时人脸检测";
            this.Load += new System.EventHandler(this.RealTimeFaceDetect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detectedFaceimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.ComboBox CamerasCbx;
        private System.Windows.Forms.Button OpenOrCloseCam;
        private System.Windows.Forms.Button DetectBtn;
        private System.Windows.Forms.PictureBox detectedFaceimg;
        private System.Windows.Forms.Label label1;
    }
}