using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataReceiver
{
    static class Program
    {
        public static string gCOM ="COM1";
        public static int gBaudRate = 9600;
        public static string gStopBit = "1";
        public static string gParity = "None";
        public static string gDataBits = "7";
        public static string gNewLine = "\n\r";
        public static string Gventana = "";
        public static string Gsoftware = "Lectura";
        public static bool Gactivado = false;





        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataReceiver());
        }
    }
}
