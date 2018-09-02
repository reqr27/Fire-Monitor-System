using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataReceiver.Formularios;
using Classes;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace DataReceiver
{
    public partial class DataReceiver : Form
    {
        GlobalFunctions GF = new GlobalFunctions();
        string dataRead = "";
        int idFacpConfigurado;
        List<String> EstatusArray = new List<String>();
        Procedimientos P = new Procedimientos();
        string NombreConfigPuertoSerial;
        int totalReads = 0;
        delegate void SetTextCallback(string text);
        public DataReceiver()
        {
            InitializeComponent();
        }


        #region Funciones

        public void GetFACP()
        {
            DataTable dt = new DataTable();
            idFacpConfigurado = Properties.Settings.Default.ID_FAPC;
            P.ID_FACP = idFacpConfigurado;
            dt = P.ObtenerNombreFacp();
            if(dt.Rows.Count > 0)
            {
                facp_cb.Text = dt.Rows[0][0].ToString();
            }
        }

        public void LLenarFacpCB()
        {
            facp_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerFacp();
            facp_cb.DataSource = dt;
            facp_cb.DisplayMember = "NOMBRE";
            facp_cb.ValueMember = "ID";
            //facp_cb.SelectedIndex = -1;


        }

        public void ConnectSerialPort()
        {
           
            Config_lbl.Text = Properties.Settings.Default.ConfiguracionSerial;
            if (serialPort1.IsOpen)
            {
                estatus_txt.Text = "Online";
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                string msj = P.ActualizarFechaOnlineFacp();

            }
            else
            {
                
                serialPort1.DtrEnable = true;
                serialPort1.ReadBufferSize = 1048576;
                serialPort1.BaudRate = Program.gBaudRate;
                serialPort1.PortName = Program.gCOM;
                if(Program.gParity == "None")
                {
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                }
                else if (Program.gParity == "Even")
                {
                    serialPort1.Parity = System.IO.Ports.Parity.Even;
                }

                else // odd
                {
                    serialPort1.Parity = System.IO.Ports.Parity.Odd;
                }
                if(Program.gDataBits == "7")
                {
                    serialPort1.DataBits = 7;
                }
                else
                {
                    serialPort1.DataBits = 8;
                }

                if (Program.gStopBit == "None")
                {
                    serialPort1.StopBits = System.IO.Ports.StopBits.None;
                }
                else if (Program.gStopBit == "1")
                {
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;

                }

                else if (Program.gStopBit == "1.5")
                {
                    serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;

                }

                else
                {
                    serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                }
                
                serialPort1.NewLine = Program.gNewLine;

                try
                {
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                       estatus_txt.Text = "Online";
                       P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                       string msj = P.ActualizarFechaOnlineFacp();
                    }
                    else
                    {
                        estatus_txt.Text = "Offline";
                    }
                }

                catch (Exception ex)
                {
                    estatus_txt.Text = "Offline";
                }
            }
        }

        public void SetText(string text)
        {
            EstatusArray.Clear();
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }

            else
            {
                ProcessDataTimer.Start();
               
                //textBox1.Text += text;


                //textBox1.SelectionStart = textBox1.Text.Length;
                //// scroll it automatically
                
                //textBox1.ScrollToCaret();
            }
            
        }

        public void ObtenerConfiguracionEspecifica()
        {
            DataTable dt = new DataTable();
            P.Nombre = NombreConfigPuertoSerial;
            dt = P.ObtenerConfiguracionesSerialEspecifica();
            if(dt.Rows.Count > 0)
            {
                Properties.Settings.Default.ConfiguracionSerial = dt.Rows[0][0].ToString();
                Properties.Settings.Default.Save();

                NombreConfigPuertoSerial = Properties.Settings.Default.ConfiguracionSerial;
                Program.gCOM = dt.Rows[0][1].ToString();
                Program.gBaudRate = Convert.ToInt32(dt.Rows[0][2].ToString());
                Program.gDataBits = dt.Rows[0][3].ToString();
                Program.gParity = dt.Rows[0][4].ToString();
                Program.gStopBit = dt.Rows[0][5].ToString();
                Program.gNewLine = dt.Rows[0][6].ToString();
               //Program.gFacp =  dt.Rows[0][7].ToString();
            }
        }

        public void ProcessData(string data)
        {
            
            string result = data;
            dataRead = "";
            string dataLineByLine = "";
            for (int i = 0; i < result.Length; i++)
            {
                dataLineByLine = dataLineByLine+ result[i];
                if (dataLineByLine.Contains("\r\n"))
                {
                    dataLineByLine = Regex.Replace(dataLineByLine, @"\r|\n", "").Trim();
                    UpdateStatusOfDetectoresDb(dataLineByLine);
                    AppendText(dataLineByLine);
                    dataLineByLine = "";
                    
                }
            }   
        }

        public void UpdateStatusOfDetectoresDb(string text)
        {
            if (text.StartsWith("ALARM") || text.StartsWith("TROUBL"))
            {
                Email_timer.Stop();
            }
           
            Console.WriteLine(text);


            
            if (text.Contains("RESET  IN SYSTEM"))
            {

                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                string msj = P.ResetEstadoTodosDetectoresFacpEspecifico();
                
            }

            else if (text.Contains("EVAC   IN SYSTEM")) // evacuar 
            {
                
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                string msj = P.ActualizarEstatusEvacuacion();
            }

            else if (text.Contains("CLEARt") || text.Contains("CLEARa"))
            {
                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "OK";
                P.Descripcion = "Sistema OK";
                string msj = P.ActualizarEstadoDetector();
            }

            else if (text.StartsWith("ALARM") && text.Contains("HEAT"))
            {
                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "HEAT";
                P.Descripcion = "Sistema detectó calor";
                string msj = P.ActualizarEstadoDetector();

            }

            else if (text.StartsWith("ALARM") && text.Contains("SMOKE"))
            {
                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "SMOKE";
                P.Descripcion = "Sistema detectó humo";
                string msj = P.ActualizarEstadoDetector();

            }

            else if (text.StartsWith("ALARM") && text.Contains("MONITOR"))
            {
                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "MONITOR";
                P.Descripcion = "PULL ACTIVO";
                string msj = P.ActualizarEstadoDetector();

            }

            else if (text.StartsWith("ALARM") && text.Contains("PULL"))
            {
                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "PULL STATION";
                P.Descripcion = "Dispositivo Manual Activado";
                string msj = P.ActualizarEstadoDetector();

            }

            else if (text.StartsWith("TROUBL") && text.Contains("INVREP"))
            {
               
                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "INVREP";
                P.Descripcion = "Alerta de mantenimiento que indica un problema de hardware o de comunicaciónen el detector";

                string msj = P.ActualizarEstadoDetector();
                
                
            }

            else if (text.StartsWith("TROUBL") && text.Contains("OPEN") && !text.Contains("NAC"))
            {
             
                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "OPEN";
                P.Descripcion = "Indica un circuito abierto en un dispositivo direccionable";

                string msj = P.ActualizarEstadoDetector();
                
            }

            else if (text.StartsWith("TROUBL") && text.Contains("SHORT"))
            {

                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "SHORT";
                P.Descripcion = "Indica un corto circuito en un dispositivo direccionable";

                string msj = P.ActualizarEstadoDetector();

            }

            else if (text.StartsWith("TROUBL") && text.Contains("DIRTY1"))
            {

                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "DIRTY1";
                P.Descripcion = "Alerta de mantenimiento que indica que un detector está cercano a alcanzar, aunque aún dentro del límite de alarma permitido, el umbral que indica que necesita mantenimiento antes de que su funcionamiento se vea comprometido";

                string msj = P.ActualizarEstadoDetector();

            }

            else if (text.StartsWith("TROUBL") && text.Contains("DIRTY2"))
            {

                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "DIRTY2";
                P.Descripcion = "Alerta de mantenimiento que indica que un detector necesita mantenimiento inmediato ya que ha estado dentro del 80 % de su límite de alarma durante 24 horas";

                string msj = P.ActualizarEstadoDetector();

            }

            else if (text.StartsWith("TROUBL") && text.Contains("INV ID"))
            {

                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "INV ID";
                P.Descripcion = "Indica que se programó un código de dispositivo incorrecto (Type ID) para un dispositivo instalado (por ejemplo, se programó como fotoeléctrico y se instaló un detector de ionización).";
                string msj = P.ActualizarEstadoDetector();

            }

            else if (text.StartsWith("TROUBL") && text.Contains("TEST F"))
            {

                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "TEST F";
                P.Descripcion = "Indica que un detector falló la operación de prueba automática que verifica el funcionamiento de la cámara sensora del detector y los elementos electrónicos";
                string msj = P.ActualizarEstadoDetector();

            }

            else if (text.StartsWith("TROUBL") && text.Contains("SW TBL"))
            {

                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "SW TBL";
                P.Descripcion = "Indica que un módulo falló la prueba de su relé de conmutación de clase A";
                string msj = P.ActualizarEstadoDetector();

            }

            else if (text.StartsWith("TROUBL") && text.Contains("BLOCK"))
            {

                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "BLOCK";
                P.Descripcion = "Indica que un detector de rayos está completamente bloqueado";
                string msj = P.ActualizarEstadoDetector();

            }

            else if (text.StartsWith("TROUBL") && text.Contains("ALIGN"))
            {

                string[] namesArray = text.Trim().Split(' ');
                int index = namesArray.Length - 1;
                P.Identificador = namesArray[index];
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.EstadoDetector = "ALIGN";
                P.Descripcion = "Indica que un detector de rayos está en modo alineación de rayo";
                string msj = P.ActualizarEstadoDetector();

            }

            else
            {
                if (text.StartsWith("TROUBL"))
                {

                    P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                    string mystring = text.Replace("\n", "");

                    P.EstadoFacp = text;

                    string msj = P.ActualizarEstadoFacp();
                }
                
            }
            if(text.StartsWith("ALARM") || text.StartsWith("TROUBL"))
            {
                Email_timer.Start();
            }
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            string status = regex.Replace(text, " "); // eliminar espacios en blanco

            InsertarLogFacp(status);
            

        }

        public void InsertarLogFacp(string estado)
        {
            P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
            P.EstadoFacp = estado;

            string msj = P.InsertarLogFacp();
        }

        public void SendMail(string titulo)
        {
            int puerto = 0;
            string host = "";
            string emailRemitente = "";
            string pass = "";
            int idFacp = Convert.ToInt32(facp_cb.SelectedValue);
            DataTable dt = new DataTable();
            DataTable dtEmails = new DataTable();
            dtEmails = P.ObtenerEmails();
            dt = P.ObtenerConfigRemitenteEmail();
            if (dt.Rows.Count > 0 && dtEmails.Rows.Count > 0)
            {
                puerto = Convert.ToInt32(dt.Rows[0][1].ToString());
                host = dt.Rows[0][2].ToString();
                emailRemitente = dt.Rows[0][3].ToString();
                pass = dt.Rows[0][4].ToString();


                try
                {


                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    smtp.Port = puerto;
                    smtp.Host = host;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(emailRemitente, pass);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                    message.From = new MailAddress(emailRemitente);

                    for (int i = 0; i < dtEmails.Rows.Count; i++)
                    {
                        string ema = dtEmails.Rows[i][2].ToString();
                        message.To.Add(new MailAddress(dtEmails.Rows[i][2].ToString()));
                    }
                    string sendMailConfirmation = "";
                    string body = "";
                    P.ID_FACP = idFacp;

                    DataTable dtestadoFacp = new DataTable();
                    dtestadoFacp = P.ObtenerEstadoFacp();
                    if(dtestadoFacp.Rows.Count > 0)
                    {
                        sendMailConfirmation = dtestadoFacp.Rows[0][0].ToString();
                       body  = "MENSAJE GENERAL PANEL:"+ Environment.NewLine + Environment.NewLine + dtestadoFacp.Rows[0][0].ToString() + Environment.NewLine + Environment.NewLine + "ESTADOS DETECTORES/MOODULOS" + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        body = "MENSAJE GENERAL PANEL:" + Environment.NewLine + Environment.NewLine + "OK" + Environment.NewLine + Environment.NewLine + "ESTADOS DETECTORES/MODULOS" + Environment.NewLine + Environment.NewLine;
                        sendMailConfirmation = "OK";
                    }

                    DataTable dtEstadosDetectores = new DataTable();
                    P.ID_FACP = idFacp;
                    dtEstadosDetectores = P.ObtenerDataDetectoresEnviarEmail();
                    for (int i = 0; i < dtEstadosDetectores.Rows.Count; i++)
                    {
                        sendMailConfirmation += dtEstadosDetectores.Rows[i][4].ToString();
                        body += "* Nombre: " + dtEstadosDetectores.Rows[i][2].ToString() + "   Identificador: " + dtEstadosDetectores.Rows[i][3].ToString() + "   ESTADO: " + dtEstadosDetectores.Rows[i][4].ToString() + Environment.NewLine;
                    }

                    message.Subject = titulo;
                    message.Body = body;
                    if(sendMailConfirmation != "OK")
                    {
                        smtp.Send(message);
                    }
                    //Console.WriteLine(body);
                    
                    
                    //MessageBox.Show("The mail was sent successfully!");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error " + ex.Message);
                }
            }



        }

        public void CheckForDailyMail()
        {
            DateTime dateConfig;
            DateTime lastDailyEmail;
            DateTime DateNow = DateTime.Now;
            DataTable dt = new DataTable();
            dt = P.ObtenerConfigRemitenteEmail();
            if (dt.Rows.Count > 0)
            {
                dateConfig = Convert.ToDateTime(dt.Rows[0][5].ToString());
                lastDailyEmail = Convert.ToDateTime(dt.Rows[0][6].ToString());
                if(lastDailyEmail.Date < DateNow.Date)
                {
                    if(DateNow.TimeOfDay >= dateConfig.TimeOfDay  )
                    {
                        SendMail(facp_cb.Text + " CORREO DIARIO");
                        string msj = P.ActualizarFechaCorreoDiario();
                    }
                }

            }
        }

        void AppendText( string text)
        {
            Color color = new Color();

            if (text.StartsWith("ALARM"))
            {
                color = Color.Red;
            }
            else if (text.StartsWith("TROUBL"))
            {
                color = Color.Orange; //FromArgb(241, 196, 15);
            }
            else
            {
                color = Color.Black;
            }
           

            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.SelectionLength = 0;

            textBox1.SelectionColor = color;
            textBox1.AppendText(text + Environment.NewLine);
            textBox1.SelectionColor = textBox1.ForeColor;
            totalReads++;
            

            // Textbox may transform chars, so (end-start) != text.Length




            // scroll it automatically

            textBox1.ScrollToCaret();
            textBox1.SelectionLength = 0; // clear
            if (totalReads == 100)
            {
                textBox1.Text = "";
                totalReads = 0;
            }
        }

        public bool CheckIfSoftwareActivated()
        {
            bool result = false;
            P.HDD_SERIAL = GF.serial();
            P.SOFTWARE = Program.Gsoftware;
            string msj = P.CheckIfSoftwareActivated();
            //msj = "FULL";

            if (msj == "Trial")
            {
                int dias = ObtenerDiasActivo();
                if (dias == 0)
                {
                    msjActivado_lbl.Text = "VERSION DE PRUEBA HA FINALIZADO";
                    ControlsState(false);
                    Program.Gactivado = false;

                }
                else
                {
                    msjActivado_lbl.Text = "VERSION DE PRUEBA - DIAS RESTANTES : " + dias;
                    ControlsState(true);
                    result = true;
                    Program.Gactivado = true;
                    activar_btn.Text = "Upgrade";
                    activar_btn.Image = null;
                    activar_btn.Image = Properties.Resources.arrow_177_48;
                }


            }

            else if (msj == "Full")
            {

                P.HDD_SERIAL = GF.serial();
                P.SOFTWARE = Program.Gsoftware;
                int puerto =Convert.ToInt32(P.ObtenerTotalPuertos());
                if(puerto == 3)
                {
                    msjActivado_lbl.Visible = false;
                    ControlsState(true);
                    activar_btn.Visible = false;
                }
                else
                {
                  
                    activar_btn.Visible = true;
                    activar_btn.Text = "Upgrade";
                    activar_btn.Image = null;
                    activar_btn.Image = Properties.Resources.arrow_177_48;
                }
               
                result = true;
                Program.Gactivado = true;
            }
            else

            {
                ControlsState(false);
                msjActivado_lbl.Text = "SOFTWARE NO HA SIDO ACTIVADO";
                result = false;
                Program.Gactivado = false;
            }

            return result;

        }


        public int ObtenerDiasActivo()
        {
            int dias = 0;
            DataTable dt = new DataTable();
            P.HDD_SERIAL = GF.serial();
            P.SOFTWARE = Program.Gsoftware;
            dt = P.ObtenerDiasActivoSoftware();
            if (dt.Rows.Count > 0)
            {
                dias = Convert.ToInt32(dt.Rows[0][0].ToString());
            }

            return dias;
        }

        public void ControlsState(bool activado)
        {
            facp_cb.Enabled = activado;
            //historial_btn.Enabled = activado;
            //ConfigMail_btn.Enabled = activado;
            //flowLayoutPanel1.Enabled = activado;
            //Refresh_btn.Enabled = activado;
            //linkLabel1.Enabled = activado;
            //msjActivado_lbl.Visible = !activado;
        }

        #endregion


        private void DataReceiver_Load(object sender, EventArgs e)
        {
        
            NombreConfigPuertoSerial = Properties.Settings.Default.ConfiguracionSerial;
            ObtenerConfiguracionEspecifica();
            if (CheckIfSoftwareActivated())
            {
                ConnectSerialPort();
                
            }
            else
            {
                estatus_txt.Text = "OFFLINE";
            }
            
            
            Config_lbl.Text = NombreConfigPuertoSerial;
            LLenarFacpCB();
            timer1.Start();
            checkSoftware_timer.Start();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {

                SerialPort sp = (SerialPort)sender;

                ProcessDataTimer.Stop();
                string data = sp.ReadExisting();
                dataRead += data;
                //ProcessDataTimer.Start();
                //sp.DiscardOutBuffer();
                //sp.DiscardInBuffer();

                SetText(data);
                //int bytes = sp.BytesToRead;
                //byte[] buffer = new byte[bytes];
                //sp.Read(buffer, 0, bytes);
                //ProcessData(data);




            }

            catch (Exception ex)
            {

            }
              
        }

        private void Config_btn_Click(object sender, EventArgs e)
        {

            Program.Gventana = "SerialConfig";
            SuperUserLoginForm form1 = new SuperUserLoginForm();
            form1.ShowDialog();
            if(Program.Gventana == "SerialConfig")
            {
                try
                {

                    serialPort1.Close();
                    timer1.Stop();
                    estatus_txt.Text = "Offline";

                }
                catch (Exception ex)
                {

                }

                ConfiguracionPuertoSerialForm form = new ConfiguracionPuertoSerialForm();
                form.ShowDialog();
                ConnectSerialPort();
                timer1.Start();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            timer1.Stop();
            if (Program.Gactivado)
            {

                //new Task(ConnectSerialPort).Start();
                ConnectSerialPort();
                CheckForDailyMail();
            }
            
            timer1.Start();
        }

        private void facp_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(facp_cb.SelectedIndex != -1)
            {
                Properties.Settings.Default.ID_FAPC = Convert.ToInt32(facp_cb.SelectedValue);
                Properties.Settings.Default.Save();
            }
        }

        private void ProcessDataTimer_Tick(object sender, EventArgs e)
        {
            ProcessDataTimer.Stop();
            ProcessData(dataRead);
        }

        private void limpiarEstados_btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void Email_timer_Tick(object sender, EventArgs e)
        {
            
            SendMail(facp_cb.Text + " WARNINGS/ALARMS");
            Email_timer.Stop();
        }

        private void activar_btn_Click(object sender, EventArgs e)
        {
            ActivationForm form = new ActivationForm();
            form.ShowDialog();
            CheckIfSoftwareActivated();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            InfoForm form = new InfoForm();
            form.ShowDialog();
        }

        private void checkSoftware_timer_Tick(object sender, EventArgs e)
        {
            checkSoftware_timer.Stop();
            CheckIfSoftwareActivated();
            checkSoftware_timer.Start();
        }
    }



}
