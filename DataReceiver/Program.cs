using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
namespace DataReceiver
{
    static class Program
    {
        public static string gCOM1 ="COM1";
        public static int gBaudRate1 = 9600;
        public static string gStopBit1 = "1";
        public static string gParity1 = "None";
        public static string gDataBits1 = "7";
        public static string gNewLine1 = "\n\r";

        public static string gCOM2 = "COM1";
        public static int gBaudRate2 = 9600;
        public static string gStopBit2 = "1";
        public static string gParity2 = "None";
        public static string gDataBits2 = "7";
        public static string gNewLine2 = "\n\r";

        public static string gCOM3 = "COM1";
        public static int gBaudRate3 = 9600;
        public static string gStopBit3 = "1";
        public static string gParity3 = "None";
        public static string gDataBits3 = "7";
        public static string gNewLine3 = "\n\r";



        public static int GnumberOfActiveWindows;
        public static string Gventana = "";
        public static string Gsoftware = "Lectura";
        public static bool Gactivado = false;
        public static int GtotalFormsOpened = 1;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalFunctions GF = new GlobalFunctions();
            string msj = GF.CheckServiceRunning(Properties.Settings.Default.SQLService);
            Console.WriteLine(msj);
            if (Process.GetProcessesByName("DataReceiver").Length == 2)
            {
               return;
               
            }
            

           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataReceiver());
        }


    }
}
