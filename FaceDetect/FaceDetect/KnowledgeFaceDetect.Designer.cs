namespace FaceDetect
{
    partial class KnowledgeFaceDetect
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
            this.FilePath = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FaceDetect = new System.Windows.Forms.Button();
            this.Original = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.PictureBox();
            this.Detected = new System.Windows.Forms.PictureBox();
            this.timeStatus = new System.Windows.Forms.StatusStrip();
            this.timeElpse = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detected)).BeginInit();
            this.timeStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(109, 43);
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Size = new System.Drawing.Size(330, 21);
            this.FilePath.TabIndex = 1;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(470, 43);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 2;
            this.OpenFileButton.Text = "打开文件";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // FaceDetect
            // 
            this.FaceDetect.Location = new System.Drawing.Point(567, 43);
            this.FaceDetect.Name = "FaceDetect";
            this.FaceDetect.Size = new System.Drawing.Size(75, 23);
            this.FaceDetect.TabIndex = 3;
            this.FaceDetect.Text = "开始检测";
            this.FaceDetect.UseVisualStyleBackColor = true;
            this.FaceDetect.Click += new System.EventHandler(this.FaceDetect_Click);
            // 
            // Original
            // 
            this.Original.Location = new System.Drawing.Point(12, 106);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(282, 362);
            this.Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Original.TabIndex = 4;
            this.Original.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.OpenFileToolStripMenuItem.Text = "打开";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalToolStripMenuItem,
            this.processToolStripMenuItem,
            this.detectToolStripMenuItem});
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.SaveToolStripMenuItem.Text = "保存";
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.originalToolStripMenuItem.Text = "原图";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.processToolStripMenuItem.Text = "处理中的图";
            this.processToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // detectToolStripMenuItem
            // 
            this.detectToolStripMenuItem.Name = "detectToolStripMenuItem";
            this.detectToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.detectToolStripMenuItem.Text = "检测结果图";
            this.detectToolStripMenuItem.Click += new System.EventHandler(this.detectToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "文件路径：";
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(300, 106);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(282, 362);
            this.Process.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Process.TabIndex = 7;
            this.Process.TabStop = false;
            // 
            // Detected
            // 
            this.Detected.Location = new System.Drawing.Point(594, 106);
            this.Detected.Name = "Detected";
            this.Detected.Size = new System.Drawing.Size(282, 362);
            this.Detected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Detected.TabIndex = 8;
            this.Detected.TabStop = false;
            // 
            // timeStatus
            // 
            this.timeStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeElpse});
            this.timeStatus.Location = new System.Drawing.Point(0, 458);
            this.timeStatus.Name = "timeStatus";
            this.timeStatus.Size = new System.Drawing.Size(894, 22);
            this.timeStatus.TabIndex = 9;
            // 
            // timeElpse
            // 
            this.timeElpse.Name = "timeElpse";
            this.timeElpse.Size = new System.Drawing.Size(0, 17);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 12;
            // 
            // KnowledgeFaceDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeStatus);
            this.Controls.Add(this.Detected);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Original);
            this.Controls.Add(this.FaceDetect);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KnowledgeFaceDetect";
            this.Text = "静态人脸检测";
            ((System.ComponentModel.ISupportInitialize)(this.Original)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detected)).EndInit();
            this.timeStatus.ResumeLayout(false);
            this.timeStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button FaceDetect;
        public System.Windows.Forms.PictureBox Original;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox Process;
        public System.Windows.Forms.PictureBox Detected;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip timeStatus;
        private System.Windows.Forms.ToolStripStatusLabel timeElpse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}