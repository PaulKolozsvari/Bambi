namespace Bambi.Winforms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlBackground = new Figlut.Server.Toolkit.Winforms.GradientPanel();
            this.pnlImageGallery = new Figlut.Server.Toolkit.Winforms.GradientPanel();
            this.btnRefreshImageGallery = new Figlut.Server.Toolkit.Winforms.GradientButton();
            this.btnExit = new Figlut.Server.Toolkit.Winforms.GradientButton();
            this.btnExtractImages = new Figlut.Server.Toolkit.Winforms.GradientButton();
            this.pnlDestinationDirectory = new System.Windows.Forms.Panel();
            this.txtImageGalleryDirectory = new System.Windows.Forms.TextBox();
            this.btnSelectImageGalleryDirectory = new Figlut.Server.Toolkit.Winforms.GradientButton();
            this.lblImageGalleryDirectory = new System.Windows.Forms.Label();
            this.pnlSourceDirectory = new System.Windows.Forms.Panel();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.btnSelectSourceDirectory = new Figlut.Server.Toolkit.Winforms.GradientButton();
            this.lblSourceDirectory = new System.Windows.Forms.Label();
            this.opdSelectDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlFormContent.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.pnlDestinationDirectory.SuspendLayout();
            this.pnlSourceDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlBackground);
            this.pnlFormContent.Location = new System.Drawing.Point(30, 38);
            this.pnlFormContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFormContent.Size = new System.Drawing.Size(1400, 462);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(1430, 38);
            this.pnlFormRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFormRight.Size = new System.Drawing.Size(30, 462);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Location = new System.Drawing.Point(0, 38);
            this.pnlFormLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFormLeft.Size = new System.Drawing.Size(30, 462);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormTitle.Size = new System.Drawing.Size(1460, 38);
            this.lblFormTitle.Text = "Bambi ";
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 500);
            this.statusMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusMain.Size = new System.Drawing.Size(1460, 38);
            this.statusMain.Text = "Acquire Windows 10 Lock Screen Images";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackground.BackgroundImage")));
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.pnlImageGallery);
            this.pnlBackground.Controls.Add(this.btnRefreshImageGallery);
            this.pnlBackground.Controls.Add(this.btnExit);
            this.pnlBackground.Controls.Add(this.btnExtractImages);
            this.pnlBackground.Controls.Add(this.pnlDestinationDirectory);
            this.pnlBackground.Controls.Add(this.lblImageGalleryDirectory);
            this.pnlBackground.Controls.Add(this.pnlSourceDirectory);
            this.pnlBackground.Controls.Add(this.lblSourceDirectory);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.GradientEndColor = System.Drawing.Color.Gainsboro;
            this.pnlBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pnlBackground.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1400, 462);
            this.pnlBackground.TabIndex = 0;
            // 
            // pnlImageGallery
            // 
            this.pnlImageGallery.AutoScroll = true;
            this.pnlImageGallery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImageGallery.BackgroundImage")));
            this.pnlImageGallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImageGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImageGallery.GradientEndColor = System.Drawing.Color.White;
            this.pnlImageGallery.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pnlImageGallery.GradientStartColor = System.Drawing.Color.White;
            this.pnlImageGallery.Location = new System.Drawing.Point(0, 190);
            this.pnlImageGallery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlImageGallery.Name = "pnlImageGallery";
            this.pnlImageGallery.Size = new System.Drawing.Size(1400, 176);
            this.pnlImageGallery.TabIndex = 10;
            // 
            // btnRefreshImageGallery
            // 
            this.btnRefreshImageGallery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshImageGallery.BackgroundImage")));
            this.btnRefreshImageGallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshImageGallery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefreshImageGallery.ForeColor = System.Drawing.Color.White;
            this.btnRefreshImageGallery.GradientEndColor = System.Drawing.Color.SteelBlue;
            this.btnRefreshImageGallery.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRefreshImageGallery.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefreshImageGallery.Location = new System.Drawing.Point(0, 366);
            this.btnRefreshImageGallery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshImageGallery.Name = "btnRefreshImageGallery";
            this.btnRefreshImageGallery.Size = new System.Drawing.Size(1400, 48);
            this.btnRefreshImageGallery.TabIndex = 9;
            this.btnRefreshImageGallery.Text = "Refresh Image Gallery";
            this.btnRefreshImageGallery.UseVisualStyleBackColor = true;
            this.btnRefreshImageGallery.Click += new System.EventHandler(this.btnRefreshImageGallery_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.GradientEndColor = System.Drawing.Color.SteelBlue;
            this.btnExit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnExit.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(0, 414);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(1400, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExtractImages
            // 
            this.btnExtractImages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExtractImages.BackgroundImage")));
            this.btnExtractImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExtractImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtractImages.ForeColor = System.Drawing.Color.White;
            this.btnExtractImages.GradientEndColor = System.Drawing.Color.SteelBlue;
            this.btnExtractImages.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnExtractImages.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.btnExtractImages.Location = new System.Drawing.Point(0, 142);
            this.btnExtractImages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExtractImages.Name = "btnExtractImages";
            this.btnExtractImages.Size = new System.Drawing.Size(1400, 48);
            this.btnExtractImages.TabIndex = 5;
            this.btnExtractImages.Text = "Extract Images";
            this.btnExtractImages.UseVisualStyleBackColor = true;
            this.btnExtractImages.Click += new System.EventHandler(this.btnExtractImages_Click);
            // 
            // pnlDestinationDirectory
            // 
            this.pnlDestinationDirectory.BackColor = System.Drawing.Color.Transparent;
            this.pnlDestinationDirectory.Controls.Add(this.txtImageGalleryDirectory);
            this.pnlDestinationDirectory.Controls.Add(this.btnSelectImageGalleryDirectory);
            this.pnlDestinationDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDestinationDirectory.Location = new System.Drawing.Point(0, 98);
            this.pnlDestinationDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDestinationDirectory.Name = "pnlDestinationDirectory";
            this.pnlDestinationDirectory.Size = new System.Drawing.Size(1400, 44);
            this.pnlDestinationDirectory.TabIndex = 4;
            // 
            // txtImageGalleryDirectory
            // 
            this.txtImageGalleryDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtImageGalleryDirectory.Location = new System.Drawing.Point(0, 0);
            this.txtImageGalleryDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImageGalleryDirectory.Name = "txtImageGalleryDirectory";
            this.txtImageGalleryDirectory.Size = new System.Drawing.Size(1304, 31);
            this.txtImageGalleryDirectory.TabIndex = 1;
            // 
            // btnSelectImageGalleryDirectory
            // 
            this.btnSelectImageGalleryDirectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectImageGalleryDirectory.BackgroundImage")));
            this.btnSelectImageGalleryDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectImageGalleryDirectory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectImageGalleryDirectory.ForeColor = System.Drawing.Color.White;
            this.btnSelectImageGalleryDirectory.GradientEndColor = System.Drawing.Color.SteelBlue;
            this.btnSelectImageGalleryDirectory.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSelectImageGalleryDirectory.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectImageGalleryDirectory.Location = new System.Drawing.Point(1304, 0);
            this.btnSelectImageGalleryDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectImageGalleryDirectory.Name = "btnSelectImageGalleryDirectory";
            this.btnSelectImageGalleryDirectory.Size = new System.Drawing.Size(96, 44);
            this.btnSelectImageGalleryDirectory.TabIndex = 0;
            this.btnSelectImageGalleryDirectory.Text = "...";
            this.btnSelectImageGalleryDirectory.UseVisualStyleBackColor = true;
            this.btnSelectImageGalleryDirectory.Click += new System.EventHandler(this.btnSelectImageGalleryDirectory_Click);
            // 
            // lblImageGalleryDirectory
            // 
            this.lblImageGalleryDirectory.AutoSize = true;
            this.lblImageGalleryDirectory.BackColor = System.Drawing.Color.Transparent;
            this.lblImageGalleryDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImageGalleryDirectory.ForeColor = System.Drawing.Color.DimGray;
            this.lblImageGalleryDirectory.Location = new System.Drawing.Point(0, 72);
            this.lblImageGalleryDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageGalleryDirectory.Name = "lblImageGalleryDirectory";
            this.lblImageGalleryDirectory.Size = new System.Drawing.Size(241, 26);
            this.lblImageGalleryDirectory.TabIndex = 3;
            this.lblImageGalleryDirectory.Text = "Image Gallery Directory";
            // 
            // pnlSourceDirectory
            // 
            this.pnlSourceDirectory.BackColor = System.Drawing.Color.Transparent;
            this.pnlSourceDirectory.Controls.Add(this.txtSourceDirectory);
            this.pnlSourceDirectory.Controls.Add(this.btnSelectSourceDirectory);
            this.pnlSourceDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSourceDirectory.Location = new System.Drawing.Point(0, 26);
            this.pnlSourceDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSourceDirectory.Name = "pnlSourceDirectory";
            this.pnlSourceDirectory.Size = new System.Drawing.Size(1400, 46);
            this.pnlSourceDirectory.TabIndex = 2;
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSourceDirectory.Location = new System.Drawing.Point(0, 0);
            this.txtSourceDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(1304, 31);
            this.txtSourceDirectory.TabIndex = 1;
            // 
            // btnSelectSourceDirectory
            // 
            this.btnSelectSourceDirectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectSourceDirectory.BackgroundImage")));
            this.btnSelectSourceDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectSourceDirectory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectSourceDirectory.ForeColor = System.Drawing.Color.White;
            this.btnSelectSourceDirectory.GradientEndColor = System.Drawing.Color.SteelBlue;
            this.btnSelectSourceDirectory.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSelectSourceDirectory.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectSourceDirectory.Location = new System.Drawing.Point(1304, 0);
            this.btnSelectSourceDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectSourceDirectory.Name = "btnSelectSourceDirectory";
            this.btnSelectSourceDirectory.Size = new System.Drawing.Size(96, 46);
            this.btnSelectSourceDirectory.TabIndex = 0;
            this.btnSelectSourceDirectory.Text = "...";
            this.btnSelectSourceDirectory.UseVisualStyleBackColor = true;
            this.btnSelectSourceDirectory.Click += new System.EventHandler(this.btnSelectSourceDirectory_Click);
            // 
            // lblSourceDirectory
            // 
            this.lblSourceDirectory.AutoSize = true;
            this.lblSourceDirectory.BackColor = System.Drawing.Color.Transparent;
            this.lblSourceDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSourceDirectory.ForeColor = System.Drawing.Color.DimGray;
            this.lblSourceDirectory.Location = new System.Drawing.Point(0, 0);
            this.lblSourceDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSourceDirectory.Name = "lblSourceDirectory";
            this.lblSourceDirectory.Size = new System.Drawing.Size(241, 26);
            this.lblSourceDirectory.TabIndex = 1;
            this.lblSourceDirectory.Text = "Image Source Directory";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnExtractImages;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 538);
            this.FormTitle = "Bambi";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Status = "Acquire Windows 10 Lock Screen Images";
            this.Text = "Bambi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlDestinationDirectory.ResumeLayout(false);
            this.pnlDestinationDirectory.PerformLayout();
            this.pnlSourceDirectory.ResumeLayout(false);
            this.pnlSourceDirectory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Figlut.Server.Toolkit.Winforms.GradientPanel pnlBackground;
        private System.Windows.Forms.Label lblSourceDirectory;
        private System.Windows.Forms.Panel pnlSourceDirectory;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private Figlut.Server.Toolkit.Winforms.GradientButton btnSelectSourceDirectory;
        private System.Windows.Forms.Panel pnlDestinationDirectory;
        private System.Windows.Forms.TextBox txtImageGalleryDirectory;
        private Figlut.Server.Toolkit.Winforms.GradientButton btnSelectImageGalleryDirectory;
        private System.Windows.Forms.Label lblImageGalleryDirectory;
        private Figlut.Server.Toolkit.Winforms.GradientButton btnExtractImages;
        private Figlut.Server.Toolkit.Winforms.GradientButton btnExit;
        private System.Windows.Forms.FolderBrowserDialog opdSelectDirectory;
        private Figlut.Server.Toolkit.Winforms.GradientPanel pnlImageGallery;
        private Figlut.Server.Toolkit.Winforms.GradientButton btnRefreshImageGallery;
    }
}

