namespace FireSystemMonitor
{
    partial class AgregarZonasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarZonasForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.verZona_btn = new System.Windows.Forms.Button();
            this.zonas_dtg = new System.Windows.Forms.DataGridView();
            this.editarZona_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.facp_dtg = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreFacp_txt = new System.Windows.Forms.TextBox();
            this.AgregarFacp_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.facp_lbl = new System.Windows.Forms.Label();
            this.EliminarFacp_btn = new System.Windows.Forms.Button();
            this.leftAreaPanel = new System.Windows.Forms.Panel();
            this.AgregarZona_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.agregarZonas_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.descripcion_txt = new System.Windows.Forms.TextBox();
            this.AgregarDetector_btn = new System.Windows.Forms.Button();
            this.estadoZona_chbox = new System.Windows.Forms.CheckBox();
            this.agregarImg_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.facp_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.workArea_panel = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonas_dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facp_dtg)).BeginInit();
            this.leftAreaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.workArea_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1260, 47);
            this.panel3.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::FireSystemMonitor.Properties.Resources.minimize_window_24;
            this.button3.Location = new System.Drawing.Point(1194, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 33;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::FireSystemMonitor.Properties.Resources.cancel_24;
            this.button2.Location = new System.Drawing.Point(1226, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 32;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label11.Location = new System.Drawing.Point(11, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "CONFIGURACIÓN";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 27);
            this.label9.TabIndex = 61;
            this.label9.Text = "ZONAS";
            // 
            // verZona_btn
            // 
            this.verZona_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.verZona_btn.FlatAppearance.BorderSize = 0;
            this.verZona_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verZona_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verZona_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verZona_btn.Image = global::FireSystemMonitor.Properties.Resources.eye_3_32;
            this.verZona_btn.Location = new System.Drawing.Point(8, 609);
            this.verZona_btn.Name = "verZona_btn";
            this.verZona_btn.Size = new System.Drawing.Size(130, 61);
            this.verZona_btn.TabIndex = 62;
            this.verZona_btn.Text = "Ver";
            this.verZona_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.verZona_btn.UseVisualStyleBackColor = false;
            this.verZona_btn.Click += new System.EventHandler(this.verZona_btn_Click);
            // 
            // zonas_dtg
            // 
            this.zonas_dtg.AllowUserToAddRows = false;
            this.zonas_dtg.AllowUserToDeleteRows = false;
            this.zonas_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.zonas_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zonas_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.zonas_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zonas_dtg.Location = new System.Drawing.Point(8, 413);
            this.zonas_dtg.MultiSelect = false;
            this.zonas_dtg.Name = "zonas_dtg";
            this.zonas_dtg.ReadOnly = true;
            this.zonas_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zonas_dtg.Size = new System.Drawing.Size(266, 190);
            this.zonas_dtg.TabIndex = 63;
            // 
            // editarZona_btn
            // 
            this.editarZona_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.editarZona_btn.FlatAppearance.BorderSize = 0;
            this.editarZona_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarZona_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarZona_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editarZona_btn.Image = global::FireSystemMonitor.Properties.Resources.edit_2_32;
            this.editarZona_btn.Location = new System.Drawing.Point(144, 609);
            this.editarZona_btn.Name = "editarZona_btn";
            this.editarZona_btn.Size = new System.Drawing.Size(130, 61);
            this.editarZona_btn.TabIndex = 65;
            this.editarZona_btn.Text = "Editar";
            this.editarZona_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editarZona_btn.UseVisualStyleBackColor = false;
            this.editarZona_btn.Click += new System.EventHandler(this.editarZona_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 66;
            this.label1.Text = "FACP";
            // 
            // facp_dtg
            // 
            this.facp_dtg.AllowUserToAddRows = false;
            this.facp_dtg.AllowUserToDeleteRows = false;
            this.facp_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facp_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facp_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.facp_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facp_dtg.Location = new System.Drawing.Point(8, 39);
            this.facp_dtg.MultiSelect = false;
            this.facp_dtg.Name = "facp_dtg";
            this.facp_dtg.ReadOnly = true;
            this.facp_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.facp_dtg.Size = new System.Drawing.Size(266, 166);
            this.facp_dtg.TabIndex = 67;
            this.facp_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facp_dtg_CellDoubleClick);
            this.facp_dtg.SelectionChanged += new System.EventHandler(this.facp_dtg_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 72;
            this.label5.Text = "Nombre:";
            // 
            // NombreFacp_txt
            // 
            this.NombreFacp_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreFacp_txt.Location = new System.Drawing.Point(8, 236);
            this.NombreFacp_txt.Name = "NombreFacp_txt";
            this.NombreFacp_txt.Size = new System.Drawing.Size(266, 22);
            this.NombreFacp_txt.TabIndex = 71;
            // 
            // AgregarFacp_btn
            // 
            this.AgregarFacp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.AgregarFacp_btn.FlatAppearance.BorderSize = 0;
            this.AgregarFacp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarFacp_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarFacp_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgregarFacp_btn.Image = global::FireSystemMonitor.Properties.Resources.save_32;
            this.AgregarFacp_btn.Location = new System.Drawing.Point(8, 279);
            this.AgregarFacp_btn.Name = "AgregarFacp_btn";
            this.AgregarFacp_btn.Size = new System.Drawing.Size(130, 61);
            this.AgregarFacp_btn.TabIndex = 73;
            this.AgregarFacp_btn.Text = "Agregar FACP";
            this.AgregarFacp_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgregarFacp_btn.UseVisualStyleBackColor = false;
            this.AgregarFacp_btn.Click += new System.EventHandler(this.AgregarFacp_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 12);
            this.label6.TabIndex = 74;
            this.label6.Text = "Doble Click Para Editar";
            // 
            // facp_lbl
            // 
            this.facp_lbl.AutoSize = true;
            this.facp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facp_lbl.Location = new System.Drawing.Point(85, 394);
            this.facp_lbl.Name = "facp_lbl";
            this.facp_lbl.Size = new System.Drawing.Size(0, 12);
            this.facp_lbl.TabIndex = 75;
            // 
            // EliminarFacp_btn
            // 
            this.EliminarFacp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.EliminarFacp_btn.FlatAppearance.BorderSize = 0;
            this.EliminarFacp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarFacp_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarFacp_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EliminarFacp_btn.Image = global::FireSystemMonitor.Properties.Resources.trash_9_32;
            this.EliminarFacp_btn.Location = new System.Drawing.Point(144, 279);
            this.EliminarFacp_btn.Name = "EliminarFacp_btn";
            this.EliminarFacp_btn.Size = new System.Drawing.Size(130, 61);
            this.EliminarFacp_btn.TabIndex = 76;
            this.EliminarFacp_btn.Text = "Eliminar FACP";
            this.EliminarFacp_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarFacp_btn.UseVisualStyleBackColor = false;
            this.EliminarFacp_btn.Click += new System.EventHandler(this.EliminarFacp_btn_Click);
            // 
            // leftAreaPanel
            // 
            this.leftAreaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.leftAreaPanel.Controls.Add(this.EliminarFacp_btn);
            this.leftAreaPanel.Controls.Add(this.facp_lbl);
            this.leftAreaPanel.Controls.Add(this.label6);
            this.leftAreaPanel.Controls.Add(this.AgregarFacp_btn);
            this.leftAreaPanel.Controls.Add(this.NombreFacp_txt);
            this.leftAreaPanel.Controls.Add(this.label5);
            this.leftAreaPanel.Controls.Add(this.facp_dtg);
            this.leftAreaPanel.Controls.Add(this.label1);
            this.leftAreaPanel.Controls.Add(this.editarZona_btn);
            this.leftAreaPanel.Controls.Add(this.zonas_dtg);
            this.leftAreaPanel.Controls.Add(this.verZona_btn);
            this.leftAreaPanel.Controls.Add(this.label9);
            this.leftAreaPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftAreaPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.leftAreaPanel.Location = new System.Drawing.Point(0, 47);
            this.leftAreaPanel.Name = "leftAreaPanel";
            this.leftAreaPanel.Size = new System.Drawing.Size(284, 676);
            this.leftAreaPanel.TabIndex = 50;
            // 
            // AgregarZona_lbl
            // 
            this.AgregarZona_lbl.AutoSize = true;
            this.AgregarZona_lbl.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarZona_lbl.Location = new System.Drawing.Point(11, 3);
            this.AgregarZona_lbl.Name = "AgregarZona_lbl";
            this.AgregarZona_lbl.Size = new System.Drawing.Size(187, 27);
            this.AgregarZona_lbl.TabIndex = 66;
            this.AgregarZona_lbl.Text = "AGREGAR ZONAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::FireSystemMonitor.Properties.Resources.add_image_256;
            this.pictureBox1.Location = new System.Drawing.Point(16, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(948, 545);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "\"Pic\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 70;
            this.label4.Text = "Nombre:";
            // 
            // agregarZonas_btn
            // 
            this.agregarZonas_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.agregarZonas_btn.FlatAppearance.BorderSize = 0;
            this.agregarZonas_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarZonas_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarZonas_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregarZonas_btn.Image = global::FireSystemMonitor.Properties.Resources.save_32;
            this.agregarZonas_btn.Location = new System.Drawing.Point(724, 28);
            this.agregarZonas_btn.Name = "agregarZonas_btn";
            this.agregarZonas_btn.Size = new System.Drawing.Size(117, 77);
            this.agregarZonas_btn.TabIndex = 71;
            this.agregarZonas_btn.Text = "Guardar";
            this.agregarZonas_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregarZonas_btn.UseVisualStyleBackColor = false;
            this.agregarZonas_btn.Click += new System.EventHandler(this.agregarZonas_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 69;
            this.label2.Text = "Descripción:";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_txt.Location = new System.Drawing.Point(102, 69);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(262, 22);
            this.nombre_txt.TabIndex = 67;
            // 
            // descripcion_txt
            // 
            this.descripcion_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_txt.Location = new System.Drawing.Point(102, 94);
            this.descripcion_txt.MaxLength = 100;
            this.descripcion_txt.Name = "descripcion_txt";
            this.descripcion_txt.Size = new System.Drawing.Size(262, 22);
            this.descripcion_txt.TabIndex = 68;
            // 
            // AgregarDetector_btn
            // 
            this.AgregarDetector_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.AgregarDetector_btn.FlatAppearance.BorderSize = 0;
            this.AgregarDetector_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarDetector_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarDetector_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgregarDetector_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarDetector_btn.Location = new System.Drawing.Point(476, 74);
            this.AgregarDetector_btn.Name = "AgregarDetector_btn";
            this.AgregarDetector_btn.Size = new System.Drawing.Size(117, 42);
            this.AgregarDetector_btn.TabIndex = 63;
            this.AgregarDetector_btn.Text = "Añadir Detector";
            this.AgregarDetector_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarDetector_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgregarDetector_btn.UseVisualStyleBackColor = false;
            this.AgregarDetector_btn.Visible = false;
            this.AgregarDetector_btn.Click += new System.EventHandler(this.AgregarDetector_btn_Click);
            // 
            // estadoZona_chbox
            // 
            this.estadoZona_chbox.AutoSize = true;
            this.estadoZona_chbox.Checked = true;
            this.estadoZona_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estadoZona_chbox.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoZona_chbox.Location = new System.Drawing.Point(370, 96);
            this.estadoZona_chbox.Name = "estadoZona_chbox";
            this.estadoZona_chbox.Size = new System.Drawing.Size(84, 18);
            this.estadoZona_chbox.TabIndex = 73;
            this.estadoZona_chbox.Text = "Habilitar";
            this.estadoZona_chbox.UseVisualStyleBackColor = true;
            // 
            // agregarImg_btn
            // 
            this.agregarImg_btn.BackColor = System.Drawing.Color.Transparent;
            this.agregarImg_btn.FlatAppearance.BorderSize = 0;
            this.agregarImg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarImg_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarImg_btn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.agregarImg_btn.Image = global::FireSystemMonitor.Properties.Resources.png_32;
            this.agregarImg_btn.Location = new System.Drawing.Point(382, 36);
            this.agregarImg_btn.Name = "agregarImg_btn";
            this.agregarImg_btn.Size = new System.Drawing.Size(48, 41);
            this.agregarImg_btn.TabIndex = 74;
            this.agregarImg_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.agregarImg_btn.UseVisualStyleBackColor = false;
            this.agregarImg_btn.Click += new System.EventHandler(this.agregarImg_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.Cancelar_btn.FlatAppearance.BorderSize = 0;
            this.Cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelar_btn.Image = global::FireSystemMonitor.Properties.Resources.trash_9_32;
            this.Cancelar_btn.Location = new System.Drawing.Point(847, 28);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(117, 77);
            this.Cancelar_btn.TabIndex = 75;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancelar_btn.UseVisualStyleBackColor = false;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // facp_cb
            // 
            this.facp_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facp_cb.FormattingEnabled = true;
            this.facp_cb.Location = new System.Drawing.Point(102, 42);
            this.facp_cb.Name = "facp_cb";
            this.facp_cb.Size = new System.Drawing.Size(262, 21);
            this.facp_cb.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 77;
            this.label3.Text = "FACP:";
            // 
            // workArea_panel
            // 
            this.workArea_panel.Controls.Add(this.label3);
            this.workArea_panel.Controls.Add(this.facp_cb);
            this.workArea_panel.Controls.Add(this.Cancelar_btn);
            this.workArea_panel.Controls.Add(this.agregarImg_btn);
            this.workArea_panel.Controls.Add(this.estadoZona_chbox);
            this.workArea_panel.Controls.Add(this.AgregarDetector_btn);
            this.workArea_panel.Controls.Add(this.descripcion_txt);
            this.workArea_panel.Controls.Add(this.nombre_txt);
            this.workArea_panel.Controls.Add(this.label2);
            this.workArea_panel.Controls.Add(this.agregarZonas_btn);
            this.workArea_panel.Controls.Add(this.label4);
            this.workArea_panel.Controls.Add(this.pictureBox1);
            this.workArea_panel.Controls.Add(this.AgregarZona_lbl);
            this.workArea_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workArea_panel.Location = new System.Drawing.Point(284, 47);
            this.workArea_panel.Name = "workArea_panel";
            this.workArea_panel.Size = new System.Drawing.Size(976, 676);
            this.workArea_panel.TabIndex = 51;
            // 
            // AgregarZonasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 723);
            this.Controls.Add(this.workArea_panel);
            this.Controls.Add(this.leftAreaPanel);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarZonasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURACION ZONAS";
            this.Load += new System.EventHandler(this.AgregarZonasForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonas_dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facp_dtg)).EndInit();
            this.leftAreaPanel.ResumeLayout(false);
            this.leftAreaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.workArea_panel.ResumeLayout(false);
            this.workArea_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button verZona_btn;
        private System.Windows.Forms.DataGridView zonas_dtg;
        private System.Windows.Forms.Button editarZona_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView facp_dtg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombreFacp_txt;
        private System.Windows.Forms.Button AgregarFacp_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label facp_lbl;
        private System.Windows.Forms.Button EliminarFacp_btn;
        private System.Windows.Forms.Panel leftAreaPanel;
        private System.Windows.Forms.Label AgregarZona_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button agregarZonas_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.TextBox descripcion_txt;
        private System.Windows.Forms.Button AgregarDetector_btn;
        private System.Windows.Forms.CheckBox estadoZona_chbox;
        private System.Windows.Forms.Button agregarImg_btn;
        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.ComboBox facp_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel workArea_panel;
    }
}

