using grupo3.prototipos.CAI.Archivos;
using grupo3.prototipos.CAI.Models;

namespace grupo3.prototipos.CAI
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new MenuPrincipal());
            }
            finally
            {
                ItinerariosModel.GuardarItinerariosEnJSON();
            }
        }
    }
}