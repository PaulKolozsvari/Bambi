namespace Bambi.Winforms.Base
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.SuspendLayout();
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Location = new System.Drawing.Point(30, 54);
            this.pnlFormContent.Size = new System.Drawing.Size(960, 589);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFormRight.BackgroundImage")));
            this.pnlFormRight.GradientEndColor = System.Drawing.Color.Gainsboro;
            this.pnlFormRight.GradientStartColor = System.Drawing.Color.Gainsboro;
            this.pnlFormRight.Location = new System.Drawing.Point(990, 54);
            this.pnlFormRight.Size = new System.Drawing.Size(30, 589);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFormLeft.BackgroundImage")));
            this.pnlFormLeft.GradientEndColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFormLeft.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFormLeft.Location = new System.Drawing.Point(0, 54);
            this.pnlFormLeft.Size = new System.Drawing.Size(30, 589);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.GradientEndColor = System.Drawing.Color.SteelBlue;
            this.lblFormTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblFormTitle.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.lblFormTitle.Size = new System.Drawing.Size(1020, 54);
            this.lblFormTitle.Text = " ";
            // 
            // statusMain
            // 
            this.statusMain.ForeColor = System.Drawing.Color.DimGray;
            this.statusMain.GradientEndColor = System.Drawing.Color.Gainsboro;
            this.statusMain.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.statusMain.Location = new System.Drawing.Point(0, 643);
            this.statusMain.Size = new System.Drawing.Size(1020, 54);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 697);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

