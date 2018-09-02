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

namespace FireSystemMonitor.Formularios
{
    public partial class MainScreenForm : Form
    {

        Color color = new Color();
        
        GlobalFunctions GF = new GlobalFunctions();
        public bool fillCombo = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public bool Evac = false;
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
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                    string msj = P.ObtenerEstadoOnlineFacp();
                    if (msj == "1")
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
                });
               
            }
            catch (ArgumentNullException ex)
            {

            }
            
           
        }

        
        public void UpdateZonaEstatus()
        {
            try
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
                    //PictureBox p = new PictureBox();
                    Label lbl = new Label();
                   

                    if (msj == "ALARMA")
                    {
                        Action action = () =>
                        {
                            try
                            {
                                foreach (Control item in control.Controls.OfType<Label>())
                                {
                                    if (item.Tag.ToString() == "Dyn")
                                    {
                                        control.Controls.Remove(item);
                                        item.Dispose();
                                    }

                                }
                            }catch(Exception ex) { }
                            

                            //p.Anchor = AnchorStyles.None;

                            ////CenterPictureBox(p);
                            //p.Image = Properties.Resources.DetectorFuego;
                            //p.Size = new Size(50, 50);
                            //p.Location = new Point((control.Width / 2) - 50, (control.Height / 2) - 50);
                            //p.BringToFront();
                            ////p.Refresh();
                            //p.Show();
                            //control.Controls.Add(p);

                            lbl.ForeColor = Color.Red;
                            lbl.Text = msj;
                            lbl.Tag = "Dyn";

                            lbl.Font = new Font("Arial", 18, FontStyle.Bold);

                            lbl.BackColor = Color.Transparent;
                            lbl.AutoSize = false;
                            lbl.Width = control.Width;
                            //lbl.Height = control.Height;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;

                            control.Controls.Add(lbl);

                        };
                        control.Invoke(action); // Or use BeginInvoke



                        this.Invoke((MethodInvoker)delegate
                        {
                            toolTip1.SetToolTip(lbl, "ALARMA");
                        });



                    }
                    else if (msj == "ADVERTENCIA")
                    {
                        Action action = () =>
                        {
                            try
                            {
                                foreach (Control item in control.Controls.OfType<Label>())
                                {
                                    if (item.Tag.ToString() == "Dyn")
                                    {
                                        control.Controls.Remove(item);
                                        item.Dispose();
                                    }

                                }
                            }
                            catch (Exception ex) { }
                            lbl.ForeColor = Color.FromArgb(241, 196, 15);
                            lbl.Text = msj;
                            lbl.Tag = "Dyn";

                            lbl.Font = new Font("Arial", 18, FontStyle.Bold);

                            lbl.BackColor = Color.Transparent;
                            lbl.AutoSize = false;
                            lbl.Width = control.Width;
                            //lbl.Height = control.Height;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;

                            control.Controls.Add(lbl);

                            control.Controls.Add(lbl);
                            //control.Controls.Add(lbl);

                            //p.SizeMode = PictureBoxSizeMode.AutoSize;
                            //p.Anchor = AnchorStyles.None;

                            ////CenterPictureBox(p);
                            //p.Image = Properties.Resources.DetectorWarning;
                            //p.Size = new Size(50, 50);
                            //p.Location = new Point((control.Width / 2) - 50, (control.Height / 2) - 50);
                            //p.BringToFront();
                            //p.Refresh();

                        };
                        control.Invoke(action);

                        this.Invoke((MethodInvoker)delegate
                        {
                            toolTip1.SetToolTip(lbl, "WARNING");
                        });

                    }

                    else // ok
                    {
                        Action action = () =>
                        {
                            try
                            {
                                foreach (Control item in control.Controls.OfType<Label>())
                                {
                                    if (item.Tag.ToString() == "Dyn")
                                    {
                                        control.Controls.Remove(item);
                                        item.Dispose();
                                    }

                                }
                            }
                            catch (Exception ex) { }

                        };
                        control.Invoke(action);


                    }



                }
            }

            catch (ArgumentNullException ex)
            {

            }
            
        }

        private void CenterPictureBox(PictureBox picBox)
        {
            try
            {
                picBox.Location = new Point((picBox.Parent.ClientSize.Width / 2) - (picBox.Width / 2),
                                        (picBox.Parent.ClientSize.Height / 2) - (picBox.Height / 2));
                picBox.Refresh();
            }
            catch(ArgumentNullException ex)
            {
                
            }
            
        }

        public void LLenarFacpCB()
        {
            try
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
            catch (ArgumentNullException ex) { }
            
            
        }

        public void obtenerEstadoFacp()
        {
            try
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
            catch (ArgumentNullException ex) { }
            
           
        }

        public void ObtenerZonasHabilitadas()
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (facp_cb.SelectedIndex != -1)
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


                        if(total == 1)
                        {
                            sizey = (panelHeight) - 10;
                            sizex = (panelWidth ) - 10;
                        }
                        else if(total == 2)
                        {
                            sizey = (panelHeight) - 10;
                            sizex = (panelWidth/total) - 10;
                        }
                        //else if (total == 3 )
                        //{
                        //    sizey = (panelHeight) - 10;
                        //    sizex = (panelWidth/3) - 10;
                        //}
                        else 
                        {
                            sizey = (panelHeight / 2) - 10;
                            sizex = (panelWidth /2) - 10;
                        }

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
                            catch (Exception ex)
                            {
                                Console.WriteLine("MAIN SCREEN OBTENER ZONAS HABILITADAS");
                                RefrescarTimer.Start();
                                EstadoZona_timer.Start();

                            }


                        }
                    }
                });
               
            }

            catch (ArgumentNullException ex)
            {

            }

            


            
        }

        public void GenerarThumbnailZonas(int idZona, string nombre, string descripcion,MemoryStream Ms, string FACP, int sizex, int sizey)
        {
            try
            {
                PictureBox Pb = new PictureBox();
                
                Pb.BringToFront();
                Pb.Tag = idZona + "*" + nombre + "*" + descripcion + "*" + FACP;
                Pb.Size = new Size(sizex, sizey);
                
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
                Lbl.Tag = "Name";
                
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
                catch (ArgumentNullException ex)
                {
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }
                flowLayoutPanel1.Controls.Add(Pb);
                Pb.Show();
                Pb.MouseUp += new MouseEventHandler(Picture_Click);
                //Pb.BackColor = Color.Green;

                Pb.MouseHover += new EventHandler(Panel_Hover);
                flowLayoutPanel1.Refresh();
            }
            catch (ArgumentNullException ex)
            {

            }
            
        }

        public void RemoveAllControlsFromFlowPanel()
        {
            try
            {
                List<Control> listControls = flowLayoutPanel1.Controls.Cast<Control>().ToList();

                foreach (Control control in listControls)
                {
                    Action action = () => 
                    {
                        flowLayoutPanel1.Controls.Remove(control);
                        control.Dispose();
                        


                    };
                    control.Invoke(action);
                    
                }
            }
            catch (ArgumentNullException ex)
            {

            }
            
        }

        public void ObtenerUltimoEstadoFacp()
        {
            try
            {
                DataTable dt = new DataTable();
                P.ID_FACP =  Convert.ToInt32(facp_cb.SelectedValue);
                dt = P.ObtenerUltimoEstadoFacp();
                if (dt.Rows.Count > 0)
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
                    P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                    dt = P.ObtenerEstadoEvacuacionFacp();
                    if (dt.Rows.Count > 0)
                    {
                        if (Convert.ToBoolean(dt.Rows[0][0].ToString()))
                        {
                            evac_lbl.Visible = true;
                            if (!Evac)
                            {
                                Evac_Timer.Start();
                            }
                            Evac = true;
                        }
                        else
                        {
                            evac_lbl.Visible = false;
                            Evac = false;
                            Evac_Timer.Stop();
                        }

                    }

                });
                      

            }
            catch (Exception ex) { }
        }

        public void  ControlsState (bool activado)
        {
            try
            {
                facp_cb.Enabled = activado;
                historial_btn.Enabled = activado;
                ConfigMail_btn.Enabled = activado;
                flowLayoutPanel1.Enabled = activado;
                Refresh_btn.Enabled = activado;
                linkLabel1.Enabled = activado;
                info_btn.Enabled = activado;
            }
            catch (ArgumentNullException ex) { }
            
          
        }

        public void CheckIfSoftwareActivated()
        {
            try
            {
                P.HDD_SERIAL = GF.serial();
                P.SOFTWARE = Program.Gsoftware;
                string msj = P.CheckIfSoftwareActivated();
                //msj = "FULL";

                if (msj == "Trial")
                {
                    int dias = ObtenerDiasActivo();
                    if (dias == 0)
                    {
                        msjActivado_lbl.Text = "VERSION DE PRUEBA HA FINALIZADO";
                        ControlsState(false);
                        CerrarForms();

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
            catch (ArgumentNullException ex)
            {

            }

        }

        public int ObtenerDiasActivo()
        {
            int dias = 0;
            try
            {
               
                DataTable dt = new DataTable();
                P.HDD_SERIAL = GF.serial();
                P.SOFTWARE = Program.Gsoftware;
                dt = P.ObtenerDiasActivoSoftware();
                if (dt.Rows.Count > 0)
                {
                    dias = Convert.ToInt32(dt.Rows[0][0].ToString());
                }
            }

            catch (ArgumentNullException ex)
            {

            }
            

            return dias;
        }

        public void CerrarForms()
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {

                if (f.Name != "MainScreenForm" && f.Name != "ActivationForm")
                    f.Close();
            }
        }

        #endregion

        #region Eventos Manuales

        private void Panel_Hover(object sender, EventArgs e)
        {
            try
            {
                string tag = (sender as PictureBox).Tag.ToString(); // format --> tipo*id*identificador*tamaño*nombre

                string[] namesArray = tag.Split('*');
                List<string> namesList = new List<string>(namesArray.Length);
                namesList.AddRange(namesArray);
                toolTip1.SetToolTip((sender as PictureBox), "FACP: " + namesList[3] + "\nZona: " + namesList[1] + "\nDescripción: " + namesList[2]);
                toolTip1.InitialDelay = 100;
            }
            catch (ArgumentNullException ex)
            {

            }

            
            
        }

        private void Picture_Click(object sender, MouseEventArgs e)
        {
            try
            {
                string tag = (sender as PictureBox).Tag.ToString();
                string[] namesArray = tag.Split('*');
                List<string> namesList = new List<string>(namesArray.Length);
                namesList.AddRange(namesArray);
                Program.GidZonaMonitorear = Convert.ToInt32(namesList[0]);
                Program.FormName = namesList[1];
                MonitoreoZonaForm form = new MonitoreoZonaForm();
                form.Show();
            }
            catch (Exception eX) { MessageBox.Show(eX.Message); }

            
            
            
            


        }



        #endregion

        #region Eventos Automaticos

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            try
            {
                color = Color.Transparent;
                RefrescarTimer.Start();
                LLenarFacpCB();
                ObtenerZonasHabilitadas();
                UpdateZonaEstatus();
                ObtenerUltimoEstadoFacp();
                ObtenerEstadoEvacuacionFacp();
                EstadoZona_timer.Start();
                //obtenerEstadoFacp();
                getIfModuleOnline();
                CheckIfSoftwareActivated();
            }
            catch (ArgumentNullException) { }
           


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
            try
            {
                Program.Gventana = "Settings";
                SuperUserLoginForm form = new SuperUserLoginForm();
                form.ShowDialog();

                if (Program.Gventana == "Settings")
                {
                    //AgregarZonasForm form1 = new AgregarZonasForm();
                    //form1.ShowDialog();

                    ConfigurarZonasForm form1 = new ConfigurarZonasForm();
                    form1.ShowDialog();
                }
            }
            catch (ArgumentNullException) { }
            

        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            try
            {
                RefrescarTimer.Stop();

                RemoveAllControlsFromFlowPanel();
                ObtenerZonasHabilitadas();
                UpdateZonaEstatus();
                getIfModuleOnline();
                CheckIfSoftwareActivated();
                ObtenerUltimoEstadoFacp();
                ObtenerEstadoEvacuacionFacp();
                RefrescarTimer.Start();
            }
            catch (ArgumentNullException) { }
         
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
            catch (ArgumentNullException) { }
            
        }

        private void RefrescarTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                RefrescarTimer.Stop();
                if (!RefrescarWorker.IsBusy)
                {
                    RefrescarWorker.RunWorkerAsync();
                }
            }
            catch (ArgumentNullException) { }
          
           
            
        }

        private void facp_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                RemoveAllControlsFromFlowPanel();
                ObtenerZonasHabilitadas();
                Program.GidFacp = Convert.ToInt32(facp_cb.SelectedValue);
                //obtenerEstadoFacp();
                getIfModuleOnline();
                ObtenerUltimoEstadoFacp();
                ObtenerEstadoEvacuacionFacp();
            }
            catch (ArgumentNullException) { }
           
        }

        private void facp_cb_DropDown(object sender, EventArgs e)
        {
            try
            {
                LLenarFacpCB();
            }
            catch (ArgumentNullException) { }
            
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
            try
            {
                EstadoZona_timer.Stop();
                if (!EstadoZonaWorker.IsBusy)
                {
                    EstadoZonaWorker.RunWorkerAsync();
                }
            }
            catch (ArgumentNullException) { }
            
            
        }

        #endregion

        private void MainScreenForm_Resize(object sender, EventArgs e)
        {

            try
            {
                RefrescarTimer.Stop();

                RemoveAllControlsFromFlowPanel();
                ObtenerZonasHabilitadas();
                UpdateZonaEstatus();
                getIfModuleOnline();
                CheckIfSoftwareActivated();
                RefrescarTimer.Start();
            }
            catch (ArgumentNullException) { }
        }

        private void RefrescarWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                RemoveAllControlsFromFlowPanel();
                ObtenerZonasHabilitadas();
                ObtenerUltimoEstadoFacp();
                CheckIfSoftwareActivated();
            }
            catch (ArgumentNullException) { }
            
        }

        private void RefrescarWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                RefrescarTimer.Start();
            }
            catch (ArgumentNullException) { }
           
        }

        private void EstadoZonaWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                UpdateZonaEstatus();
                ObtenerUltimoEstadoFacp();
                ObtenerEstadoEvacuacionFacp();
                getIfModuleOnline();
            }
            catch (ArgumentNullException) { }
            
        }

        private void EstadoZonaWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                EstadoZona_timer.Start();
            }
            catch (ArgumentNullException){}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Evac_Timer_Tick(object sender, EventArgs e)
        {
            Evac_Timer.Stop();
            evac_lbl.Visible = !evac_lbl.Visible;
            Evac_Timer.Start();
        }
    }
}
