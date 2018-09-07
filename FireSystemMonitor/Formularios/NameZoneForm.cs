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
namespace FireSystemMonitor
{
    public partial class NameZoneForm : Form
    {
        Procedimientos P = new Procedimientos();
        string nombre = Program.TagName;
        string tamaño = Program.SizeInPX.ToString();
        string identificador = Program.Identificador;
        string dispositivo = Program.Gdispositivo;
        string tipoDispositivo = Program.GtipoDispositivo;
        string figura = Program.Gfigura;
        public NameZoneForm()
        {
            InitializeComponent();
        }

        public void LLenarDispositivoCB()
        {
            dispositivo_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerDispositivos();
            dispositivo_cb.DataSource = dt;
            dispositivo_cb.DisplayMember = "DISPOSITIVO";
            dispositivo_cb.ValueMember = "ID";
            if(dt.Rows.Count > 0)
            {
                dispositivo_cb.SelectedIndex = 0;
               
            }
            
        }

        public void LLenarTipoDispositivoCB()
        {
            tipoDispositivo_cb.DataSource = null;
            DataTable dt = new DataTable();
            P.Id = Convert.ToInt32(dispositivo_cb.SelectedValue);
            dt = P.ObtenerTiposDispositivos();
            tipoDispositivo_cb.DataSource = dt;
            tipoDispositivo_cb.DisplayMember = "TIPO_DISPOSITIVO";
            tipoDispositivo_cb.ValueMember = "ID";
            if (dt.Rows.Count > 0)
            {
                //tipoDispositivo_cb.SelectedIndex = 0;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() != "" && identificador_txt.Text != "" && dispositivo_cb.Text != "" && tipoDispositivo_cb.Text != "" && figura_cb.Text != "") 
            {
                try
                {
                    Convert.ToInt32(textBox2.Text);
                    Program.TagName = textBox1.Text.Trim();
                    Program.SizeInPX = Convert.ToInt32(textBox2.Text);
                    Program.Identificador = identificador_txt.Text;
                    Program.Gdispositivo = dispositivo_cb.Text;
                    Program.GtipoDispositivo = tipoDispositivo_cb.Text;
                    Program.Gfigura = figura_cb.Text;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tamaño debe ser número entero");
                    
                }
            }

            else
            {
                MessageBox.Show("Todos los campos son necesarios");
            }
            
        }

        private void NameZoneForm_Load(object sender, EventArgs e)
        {
            P.InsertarDispositivos_yTipos();
            LLenarDispositivoCB();
            
            figura_cb.SelectedIndex = 0;
            textBox1.Text = nombre.Trim();
            textBox2.Text = tamaño.Trim();
            identificador_txt.Text = identificador.Trim();
            dispositivo_cb.Text = dispositivo;
            LLenarTipoDispositivoCB();
            tipoDispositivo_cb.Text = tipoDispositivo;
            figura_cb.Text = figura;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.SizeInPX = 25;
            Program.TagName = "";
            Program.Identificador = "";

            this.Close();
        }

        private void dispositivo_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LLenarTipoDispositivoCB();
        }
    }
}
