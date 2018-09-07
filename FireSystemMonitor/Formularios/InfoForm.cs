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
using System.Reflection;

namespace FireSystemMonitor.Formularios
{
    public partial class InfoForm : Form
    {
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public InfoForm()
        {
            InitializeComponent();
        }

        #region FUNCIONES



        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            label3.Text = GF.DevelopedBy;
            label6.Text = GF.Tel;
            linkLabel1.Text = GF.WebPage;
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            P.HDD_SERIAL = GF.serial();
            P.SOFTWARE = Program.Gsoftware;
            DataTable dt = new DataTable();
            dt = P.ObtenerInfoSoftware();
            if(dt.Rows.Count > 0)
            {
                if(Program.Gsoftware == "Lectura")
                {
                    software_lbl.Text = "FACP DATA RECEIVER - Version: " + version;
                    licencia_lbl.Text = dt.Rows[0][0].ToString() + " - Total Puertos:" + dt.Rows[0][3].ToString();
                    fActivado_txt.Text = (Convert.ToDateTime(dt.Rows[0][1].ToString())).ToString("dd/MM/yyyy");
                    if (dt.Rows[0][0].ToString() == "Trial")
                    {
                        fVencimiento_txt.Text = (Convert.ToDateTime(dt.Rows[0][2].ToString())).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        fVencimiento_txt.Text = "∞";

                    }



                }
                else
                {
                    software_lbl.Text = "FIRE MONITOR SYSTEM - Version: " + version;
                    licencia_lbl.Text = dt.Rows[0][0].ToString();
                    fActivado_txt.Text = (Convert.ToDateTime(dt.Rows[0][1].ToString())).ToString("dd/MM/yyyy");
                    if (dt.Rows[0][0].ToString() == "Trial")
                    {
                        fVencimiento_txt.Text = (Convert.ToDateTime(dt.Rows[0][2].ToString())).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        fVencimiento_txt.Text = "∞";

                    }

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.multiservicioslea.com");
        }
    }
}
