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

namespace DataReceiver
{
    public partial class SuperUserLoginForm : Form
    {
        GlobalFunctions GF = new GlobalFunctions();
        
        public SuperUserLoginForm()
        {
            InitializeComponent();
        }

        private void entrar_btn_Click(object sender, EventArgs e)
        {
            SuperUserLogin();
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            Program.Gventana = "";
            this.Close();
        }

        private void entrar_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SuperUserLogin();
            }
        }
        public void SuperUserLogin()
        {
            if (GF.TodayPassWord(Password_txt.Text))
            {
                this.Close();
            }
           
            else
            {
                MessageBox.Show("Access denied", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Password_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SuperUserLogin();
            }
        }

        private void SuperUserLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
