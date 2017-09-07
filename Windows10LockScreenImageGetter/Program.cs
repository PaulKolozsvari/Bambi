namespace Bambi.Console
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion //Using Directives

    class Program
    {
        #region Methods

        private const string LOCK_SCREEN_IMAGE_DIRECTORY = @"C:\Users\{USER}\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";
        private const int ACCEPTABLE_WIDTH = 1920;
        private const int ACCEPTABLE_HEIGHT = 1080;

        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 1)
                {
                    throw new ArgumentException("Destination directory parameter not specified.");
                }
                string destinationDirectory = args[0];
                if (!Directory.Exists(destinationDirectory))
                {
                    throw new DirectoryNotFoundException(string.Format("Could not find destination directcory {0}.", destinationDirectory));
                }
                string userName = Environment.UserName;
                string sourceDirectory = LOCK_SCREEN_IMAGE_DIRECTORY.Replace("{USER}", userName);
                if (!Directory.Exists(sourceDirectory))
                {
                    throw new DirectoryNotFoundException(string.Format("Could not find source directory {0}.", sourceDirectory));
                }
                int imagesCopied = 0;
                foreach (string imageSourceFilePath in Directory.GetFiles(sourceDirectory))
                {
                    try
                    {
                        using (Image image = Image.FromFile(imageSourceFilePath))
                        {
                            if (image.Width < ACCEPTABLE_WIDTH || image.Height < ACCEPTABLE_HEIGHT)
                            {
                                continue;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine(string.Format("Could not load image from path: {0}.", imageSourceFilePath));
                        Console.Error.WriteLine(ex.Message);
                    }
                    string imageFileName = Path.GetFileName(imageSourceFilePath);
                    string imageFileNameWithExtension = Path.ChangeExtension(imageFileName, ".jpg");
                    string imageDestinationFilePath = Path.Combine(destinationDirectory, imageFileNameWithExtension);
                    File.Copy(imageSourceFilePath, imageDestinationFilePath);
                    Console.WriteLine("Copied: {0}", imageDestinationFilePath);
                    imagesCopied++;
                }
                Console.WriteLine();
                Console.WriteLine("Images Copied: {0}", imagesCopied);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        #endregion //Methods
    }
}
