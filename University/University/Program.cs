using Services;
using Services.SupportClasses;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace University
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var form = new LoginForm();
            Application.Run(new LoginForm());
        }
    }
}