using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSystemMonitor.Formularios;
using System.Threading;

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
        private static Mutex mutex = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                const string appName = "Fire System Monitor";
                bool createdNew;

                mutex = new Mutex(true, appName, out createdNew);

                if (!createdNew)
                {
                    //app is already running! Exiting the application  
                    return;
                }

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
