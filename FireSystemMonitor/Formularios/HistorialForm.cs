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
    public partial class HistorialForm : Form
    {
        public bool fillCombo = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Procedimientos P = new Procedimientos();
        public HistorialForm()
        {
            InitializeComponent();
        }

        #region Funciones

        public void LLenarFacpCB()
        {
            facp_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerFacp();
            facp_cb.DataSource = dt;
            facp_cb.DisplayMember = "NOMBRE";
            facp_cb.ValueMember = "ID";
            if (dt.Rows.Count > 0)
            {
                facp_cb.SelectedIndex = 0;

            }

        }

        public void LlenarDtgHistorial()
        {
            DataTable dt = new DataTable();
            historial_dtg.DataSource = null;
            P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
            P.Desde = desde_dtp.Value;
            P.Hasta = hasta_dtp.Value;
            dt = P.ObtenerLogFacp();
            historial_dtg.DataSource = dt;
        }


        #endregion

        private void HistorialForm_Load(object sender, EventArgs e)
        {
            LLenarFacpCB();
            desde_dtp.Value = DateTime.Now.AddDays(-1);
            hasta_dtp.Value = DateTime.Now;
        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            if(facp_cb.SelectedIndex != -1)
            {
                LlenarDtgHistorial();
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
