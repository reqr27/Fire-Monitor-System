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
using System.IO;
using System.Security;

namespace FireSystemMonitor.Formularios
{
    public partial class ConfigurarZonasForm : Form
    {

        string file;
        int idEvento;
        Procedimientos P = new Procedimientos();
        int IdDetectorAeditar = 0;
        public ConfigurarZonasForm()
        {
            InitializeComponent();
        }

        List<PictureBox> PanelesAEliminar = new List<PictureBox>();
        List<PictureBox> Detectores_Guardar_Y_Actualizar = new List<PictureBox>();


        #region Funciones

        public void LlenarDtgZonas(int idFacp)
        {
            DataTable dt = new DataTable();
            zonas_dtg.DataSource = null;
            P.ID_FACP = idFacp;
            dt = P.ObtenerZonas();
            zonas_dtg.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                //deshabilitarZona_btn.Enabled = false;
                editarZona_btn.Enabled = false;
                verZona_btn.Enabled = false;
            }
            else
            {
                //deshabilitarZona_btn.Enabled = true;
                editarZona_btn.Enabled = true;
                verZona_btn.Enabled = true;
            }

        }

        public void LlenarDtgFacp()
        {
            DataTable dt = new DataTable();
            facp_dtg.DataSource = null;
            dt = P.ObtenerFacp();
            facp_dtg.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                facp_lbl.Text = "(" + dt.Rows[0][1].ToString() + ")";
                int idFacp = Convert.ToInt32(dt.Rows[0][0].ToString());
                LlenarDtgZonas(idFacp);
            }


        }

        public void LLenarFacpCB()
        {
            facp_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerFacp();
            facp_cb.DataSource = dt;
            facp_cb.DisplayMember = "NOMBRE";
            facp_cb.ValueMember = "ID";
            facp_cb.SelectedIndex = -1;


        }


        public void GenerarDetectorZona(int posx, int posy, string tipo, int sizepx, string name, bool mover, int idDetector, Image img, string identificador, string dispositivo, string tipoDispositivo, string figura)
        {
            //NameZoneForm form = new NameZoneForm();
            //form.ShowDialog();


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
            if (mover)
            {
                p.MouseUp += new MouseEventHandler(Panel_Click);
                p.DoubleClick += new EventHandler(Panel_DoubleClick);

            }

        }

        public void CambiarEstadoControles(bool estado, Control control)
        {
            control.Enabled = estado;
        }

        public void CargarImagenDesdeBd(int idZona)
        {
            pictureBox1.Image = null;
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
                catch (SecurityException ex)
                {
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
                int posx = Convert.ToInt32(dt.Rows[i][3].ToString());
                int posy = Convert.ToInt32(dt.Rows[i][4].ToString());
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

        public void EncontrarDetectores(List<PictureBox> panels, string tipo)
        {
            foreach (var p in panels)
            {
                if (tipo == "TODOS")
                {
                    if (p.Tag.ToString().StartsWith("OLD") || p.Tag.ToString().StartsWith("NEW"))
                    {
                        p.Dispose();
                    }

                }
                else if (tipo == "NEW")
                {
                    string tag = p.Tag.ToString();
                    if (tag.StartsWith("NEW"))
                    {
                        p.Dispose();
                    }
                }

                else// (tipo == "OLD")
                {
                    string tag = p.Tag.ToString();
                    if (tag.StartsWith("OLD"))
                    {
                        p.Dispose();
                    }
                }
            }
            PanelesAEliminar.Clear();
        }


        public void EliminarTodosDetectores(string tipo)
        {

            foreach (var pb in pictureBox1.Controls.OfType<PictureBox>())
            {

                PanelesAEliminar.Add(pb);
            }

            EncontrarDetectores(PanelesAEliminar, tipo);

        }


        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }


        public void ResetCamposGeneral()
        {
            pictureBox1.Image = Properties.Resources.add_image_256;
            EliminarTodosDetectores("TODOS");
            editarZona_btn.BackColor = Color.FromArgb(72, 84, 96);
            editarZona_btn.Text = "Editar";

            verZona_btn.BackColor = Color.FromArgb(72, 84, 96);
            verZona_btn.Text = "Ver";
            AgregarZona_lbl.Text = "AGREGAR ZONAS";

            agregarZonas_btn.Text = "Guardar";
            agregarZonas_btn.BackColor = Color.FromArgb(11, 232, 129);

            AgregarDetector_btn.Visible = false;

            idEvento = 0;
            nombre_txt.Text = "";
            descripcion_txt.Text = "";
            estadoZona_chbox.Checked = true;
            AgregarDetector_btn.Visible = false;
            CambiarEstadoControles(true, Cancelar_btn);
        }

        public void ActualizarZonas()
        {
            if (pictureBox1.Image != Properties.Resources.add_image_256)
            {
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.IdZona = idEvento;
                P.Nombre = nombre_txt.Text;
                P.Descripcion = descripcion_txt.Text;
                P.Estado = estadoZona_chbox.Checked;
                P.Img = ImageToByte(pictureBox1.Image);
                string msj = P.ActualizarZona();
                if (Convert.ToInt32(msj) != 0)
                {

                    ActualizarOGuardarDetectoresPorZona();
                    ResetCamposGeneral();
                }
                else
                {
                    MessageBox.Show("!No pudo actualizarse correctamente nada");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar imágen");
            }
        }

        public void ActualizarOGuardarDetectoresPorZona()
        {
            EncontrarDetectoresGuardarActualizar();
            string msjActualizar = "";
            string msjGuardar = "";
            foreach (var detector in Detectores_Guardar_Y_Actualizar)
            {
                Point locationOnForm = detector.Location;


                if ((detector.Tag.ToString().StartsWith("OLD"))) //Actualizar
                {
                    msjActualizar += ActualizarDetector(idEvento, ObtenerIdDetector(detector), ObtenerNombreDetector(detector), locationOnForm.X,
                    locationOnForm.Y, ObtenerTamañoDetector(detector), ObtenerIdentificadorDetector(detector), ObtenerDispositivoDetector(detector),
                    ObtenerTipoDispositivoDetector(detector), ObtenerFiguraDetector(detector)) + "\n";
                }

                else // Registrar
                {
                    msjGuardar += RegistrarDetector(idEvento, ObtenerIdDetector(detector), ObtenerNombreDetector(detector), locationOnForm.X,
                    locationOnForm.Y, ObtenerTamañoDetector(detector), ObtenerIdentificadorDetector(detector), ObtenerDispositivoDetector(detector),
                    ObtenerTipoDispositivoDetector(detector), ObtenerFiguraDetector(detector)) + "\n";
                }

            }

            if (msjActualizar.Trim() == "" && msjGuardar.Trim() == "")
            {
                MessageBox.Show("Cambios Realizados Exitosamente!");
            }
            else
            {
                MessageBox.Show("No se pudieron Actualizar los siguientes Detectores: " + msjActualizar +
                    "\n \n" + "No se Pudieron guardan los siguientes Detectores: " + msjGuardar);
            }
            Detectores_Guardar_Y_Actualizar.Clear();

        }

        public string RegistrarDetector(int idZona, int idDetector, string nombre, int posx, int posy, int tamañopx, string identificador, string dispositivo, string tipoDispositivo, string figura)
        {
            string msj = "";
            string msjReturn = "";
            P.IdZona = idZona;
            P.IdDetector = idDetector;
            P.Nombre = nombre.Trim();
            P.Tamaño = tamañopx;
            P.PosX = posx;
            P.PosY = posy;
            P.Identificador = identificador;
            P.Dispositivo = dispositivo;
            P.TipoDispositivo = tipoDispositivo;
            P.Figura = figura;
            msj = P.InsertarDetectoresZona();
            if (msj != "1")
            {
                msjReturn = nombre;
            }

            return msjReturn;
        }

        public string ActualizarDetector(int idZona, int idDetector, string nombre, int posx, int posy, int tamañopx, string identificador, string dispositivo, string tipoDispositivo, string figura)
        {
            string msj = "";
            string msjReturn = "";
            P.IdZona = idZona;
            P.IdDetector = idDetector;
            P.Nombre = nombre.Trim();
            P.Tamaño = tamañopx;
            P.PosX = posx;
            P.PosY = posy;
            P.Identificador = identificador;
            P.Dispositivo = dispositivo;
            P.TipoDispositivo = tipoDispositivo;
            P.Figura = figura;
            msj = P.ActualizarDetectoresZona();
            if (msj != "1")
            {
                msjReturn = nombre;
            }

            return msjReturn;
        }

        public void EncontrarDetectoresGuardarActualizar()
        {
            foreach (var pb in pictureBox1.Controls.OfType<PictureBox>())
            {
                if ((pb.Tag.ToString()).StartsWith("OLD") || (pb.Tag.ToString()).StartsWith("NEW"))
                {
                    Detectores_Guardar_Y_Actualizar.Add(pb);
                }

            }
        }

        public int ObtenerIdDetector(PictureBox p)
        {
            string tag = p.Tag.ToString(); // format --> tipo-id-identificador-tamaño-nombre

            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);




            return Convert.ToInt32(namesList[1]);
        }

        public string ObtenerIdentificadorDetector(PictureBox p)
        {
            string tag = p.Tag.ToString(); // format --> tipo-id-identificador-tamaño-nombre

            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);




            return (namesList[2]);
        }

        public int ObtenerTamañoDetector(PictureBox p)
        {
            string tag = p.Tag.ToString(); // format --> tipo*id*identificador*tamaño*nombre

            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);



            return Convert.ToInt32(namesList[3]);
        }

        public string ObtenerNombreDetector(PictureBox p)
        {
            string tag = p.Tag.ToString(); // format --> tipo*id*identificador*tamaño*nombre

            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);



            return namesList[4];
        }

        public string ObtenerDispositivoDetector(PictureBox p)
        {
            string tag = p.Tag.ToString(); // format --> tipo*id*identificador*tamaño*nombre*dispositivo*tipoDispositvo*figura

            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);



            return namesList[5];
        }

        public string ObtenerTipoDispositivoDetector(PictureBox p)
        {
            string tag = p.Tag.ToString(); // format --> tipo*id*identificador*tamaño*nombre*dispositivo*tipoDispositvo*figura

            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);



            return namesList[6];
        }

        public string ObtenerFiguraDetector(PictureBox p)
        {
            string tag = p.Tag.ToString(); // format --> tipo*id*identificador*tamaño*nombre*dispositivo*tipoDispositvo*figura

            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);



            return namesList[7];
        }

        public void RegistrarZonas()
        {
            if (pictureBox1.Image != Properties.Resources.add_image_256 && nombre_txt.Text.Trim() != "" && descripcion_txt.Text.Trim() != "" && facp_cb.Text != "")
            {
                P.ID_FACP = Convert.ToInt32(facp_cb.SelectedValue);
                P.Nombre = nombre_txt.Text;
                P.Descripcion = descripcion_txt.Text;
                P.Estado = estadoZona_chbox.Checked;
                P.Img = ImageToByte(pictureBox1.Image);
                string msj = P.InsertarZona();
                if (Convert.ToInt32(msj) != 0)
                {
                    idEvento = Convert.ToInt32(msj);
                    ActualizarOGuardarDetectoresPorZona();

                    ResetCamposGeneral();
                }
                else
                {
                    MessageBox.Show("!No pudo actualizarse correctamente nada");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar imágen y llenar campos 'Nombre' y 'Descripción'");
            }
        }

        public void EliminarDetectorenBD(int IdZona, int @IdDetectorAeliminar, PictureBox p)
        {
            P.IdZona = IdZona;
            P.IdDetector = IdDetectorAeliminar;
            string msj = P.BorrarDetector();
            if (msj != "0")
            {
                p.Dispose();
                MessageBox.Show("Eliminado Correctamente!");
            }
            else
            {
                MessageBox.Show("Error Eliminando Detector!");
            }
        }

        public void RegistrarFacp()
        {
            if (NombreFacp_txt.Text.Trim() != "")
            {
                P.Nombre = NombreFacp_txt.Text;
                string msj = P.InsertarFacp();
                if (msj == "1")
                {
                    LlenarDtgFacp();
                    LLenarFacpCB();
                    NombreFacp_txt.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo agregar Fire Alarm Control Panel(FACP)");
                }
            }
            else
            {
                MessageBox.Show("Nombre FACP es necesario");
            }
        }

        public void ActualizarFacp()
        {
            if (NombreFacp_txt.Text.Trim() != "")
            {
                P.ID_FACP = Convert.ToInt32(facp_dtg.CurrentRow.Cells[0].Value.ToString());
                P.Nombre = NombreFacp_txt.Text;
                string msj = P.ActualizarFacp();
                if (msj == "1")
                {
                    LlenarDtgFacp();
                    LLenarFacpCB();



                }
                else
                {
                    MessageBox.Show("No se pudo agregar Fire Alarm Control Panel(FACP)");
                }
                NombreFacp_txt.Text = "";
                facp_dtg.Enabled = true;
                AgregarFacp_btn.Image = Properties.Resources.save_32;
                AgregarFacp_btn.Text = "Agregar FACP";
                AgregarFacp_btn.BackColor = Color.FromArgb(72, 84, 96);

            }


            else
            {
                MessageBox.Show("Nombre FACP es necesario");
            }
        }

        public void BorrarFACP()
        {
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar este panel de control?\n Nota: Esta acción Elimina las zonas asociadas a este FACP.", "Borrar FACP", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                P.ID_FACP = Convert.ToInt32(facp_dtg.CurrentRow.Cells[0].Value.ToString());
                string msj = P.BorrarFACP();
                if (msj != "1")
                {
                    MessageBox.Show("No se pudo eliminar FACP");
                }
                else
                {
                    LLenarFacpCB();
                    LlenarDtgFacp();
                }
            }

        }

        #endregion


        #region EventosManuales

        private void Panel_Leave(object sender, EventArgs e)
        {
            Point locationOnForm = (sender as PictureBox).Location;
            Point controlLoc = workArea_panel.PointToScreen((sender as PictureBox).Location);
        }

        private void Panel_Hover(object sender, EventArgs e)
        {

            string tag = (sender as PictureBox).Tag.ToString(); // format --> tipo*id*identificador*tamaño*nombre*dispositivo*tipoDispositivo*figura

            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);
            toolTip1.SetToolTip((sender as PictureBox), "Nombre: " + namesList[4] + "\nIdentificador: " + namesList[2] + "\nTipo: " + namesList[5] + "\nCategoría: " + namesList[6]);
        }

        private void Panel_DoubleClick(object sender, EventArgs e)
        {

            string tag = (sender as PictureBox).Tag.ToString();
            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);

            Program.TagName = namesList[4];
            Program.SizeInPX = Convert.ToInt32(namesList[3]);
            IdDetectorAeditar = Convert.ToInt32(namesList[1]);
            Program.Identificador = namesList[2];
            Program.Gdispositivo = namesList[5];
            Program.GtipoDispositivo = namesList[6];
            Program.Gfigura = namesList[7];

            NameZoneForm form = new NameZoneForm();
            form.ShowDialog();
            if (Program.TagName != "")
            {
                (sender as PictureBox).Tag = namesList[0] + "*" + IdDetectorAeditar + "*" + Program.Identificador + "*" + Program.SizeInPX.ToString() + "*" + Program.TagName + "*" + Program.Gdispositivo + "*" + Program.GtipoDispositivo + "*" + Program.Gfigura;

                if (Program.Gfigura == "Círculo")
                {
                    (sender as PictureBox).Region = null;
                    (sender as PictureBox).Size = new Size(Program.SizeInPX, Program.SizeInPX);
                    var path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(0, 0, Program.SizeInPX, Program.SizeInPX);
                    (sender as PictureBox).Region = new Region(path);
                    (sender as PictureBox).Image = null;
                    (sender as PictureBox).Image = Properties.Resources.cuadroVerde;
                }
                else
                {
                    (sender as PictureBox).Region = null;
                    (sender as PictureBox).Size = new Size(Program.SizeInPX, Program.SizeInPX);
                    if (Program.Gfigura == "Letra P")
                    {
                        (sender as PictureBox).Image = null;
                        (sender as PictureBox).Image = Properties.Resources.transLetraPverde;
                    }
                    else
                    {
                        (sender as PictureBox).Image = null;
                        (sender as PictureBox).Image = Properties.Resources.cuadroVerde;
                    }

                }

            }


        }

        private void Panel_Click(object sender, MouseEventArgs e)
        {
            int idDetector = 0;

            string tag = (sender as PictureBox).Tag.ToString();
            string[] namesArray = tag.Split('*');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);

            idDetector = Convert.ToInt32(namesList[1]);

            string info = "";
            if (agregarZonas_btn.Text == "Guardar")
            {
                info = "Eliminar Detector " + "'" + namesList[4] + "' " + "?";
            }

            else
            {
                info = "Eliminar Detector " + "'" + namesList[4] + "' " + "? \nNota: Esta acción elimina directamente en la  Base De datos.";
            }

            if (e.Button == MouseButtons.Right)
            {
                DialogResult dialogResult = MessageBox.Show(info, "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (agregarZonas_btn.Text == "Guardar")
                    {
                        (sender as PictureBox).Dispose();
                    }

                    else
                    {
                        EliminarDetectorenBD(idEvento, idDetector, (sender as PictureBox));

                    }

                }

            }


            //MessageBox.Show( ((sender as PictureBox).Tag).ToString());


        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void agregarImg_btn_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = this.openFileDialog1.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {

                    file = openFileDialog1.FileName;
                    Image loadedImage = Image.FromFile(file);
                    pictureBox1.Image = loadedImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.SendToBack();

                    if (agregarZonas_btn.Text == "Guardar")
                    {
                        AgregarDetector_btn.Visible = true;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarDetector_btn_Click(object sender, EventArgs e)
        {
            Program.SizeInPX = 25;
            Program.TagName = "";
            Program.Identificador = "";
            Program.Gdispositivo = "";
            Program.GtipoDispositivo = "";
            Program.Gfigura = "";
            NameZoneForm form = new NameZoneForm();
            form.ShowDialog();
            if (Program.TagName != "")
            {
                if (Program.Gfigura == "Letra P")
                {
                    GenerarDetectorZona(200, 5, "NEW", Program.SizeInPX, Program.TagName, true, 0, Properties.Resources.transLetraPverde,
                        Program.Identificador, Program.Gdispositivo, Program.Gdispositivo, Program.Gfigura);

                }
                else
                {
                    GenerarDetectorZona(200, 5, "NEW", Program.SizeInPX, Program.TagName, true, 0, Properties.Resources.cuadroVerde,
                        Program.Identificador, Program.Gdispositivo, Program.Gdispositivo, Program.Gfigura);
                }

            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            ResetCamposGeneral();
        }

        private void AgregarFacp_btn_Click(object sender, EventArgs e)
        {
            if (AgregarFacp_btn.Text == "Agregar FACP")
            {
                RegistrarFacp();
            }
            else
            {
                ActualizarFacp();
            }
        }

        private void facp_dtg_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int idFacp = Convert.ToInt32(facp_dtg.CurrentRow.Cells[0].Value.ToString());
                facp_lbl.Text = "(" + facp_dtg.CurrentRow.Cells[1].Value.ToString() + ")";
                LlenarDtgZonas(idFacp);
            }
            catch
            {

            }
        }

        private void facp_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AgregarFacp_btn.Text = "Actualizar";
            AgregarFacp_btn.BackColor = Color.FromArgb(255, 168, 1);
            facp_dtg.Enabled = false;
            NombreFacp_txt.Text = facp_dtg.CurrentRow.Cells[1].Value.ToString();
        }

        private void verZona_btn_Click(object sender, EventArgs e)
        {
            if (verZona_btn.Text == "Ver")
            {
                CambiarEstadoControles(false, nombre_txt);
                CambiarEstadoControles(false, descripcion_txt);
                CambiarEstadoControles(false, estadoZona_chbox);
                CambiarEstadoControles(false, agregarImg_btn);
                CambiarEstadoControles(false, agregarZonas_btn);
                CambiarEstadoControles(false, editarZona_btn);
                CambiarEstadoControles(false, facp_cb);
                CambiarEstadoControles(false, Cancelar_btn);
                CambiarEstadoControles(false, NombreFacp_txt);
                CambiarEstadoControles(false, facp_dtg);
                CambiarEstadoControles(false, AgregarFacp_btn);



                AgregarZona_lbl.Text = "VER ZONAS";
                verZona_btn.BackColor = Color.Red;
                verZona_btn.Text = "Cancelar Ver";

                idEvento = Convert.ToInt32(zonas_dtg.CurrentRow.Cells[0].Value.ToString());
                nombre_txt.Text = (zonas_dtg.CurrentRow.Cells[1].Value.ToString());
                descripcion_txt.Text = (zonas_dtg.CurrentRow.Cells[2].Value.ToString());
                estadoZona_chbox.Checked = Convert.ToBoolean(zonas_dtg.CurrentRow.Cells[3].Value);
                facp_cb.Text = (zonas_dtg.CurrentRow.Cells[4].Value.ToString());
                CargarImagenDesdeBd(idEvento);
                ObtenerDetectoresZona(idEvento, false);
            }

            else
            {
                pictureBox1.Image = Properties.Resources.add_image_256;
                EliminarTodosDetectores("TODOS");
                verZona_btn.BackColor = Color.FromArgb(72, 84, 96);
                verZona_btn.Text = "Ver";
                AgregarZona_lbl.Text = "AGREGAR ZONAS";
                CambiarEstadoControles(true, nombre_txt);
                CambiarEstadoControles(true, descripcion_txt);
                CambiarEstadoControles(true, estadoZona_chbox);
                CambiarEstadoControles(true, agregarImg_btn);
                CambiarEstadoControles(true, agregarZonas_btn);
                CambiarEstadoControles(true, editarZona_btn);
                CambiarEstadoControles(true, facp_cb);
                CambiarEstadoControles(true, Cancelar_btn);
                CambiarEstadoControles(true, NombreFacp_txt);
                CambiarEstadoControles(true, facp_dtg);
                CambiarEstadoControles(true, AgregarFacp_btn);


                idEvento = 0;
                nombre_txt.Text = "";
                descripcion_txt.Text = "";
                estadoZona_chbox.Checked = true;

            }
        }

        private void editarZona_btn_Click(object sender, EventArgs e)
        {
            if (editarZona_btn.Text == "Editar")
            {
                agregarZonas_btn.Text = "Actualizar";
                agregarZonas_btn.BackColor = Color.FromArgb(255, 168, 1);
                AgregarZona_lbl.Text = "EDITAR ZONAS";
                editarZona_btn.BackColor = Color.Red;
                editarZona_btn.Text = "Cancelar Editar";
                AgregarDetector_btn.Visible = true;
                CambiarEstadoControles(false, Cancelar_btn);
                CambiarEstadoControles(false, NombreFacp_txt);
                CambiarEstadoControles(false, facp_dtg);
                CambiarEstadoControles(false, AgregarFacp_btn);


                idEvento = Convert.ToInt32(zonas_dtg.CurrentRow.Cells[0].Value.ToString());
                nombre_txt.Text = (zonas_dtg.CurrentRow.Cells[1].Value.ToString());
                descripcion_txt.Text = (zonas_dtg.CurrentRow.Cells[2].Value.ToString());
                estadoZona_chbox.Checked = Convert.ToBoolean(zonas_dtg.CurrentRow.Cells[3].Value);
                facp_cb.Text = (zonas_dtg.CurrentRow.Cells[4].Value.ToString());

                CargarImagenDesdeBd(idEvento);
                ObtenerDetectoresZona(idEvento, true);
            }

            else
            {
                pictureBox1.Image = Properties.Resources.add_image_256;
                EliminarTodosDetectores("TODOS");
                editarZona_btn.BackColor = Color.FromArgb(72, 84, 96);
                editarZona_btn.Text = "Editar";
                AgregarZona_lbl.Text = "AGREGAR ZONAS";

                agregarZonas_btn.Text = "Guardar";
                agregarZonas_btn.BackColor = Color.FromArgb(11, 232, 129);


                idEvento = 0;
                nombre_txt.Text = "";
                descripcion_txt.Text = "";
                estadoZona_chbox.Checked = true;
                AgregarDetector_btn.Visible = false;
                CambiarEstadoControles(true, Cancelar_btn);
                CambiarEstadoControles(true, NombreFacp_txt);
                CambiarEstadoControles(true, facp_dtg);
                CambiarEstadoControles(true, AgregarFacp_btn);

            }
        }

        private void ConfigurarZonasForm_Load(object sender, EventArgs e)
        {

            leftAreaPanel.Location = new Point(
            this.ClientSize.Width / 2 - leftAreaPanel.Size.Width / 2,
            this.ClientSize.Height / 2 - leftAreaPanel.Size.Height / 2);
            leftAreaPanel.Anchor = AnchorStyles.None;
            LlenarDtgFacp();
            LLenarFacpCB();
        }

        private void agregarZonas_btn_Click(object sender, EventArgs e)
        {
            if (agregarZonas_btn.Text == "Actualizar")
            {
                ActualizarZonas();
                //LlenarDtgZonas();
            }
            else
            {
                RegistrarZonas();
                //LlenarDtgZonas();
            }
            LlenarDtgFacp();
        }
    }
}
