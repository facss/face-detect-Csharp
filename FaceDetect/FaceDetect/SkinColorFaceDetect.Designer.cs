namespace FaceDetect
{
    partial class SkinColorFaceDetect
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
            this.Process2 = new System.Windows.Forms.PictureBox();
            this.Process1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Original = new System.Windows.Forms.PictureBox();
            this.FaceDetect = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.normalieddetect = new System.Windows.Forms.Button();
            this.skinopenfile = new System.Windows.Forms.Button();
            this.skinfilepath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.process1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.process2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Detected = new System.Windows.Forms.PictureBox();
            this.skindetect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timeElpsed = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Process2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Process1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Detected)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Process2
            // 
            this.Process2.Location = new System.Drawing.Point(590, 95);
            this.Process2.Name = "Process2";
            this.Process2.Size = new System.Drawing.Size(282, 362);
            this.Process2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Process2.TabIndex = 15;
            this.Process2.TabStop = false;
            // 
            // Process1
            // 
            this.Process1.Location = new System.Drawing.Point(299, 95);
            this.Process1.Name = "Process1";
            this.Process1.Size = new System.Drawing.Size(282, 362);
            this.Process1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Process1.TabIndex = 14;
            this.Process1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-60, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "文件路径：";
            // 
            // Original
            // 
            this.Original.Location = new System.Drawing.Point(6, 95);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(282, 362);
            this.Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Original.TabIndex = 12;
            this.Original.TabStop = false;
            // 
            // FaceDetect
            // 
            this.FaceDetect.Location = new System.Drawing.Point(473, -22);
            this.FaceDetect.Name = "FaceDetect";
            this.FaceDetect.Size = new System.Drawing.Size(75, 23);
            this.FaceDetect.TabIndex = 11;
            this.FaceDetect.Text = "开始检测";
            this.FaceDetect.UseVisualStyleBackColor = true;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(376, -22);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 10;
            this.OpenFileButton.Text = "打开文件";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(15, -22);
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Size = new System.Drawing.Size(330, 21);
            this.FilePath.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "文件路径：";
            // 
            // normalieddetect
            // 
            this.normalieddetect.Location = new System.Drawing.Point(656, 36);
            this.normalieddetect.Name = "normalieddetect";
            this.normalieddetect.Size = new System.Drawing.Size(75, 23);
            this.normalieddetect.TabIndex = 18;
            this.normalieddetect.Text = "基准白矫正";
            this.normalieddetect.UseVisualStyleBackColor = true;
            this.normalieddetect.Click += new System.EventHandler(this.normalieddetect_Click);
            // 
            // skinopenfile
            // 
            this.skinopenfile.Location = new System.Drawing.Point(559, 36);
            this.skinopenfile.Name = "skinopenfile";
            this.skinopenfile.Size = new System.Drawing.Size(75, 23);
            this.skinopenfile.TabIndex = 17;
            this.skinopenfile.Text = "打开文件";
            this.skinopenfile.UseVisualStyleBackColor = true;
            this.skinopenfile.Click += new System.EventHandler(this.skinopenfile_Click);
            // 
            // skinfilepath
            // 
            this.skinfilepath.Location = new System.Drawing.Point(198, 36);
            this.skinfilepath.Name = "skinfilepath";
            this.skinfilepath.ReadOnly = true;
            this.skinfilepath.Size = new System.Drawing.Size(330, 21);
            this.skinfilepath.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 25);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.process1ToolStripMenuItem,
            this.process2ToolStripMenuItem,
            this.resultToolStripMenuItem1,
            this.OriToolStripMenuItem});
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            // 
            // process1ToolStripMenuItem
            // 
            this.process1ToolStripMenuItem.Name = "process1ToolStripMenuItem";
            this.process1ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.process1ToolStripMenuItem.Text = "处理中的图1";
            this.process1ToolStripMenuItem.Click += new System.EventHandler(this.process1ToolStripMenuItem_Click);
            // 
            // process2ToolStripMenuItem
            // 
            this.process2ToolStripMenuItem.Name = "process2ToolStripMenuItem";
            this.process2ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.process2ToolStripMenuItem.Text = "处理中的图2";
            this.process2ToolStripMenuItem.Click += new System.EventHandler(this.process2ToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem1
            // 
            this.resultToolStripMenuItem1.Name = "resultToolStripMenuItem1";
            this.resultToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.resultToolStripMenuItem1.Text = "检测结果图";
            this.resultToolStripMenuItem1.Click += new System.EventHandler(this.resultToolStripMenuItem1_Click);
            // 
            // OriToolStripMenuItem
            // 
            this.OriToolStripMenuItem.Name = "OriToolStripMenuItem";
            this.OriToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.OriToolStripMenuItem.Text = "原图";
            this.OriToolStripMenuItem.Click += new System.EventHandler(this.OriToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // Detected
            // 
            this.Detected.Location = new System.Drawing.Point(883, 94);
            this.Detected.Name = "Detected";
            this.Detected.Size = new System.Drawing.Size(282, 362);
            this.Detected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Detected.TabIndex = 21;
            this.Detected.TabStop = false;
            // 
            // skindetect
            // 
            this.skindetect.Location = new System.Drawing.Point(750, 36);
            this.skindetect.Name = "skindetect";
            this.skindetect.Size = new System.Drawing.Size(75, 23);
            this.skindetect.TabIndex = 22;
            this.skindetect.Text = "肤色分割";
            this.skindetect.UseVisualStyleBackColor = true;
            this.skindetect.Click += new System.EventHandler(this.skindetect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeElpsed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1203, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timeElpsed
            // 
            this.timeElpsed.Name = "timeElpsed";
            this.timeElpsed.Size = new System.Drawing.Size(0, 17);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "原图";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "基准白矫正";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "大津法二值化";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1004, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "检测结果";
            // 
            // SkinColorFaceDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 464);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.skindetect);
            this.Controls.Add(this.Detected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.normalieddetect);
            this.Controls.Add(this.skinopenfile);
            this.Controls.Add(this.skinfilepath);
            this.Controls.Add(this.Process2);
            this.Controls.Add(this.Process1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Original);
            this.Controls.Add(this.FaceDetect);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SkinColorFaceDetect";
            this.Text = "肤色人脸检测";
            ((System.ComponentModel.ISupportInitialize)(this.Process2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Process1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Detected)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox Process2;
        public System.Windows.Forms.PictureBox Process1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox Original;
        private System.Windows.Forms.Button FaceDetect;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button normalieddetect;
        private System.Windows.Forms.Button skinopenfile;
        private System.Windows.Forms.TextBox skinfilepath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem process1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem process2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        public System.Windows.Forms.PictureBox Detected;
        private System.Windows.Forms.Button skindetect;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timeElpsed;
        private System.Windows.Forms.ToolStripMenuItem OriToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}