namespace FaceDetect
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.StaticFaceDetectButton = new System.Windows.Forms.Button();
            this.RealTimeFaceDeteectButton = new System.Windows.Forms.Button();
            this.SkinColorFaceDetectButton = new System.Windows.Forms.Button();
            this.ViolaJonesFaceDetectButton = new System.Windows.Forms.Button();
            this.imageprocessbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaticFaceDetectButton
            // 
            this.StaticFaceDetectButton.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StaticFaceDetectButton.Location = new System.Drawing.Point(71, 41);
            this.StaticFaceDetectButton.Name = "StaticFaceDetectButton";
            this.StaticFaceDetectButton.Size = new System.Drawing.Size(143, 51);
            this.StaticFaceDetectButton.TabIndex = 0;
            this.StaticFaceDetectButton.Text = "基于知识的人脸检测";
            this.StaticFaceDetectButton.UseVisualStyleBackColor = true;
            this.StaticFaceDetectButton.Click += new System.EventHandler(this.StaticFaceDetectButton_Click);
            // 
            // RealTimeFaceDeteectButton
            // 
            this.RealTimeFaceDeteectButton.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RealTimeFaceDeteectButton.Location = new System.Drawing.Point(248, 120);
            this.RealTimeFaceDeteectButton.Name = "RealTimeFaceDeteectButton";
            this.RealTimeFaceDeteectButton.Size = new System.Drawing.Size(143, 52);
            this.RealTimeFaceDeteectButton.TabIndex = 1;
            this.RealTimeFaceDeteectButton.Text = "动态人脸检测";
            this.RealTimeFaceDeteectButton.UseVisualStyleBackColor = true;
            this.RealTimeFaceDeteectButton.Click += new System.EventHandler(this.RealTimeFaceDeteectButton_Click);
            // 
            // SkinColorFaceDetectButton
            // 
            this.SkinColorFaceDetectButton.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkinColorFaceDetectButton.Location = new System.Drawing.Point(248, 41);
            this.SkinColorFaceDetectButton.Name = "SkinColorFaceDetectButton";
            this.SkinColorFaceDetectButton.Size = new System.Drawing.Size(143, 51);
            this.SkinColorFaceDetectButton.TabIndex = 2;
            this.SkinColorFaceDetectButton.Text = "基于肤色的人脸检测";
            this.SkinColorFaceDetectButton.UseVisualStyleBackColor = true;
            this.SkinColorFaceDetectButton.Click += new System.EventHandler(this.SkinColorFaceDetectButton_Click);
            // 
            // ViolaJonesFaceDetectButton
            // 
            this.ViolaJonesFaceDetectButton.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ViolaJonesFaceDetectButton.Location = new System.Drawing.Point(71, 120);
            this.ViolaJonesFaceDetectButton.Name = "ViolaJonesFaceDetectButton";
            this.ViolaJonesFaceDetectButton.Size = new System.Drawing.Size(143, 51);
            this.ViolaJonesFaceDetectButton.TabIndex = 4;
            this.ViolaJonesFaceDetectButton.Text = "基于统计的人脸检测";
            this.ViolaJonesFaceDetectButton.UseVisualStyleBackColor = true;
            this.ViolaJonesFaceDetectButton.Click += new System.EventHandler(this.ImprovedFaceDetectButton_Click);
            // 
            // imageprocessbtn
            // 
            this.imageprocessbtn.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.imageprocessbtn.Location = new System.Drawing.Point(71, 194);
            this.imageprocessbtn.Name = "imageprocessbtn";
            this.imageprocessbtn.Size = new System.Drawing.Size(143, 51);
            this.imageprocessbtn.TabIndex = 5;
            this.imageprocessbtn.Text = "图像处理";
            this.imageprocessbtn.UseVisualStyleBackColor = true;
            this.imageprocessbtn.Click += new System.EventHandler(this.imageprocessbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 278);
            this.Controls.Add(this.imageprocessbtn);
            this.Controls.Add(this.ViolaJonesFaceDetectButton);
            this.Controls.Add(this.SkinColorFaceDetectButton);
            this.Controls.Add(this.RealTimeFaceDeteectButton);
            this.Controls.Add(this.StaticFaceDetectButton);
            this.Name = "MainForm";
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StaticFaceDetectButton;
        private System.Windows.Forms.Button RealTimeFaceDeteectButton;
        private System.Windows.Forms.Button SkinColorFaceDetectButton;
        private System.Windows.Forms.Button ViolaJonesFaceDetectButton;
        private System.Windows.Forms.Button imageprocessbtn;
    }
}

