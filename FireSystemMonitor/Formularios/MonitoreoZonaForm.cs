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
using System.Text.RegularExpressions;

namespace FireSystemMonitor.Classes
{
    public partial class MonitoreoZonaForm : Form
    {
        bool Play = true;
        int indexSlideShow = 0;
        Color Rojo = Color.FromArgb(192, 57, 43);
        Color Amarillo = Color.FromArgb(251, 197, 49);
        Color Gray = Color.LightGray;
        Color Blanco = Color.FromArgb(236, 240, 241);
        Color Negro = Color.Black;
        Color Verde = Color.FromArgb(0, 148, 50);
        int IdFacpToShow = Program.GidFacp;
        string formname = Program.FormName;
        string estadoDevice = "OK";
        bool changeColor = false;
        public bool fillCombo = false;
        public bool Evac = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        List<PictureBox> PanelesAEliminar = new List<PictureBox>();

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        int idZonaMonitorear = Program.GidZonaMonitorear;
        
        List<Int32> zonasIdList = new List<int>();
        List<String> zonasNombresList = new List<string>();    
        Procedimientos P = new Procedimientos();
        List<PictureBox> ListaDetectores = new List<PictureBox>();


        public MonitoreoZonaForm()
        {
            InitializeComponent();
            try
            {
                numericUpDown1.Value = Properties.Settings.Default.SlideShowTime;
                
            }
            catch { numericUpDown1.Value = numericUpDown1.Minimum; Properties.Settings.Default.SlideShowTime = Convert.ToInt32(numericUpDown1.Value); Properties.Settings.Default.Save(); }
            SlideShowTimer.Interval = Convert.ToInt32(Properties.Settings.Default.SlideShowTime) * 1000;
            P.ID_FACP = IdFacpToShow;
            DataTable dt = new DataTable();
            dt = P.ObtenerZonasHabilitadas();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(Convert.ToInt32(dt.Rows[i][0].ToString()) == idZonaMonitorear)
                {
                    indexSlideShow = i;
                }
                zonasIdList.Add(Convert.ToInt32(dt.Rows[i][0].ToString()));
                zonasNombresList.Add(dt.Rows[i][1].ToString());

            }

            
        }

        #region Funciones

        public void CargarZona()
        {
            try
            {
                CargarImagenDesdeBd(zonasIdList[indexSlideShow]);
                

            }

            catch (ArgumentNullException ex) { }
            
        }

        public void CargarDetectores(int idZonaSlide)
        {
            EliminarTodosDetectores();
            ObtenerDetectoresZona(idZonaSlide, false);
            LeerEstadoDetectores(idZonaSlide);
            ObtenerUltimoEstadoFacp();
            ObtenerEstadoEvacuacionFacp();
        }

        public void CargarImagenDesdeBd(int idZona)
        {
            try
            {
                //if (pictureBox1.Image != null)
                //{
                //    pictureBox1.Image = null;
                //}
                PictureBox pic = new PictureBox();
                pic.Tag = "ZONA PIC";
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Dock = DockStyle.Fill;
                pic.BringToFront();
                panel1.Controls.Add(pic);
                
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
                        pic.Image = loadedImage;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Refresh();



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
            catch (ArgumentNullException ex) { }
            

        }

        public void ObtenerDetectoresZona(int idZona, bool MoverDetector)
        {
            try
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

                    else if (figura == "Letra M")
                    {
                        GenerarDetectorZona(posx, posy, "OLD", sizepx, name, MoverDetector, idDetector, Properties.Resources.transLetraMverde,
                        identificador, dispositivo, tipoDispositivo, figura);
                    }
                    else
                    {
                        GenerarDetectorZona(posx, posy, "OLD", sizepx, name, MoverDetector, idDetector, Properties.Resources.cuadroVerde,
                        identificador, dispositivo, tipoDispositivo, figura);
                    }


                }
            }
            catch (ArgumentNullException ex) { }
            
        }

        public void GenerarDetectorZona(int posx, int posy, string tipo, int sizepx, string name, bool mover, int idDetector, Image img, string identificador, string dispositivo, string tipoDispositivo, string figura)

        {
            
            try
            {
                PictureBox p = new PictureBox();
                p.Location = new Point(posx, posy);
                
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
                p.Image = null;
                p.BackColor = Color.Transparent;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.BackColor = Color.Transparent;
                p.Draggable(mover);
                p.MouseHover += new EventHandler(Panel_Hover);
                p.MouseLeave += new EventHandler(Panel_Leave);

                PictureBox pic = FindPictureBox();

                
                   
                Action action = () =>
                {

                    pic.Controls.Add(p);
                };
                pic.Invoke(action);
                    
                
               
                
                
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine("MONITOREO GENERAR DETECTOR");
                TimerLeerStatusDetector.Start();
                border_timer.Start();
            }
            


        }

        public PictureBox FindPictureBox()
        {
            PictureBox pic = new PictureBox();
            foreach (PictureBox control in panel1.Controls.OfType<PictureBox>())
            {
                if (control.Tag.ToString() == "ZONA PIC")
                {
                    pic = control;
                    return  pic;
                }
            }
            return pic;
        }

        public void LeerEstadoDetectores(int idZonaSlide)
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
                    P.IdZona = idZonaSlide;
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
                        if (Estado == "HEAT" || Estado == "SMOKE" || Estado == "PULL STATION" || Estado == "MONITOR")
                        {
                            estadoDevice = "ALARM";
                            check = true;
                            //border_timer.Start();

                        }
                        else if (Estado != "OK")
                        {
                            estadoDevice = "WARNING";
                            //border_timer.Start();
                        }

                    }
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    CambiarEstadoDetector(pb, Estado, namesList[7]);
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    //Console.WriteLine( "TIME: "  + elapsedMs);
                    Console.WriteLine(estadoDevice);

                }
            }

            catch
            {

            }
            
        }

        public void EncontrarDetectores()
        {
            try
            {
                ListaDetectores.Clear();
                PictureBox pic = FindPictureBox();
                foreach (var pb in pic.Controls.OfType<PictureBox>())
                {
                    if ((pb.Tag.ToString()).StartsWith("OLD") || (pb.Tag.ToString()).StartsWith("NEW"))
                    {
                        ListaDetectores.Add(pb);
                    }

                }
            }
            catch (ArgumentNullException ex) { }
            
        }

        public void CambiarEstadoDetector (PictureBox pb, string estado, string figura)
        {
            try
            {
                if (pb.Image != null)
                {
                    pb.Image = null;
                    //pb.Refresh();
                }

                if (figura == "Círculo" || figura == "Cuadro")
                {

                    if (estado == "OK")
                    {
                        pb.Image = Properties.Resources.DetectorOK;


                    }
                    else if (estado == "HEAT" || estado == "SMOKE" || estado == "PULL STATION" || estado == "MONITOR")
                    {
                        pb.Image = Properties.Resources.DetectorFuego;


                    }

                    else if (estado == "INVREP")
                    {

                        pb.Image = Properties.Resources.DetectorFalta;

                    }

                    else if (estado == "OPEN" || estado == "SHORT" || estado == "DIRTY1" || estado == "DIRTY2" || estado == "INV ID" || estado == "TEST F")
                    {
                        pb.Image = Properties.Resources.DetectorWarning;
                    }
                    else //no pudo ser leido
                    {
                        pb.Image = Properties.Resources.DetectorNoLeido;
                    }
                }

                else if (figura == "Letra M")
                {
                    if (estado == "OK")
                    {
                        pb.Image = Properties.Resources.transLetraMverde;
                    }
                    else if (estado == "HEAT" || estado == "SMOKE" || estado == "PULL STATION" || estado == "MONITOR")
                    {
                        pb.Image = Properties.Resources.ModuloActivo;
                    }

                    else if (estado == "INVREP")
                    {
                        pb.Image = Properties.Resources.ModuloFalta;
                    }

                    else if (estado == "OPEN" || estado == "SHORT" || estado == "DIRTY1" || estado == "DIRTY2" || estado == "INV ID" || estado == "TEST F")
                    {
                        pb.Image = Properties.Resources.transLetraMamarilla;
                    }
                    else //no pudo ser leido
                    {
                        pb.Image = Properties.Resources.ModuloFalta;
                    }
                }

                else // Letra P
                {
                    if (estado == "OK")
                    {
                        pb.Image = Properties.Resources.transLetraPverde;
                    }
                    else if (estado == "HEAT" || estado == "SMOKE" || estado == "PULL STATION" || estado == "MONITOR")
                    {
                        pb.Image = Properties.Resources.PullActivo;
                    }

                    else if (estado == "INVREP")
                    {
                        pb.Image = Properties.Resources.DetectorFalta;
                    }

                    else if (estado == "OPEN" || estado == "SHORT" || estado == "DIRTY1" || estado == "DIRTY2" || estado == "INV ID" || estado == "TEST F")
                    {
                        pb.Image = Properties.Resources.transLetraPamarilla;
                    }
                    else //no pudo ser leido
                    {
                        pb.Image = Properties.Resources.PullFalta;
                    }
                    // pb.Show();
                    //pb.Load();

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
            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    if (estadoDevice == "ALARM")
                    {
                        if (!changeColor)
                        {
                            changeColor = !changeColor;


                            panel3.BackColor = Rojo; //rojo
                            NombreZona_lbl.ForeColor = Gray;

                            panel2.BackColor = Rojo; //rojo
                        }
                        else
                        {
                            changeColor = !changeColor;
                            panel3.BackColor = Gray;
                            NombreZona_lbl.ForeColor = Rojo; //rojo

                            panel2.BackColor = Gray;
                        }
                    }
                    else if (estadoDevice == "WARNING")
                    {
                        if (!changeColor)
                        {
                            changeColor = !changeColor;


                            panel3.BackColor = Amarillo; //amarillo
                            NombreZona_lbl.ForeColor = Gray;

                            panel2.BackColor = Amarillo;//amarillo
                        }
                        else
                        {
                            changeColor = !changeColor;
                            panel3.BackColor = Gray;
                            NombreZona_lbl.ForeColor = Amarillo; //amarillo

                            panel2.BackColor = Gray;
                        }
                    }
                    else
                    {
                        panel3.BackColor = Verde; ;
                        NombreZona_lbl.ForeColor = Blanco;

                        panel2.BackColor = Gray;
                        //border_timer.Stop();
                    }
                }
                catch (ArgumentNullException ex)
                {

                }
            });

            
            
        }

        public void EncontrarDetectores(List<PictureBox> panels)
        {
            this.Invoke((MethodInvoker)delegate
            {
                foreach (var p in panels)
                {

                    p.Dispose();


                }
                PanelesAEliminar.Clear();

            });
           
        }

        public void EliminarTodosDetectores()
        {
            ListaDetectores.Clear();
            this.Invoke((MethodInvoker)delegate
            {
                PictureBox pic = FindPictureBox();
                foreach (var pb in pic.Controls.OfType<PictureBox>())
                {

                    PanelesAEliminar.Add(pb);
                }

                EncontrarDetectores(PanelesAEliminar);
            });

            

        }

        public void EliminarPlanoPrincipal()
        {
            try
            {
                foreach (PictureBox control in panel1.Controls.OfType<PictureBox>())
                {
                    if (control.Tag.ToString() == "ZONA PIC")
                    {
                        panel1.Controls.Remove(control);
                        control.Dispose();
                    }
                }
            }
            catch (Exception ex) { }
            
        }
        
        public void LoadSlideShows(int idZonaSlide)
        {
            estadoDevice = "OK";
            panel3.BackColor = Verde; //rojo;
            NombreZona_lbl.ForeColor = Blanco;

            panel2.BackColor = Gray;

            TimerLeerStatusDetector.Stop();
            border_timer.Stop();
            
            EliminarTodosDetectores();
            EliminarPlanoPrincipal();
            ObtenerUltimoEstadoFacp();
            ObtenerEstadoEvacuacionFacp();
            NombreZona_lbl.Text = zonasNombresList[indexSlideShow];
            this.Text = zonasNombresList[indexSlideShow];
            CargarZona();
            CargarDetectores(idZonaSlide);
            
            CambiarColorBorde();
            TimerLeerStatusDetector.Start();
            border_timer.Start();
        }
        
        public void NextSlideShow()
        {
            int totalZonas = zonasIdList.Count - 1;
            if (indexSlideShow == totalZonas)
            {
                indexSlideShow = 0;
            }
            else
            {
                indexSlideShow++;
            }

            LoadSlideShows(zonasIdList[indexSlideShow]);
        }

        public void PreviousSlideShow()
        {
            int totalZonas = zonasIdList.Count - 1;
            if (indexSlideShow == 0)
            {
                indexSlideShow = totalZonas;
            }
            else
            {
                indexSlideShow--;
            }

            LoadSlideShows(zonasIdList[indexSlideShow]);
        }

        public void ObtenerUltimoEstadoFacp()
        {
            try
            {
                DataTable dt = new DataTable();
                P.ID_FACP = IdFacpToShow;
                dt = P.ObtenerUltimoEstadoFacp();
                if(dt.Rows.Count > 0)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                       
                        RegexOptions options = RegexOptions.None;
                        Regex regex = new Regex("[ ]{2,}", options);
                        lastFacpStatus_lbl.Text = regex.Replace(dt.Rows[0][0].ToString().Trim(), " ");

                    });
                    
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        lastFacpStatus_lbl.Text = "No se pudo obtener último estado Facp";

                    });
                }
            }
            catch (Exception ex) { }
        }

        public void ObtenerEstadoEvacuacionFacp()
        {
            try
            {

                this.Invoke((MethodInvoker)delegate
                {

                    DataTable dt = new DataTable();
                    P.ID_FACP = IdFacpToShow;
                    dt = P.ObtenerEstadoEvacuacionFacp();
                    if (dt.Rows.Count > 0)
                    {
                        if (Convert.ToBoolean(dt.Rows[0][0].ToString()))
                        {
                            evac_lbl.Visible = true;
                            if (!Evac)
                            {
                                Evac_timer.Start();
                            }
                            Evac = true;
                        }
                        else
                        {
                            evac_lbl.Visible = false;
                            Evac = false;
                            Evac_timer.Stop();
                        }

                    }

                });


            }
            catch (Exception ex) { }
        }

        #endregion


        #region EventosManuales

        private void Panel_Leave(object sender, EventArgs e)
        {
            //Point locationOnForm = (sender as PictureBox).Location;
        }

        private void Panel_Hover(object sender, EventArgs e)
        {

            try
            {
                string Estado = "No se pudo obtener estado";
                string tag = (sender as PictureBox).Tag.ToString(); // format --> tipo*id*identificador*tamaño*nombre
                string Descripcion = "";
                string[] namesArray = tag.Split('*');
                List<string> namesList = new List<string>(namesArray.Length);
                namesList.AddRange(namesArray);
                P.IdZona = zonasIdList[indexSlideShow];
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
            catch(ArgumentNullException ex)
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
            try
            {

                LoadSlideShows(zonasIdList[indexSlideShow]);
                SlideShowTimer.Start();
            }
            catch (ArgumentNullException ex)
            {

            }
            
        }

        private void TimerLeerStatusDetector_Tick(object sender, EventArgs e)
        {
            try
            {
                TimerLeerStatusDetector.Stop();
                if (!LeerStatusWorker.IsBusy)
                {
                    LeerStatusWorker.RunWorkerAsync();
                }
            }
            catch (ArgumentNullException ex)
            {
               
            }
            
            

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch (ArgumentNullException ex)
            {

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
            try
            {
                border_timer.Stop();
                if (!BorderColorWorker.IsBusy)
                {
                    BorderColorWorker.RunWorkerAsync();
                }
            }
            catch (ArgumentNullException ex)
            {
                
            }
           
            
        }

        private void MonitoreoZonaForm_Resize(object sender, EventArgs e)
        {
            
        }

        private void LeerStatusWorker_DoWork(object sender, DoWorkEventArgs e)
        {
           try
            {
                CargarDetectores(zonasIdList[indexSlideShow]);
            }
            catch (ArgumentNullException ex)
            {

            }
            
            
                 
        }

        private void BorderColorWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                CambiarColorBorde();
            }
            catch (ArgumentNullException ex) { }
            
            
        }

        private void LeerStatusWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try { TimerLeerStatusDetector.Start(); }
            catch (ArgumentNullException ex) { }
            
        }

        private void BorderColorWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                border_timer.Start();
            }
            catch (ArgumentNullException ex)
            {
               
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SlideShowTime = Convert.ToInt32(numericUpDown1.Value);
            Properties.Settings.Default.Save();
            SlideShowTimer.Stop();
            SlideShowTimer.Interval = Convert.ToInt32(numericUpDown1.Value) * 1000;
            SlideShowTimer.Start();
        }

        private void SlideShowTimer_Tick(object sender, EventArgs e)
        {
            NextSlideShow();
        }

        private void pausePlay_btn_Click(object sender, EventArgs e)
        {
            if (Play)
            {
                pausePlay_btn.Image = Properties.Resources.play_3_24;
                SlideShowTimer.Stop();
                next_btn.Enabled = true;
                previous_btn.Enabled = true;
            }
            else
            {
                pausePlay_btn.Image = Properties.Resources.pause_24;
                SlideShowTimer.Start();
                next_btn.Enabled = false;
                previous_btn.Enabled = false ;
            }

            Play = !Play;
            
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            NextSlideShow();
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            PreviousSlideShow();
        }

        private void Evac_timer_Tick(object sender, EventArgs e)
        {
            if (!Evac_Worker.IsBusy)
            {
                Evac_Worker.RunWorkerAsync();
            }
        }

        private void Evac_Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Evac_timer.Stop();
            this.Invoke((MethodInvoker)delegate
            {
                evac_lbl.Visible = !evac_lbl.Visible;
            });
        }

        private void Evac_Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Evac_timer.Start();
        }
    }
}
