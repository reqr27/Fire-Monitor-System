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
        public Form1()
        {
            InitializeComponent();
        }

        private void activar_btn_Click(object sender, EventArgs e)
        {
            int totalSumSerial;
            if (numericUpDown1.Value == 1)
            {
                if (trial_radiobtn.Checked)
                {
                    totalSumSerial = 5000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);
                }
                else
                {
                    totalSumSerial = 10000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);
                }
            }
            else if (numericUpDown1.Value == 2)
            {
                totalSumSerial = 15000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);

            }

            else
            {
                totalSumSerial = 20000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);

            }


            Random r = new Random();
            int rInt1 = r.Next(0, 9999); //for ints
            int rInt2 = r.Next(0, 9999); //for ints
            if (trial_radiobtn.Checked)
            {
                rInt1 = r.Next(0, 2000); //for ints
                rInt1 = r.Next(0, 2000); //for ints
            }
            
            
            if(rInt1 + rInt2 > totalSumSerial)
            {
                while(rInt1 + rInt2 > totalSumSerial)
                {
                    if (trial_radiobtn.Checked)
                    {
                        rInt2 = r.Next(0, 2000); //for ints
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
    }
}
