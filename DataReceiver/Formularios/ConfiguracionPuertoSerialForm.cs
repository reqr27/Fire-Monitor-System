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
        int activeWindow = Program.GnumberOfActiveWindows;
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
            label11.Text = label11.Text + " - #" + activeWindow;

            LlenarDtgPuertoSerial();
            if(activeWindow == 1)
            {
                Config_lbl.Text = Properties.Settings.Default.ConfiguracionSerial1;

            }
            else if (activeWindow == 2)
            {
                Config_lbl.Text = Properties.Settings.Default.ConfiguracionSerial2;

            }
            else
            {
                Config_lbl.Text = Properties.Settings.Default.ConfiguracionSerial3;

            }
            ObtenerListadoPuertos();
        }

        private void UsarConfig_btn_Click(object sender, EventArgs e)
        {
            if(serialPort_dtg.Rows.Count > 0)
            {
                if(activeWindow == 1)
                {
                    Properties.Settings.Default.ConfiguracionSerial1 = serialPort_dtg.CurrentRow.Cells[1].Value.ToString();
                    Properties.Settings.Default.Save();
                    Config_lbl.Text = Properties.Settings.Default.ConfiguracionSerial1;

                    Program.gCOM1 = serialPort_dtg.CurrentRow.Cells[2].Value.ToString();
                    Program.gBaudRate1 = Convert.ToInt32(serialPort_dtg.CurrentRow.Cells[3].Value.ToString());
                    Program.gDataBits1 = serialPort_dtg.CurrentRow.Cells[4].Value.ToString();
                    Program.gParity1 = serialPort_dtg.CurrentRow.Cells[5].Value.ToString();
                    Program.gStopBit1 = serialPort_dtg.CurrentRow.Cells[6].Value.ToString();
                    Program.gNewLine1 = serialPort_dtg.CurrentRow.Cells[7].Value.ToString();
                }
                else if (activeWindow == 2)
                {
                    Properties.Settings.Default.ConfiguracionSerial2 = serialPort_dtg.CurrentRow.Cells[1].Value.ToString();
                    Properties.Settings.Default.Save();
                    Config_lbl.Text = Properties.Settings.Default.ConfiguracionSerial2;
                    Program.gCOM2 = serialPort_dtg.CurrentRow.Cells[2].Value.ToString();
                    Program.gBaudRate2 = Convert.ToInt32(serialPort_dtg.CurrentRow.Cells[3].Value.ToString());
                    Program.gDataBits2 = serialPort_dtg.CurrentRow.Cells[4].Value.ToString();
                    Program.gParity2 = serialPort_dtg.CurrentRow.Cells[5].Value.ToString();
                    Program.gStopBit2 = serialPort_dtg.CurrentRow.Cells[6].Value.ToString();
                    Program.gNewLine2 = serialPort_dtg.CurrentRow.Cells[7].Value.ToString();
                }

                else
                {
                    Properties.Settings.Default.ConfiguracionSerial3 = serialPort_dtg.CurrentRow.Cells[1].Value.ToString();
                    Properties.Settings.Default.Save();
                    Config_lbl.Text = Properties.Settings.Default.ConfiguracionSerial3;
                    
                    Program.gCOM3 = serialPort_dtg.CurrentRow.Cells[2].Value.ToString();
                    Program.gBaudRate3 = Convert.ToInt32(serialPort_dtg.CurrentRow.Cells[3].Value.ToString());
                    Program.gDataBits3 = serialPort_dtg.CurrentRow.Cells[4].Value.ToString();
                    Program.gParity3 = serialPort_dtg.CurrentRow.Cells[5].Value.ToString();
                    Program.gStopBit3 = serialPort_dtg.CurrentRow.Cells[6].Value.ToString();
                    Program.gNewLine3 = serialPort_dtg.CurrentRow.Cells[7].Value.ToString();
                    

                    

                }
                MessageBox.Show("Change Done!");

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
                    if(activeWindow == 1)
                    {
                        Properties.Settings.Default.ConfiguracionSerial1 = identificador_txt.Text;
                    }
                    else if(activeWindow == 2)
                    {
                        Properties.Settings.Default.ConfiguracionSerial2 = identificador_txt.Text;

                    }
                    else
                    {
                        Properties.Settings.Default.ConfiguracionSerial3 = identificador_txt.Text;
                        
                    }

                    Properties.Settings.Default.Save();
                    Config_lbl.Text = identificador_txt.Text;

                    MessageBox.Show("Configuration was saved!");
                    LlenarDtgPuertoSerial();
                    ResetCampos();
                    
                    
                }
                else
                {
                    MessageBox.Show("Configuration was not saved, try again!");
                    ResetCampos();
                }
            }

            else
            {
                MessageBox.Show("All fields are required!");
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
