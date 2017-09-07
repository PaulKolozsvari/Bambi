namespace Bambi.Winforms
{
    #region Using Directives

    using Bambi.Winforms.Utilities;
    using Figlut.Server.Toolkit.Utilities;
    using Figlut.Server.Toolkit.Utilities.Logging;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    #endregion //Using Directives

    static class Program
    {
        #region Fields

        private static MainForm _mainForm;

        #endregion //Fields

        #region Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GOC.Instance.ShowMessageBoxOnException = true;
            if (!File.Exists(new BambiDesktopSettings().FilePath))
            {
                GetDefaultSettings().SaveToFile();
            }
            BambiDesktopSettings settings = GOC.Instance.GetSettings<BambiDesktopSettings>(true, true);
            _mainForm = new MainForm(settings);
            Application.Run(_mainForm);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (ExceptionHandler.HandleException(e.Exception))
            {
                _mainForm.ForceClose = true;
                Application.Exit();
            }
        }

        private static BambiDesktopSettings GetDefaultSettings()
        {
            return new BambiDesktopSettings()
            {
                Windows10LockScreenImageDirectory = @"C:\Users\{USER}\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets",
                UserParameterInImageDirectory = "{USER}",
                ImageGalleryDirectory = @"C:\",
                MinimumImageWidth = 1920,
                MinimumImageHeight = 1080,
                RefreshImageGalleryOnStartup = false,
                LogToFile = false,
                LogToWindowsEventLog = true, 
                LogToConsole = false,
                LogFileName = "Bambi.Log.txt",
                EventSourceName = "Bambi.Source",
                EventLogName = "Bambi.Log",
                LoggingLevel = LoggingLevel.Normal,
            };
        }

        #endregion //Methods
    }
}
