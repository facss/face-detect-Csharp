namespace FaceDetect
{
    partial class FilterForm
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
            this.components = new System.ComponentModel.Container();
            this.originalpic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GaussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threshingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultpic = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.originalpic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultpic)).BeginInit();
            this.SuspendLayout();
            // 
            // originalpic
            // 
            this.originalpic.Location = new System.Drawing.Point(27, 41);
            this.originalpic.Name = "originalpic";
            this.originalpic.Size = new System.Drawing.Size(388, 393);
            this.originalpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalpic.TabIndex = 2;
            this.originalpic.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "保存";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "退出";
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToGrayToolStripMenuItem,
            this.GaussToolStripMenuItem,
            this.BLToolStripMenuItem,
            this.threshingToolStripMenuItem,
            this.binaryToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.filtersToolStripMenuItem.Text = "滤波";
            // 
            // ToGrayToolStripMenuItem
            // 
            this.ToGrayToolStripMenuItem.Name = "ToGrayToolStripMenuItem";
            this.ToGrayToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ToGrayToolStripMenuItem.Text = "灰度化";
            this.ToGrayToolStripMenuItem.Click += new System.EventHandler(this.ToGrayToolStripMenuItem_Click);
            // 
            // GaussToolStripMenuItem
            // 
            this.GaussToolStripMenuItem.Name = "GaussToolStripMenuItem";
            this.GaussToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.GaussToolStripMenuItem.Text = "高斯滤波";
            this.GaussToolStripMenuItem.Click += new System.EventHandler(this.GaussToolStripMenuItem_Click);
            // 
            // BLToolStripMenuItem
            // 
            this.BLToolStripMenuItem.Name = "BLToolStripMenuItem";
            this.BLToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.BLToolStripMenuItem.Text = "双边滤波";
            this.BLToolStripMenuItem.Click += new System.EventHandler(this.BLToolStripMenuItem_Click);
            // 
            // threshingToolStripMenuItem
            // 
            this.threshingToolStripMenuItem.Name = "threshingToolStripMenuItem";
            this.threshingToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.threshingToolStripMenuItem.Text = "大津法图像分割";
            this.threshingToolStripMenuItem.Click += new System.EventHandler(this.threshingToolStripMenuItem_Click);
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.binaryToolStripMenuItem.Text = "二值化";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // resultpic
            // 
            this.resultpic.Location = new System.Drawing.Point(435, 41);
            this.resultpic.Name = "resultpic";
            this.resultpic.Size = new System.Drawing.Size(385, 400);
            this.resultpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultpic.TabIndex = 2;
            this.resultpic.TabStop = false;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 446);
            this.Controls.Add(this.resultpic);
            this.Controls.Add(this.originalpic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FilterForm";
            this.Text = "图像处理";
            ((System.ComponentModel.ISupportInitialize)(this.originalpic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox originalpic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GaussToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threshingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private Emgu.CV.UI.ImageBox resultpic;
    }
}