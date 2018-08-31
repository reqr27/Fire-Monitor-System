using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
namespace DataReceiver.Formularios
{
    public partial class ConfiguracionPuertoSerialForm : Form
    {
        int idEvento;
        Procedimientos P = new Procedimientos();
        public ConfiguracionPuertoSerialForm()
        {
            InitializeComponent();
        }

        #region Funciones


        public void ObtenerListadoPuertos()
        {
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                SerialPortName_cb.Items.Add(s);
            }
        }

        public void LlenarDtgPuertoSerial()
        {
            DataTable dt = new DataTable();
            dt = P.ObtenerConfiguracionesSerial();
            serialPort_dtg.DataSource = null;
            serialPort_dtg.DataSource = dt;
            if(dt.Rows.Count > 0)
            {
                UsarConfig_btn.Enabled = true;
            }
            else
            {
                UsarConfig_btn.Enabled = false;
            }
        }

        public  string ValidarCampos()
        {
            string msj = "";
            
            foreach (Control control in this.Controls)
            {
                
                if (control is TextBox )
                {
                    if (((TextBox)control).Text == "")
                    {
                        msj += ((TextBox)control).Name.ToString();
                    }

                }
                if(control is ComboBox)
                {
                    if (((ComboBox)control).Text == "")
                    {
                        msj += ((ComboBox)control).Name.ToString();
                    }
                }
            }

            return msj;
        }


        public string ResetCampos()
        {
            idEvento = 0;
            string msj = "";
           
            foreach (var control in this.Controls)
            {

                if (control is TextBox || control is ComboBox)
                {
                    try
                    {
                       
                            (control as TextBox).Text = "";
                        
                    }

                    catch
                    {
                            (control as ComboBox).SelectedIndex = -1;
                        
                    }

                }
            }

            return msj;
        }

        #endregion

        private void ConfiguracionPuertoSerialForm_Load(object sender, EventArgs e)
        {
            LlenarDtgPuertoSerial();
            Config_lbl.Text = Properties.Settings.Default.ConfiguracionSerial;
            ObtenerListadoPuertos();
        }

        private void UsarConfig_btn_Click(object sender, EventArgs e)
        {
            if(serialPort_dtg.Rows.Count > 0)
            {
                Properties.Settings.Default.ConfiguracionSerial = serialPort_dtg.CurrentRow.Cells[1].Value.ToString();
                Properties.Settings.Default.Save();
                Config_lbl.Text = Properties.Settings.Default.ConfiguracionSerial;
                Program.gCOM = serialPort_dtg.CurrentRow.Cells[2].Value.ToString();
                Program.gBaudRate = Convert.ToInt32(serialPort_dtg.CurrentRow.Cells[3].Value.ToString());
                Program.gDataBits = serialPort_dtg.CurrentRow.Cells[4].Value.ToString();
                Program.gParity= serialPort_dtg.CurrentRow.Cells[5].Value.ToString();
                Program.gStopBit = serialPort_dtg.CurrentRow.Cells[6].Value.ToString();
                Program.gNewLine = serialPort_dtg.CurrentRow.Cells[7].Value.ToString();
            }

        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            string msj = ValidarCampos();
            if (msj.Trim() == "")
            {
                P.Id = idEvento;
                P.Identificador = identificador_txt.Text;
                P.COM = SerialPortName_cb.Text;
                P.BaudRate = Convert.ToInt32(baudRate_cb.Text);
                P.Databits = databit_cb.Text;
                P.Parity = paridad_cb.Text;
                P.StopBit = stopbit_cb.Text;
                P.NewLine = newLine_txt.Text;
                if(idEvento != 0)
                {
                    msj = P.ActualizarConfiguracionPuertoSerial();
                }
                else
                {
                    msj = P.InsertarConfiguracionPuertoSerial();
                }
               
                if(msj == "1")
                {
                    Properties.Settings.Default.ConfiguracionSerial = identificador_txt.Text;
                    Properties.Settings.Default.Save();
                    Config_lbl.Text = identificador_txt.Text;

                    MessageBox.Show("Configuración guardada!");
                    LlenarDtgPuertoSerial();
                    ResetCampos();
                    
                    
                }
                else
                {
                    MessageBox.Show("No se pudo realizar esta Acción!");
                    ResetCampos();
                }
            }

            else
            {
                MessageBox.Show("Todos los campos son necesarios");
            }
        }

        private void serialPort_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idEvento = Convert.ToInt32(serialPort_dtg.CurrentRow.Cells[0].Value.ToString());
            identificador_txt.Text = serialPort_dtg.CurrentRow.Cells[1].Value.ToString();
            SerialPortName_cb.Text = serialPort_dtg.CurrentRow.Cells[2].Value.ToString();
            baudRate_cb.Text = serialPort_dtg.CurrentRow.Cells[3].Value.ToString();
            databit_cb.Text = serialPort_dtg.CurrentRow.Cells[4].Value.ToString();
            paridad_cb.Text = serialPort_dtg.CurrentRow.Cells[5].Value.ToString();
            stopbit_cb.Text = serialPort_dtg.CurrentRow.Cells[6].Value.ToString();
            newLine_txt.Text = serialPort_dtg.CurrentRow.Cells[7].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }



}
