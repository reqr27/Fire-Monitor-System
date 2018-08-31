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

namespace FireSystemMonitor.Formularios
{
    public partial class EmailForm : Form
    {

        public bool fillCombo = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Procedimientos P = new Procedimientos();
        public EmailForm()
        {
            InitializeComponent();
        }

        #region Funciones


        public void ObtenerConfigRemitente()
        {
            DataTable dt = new DataTable();
            dt = P.ObtenerConfigRemitenteEmail();
            if(dt.Rows.Count > 0)
            {
                numericUpDown1.Value = Convert.ToInt32(dt.Rows[0][1].ToString());
                host_txt.Text = dt.Rows[0][2].ToString();
                emailRemitente_txt.Text = dt.Rows[0][3].ToString();
                pass_txt.Text = dt.Rows[0][4].ToString();
                desde_dtp.Value = Convert.ToDateTime(dt.Rows[0][5].ToString());
                
            }
        }

        public void LlenarDtgEmails()
        {
            DataTable dt = new DataTable();
            email_dtg.DataSource = null;
            
            dt = P.ObtenerEmails();
            email_dtg.DataSource = dt;
        }

        public string ValidarRegistrarEmail()
        {
            string result = "";
            if(nombre_txt.Text.Trim() == "")
            {
                result += "Nombre es necesario\n";
                
            }
            if(email_txt.Text.Trim() != "")
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email_txt.Text);
                    if (addr.Address != email_txt.Text)
                    {
                        result += "Email inválido";
                    }
                }
                catch (Exception)
                {
                    result += "Email inválido";
                }
                
            }
            else
            {
                result += "Email inválido";
            }
            



            return result;
        }

        public string ValidarRegistrarConfig()
        {
            string result = "";
            if (host_txt.Text.Trim() == "")
            {
                result += "Host es necesario\n";

            }
            if(emailRemitente_txt.Text != "")
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(emailRemitente_txt.Text);
                    if (addr.Address != emailRemitente_txt.Text)
                    {
                        result += "Email inválido";
                    }
                }
                catch (Exception)
                {
                    result += "Email inválido";
                }
            }
            else
            {
                result += "Email inválido\n";
            }
            

            if (pass_txt.Text.Trim() == "")
            {
                result += "Password es necesario";
            }



            return result;
        }

        public void RegistrarEmail()
        {
            if (ValidarRegistrarEmail() == "")
            {
                P.Nombre = nombre_txt.Text;
                P.Email = email_txt.Text;
                P.Conexion = conexion_chbox.Checked;
                P.Warning = warning_chbox.Checked;
                P.Alarma = alarm_chbox.Checked;
                string msj = P.RegistrarEmail();
                if(msj != "1")
                {
                    MessageBox.Show("No se pudo realizar esta acción");
                }
                else
                {
                    LlenarDtgEmails();
                }
            }
            else
            {
                MessageBox.Show(ValidarRegistrarEmail());
            }
        }

        public void RegistrarConfigRemitente()
        {
            if (ValidarRegistrarConfig() == "")
            {
                
                P.Email =emailRemitente_txt.Text;
                P.Puerto = Convert.ToInt32(numericUpDown1.Value);
                P.Host = host_txt.Text;
                P.Password = pass_txt.Text;
                P.Desde = desde_dtp.Value;
                string msj = P.RegistrarConfigRemitente();
                if (msj != "1")
                {
                    MessageBox.Show("No se pudo realizar esta acción");
                }
                else
                {
                    MessageBox.Show("Configuración Guardada");
                }
            }
            else
            {
                MessageBox.Show(ValidarRegistrarConfig());
            }
        }

        public void BorrarEmail()
        {
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar este email?", "Borrar Email", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                P.Id = Convert.ToInt32(email_dtg.CurrentRow.Cells[0].Value.ToString());
                string msj = P.BorrarEmail();
                if (msj != "1")
                {
                    MessageBox.Show("No se pudo eliminar email");
                }
                else
                {
                    LlenarDtgEmails();
                }
            }

        }

        #endregion

        private void EmailForm_Load(object sender, EventArgs e)
        {
            LlenarDtgEmails();
            ObtenerConfigRemitente();
        }

        private void agregarEmail_btn_Click(object sender, EventArgs e)
        {
            RegistrarEmail();
        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            BorrarEmail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarConfigRemitente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
