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
    public partial class FacpStatusForm : Form
    {
        
        public FacpStatusForm()
        {
            InitializeComponent();
        }


        public void obtenerEstadoFacp()
        {
            try
            {
                Procedimientos P = new Procedimientos();
                Program.GestadoFacp = "";
                DataTable dt = new DataTable();
                P.ID_FACP = Program.GidFacp;
                dt = P.ObtenerEstadoFacp();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string msj = dt.Rows[i][0].ToString() + Environment.NewLine;
                    Program.GestadoFacp += dt.Rows[i][0].ToString() + Environment.NewLine;
                }
            }
            catch
            {

            }
            

        }

        private void FacpStatusForm_Load(object sender, EventArgs e)
        {
            try
            {
                obtenerEstadoFacp();
                richTextBox1.Text = Program.GestadoFacp;
            }
            catch
            {

            }
            
            
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                richTextBox1.Focus();
                obtenerEstadoFacp();
                richTextBox1.Text = Program.GestadoFacp;
            }
            catch
            {

            }
            
            
        }
    }
}
