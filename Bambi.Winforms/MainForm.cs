namespace Bambi.Winforms
{
    #region Using Directives

    using Bambi.Winforms.Base;
    using Bambi.Winforms.Utilities;
    using Figlut.Server.Toolkit.Utilities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    #endregion //Using Directives

    public partial class MainForm : BaseForm
    {
        #region Constructors

        public MainForm(BambiDesktopSettings settings)
        {
            InitializeComponent();
            if (settings == null)
            {
                throw new NullReferenceException(string.Format(
                    "{0} may not be null when constructing a {1}.",
                    typeof(BambiDesktopSettings).Name,
                    typeof(MainForm).Name));
            }
            _settings = settings;
            _thumbnailCallback = new Image.GetThumbnailImageAbort(delegate() { return false; });
        }

        #endregion //Constructors

        #region Fields

        private BambiDesktopSettings _settings;
        private bool _forceClose;
        private Image.GetThumbnailImageAbort _thumbnailCallback;

        #endregion //Fields

        #region Properties

        public bool ForceClose
        {
            get { return _forceClose; }
            set { _forceClose = value; }
        }

        #endregion //Properties

        #region Methods

        private void SaveSettings()
        {
            using (WaitProcess w = new WaitProcess(this))
            {
                w.ChangeStatus("Saving settings ...");
                if (Directory.Exists(txtImageGalleryDirectory.Text))
                {
                    _settings.ImageGalleryDirectory = txtImageGalleryDirectory.Text;
                    _settings.SaveToFile();
                }
            }
        }

        private bool InputFieldsValid()
        {
            if (string.IsNullOrEmpty(txtSourceDirectory.Text))
            {
                UIHelper.DisplayError("Source Directory not entered.");
                txtSourceDirectory.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtImageGalleryDirectory.Text))
            {
                UIHelper.DisplayError("Image Gallery Directory not entered.");
                txtImageGalleryDirectory.Focus();
                return false;
            }
            if (!Directory.Exists(txtSourceDirectory.Text))
            {
                UIHelper.DisplayError(string.Format("Could not find Source Directory {0}.", txtSourceDirectory.Text));
                txtSourceDirectory.Focus();
                return false;
            }
            if (!Directory.Exists(txtImageGalleryDirectory.Text))
            {
                UIHelper.DisplayError(string.Format("Could not find Destination Directory {0}.", txtImageGalleryDirectory.Text));
                txtImageGalleryDirectory.Focus();
                txtImageGalleryDirectory.Focus();
            }
            return true;
        }

        private void RefreshImageGallery()
        {
            int thumbnailHeight = 98;
            int thumbnailWidth = 98;
            pnlImageGallery.Height = thumbnailHeight * 2;
            foreach (PictureBox oldPicBox in pnlImageGallery.Controls)
            {
                oldPicBox.Image = null;
                oldPicBox.DoubleClick -= picBox_DoubleClick;
            }
            pnlImageGallery.Controls.Clear();
            foreach (string imageFilePath in Directory.GetFiles(txtImageGalleryDirectory.Text))
            {
                Image image = null;
                try
                {
                    image = Image.FromFile(imageFilePath);
                }
                catch (Exception)
                {
                    continue;
                }
                Image thumbnail = image.GetThumbnailImage(thumbnailWidth, thumbnailHeight, _thumbnailCallback, IntPtr.Zero);
                PictureBox picBox = new PictureBox()
                {
                    Name = Path.GetFileName(imageFilePath),
                    Tag = imageFilePath,
                    Image = thumbnail,
                    Dock = DockStyle.Left,
                    Width = 96,
                    Height = 96,
                };
                picBox.DoubleClick += picBox_DoubleClick;
                pnlImageGallery.Controls.Add(picBox);
            }
        }

        #endregion //Methods

        #region Event Handlers

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string sourceDirectory = _settings.Windows10LockScreenImageDirectory.Replace(_settings.UserParameterInImageDirectory, Environment.UserName);
            if (!Directory.Exists(sourceDirectory))
            {
                UIHelper.DisplayWarning(string.Format(
                    "Could not find Windows 10 lock screen image directory {0}. Update with correct Windows image directory.",
                    sourceDirectory,
                    _settings.FilePath));
            }
            if (!Directory.Exists(_settings.ImageGalleryDirectory))
            {
                UIHelper.DisplayWarning(string.Format(
                    "Could not find default destination directory {0}.",
                    _settings.ImageGalleryDirectory));
            }
            txtSourceDirectory.Text = sourceDirectory;
            txtImageGalleryDirectory.Text = _settings.ImageGalleryDirectory;
            if (_settings.RefreshImageGalleryOnStartup)
            {
                this.BeginInvoke(new Action(RefreshImageGallery));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_forceClose && UIHelper.AskQuestion("Are you sure you want to exit?") != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                AnimateHideForm();
            }
            SaveSettings();
        }

        private void btnSelectSourceDirectory_Click(object sender, EventArgs e)
        {
            string originalSelectedPath = opdSelectDirectory.SelectedPath;
            if (!string.IsNullOrEmpty(txtSourceDirectory.Text) && Directory.Exists(txtSourceDirectory.Text))
            {
                opdSelectDirectory.SelectedPath = txtSourceDirectory.Text;
            }
            if (opdSelectDirectory.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSourceDirectory.Text = opdSelectDirectory.SelectedPath;
            }
            opdSelectDirectory.SelectedPath = originalSelectedPath;
        }

        private void btnSelectImageGalleryDirectory_Click(object sender, EventArgs e)
        {
            string originalSelectedPath = opdSelectDirectory.SelectedPath;
            if (!string.IsNullOrEmpty(txtImageGalleryDirectory.Text) && Directory.Exists(txtImageGalleryDirectory.Text))
            {
                opdSelectDirectory.SelectedPath = txtImageGalleryDirectory.Text;
            }
            if (opdSelectDirectory.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtImageGalleryDirectory.Text = opdSelectDirectory.SelectedPath;
            }
            opdSelectDirectory.SelectedPath = originalSelectedPath;
        }

        private void btnExtractImages_Click(object sender, EventArgs e)
        {
            if (!InputFieldsValid())
            {
                return;
            }
            int imagesExtracted = 0;
            foreach (string sourceFilePath in Directory.GetFiles(txtSourceDirectory.Text))
            {
                try
                {
                    using (Image image = Image.FromFile(sourceFilePath))
                    {
                        if (image.Width < _settings.MinimumImageWidth || image.Height < _settings.MinimumImageHeight)
                        {
                            continue;
                        }
                    }
                }
                catch (Exception)
                {
                    continue;
                }
                string fileName = Path.GetFileName(sourceFilePath);
                string fileNameWithExtension = Path.ChangeExtension(fileName, _settings.ImageFileExtensionToAdd);
                string destinationFilePath = Path.Combine(txtImageGalleryDirectory.Text, fileNameWithExtension);
                if (!File.Exists(destinationFilePath))
                {
                    File.Copy(sourceFilePath, destinationFilePath);
                    imagesExtracted++;
                }
                Application.DoEvents();
            }
            UIHelper.DisplayInformation(string.Format("{0} new images extracted.", imagesExtracted));
            RefreshImageGallery();
        }

        void picBox_DoubleClick(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            if (picBox == null)
            {
                return;
            }
            string filePath = picBox.Tag.ToString();
            using (Process p = new Process() { StartInfo = new ProcessStartInfo(filePath) })
            {
                p.Start();
            }
        }

        private void btnRefreshImageGallery_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(RefreshImageGallery));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion //Event Handlers
    }
}