using OfficeOpenXml;

namespace MarkReportUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplyLicense();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }

        private static void ApplyLicense()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
    }
}