﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
namespace Classes
{
    
    public class GlobalFunctions
    {
        public string Company = "ELECTRO SOLUCIONES FERNANDEZ CARDENA";
        public string DevelopedBy = "Contact: Román Fernández";
        public string Tel = "Phone: 809-889-5379";
        public string WebPage = "";

        //public string Company = "MULTISERVICIOS LEA";
        //public string DevelopedBy = "Developed by Multiservicios LEA";
        //public string Tel = "Phone: 809-341-4429";
        //public string WebPage = "www.multiservicioslea.com";

        public string ValidarCampoString(string[] valores)
        {
            string msj = "OK";
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i].Trim() == "")
                {
                    msj = "Favor completar todos los campos";
                    break;
                }
            }
            return msj;
        }

        public string ValidarCampoNumerico(string[] valores)
        {
            string msj = "OK";
            double n;

            for (int i = 0; i < valores.Length; i++)
            {
                bool Num = double.TryParse(valores[i].ToString(), out n);
                if (!Num)
                {
                    msj = "Los campos numéricos no permiten letras";
                }
            }
            return msj;
        }

        public string serial()
        {
            string result = "";
            try
            {
                //wmic diskdrive get serialnumber
                ManagementClass mangnmt = new ManagementClass("Win32_DiskDrive");
                ManagementObjectCollection mcol = mangnmt.GetInstances();
                

                foreach (ManagementObject strt in mcol)
                {
                    if (Convert.ToString(strt["MediaType"]).ToUpper().Contains("FIXED"))
                    {
                        result += Convert.ToString(strt["SerialNumber"]);
                    }
                }


                
            }
            catch
            {

            }

            return result.Trim();

        }

        public List<string> GetArrayofYears()
        {
            List<String> years = new List<String>();
            var myDate = DateTime.Now.Year;
            var minDate = myDate - 20;
            if (DateTime.Now.Month >= 7)
            {
                myDate = DateTime.Now.Year + 1;
                minDate = myDate - 11;
            }
            
            
            for (int i = minDate; i <= myDate; i++)
            {
                years.Add(i.ToString());
            }

            return years;
        }

        //public bool ValidarPermisoTransaccion(string transaccion)
        //{
        //    bool acceso = false;
        //    Procedimientos P = new Procedimientos();
        //    DataTable dt = new DataTable();
        //    P.Id = Program.GidUsuario;
        //    dt = P.ObtenerPermisosUsuario();
        //    if (Convert.ToBoolean(dt.Rows[0]["ESTADO USUARIO"]))
        //    {
        //        if (transaccion == "CREAR USUARIOS")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["CREAR USUARIOS"]);
        //        }
        //        else if (transaccion == "TASA CAMBIO")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["TASA CAMBIO"]);
        //        }

        //        else if (transaccion == "CREAR FABRICANTES/MODELOS")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["CREAR FABRICANTES/MODELOS"]);
        //        }

        //        else if (transaccion == "CREAR PIEZAS/REPUESTOS")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["CREAR PIEZAS/REPUESTOS"]);
        //        }
        //        else if (transaccion == "CREAR TALLER")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["CREAR TALLER"]);
        //        }

        //        else if (transaccion == "CREAR PROPIETARIOS")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["CREAR PROPIETARIOS"]);
        //        }

        //        else if (transaccion == "CREAR CLIENTES")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["CREAR CLIENTES"]);
        //        }

        //        else if (transaccion == "CREAR GASTOS")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["CREAR GASTOS"]);
        //        }

        //        else if (transaccion == "IMPORTAR VEHICULOS")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["IMPORTAR VEHICULOS"]);
        //        }

        //        else if (transaccion == "COMPRAS")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["COMPRAS"]);
        //        }

        //        else if (transaccion == "CAMBIAR ESTADO VEHICULOS")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["CAMBIAR ESTADO VEHICULOS"]);
        //        }

        //        else if (transaccion == "AGREGAR GASTO A VEHICULO")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR GASTO A VEHICULO"]);
        //        }

        //        else if (transaccion == "AGREGAR PIEZAS A VEHICULO")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR PIEZAS A VEHICULO"]);
        //        }

        //        else if (transaccion == "REPORTES")
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["REPORTES"]);
        //        }

        //        else if ((transaccion == "FACTURACION"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["FACTURACION"]);
        //        }

        //        else if ((transaccion == "MODIFICAR VEHICULO"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["MODIFICAR VEHICULO"]);
        //        }

        //        else if ((transaccion == "CUENTAS COBRAR"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["CUENTAS COBRAR"]);
        //        }

        //        else if ((transaccion == "CUENTAS PAGAR"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["CUENTAS PAGAR"]);
        //        }

        //        else if ((transaccion == "ACTUALIZAR TASA DIARIO"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["ACTUALIZAR TASA DIARIO"]);
        //        }

        //        else if ((transaccion == "AGREGAR PAISES"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR PAISES"]);
        //        }

        //        else if ((transaccion == "AGREGAR CIUDADES"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR CIUDADES"]);
        //        }

        //        else if ((transaccion == "AGREGAR COLORES"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR COLORES"]);
        //        }

        //        else if ((transaccion == "AGREGAR SUPLIDORES"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR SUPLIDORES"]);
        //        }

        //        else if ((transaccion == "AGREGAR UBICACIONES"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR UBICACIONES"]);
        //        }

        //        else if ((transaccion == "AGREGAR SEGUROS"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR SEGUROS"]);
        //        }

        //        else if ((transaccion == "AGREGAR CUENTAS ANTIGUAS"))
        //        {
        //            acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR CUENTAS ANTIGUAS"]);
        //        }
        //    }


        //    return acceso;
        //}

        public string serialKeyActivation(int total)
        {
            string result = "none";



            int totalSumSerial = 10000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);//normal
            int totalSumSerial3 = 15000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);//advanced
            int totalSumSerial4 = 20000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);//premium

            int totalSumSerial2 = 5000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);

            if (totalSumSerial == total || totalSumSerial3 == total || totalSumSerial4 == total)
            {
                result = "Full";
            }
            else if (totalSumSerial2 == total)
            {
                result = "Trial";
            }
            return result;
        }


        public int KeytotalPuertos(int total)
        {
           int result = 1;


            int trial = 5000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);//trial
            int totalSumSerial = 10000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);//normal
            int totalSumSerial2 = 15000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);//advanced
            int totalSumSerial3 = 20000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);//premium

          
            if (totalSumSerial == total || trial == total)
            {
                result = 1;
            }
            else if (totalSumSerial2 == total)
            {
                result = 2;
            }
            else
            {
                result = 3;
            }
            return result;
        }

        public bool TodayPassWord(string passwordEntered)
        {
            bool Result = false;
            int datekey = 100000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);
            string todayPass = "MULTISERVICIOS" + datekey.ToString();

            if(todayPass == passwordEntered)
            {
                Result = true;
            }
            return Result;
        }

        public static void StartSQLService()
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "net start \"Sql Server (MSSQLSERVER)\"";
                process.Start();
            } catch(Exception ex)
            {
               
            }
        }

        public string CheckServiceRunning(string service)
        {
           
            ServiceController sc = new ServiceController(service);

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    return "Running";
                case ServiceControllerStatus.Stopped:
                    try
                    {
                        sc.Start();
                    }
                    catch { }
                   
                    return "Stopped";
                case ServiceControllerStatus.Paused:
                    return "Paused";
                case ServiceControllerStatus.StopPending:
                    return "Stopping";
                case ServiceControllerStatus.StartPending:
                    return "Starting";
                default:
                    return "Status Changing";
            }
        }



    }

}
