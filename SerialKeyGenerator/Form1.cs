using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialKeyGenerator
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        public void GenerarSerial()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            txt1.Text = "";
            Random r = new Random();

            int rInt1 = 0; //for ints
            int rInt2 = 0; //for ints
            int totalSumSerial;
            if (numericUpDown1.Value == 1)
            {
                if (trial_radiobtn.Checked)
                {
                    rInt1 = r.Next(0, 4000); //for ints
                    rInt2 = r.Next(0, 4000); //for ints

                    totalSumSerial = 5000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);
                }
                else
                {
                    rInt1 = r.Next(1000, 6500); //for ints
                    rInt2 = r.Next(1000, 6500); //for ints
                    totalSumSerial = 10000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);

                }
            }
            else if (numericUpDown1.Value == 2)
            {
                rInt1 = r.Next(1000, 6500); //for ints
                rInt2 = r.Next(1000, 6500); //for ints
                totalSumSerial = 15000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);

            }

            else
            {
                rInt1 = r.Next(1000, 9999); //for ints
                rInt2 = r.Next(1000, 9999); //for ints
                totalSumSerial = 20000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);

            }





            if (rInt1 + rInt2 > totalSumSerial)
            {
                while (rInt1 + rInt2 > totalSumSerial)
                {
                    if (trial_radiobtn.Checked)
                    {
                        rInt2 = r.Next(0, 4000); //for ints
                    }
                    else
                    {
                        rInt2 = r.Next(0, 9999); //for ints
                    }

                }
            }

            int rInt3 = totalSumSerial - rInt1 - rInt2;
            txt1.Text = rInt1.ToString("D4");
            textBox1.Text = rInt2.ToString("D4");
            textBox2.Text = rInt3.ToString("D4");
            if (rInt3.ToString().Length > 4)
            {
                GenerarSerial();
                return;
            }
            
        }

        private void activar_btn_Click(object sender, EventArgs e)
        {
            GenerarSerial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trial_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (trial_radiobtn.Checked)
            {
                numericUpDown1.Value = 1;
                numericUpDown1.Enabled = false;
            }
            else
            {
                numericUpDown1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DailyPassword form = new DailyPassword();
            form.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
