using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSystemMonitor.Classes;
using System.IO;
using System.Security;
using Classes;
namespace FireSystemMonitor.Classes
{
    public partial class MonitoreoZonaForm : Form
    {
        string formname = Program.FormName;
        string estadoDevice = "OK";
        bool changeColor = false;
        public bool fillCombo = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        int idZonaMonitorear = Program.GidZonaMonitorear;
        Procedimientos P = new Procedimientos();
        List<PictureBox> ListaDetectores = new List<PictureBox>();
        public MonitoreoZonaForm()
        {
            InitializeComponent();
        }

        #region Funciones

        public void CargarZona()
        {
            CargarImagenDesdeBd(idZonaMonitorear);
            ObtenerDetectoresZona(idZonaMonitorear, false);
        }

        public void CargarImagenDesdeBd(int idZona)
        {
            if(pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
            }
            
            DataTable dt = new DataTable();
            P.Id = idZona;
            dt = P.ObtenerImagenesZonas();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                byte[] imgshow = (byte[])(dt.Rows[i][1]);
                MemoryStream Ms = new MemoryStream(imgshow);

                try
                {
                    Image loadedImage = Image.FromStream(Ms);
                    pictureBox1.Image = loadedImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;




                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("MONITOREO CARGAR IMAGEN DESDE BD");
                    TimerLeerStatusDetector.Start();
                    border_timer.Start();
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }

            }

        }

        public void ObtenerDetectoresZona(int idZona, bool MoverDetector)
        {
            P.IdZona = idZona;
            DataTable dt = new DataTable();
            dt = P.ObtenerDetectoresZonas();

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                int addToX = 0;//pictureBox1.Width - 948;
                int addToY = 0;//pictureBox1.Height - 545;

                int posx = Convert.ToInt32(dt.Rows[i][3].ToString()) + addToX;
                int posy = Convert.ToInt32(dt.Rows[i][4].ToString()) + addToY;

               

                int sizepx = Convert.ToInt32(dt.Rows[i][2].ToString());
                string name = dt.Rows[i][1].ToString();
                string identificador = dt.Rows[i][5].ToString();
                int idDetector = Convert.ToInt32(dt.Rows[i][0].ToString());
                string dispositivo = dt.Rows[i][8].ToString();
                string tipoDispositivo = dt.Rows[i][9].ToString();
                string figura = dt.Rows[i][10].ToString();
                if (figura == "Letra P")
                {
                    GenerarDetectorZona(posx, posy, "OLD", sizepx, name, MoverDetector, idDetector, Properties.Resources.transLetraPverde,
                    identificador, dispositivo, tipoDispositivo, figura);
                }
                else
                {
                    GenerarDetectorZona(posx, posy, "OLD", sizepx, name, MoverDetector, idDetector, Properties.Resources.cuadroVerde,
                    identificador, dispositivo, tipoDispositivo, figura);
                }

                
            }
        }

        public void GenerarDetectorZona(int posx, int posy, string tipo, int sizepx, string name, bool mover, int idDetector, Image img, string identificador, string dispositivo, string tipoDispositivo, string figura)

        {
            //NameZoneForm form = new NameZoneForm();
            //form.ShowDialog();
            try
            {
                PictureBox p = new PictureBox();
                p.Location = new Point(posx, posy);
                pictureBox1.Controls.Add(p);
                p.BringToFront();
                if (figura == "Círculo")
                {
                    var path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(0, 0, sizepx, sizepx);

                    p.Region = new Region(path);
                }
                else
                {
                    p.Size = new Size(sizepx, sizepx);
                }

                p.Tag = tipo + "*" + idDetector.ToString() + "*" + identificador + "*" + sizepx.ToString() + "*" + name.Trim() + "*" + dispositivo + "*" + tipoDispositivo + "*" + figura;
                p.Image = img;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.BackColor = Color.Transparent;
                p.Draggable(mover);
                p.MouseHover += new EventHandler(Panel_Hover);
                p.MouseLeave += new EventHandler(Panel_Leave);
                pictureBox1.Refresh();
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine("MONITOREO GENERAR DETECTOR");
                TimerLeerStatusDetector.Start();
                border_timer.Start();
            }
            


        }

        public void LeerEstadoDetectores()
        {
            try
            {
                bool check = false;
                estadoDevice = "OK";
                EncontrarDetectores();
                foreach (var pb in ListaDetectores)
                {

                    string Estado = "No se pudo encontrar";
                    //string Descripcion = "";
                    string tag = pb.Tag.ToString();
                    string[] namesArray = tag.Split('*');
                    List<string> namesList = new List<string>(namesArray.Length);
                    namesList.AddRange(namesArray);
                    P.IdZona = idZonaMonitorear;
                    P.IdDetector = Convert.ToInt32(namesList[1]);
                    P.Identificador = namesList[2];
                    P.Nombre = namesList[4];

                    DataTable dt = new DataTable();
                    dt = P.ObtenerEstadoDetectorIndividual();
                    if (dt.Rows.Count > 0)
                    {
                        Estado = dt.Rows[0][0].ToString();

                    }
                    if (!check)
                    {
                        if (Estado == "HEAT" || Estado == "SMOKE" || Estado == "PULL STATION")
                        {
                            estadoDevice = "ALARM";
                            check = true;
                            border_timer.Start();

                        }
                        else if (Estado != "OK")
                        {
                            estadoDevice = "WARNING";
                            border_timer.Start();
                        }

                    }
                    CambiarEstadoDetector(pb, Estado, namesList[7]);

                }
            }

            catch
            {

            }
            
        }

        public void EncontrarDetectores()
        {
            foreach (var pb in pictureBox1.Controls.OfType<PictureBox>())
            {
                if ((pb.Tag.ToString()).StartsWith("OLD") || (pb.Tag.ToString()).StartsWith("NEW"))
                {
                    ListaDetectores.Add(pb);
                }

            }
        }

        public void CambiarEstadoDetector (PictureBox pb, string estado, string figura)
        {
            try
            {
                if (pb.Image != null)
                {
                    pb.Image = null;
                }
                    
                if (figura == "Círculo" || figura == "Cuadro")
                {

                    if (estado == "OK")
                    {
                        pb.Image = Properties.Resources.DetectorOK;
                    }
                    else if (estado == "HEAT" || estado == "SMOKE" || estado == "PULL STATION")
                    {
                        pb.Image = Properties.Resources.DetectorFuego;
                    }

                    else if (estado == "INVREP")
                    {
                        pb.Image = Properties.Resources.DetectorFalta;
                    }

                    else if (estado == "OPEN" || estado == "SHORT" || estado == "DIRTY1" || estado == "DIRTY2" || estado == "INV ID")
                    {
                        pb.Image = Properties.Resources.DetectorWarning;
                    }
                    else //no pudo ser leido
                    {
                        pb.Image = Properties.Resources.DetectorNoLeido;
                    }
                }
                else
                {
                    if (estado == "OK")
                    {
                        pb.Image = Properties.Resources.transLetraPverde;
                    }
                    else if (estado == "HEAT" || estado == "SMOKE" || estado == "PULL STATION")
                    {
                        pb.Image = Properties.Resources.PullActivo;
                    }

                    else if (estado == "INVREP")
                    {
                        pb.Image = Properties.Resources.DetectorFalta;
                    }

                    else if (estado == "OPEN" || estado == "SHORT" || estado == "DIRTY1" || estado == "DIRTY2" || estado == "INV ID")
                    {
                        pb.Image = Properties.Resources.transLetraPamarilla;
                    }
                    else //no pudo ser leido
                    {
                        pb.Image = Properties.Resources.PullFalta;
                    }


                }


            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("MONITOREO CAMBIAR ESTADO DETECTOR");
                TimerLeerStatusDetector.Start();
                border_timer.Start();
            }
            //estadoDevice = estado;
           
            



        }

        public void CambiarColorBorde()
        {
            if(estadoDevice == "ALARM")
            {
                if (!changeColor)
                {
                    changeColor = !changeColor;
                    
                   
                    panel3.BackColor = Color.FromArgb(194, 54, 22); //rojo
                    NombreZona_lbl.ForeColor = Color.LightGray;

                    panel2.BackColor = Color.FromArgb(194, 54, 22); //rojo
                }
                else
                {
                    changeColor = !changeColor;
                    panel3.BackColor = Color.LightGray;
                    NombreZona_lbl.ForeColor = Color.FromArgb(194, 54, 22); //rojo

                    panel2.BackColor = Color.LightGray; 
                }
            }
            else if (estadoDevice == "WARNING")
            {
                if (!changeColor)
                {
                    changeColor = !changeColor;


                    panel3.BackColor = Color.FromArgb(241, 196, 15); //amarillo
                    NombreZona_lbl.ForeColor = Color.DarkGray;

                    panel2.BackColor = Color.FromArgb(241, 196, 15);//amarillo
                }
                else
                {
                    changeColor = !changeColor;
                    panel3.BackColor = Color.DarkGray;
                    NombreZona_lbl.ForeColor = Color.FromArgb(241, 196, 15); //amarillo

                    panel2.BackColor = Color.DarkGray;
                }
            }
            else
            {
                panel3.BackColor = Color.FromArgb(194, 54, 22); //rojo;
                NombreZona_lbl.ForeColor = Color.White;

                panel2.BackColor = Color.LightGray;
                border_timer.Stop();
            }
        }

        #endregion


        #region EventosManuales

        private void Panel_Leave(object sender, EventArgs e)
        {
            Point locationOnForm = (sender as PictureBox).Location;
        }

        private void Panel_Hover(object sender, EventArgs e)
        {
            string Estado = "No se pudo obtener estado";
            string tag = (sender as PictureBox).Tag.ToString(); // format --> tipo*id*identificador*tamaño*nombre
            string Descripcion = "";
            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);

            try
            {
                P.IdZona = idZonaMonitorear;
                P.IdDetector = Convert.ToInt32(namesList[1]);
                P.Identificador = namesList[2];
                P.Nombre = namesList[4];
                DataTable dt = new DataTable();
                dt = P.ObtenerEstadoDetectorIndividual();
                if (dt.Rows.Count > 0)
                {
                    Estado = dt.Rows[0][0].ToString();
                    Descripcion = dt.Rows[0][1].ToString();
                }

                toolTip1.SetToolTip((sender as PictureBox), "Nombre: " + namesList[4] + "\nIdentificador: " + namesList[2] + "\nTipo: " + namesList[5] + "\nCategoría: " + namesList[6] + "\nEstado: " + Estado);// + "\nDescripción Estado: " + Descripcion);

            }
            catch
            {

            }


        }

        
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonitoreoZonaForm_Load(object sender, EventArgs e)
        {

            NombreZona_lbl.Text = formname ;
            this.Text = formname;

            CargarZona();
            LeerEstadoDetectores();
            TimerLeerStatusDetector.Start();
        }

        private void TimerLeerStatusDetector_Tick(object sender, EventArgs e)
        {
            TimerLeerStatusDetector.Stop();
            
            new Task(LeerEstadoDetectores).Start();
            //LeerEstadoDetectores();
            TimerLeerStatusDetector.Start();

            //backgroundWorker1.RunWorkerAsync();

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void border_timer_Tick(object sender, EventArgs e)
        {
            CambiarColorBorde();
        }

        private void MonitoreoZonaForm_Resize(object sender, EventArgs e)
        {
            try
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    TimerLeerStatusDetector.Stop();
                    border_timer.Stop();
                    NombreZona_lbl.Text = formname;
                    this.Text = formname;
                    pictureBox1.Image = null;
                    pictureBox1.Controls.Clear();
                    this.Refresh();
                    CargarZona();
                    LeerEstadoDetectores();
                    TimerLeerStatusDetector.Start();
                }
            }
            catch
            {
                
            }
            
        }
    }
}
