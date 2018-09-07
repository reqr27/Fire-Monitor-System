using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Classes
{
    public class Procedimientos
    {
        private Conexion C = new Conexion();
        byte[] Mimg;
        int Mid;
        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }

        string Mnombre;
        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }


        string Mapellido;
        public string Apellido
        {
            get { return Mapellido; }
            set { Mapellido = value; }
        }

        string McedulaRnc;
        public string CedulaRNC
        {
            get { return McedulaRnc; }
            set { McedulaRnc = value; }
        }

        string Mdireccion;
        public string Direccion
        {
            get { return Mdireccion; }
            set { Mdireccion = value; }
        }

        string Mtelefono1;
        public string Telefono1
        {
            get { return Mtelefono1; }
            set { Mtelefono1 = value; }
        }

        bool Mestado;
        public bool Estado
        {
            get { return Mestado; }
            set { Mestado
                    = value; }
        }

        string Mcliente;
        public string Cliente
        {
            get { return Mcliente; }
            set { Mcliente = value; }
        }

        int MidTipoCliente;
        public int IdTipoCliente
        {
            get { return MidTipoCliente; }
            set { MidTipoCliente = value; }
        }
        string Mdescripcion;
        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }

        double MprecioSinItbis;
        public double PrecioSinItbis
        {
            get { return MprecioSinItbis; }
            set {MprecioSinItbis = value; }
        }

        double Mitbis;
        public double Itbis
        {
            get { return Mitbis; }
            set { Mitbis = value; }
        }

        public byte[] Img
        {
            get { return Mimg; }
            set { Mimg = value; }
        }

        int Mtamaño;
        public int Tamaño
        {
            get { return Mtamaño; }
            set { Mtamaño = value; }
        }

        int MidZona;
        public int IdZona
        {
            get { return MidZona; }
            set { MidZona = value; }
        }

        int MidDetector;
        public int IdDetector
        {
            get { return MidDetector; }
            set { MidDetector = value; }
        }

        int MposX;
        public int PosX
        {
            get { return MposX; }
            set { MposX = value; }
        }

        int MposY;
        public int PosY
        {
            get { return MposY; }
            set { MposY = value; }
        }

        string Midentificador;
        public string Identificador
        {
            get { return Midentificador; }
            set { Midentificador = value; }
        }

        string MestadoDetector;
        public string EstadoDetector
        {
            get { return MestadoDetector; }
            set { MestadoDetector = value; }
        }

        string MestadoFacp;
        public string EstadoFacp
        {
            get { return MestadoFacp; }
            set { MestadoFacp = value; }
        }

        string Mcom;
        public string COM
        {
            get { return Mcom; }
            set { Mcom = value; }
        }

        int MbaudRate;
        public int BaudRate
        {
            get { return MbaudRate; }
            set { MbaudRate = value; }
        }

        string Mdatabits;
        public string Databits
        {
            get { return Mdatabits; }
            set { Mdatabits = value; }
        }

        string Mparity;
        public string Parity
        {
            get { return Mparity; }
            set { Mparity = value; }
        }

        string MstopBit;
        public string StopBit
        {
            get { return MstopBit; }
            set {MstopBit = value; }
        }

        string MnewLine;
        public string NewLine
        {
            get { return MnewLine; }
            set { MnewLine = value; }
        }

        int MidFacp;
        public int ID_FACP
        {
            get { return MidFacp; }
            set { MidFacp = value; }
        }

        DateTime Mdesde;
        public DateTime Desde
        {
            get { return Mdesde; }
            set { Mdesde = value; }
        }

        DateTime Mhasta;
        public DateTime Hasta
        {
            get { return Mhasta; }
            set { Mhasta = value; }
        }

        int Mpuerto;
        public int Puerto
        {
            get { return Mpuerto; }
            set { Mpuerto = value; }
        }

        string Memail;
        public string Email
        {
            get { return Memail; }
            set { Memail = value; }
        }

        string Mhost;
        public string Host
        {
            get { return Mhost; }
            set { Mhost = value; }
        }

        string Mpass;
        public string Password
        {
            get { return Mpass; }
            set { Mpass = value; }
        }

        bool Mconexion;
        public bool Conexion
        {
            get { return Mconexion; }
            set { Mconexion = value; }
        }

        bool Mwarning;
        public bool Warning
        {
            get { return Mwarning; }
            set { Mwarning = value; }
        }

        bool Malarma;
        public bool Alarma
        {
            get { return Malarma; }
            set { Malarma = value; }
        }

        string MhddSerial;
        public string HDD_SERIAL
        {
            get { return MhddSerial; }
            set { MhddSerial = value; }
        }

        string Msoftware;
        public string SOFTWARE
        {
            get { return Msoftware; }
            set { Msoftware = value; }
        }

        string MtipoActivacion;
        public string TipoActivacion
        {
            get { return MtipoActivacion; }
            set { MtipoActivacion = value; }
        }

        int MtotalPuerto;
        public int TotalPuertos
        {
            get { return MtotalPuerto; }
            set { MtotalPuerto = value; }
        }

        string Mdispositivo;
        public string Dispositivo
        {
            get { return Mdispositivo; }
            set { Mdispositivo = value; }
        }

        string MtipoDispositivo;
        public string TipoDispositivo
        {
            get { return MtipoDispositivo; }
            set { MtipoDispositivo = value; }
        }

        string Mfigura;
        public string Figura
        {
            get { return Mfigura; }
            set { Mfigura = value; }
        }

        #region ConfigurarZonas

        public string InsertarZona()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@img", Mimg));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@idFacp", MidFacp));

            C.EjecutarSP("REGISTRAR_ZONAS", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarEmail()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@email", Memail));
            lst.Add(new clsParametros("@conexion", Mconexion));
            lst.Add(new clsParametros("@warning", Mwarning));
            lst.Add(new clsParametros("@alarma", Malarma));


            C.EjecutarSP("REGISTRAR_EMAIL", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarConfigRemitente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            
            lst.Add(new clsParametros("@email", Memail));
            lst.Add(new clsParametros("@puerto", Mpuerto));
            lst.Add(new clsParametros("@host", Mhost));
            lst.Add(new clsParametros("@password", Mpass));
            lst.Add(new clsParametros("@desde", Mdesde));


            C.EjecutarSP("REGISTRAR_CONFIG_REMITENTE", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string InsertarFacp()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@nombre", Mnombre));
            
            C.EjecutarSP("REGISTRAR_FACP", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string InsertarDetectoresZona()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@tamaño", Mtamaño));
            lst.Add(new clsParametros("@pos_x", MposX));
            lst.Add(new clsParametros("@pos_y", MposY));
            lst.Add(new clsParametros("@idZona", MidZona));
            lst.Add(new clsParametros("@identificador", Midentificador));
            lst.Add(new clsParametros("@dispositivo", Mdispositivo));
            lst.Add(new clsParametros("@tipoDispositivo", MtipoDispositivo));
            lst.Add(new clsParametros("@figura", Mfigura));

            C.EjecutarSP("REGISTRAR_DETECTORES", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string CheckIfSoftwareActivated()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@hdd_serial", MhddSerial));

            lst.Add(new clsParametros("@software", Msoftware));


            C.EjecutarSP("CHECK_SOFTWARE_ACTIVATION", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ObtenerTotalPuertos()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@hdd_serial", MhddSerial));

            lst.Add(new clsParametros("@software", Msoftware));


            C.EjecutarSP("OBTENER_TOTAL_PUERTOS", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public void InsertarDispositivos_yTipos()
        {
            
            List<clsParametros> lst = new List<clsParametros>();
            C.EjecutarSP("INSERTAR_DISPOSITIVOS_Y_TIPOS", ref lst);
            
        }

        public string ActualizarZona()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@img", Mimg));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@idZona", MidZona));
            lst.Add(new clsParametros("@estado", Mestado));
            lst.Add(new clsParametros("@idFacp", MidFacp));

            C.EjecutarSP("ACTUALIZAR_ZONA", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarFacp()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@idFacp", MidFacp));
            

            C.EjecutarSP("ACTUALIZAR_FACP", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarFechaOnlineFacp()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idFacp", MidFacp));


            C.EjecutarSP("ACTUALIZAR_ONLINE_ESTATUS_FACP", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarEstadoFacp()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@estado", MestadoFacp));
            lst.Add(new clsParametros("@idFacp", MidFacp));

            C.EjecutarSP("ACTUALIZAR_ESTADO_FACP", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ObtenerEstadoOnlineFacp()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idFacp", MidFacp));

            C.EjecutarSP("OBTENER_ONLINE_ESTATUS_FACP", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerDiasActivoSoftware()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@hdd_serial", MhddSerial));
            lst.Add(new clsParametros("@software", Msoftware));

           
           
            return dt = C.Listado("OBTENER_DIAS_ACTIVO", lst);
        }

        public string ActualizarFechaCorreoDiario()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            

            C.EjecutarSP("ACTUALIZAR_FECHA_CORREO_DIARIO", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerConfigRemitenteEmail()
        {
            List<clsParametros> lst = new List<clsParametros>();

            DataTable dt = new DataTable();

            return dt = C.Listado("OBTENER_CONFIG_REMITENTE", lst);
        }

        public DataTable ObtenerLogFacp()
        {
            
            List<clsParametros> lst = new List<clsParametros>();

            DataTable dt = new DataTable();
            
            lst.Add(new clsParametros("@idFacp", MidFacp));
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));

            return dt = C.Listado("OBTENER_LOG_FACP", lst);

            
        }

        public DataTable ObtenerDataDetectoresEnviarEmail()
        {

            List<clsParametros> lst = new List<clsParametros>();

            DataTable dt = new DataTable();

            lst.Add(new clsParametros("@idFacp", MidFacp));
           

            return dt = C.Listado("OBTENER_DATA_ENVIAR_EMAIL", lst);


        }

        public DataTable ObtenerEmails()
        {

            List<clsParametros> lst = new List<clsParametros>();

            DataTable dt = new DataTable();
            return dt = C.Listado("OBTENER_EMAILS", lst);

         }

        public DataTable ObtenerDispositivos()
        {

            List<clsParametros> lst = new List<clsParametros>();

            DataTable dt = new DataTable();
            return dt = C.Listado("OBTENER_DISPOSITIVOS", lst);

        }

        public DataTable ObtenerTiposDispositivos()
        {

            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Mid));
            DataTable dt = new DataTable();
            return dt = C.Listado("OBTENER_TIPOS_DISPOSITIVOS", lst);

        }

        public string BorrarEmail()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id", Mid));

            C.EjecutarSP("BORRAR_EMAIL", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerImagenesZonas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idZona", Mid));
            return dt = C.Listado("OBTENER_IMAGENES_ZONAS", lst);
        }

        public DataTable ObtenerDetectoresZonas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idZona", MidZona));
            return dt = C.Listado("OBTENER_DETECTORES_POR_ZONAS", lst);
        }

        public DataTable ObtenerZonas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idFacp", MidFacp));
            return dt = C.Listado("OBTENER_ZONAS", lst);
        }

        public DataTable ObtenerFacp()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@idZona", MidZona));
            return dt = C.Listado("OBTENER_FACP", lst);
        }


        public DataTable ObtenerZonasHabilitadas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idFacp", MidFacp));
            return dt = C.Listado("OBTENER_ZONAS_HABILITADAS", lst);
        }


        public DataTable ObtenerEstadoDetectorIndividual()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idZona", MidZona));
            lst.Add(new clsParametros("@idDetector", MidDetector));
            lst.Add(new clsParametros("@identificador", Midentificador));
            lst.Add(new clsParametros("@nombre", Mnombre));


            return dt = C.Listado("OBTENER_ESTADO_DETECTOR_INDIVIDUAL", lst);
        }



        public string ActualizarDetectoresZona()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@tamaño", Mtamaño));
            lst.Add(new clsParametros("@pos_x", MposX));
            lst.Add(new clsParametros("@pos_y", MposY));
            lst.Add(new clsParametros("@idZona", MidZona));
            lst.Add(new clsParametros("@idDetector", MidDetector));
            lst.Add(new clsParametros("@identificador", Midentificador));
            lst.Add(new clsParametros("@dispositivo", Mdispositivo));
            lst.Add(new clsParametros("@tipoDispositivo", MtipoDispositivo));
            lst.Add(new clsParametros("@figura", Mfigura));



            C.EjecutarSP("ACTUALIZAR_DETECTORES_ZONA", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ResetEstadoTodosDetectoresFacpEspecifico()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
       
            lst.Add(new clsParametros("@idFacp", MidFacp));

            C.EjecutarSP("RESET_ESTADOS_DETECTORES_FACP_ESPECIFICO", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string BorrarDetector()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

            lst.Add(new clsParametros("@idZona", MidZona));
            lst.Add(new clsParametros("@idDetector", MidDetector));
            C.EjecutarSP("BORRAR_DETECTOR", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string BorrarFACP()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

            lst.Add(new clsParametros("@idFacp", MidFacp));
            //lst.Add(new clsParametros("@idDetector", MidDetector));
            C.EjecutarSP("ELIMINAR_FACP", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerConfiguracionesSerial()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("OBTENER_CONFIGURACIONES_PUERTO_SERIAL", lst);
        }


        public DataTable ObtenerConfiguracionesSerialEspecifica()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@nombre", Mnombre));
            return dt = C.Listado("OBTENER_CONFIGURACION_ESPECIFICA", lst);
        }

        public DataTable ObtenerNombreFacp()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idFacp", MidFacp));
            return dt = C.Listado("OBTENER_NOMBRE_FACP", lst);
        }

        public DataTable ObtenerEstadoFacp()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idFacp", MidFacp));
            return dt = C.Listado("OBTENER_ESTADO_FACP", lst);
        }

        public DataTable ObtenerEstadoEmailFacp()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idFacp", MidFacp));
            return dt = C.Listado("OBTENER_ESTADO_EMAIL_FACP", lst);
        }


        public string ActualizarEstadoDetector()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idFacp", MidFacp));
            lst.Add(new clsParametros("@estado", MestadoDetector));
            lst.Add(new clsParametros("@identificador", Midentificador));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));

            C.EjecutarSP("ACTUALIZAR_ESTADO_DETECTOR", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string InsertarConfiguracionPuertoSerial()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@identificador", Midentificador));
            lst.Add(new clsParametros("@com", Mcom));
            lst.Add(new clsParametros("@baudrate", MbaudRate));
            lst.Add(new clsParametros("@databits", Mdatabits));
            lst.Add(new clsParametros("@parity", Mparity));
            lst.Add(new clsParametros("@stopbit", MstopBit));
            lst.Add(new clsParametros("@newline", MnewLine));


            C.EjecutarSP("REGISTRAR_CONFIGURACION_PUERTO_SERIAL", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string InsertarLogFacp()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idFacp", MidFacp));
            lst.Add(new clsParametros("@estadoFacp", MestadoFacp));
            
            C.EjecutarSP("INSERTAR_LOG_FACP ", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }



        public string ActualizarConfiguracionPuertoSerial()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@identificador", Midentificador));
            lst.Add(new clsParametros("@com", Mcom));
            lst.Add(new clsParametros("@baudrate", MbaudRate));
            lst.Add(new clsParametros("@databits", Mdatabits));
            lst.Add(new clsParametros("@parity", Mparity));
            lst.Add(new clsParametros("@stopbit", MstopBit));
            lst.Add(new clsParametros("@newline", MnewLine));
            lst.Add(new clsParametros("@id", Mid));



            C.EjecutarSP("ACTUALIZAR_CONFIGURACION_PUERTO_SERIAL", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActivarSoftware()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@tipo", MtipoActivacion));
            lst.Add(new clsParametros("@hdd_serial", MhddSerial));
            lst.Add(new clsParametros("@software", Msoftware));
            lst.Add(new clsParametros("@totalPuertos", MtotalPuerto));
            C.EjecutarSP("ACTIVAR_SOFTWARE", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;

        }


        public DataTable ObtenerInfoSoftware()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@hdd_serial", MhddSerial));
            lst.Add(new clsParametros("@software", Msoftware));
            return dt = C.Listado("OBTENER_INFO_SOFTWARE", lst);
        }

        public DataTable ObtenerEstadoZonas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idZona", MidZona));
            
            return dt = C.Listado("OBTENER_ESTADO_ZONA", lst);
        }

        public DataTable ObtenerUltimoEstadoFacp()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idFacp", MidFacp));

            return dt = C.Listado("OBTENER_ULTIMO_ESTADO_FACP", lst);
        }


        public string ActualizarEstatusEvacuacion()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idFacp", MidFacp));
           
            C.EjecutarSP("UPDATE_EVACUACION_FIELD_FACP", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerEstadoEvacuacionFacp()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idFacp", MidFacp));

            return dt = C.Listado("OBTENER_ESTADO_EVACUACION_FACP", lst);
        }

        #endregion




    }
}
