using Microsoft.AspNetCore.Builder;

namespace lot {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            var form1 = new Form1();
            var app = WebApplication.Create();
            app.MapGet("/on", () => {
                form1.Turn_On();
            });
            app.MapGet("/off", () => {
                form1.Turn_Off();
            });
            app.RunAsync("http://*:80");
        
            Application.Run(form1);
        }
    }
}