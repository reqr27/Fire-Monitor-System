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
namespace FireSystemMonitor.Formularios
{
    public partial class MainScreenForm : Form
    {
        Color color = new Color();
        
        GlobalFunctions GF = new GlobalFunctions();
        public bool fillCombo = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Procedimientos P = new Procedimientos();
        public MainScreenForm()
        {
            InitializeComponent();
        }

        #region Funciones

        public void getIfModuleOnline()
        {
            P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
            string msj = P.ObtenerEstadoOnlineFacp();
            if(msj == "1")
            {
                onlineStatus_lbl.Text = "Online";
                onlineStatus_lbl.ForeColor = Color.White;
                onlineStatus_lbl.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            }
            else
            {
                onlineStatus_lbl.Text = "Offline";
                onlineStatus_lbl.ForeColor = Color.Red;
                onlineStatus_lbl.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

            }
        }

        public void paint (object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,(sender as PictureBox).ClientRectangle, color, ButtonBorderStyle.Solid);
            (sender as PictureBox).Refresh();
        }

        public void UpdateZonaEstatus()
        {
            DataTable dt = new DataTable();
            List<PictureBox> listControls = flowLayoutPanel1.Controls.Cast<PictureBox>().ToList();

            foreach (PictureBox control in listControls)
            {
                string tag = control.Tag.ToString(); // 

                string[] namesArray = tag.Split('*');
                List<string> namesList = new List<string>(namesArray.Length);
                namesList.AddRange(namesArray);
                int idZona = Convert.ToInt32(namesList[0].ToString());
                P.IdZona = idZona;
                dt = P.ObtenerEstadoZonas();
                string msj = dt.Rows[0][0].ToString();
                PictureBox p = new PictureBox();
                if (msj == "ALARM")
                {
                    control.Controls.Add(p);
                    //p.SizeMode = PictureBoxSizeMode.AutoSize;
                    p.Anchor = AnchorStyles.None;

                    //CenterPictureBox(p);
                    p.Image = Properties.Resources.DetectorFuego;
                    p.Size = new Size(50, 50);
                    p.Location = new Point((control.Width / 2) - 50, (control.Height / 2) - 50);
                    p.BringToFront();
                    p.Refresh();
                    toolTip1.SetToolTip(p, "ALARMA");


                }
                else if (msj == "WARNING")
                {
                    control.Controls.Add(p);
                    //p.SizeMode = PictureBoxSizeMode.AutoSize;
                    p.Anchor = AnchorStyles.None;

                    //CenterPictureBox(p);
                    p.Image = Properties.Resources.DetectorWarning;
                    p.Size = new Size(50, 50);
                    p.Location = new Point((control.Width / 2) - 50, (control.Height / 2) - 50);
                    p.BringToFront();
                    p.Refresh();
                    toolTip1.SetToolTip(p, "WARNING");

                }

                else // ok
                {

                    foreach (Control item in control.Controls.OfType<PictureBox>())
                    {
                        
                            control.Controls.Remove(item);
                    }
                }


               
            }
        }
        private void CenterPictureBox(PictureBox picBox)
        {
            
            picBox.Location = new Point((picBox.Parent.ClientSize.Width / 2) - (picBox.Width / 2),
                                        (picBox.Parent.ClientSize.Height / 2) - (picBox.Height / 2));
            picBox.Refresh();
        }

        public void LLenarFacpCB()
        {
            facp_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerFacp();
            facp_cb.DataSource = dt;
            facp_cb.DisplayMember = "NOMBRE";
            facp_cb.ValueMember = "ID";
            if(dt.Rows.Count > 0)
            {
                facp_cb.SelectedIndex = 0;
                
            }
            
        }

        public void obtenerEstadoFacp()
        {
            Program.GestadoFacp = "";
            DataTable dt = new DataTable();
            P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
            dt = P.ObtenerEstadoFacp();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string msj = dt.Rows[i][0].ToString() + Environment.NewLine;
                Program.GestadoFacp += dt.Rows[i][0].ToString() + Environment.NewLine;
            }
           
        }

        public void ObtenerZonasHabilitadas()
        {
            if(facp_cb.SelectedIndex != -1)
            {
                int sizex = 195;
                int sizey = 195;
                DataTable dt = new DataTable();
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                Program.GidFacp = Convert.ToInt32(facp_cb.SelectedValue);
                dt = P.ObtenerZonasHabilitadas();
                int panelHeight = flowLayoutPanel1.Height;
                int panelWidth = flowLayoutPanel1.Width;
                int total = dt.Rows.Count;



                if (total <= 4 && total > 0)
                {
                    sizey = (panelHeight / total) - 10;
                    sizex = (panelWidth / total) - 10;
                }
                else
                {
                    sizey = (panelHeight / 4) - 10;
                    sizex = (panelWidth / 4) - 10;
                }
                //if(total == 1)
                //{
                //    sizex = 1000;
                //    sizey = 400;
                //}
                //else if(total == 2)
                //{
                //    sizex = 495;
                //    sizey = 400;
                //}
                //else if (total == 3)
                //{
                //    sizex = 320;
                //    sizey = 400;
                //}

                //else if (total == 4)
                //{
                //    sizex = 495;
                //    sizey = 195;
                //}
                //else
                //{
                //    sizex = 195;
                //    sizey = 195;
                //}
                for (int i = dt.Rows.Count - 1; i > -1; i--)
                {
                    int idZona = Convert.ToInt32(dt.Rows[i][0]);
                    string nombre = dt.Rows[i][1].ToString();
                    string Descripcion = dt.Rows[i][2].ToString();
                    byte[] imgshow = (byte[])(dt.Rows[i][3]);
                    string FACP = dt.Rows[i][4].ToString();
                    MemoryStream Ms = new MemoryStream(imgshow);
                    try
                    {
                        GenerarThumbnailZonas(idZona, nombre, Descripcion, Ms, FACP, sizex, sizey);
                    }
                    catch(ArgumentNullException ex)
                    {
                        Console.WriteLine("MAIN SCREEN OBTENER ZONAS HABILITADAS");
                        RefrescarTimer.Start();
                        EstadoZona_timer.Start();

                    }

                    
                }
            }


            
        }

        public void GenerarThumbnailZonas(int idZona, string nombre, string descripcion,MemoryStream Ms, string FACP, int sizex, int sizey)
        {
            PictureBox Pb = new PictureBox();
            flowLayoutPanel1.Controls.Add(Pb);
            Pb.BringToFront();
            Pb.Tag = idZona + "*" + nombre + "*" + descripcion + "*" + FACP;
            Pb.Size = new Size(sizex, sizey);
            //Pb.Padding = new Padding(1);
            Pb.Cursor = Cursors.Hand;
            
            Label Lbl = new Label();
            Lbl.Text = nombre;
            Pb.Controls.Add(Lbl);
            Lbl.Font = new Font("Arial", 14, FontStyle.Bold);
            Lbl.BackColor = Color.Transparent;
            Lbl.AutoSize = false;
            Lbl.ForeColor = Color.FromArgb(47, 54, 64);
            Lbl.Size = new Size(200, 30);
            Lbl.TextAlign = ContentAlignment.TopCenter;
            //Pb.Paint += new PaintEventHandler(paint);
            //Lbl.Padding = new Padding(1);

            

            try
            {
               
                Image loadedImage = Image.FromStream(Ms);
                Pb.Image = loadedImage;
                Pb.SizeMode = PictureBoxSizeMode.StretchImage;

                //using (Graphics G = Graphics.FromImage(Pb.Image))
                //{
                //    //G.DrawRectangle(Pens.Orange, new Rectangle(13, 14, 44, 44));
                //    Pen redPen = new Pen(Color.Red, 10);
                //    G.DrawRectangle(redPen,
                //                new Rectangle(Pb.Location.X, Pb.Location.Y,
                //                             Pb.Image.Width - 5, Pb.Image.Height - 5));
                //    Pb.Refresh();

                //}

            }
            catch (SecurityException ex)
            {
                // The user lacks appropriate permissions to read files, discover paths, etc.
                MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                    "Error message: " + ex.Message + "\n\n" +
                    "Details (send to Support):\n\n" + ex.StackTrace
                );
            }

            Pb.MouseUp += new MouseEventHandler(Picture_Click);
            //Pb.BackColor = Color.Green;

            Pb.MouseHover += new EventHandler(Panel_Hover);
            flowLayoutPanel1.Refresh();
            //if (mover)
            //{
            //    P.MouseUp += new MouseEventHandler(Panel_Click);
            //    P.DoubleClick += new EventHandler(Pb_DoubleClick);

            //}
        }

        public void RemoveAllControlsFromFlowPanel()
        {
            List<Control> listControls = flowLayoutPanel1.Controls.Cast<Control>().ToList();

            foreach (Control control in listControls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }
        }

        public void  ControlsState (bool activado)
        {
            facp_cb.Enabled = activado;
            historial_btn.Enabled = activado;
            ConfigMail_btn.Enabled = activado;
            flowLayoutPanel1.Enabled = activado;
            Refresh_btn.Enabled = activado;
            linkLabel1.Enabled = activado;
            info_btn.Enabled = activado;
           // msjActivado_lbl.Visible = !activado;
        }

        public void CheckIfSoftwareActivated()
        {
            P.HDD_SERIAL = GF.serial();
            P.SOFTWARE = Program.Gsoftware ;
            string msj = P.CheckIfSoftwareActivated();
            //msj = "FULL";
            
            if(msj == "Trial")
            {
                int dias = ObtenerDiasActivo();
                if(dias == 0)
                {
                    msjActivado_lbl.Text = "VERSION DE PRUEBA HA FINALIZADO";
                    ControlsState(false);

                }
                else
                {
                    msjActivado_lbl.Text = "VERSION DE PRUEBA - DIAS RESTANTES : " + dias;
                    ControlsState(true);
                    activar_btn.Text = "Upgrade";
                    activar_btn.Image = null;
                    activar_btn.Image = Properties.Resources.arrow_177_48;
                }
                

            }

            else if (msj == "Full")
            {
                msjActivado_lbl.Visible = false;
                ControlsState(true);
                activar_btn.Visible = false;
            }
            else
            
            {
                ControlsState(false);
                msjActivado_lbl.Text = "SOFTWARE NO HA SIDO ACTIVADO";
            }

        }


        public int ObtenerDiasActivo()
        {
            int dias = 0;
            DataTable dt = new DataTable();
            P.HDD_SERIAL = GF.serial();
            P.SOFTWARE = Program.Gsoftware;
            dt = P.ObtenerDiasActivoSoftware();
            if(dt.Rows.Count > 0)
            {
                dias = Convert.ToInt32(dt.Rows[0][0].ToString());
            }

            return dias;
        }
        #endregion

        #region Eventos Manuales

        //public void paintBorder(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;

        //    // Draw a string on the PictureBox.
        //    //g.DrawString("This is a diagonal line drawn on the control",
        //    //    new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(30, 30));
        //    // Draw a line in the PictureBox.
        //    //g.DrawRectangle(System.Drawing.Pens.Red, (sender as PictureBox).Left, (sender as PictureBox).Top,
        //    //    (sender as PictureBox).Right, (sender as PictureBox).Bottom);
        //    Pen redPen = new Pen(Color.Red, 5);
        //    e.Graphics.DrawRectangle(redPen,
        //                new Rectangle((sender as PictureBox).Location.X, (sender as PictureBox).Location.Y,
        //                              (sender as PictureBox).Size.Width - 5, (sender as PictureBox).Size.Height - 5));
        //}

        private void Panel_Hover(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.Cross;

            string tag = (sender as PictureBox).Tag.ToString(); // format --> tipo*id*identificador*tamaño*nombre

            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);
            toolTip1.SetToolTip((sender as PictureBox), "FACP: " + namesList[3] + "\nZona: " + namesList[1] + "\nDescripción: " + namesList[2]);
            toolTip1.InitialDelay = 100;
            
        }

        private void Picture_Click(object sender, MouseEventArgs e)
        {
            

            string tag = (sender as PictureBox).Tag.ToString();
            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);
            Program.GidZonaMonitorear = Convert.ToInt32(namesList[0]);
            Program.FormName = namesList[1];
            MonitoreoZonaForm form = new MonitoreoZonaForm();
            form.Show();
            
            
            //MessageBox.Show( ((sender as PictureBox).Tag).ToString());


        }

        #endregion

        #region Eventos Automaticos

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            color = Color.Transparent;
            RefrescarTimer.Start();
            LLenarFacpCB();
            ObtenerZonasHabilitadas();
            //UpdateZonaEstatus();
            EstadoZona_timer.Start();
            //obtenerEstadoFacp();
            getIfModuleOnline();
            CheckIfSoftwareActivated();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            Program.Gventana = "Settings";
            //SuperUserLoginForm form = new SuperUserLoginForm();
            //form.ShowDialog();

            if (Program.Gventana == "Settings")
            {
                //AgregarZonasForm form1 = new AgregarZonasForm();
                //form1.ShowDialog();

                ConfigurarZonasForm form1 = new ConfigurarZonasForm();
                form1.ShowDialog();
            }

        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            RefrescarTimer.Stop();

            RemoveAllControlsFromFlowPanel();
            ObtenerZonasHabilitadas();
            UpdateZonaEstatus();
            //obtenerEstadoFacp();
            getIfModuleOnline();
            CheckIfSoftwareActivated();
            RefrescarTimer.Start();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RefrescarTimer_Tick(object sender, EventArgs e)
        {
            RefrescarTimer.Stop();
            RemoveAllControlsFromFlowPanel();
            ObtenerZonasHabilitadas();
            
            CheckIfSoftwareActivated();
            RefrescarTimer.Start();
        }

        private void facp_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RemoveAllControlsFromFlowPanel();
            ObtenerZonasHabilitadas();
            Program.GidFacp = Convert.ToInt32(facp_cb.SelectedValue);
            //obtenerEstadoFacp();
            getIfModuleOnline();
        }

        private void facp_cb_DropDown(object sender, EventArgs e)
        {
            LLenarFacpCB();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FacpStatusForm form = new FacpStatusForm();
            form.ShowDialog();
        }

        private void historial_btn_Click(object sender, EventArgs e)
        {
            HistorialForm form = new HistorialForm();
            form.ShowDialog();
        }

        private void ConfigMail_btn_Click(object sender, EventArgs e)
        {
            EmailForm form = new EmailForm();
            form.ShowDialog();
        }


        private void activar_btn_Click(object sender, EventArgs e)
        {
            ActivationForm form = new ActivationForm();
            form.ShowDialog();
            CheckIfSoftwareActivated();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            InfoForm form = new InfoForm();
            form.Show();
        }

        private void EstadoZona_timer_Tick(object sender, EventArgs e)
        {
            EstadoZona_timer.Stop();
            UpdateZonaEstatus();
            getIfModuleOnline();
            EstadoZona_timer.Start();
        }

        #endregion

        private void MainScreenForm_Resize(object sender, EventArgs e)
        {
            try
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    RefrescarTimer.Stop();

                    RemoveAllControlsFromFlowPanel();
                    ObtenerZonasHabilitadas();
                    UpdateZonaEstatus();
                    //obtenerEstadoFacp();
                    getIfModuleOnline();
                    CheckIfSoftwareActivated();
                    RefrescarTimer.Start();
                }
            }
            catch
            {

            }
            
        }
    }
}
