namespace Bambi.Winforms.Utilities
{
    #region Using Directives

    using Figlut.Server.Toolkit.Utilities.Logging;
    using Figlut.Server.Toolkit.Utilities.SettingsFile;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion //Using Directives

    public class BambiDesktopSettings : Settings
    {
        #region Properties

        #region Application Settings

        public string Windows10LockScreenImageDirectory { get; set; }

        public string UserParameterInImageDirectory { get; set; }

        public string ImageGalleryDirectory { get; set; }

        public int MinimumImageWidth { get; set; }

        public int MinimumImageHeight { get; set; }

        public string ImageFileExtensionToAdd { get; set; }

        public bool RefreshImageGalleryOnStartup { get; set; }

        #endregion //Application Settings

        #region Logging

        public bool LogToFile { get; set; }

        public bool LogToWindowsEventLog { get; set; }

        public bool LogToConsole { get; set; }

        public string LogFileName { get; set; }

        public string EventSourceName { get; set; }

        public string EventLogName { get; set; }

        public LoggingLevel LoggingLevel { get; set; }

        #endregion //Logging

        #endregion //Properties
    }
}
