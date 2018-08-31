using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSystemMonitor.Formularios;
namespace FireSystemMonitor
{
    static class Program
    {

        public static string TagName;
        public static int SizeInPX;
        public static string Identificador;
        public static string Gdispositivo;
        public static string GtipoDispositivo;
        public static string Gfigura;

        public static string FormName;
        public static int GidZonaMonitorear;
        public static int GidFacp;
        public static string GestadoFacp;
        public static string Gventana;
        public static string Gsoftware = "Monitoreo";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainScreenForm());
            }
            catch (ArgumentNullException ex)
            {

            }
           
        }
    }
}
