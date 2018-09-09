﻿namespace FireSystemMonitor.Formularios
{
    partial class ConfigurarZonasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurarZonasForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NombreZona_lbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.leftAreaPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.facp_cb = new System.Windows.Forms.ComboBox();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.agregarImg_btn = new System.Windows.Forms.Button();
            this.estadoZona_chbox = new System.Windows.Forms.CheckBox();
            this.descripcion_txt = new System.Windows.Forms.TextBox();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agregarZonas_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarZona_lbl = new System.Windows.Forms.Label();
            this.EliminarFacp_btn = new System.Windows.Forms.Button();
            this.facp_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarFacp_btn = new System.Windows.Forms.Button();
            this.NombreFacp_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.facp_dtg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.editarZona_btn = new System.Windows.Forms.Button();
            this.zonas_dtg = new System.Windows.Forms.DataGridView();
            this.verZona_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.workArea_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AgregarDetector_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.leftAreaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facp_dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonas_dtg)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.workArea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.NombreZona_lbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 24);
            this.panel3.TabIndex = 52;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::FireSystemMonitor.Properties.Resources.maximize_window_16;
            this.button1.Location = new System.Drawing.Point(943, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 34;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::FireSystemMonitor.Properties.Resources.minimize_window_16;
            this.button3.Location = new System.Drawing.Point(911, -2);
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
            this.button2.Image = global::FireSystemMonitor.Properties.Resources.close_window_16;
            this.button2.Location = new System.Drawing.Point(973, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 32;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NombreZona_lbl
            // 
            this.NombreZona_lbl.AutoSize = true;
            this.NombreZona_lbl.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreZona_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.NombreZona_lbl.Location = new System.Drawing.Point(3, 3);
            this.NombreZona_lbl.Name = "NombreZona_lbl";
            this.NombreZona_lbl.Size = new System.Drawing.Size(244, 22);
            this.NombreZona_lbl.TabIndex = 26;
            this.NombreZona_lbl.Text = "ZONE CONFIGURATION";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 742);
            this.tabControl1.TabIndex = 53;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.leftAreaPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(999, 716);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DETAILS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // leftAreaPanel
            // 
            this.leftAreaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.leftAreaPanel.Controls.Add(this.label3);
            this.leftAreaPanel.Controls.Add(this.facp_cb);
            this.leftAreaPanel.Controls.Add(this.Cancelar_btn);
            this.leftAreaPanel.Controls.Add(this.agregarImg_btn);
            this.leftAreaPanel.Controls.Add(this.estadoZona_chbox);
            this.leftAreaPanel.Controls.Add(this.descripcion_txt);
            this.leftAreaPanel.Controls.Add(this.nombre_txt);
            this.leftAreaPanel.Controls.Add(this.label2);
            this.leftAreaPanel.Controls.Add(this.agregarZonas_btn);
            this.leftAreaPanel.Controls.Add(this.label4);
            this.leftAreaPanel.Controls.Add(this.AgregarZona_lbl);
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
            this.leftAreaPanel.Controls.Add(this.shapeContainer1);
            this.leftAreaPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.leftAreaPanel.Location = new System.Drawing.Point(85, 6);
            this.leftAreaPanel.Name = "leftAreaPanel";
            this.leftAreaPanel.Size = new System.Drawing.Size(848, 676);
            this.leftAreaPanel.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 88;
            this.label3.Text = "FACP:";
            // 
            // facp_cb
            // 
            this.facp_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facp_cb.FormattingEnabled = true;
            this.facp_cb.Location = new System.Drawing.Point(146, 435);
            this.facp_cb.Name = "facp_cb";
            this.facp_cb.Size = new System.Drawing.Size(262, 21);
            this.facp_cb.TabIndex = 87;
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.Cancelar_btn.FlatAppearance.BorderSize = 0;
            this.Cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelar_btn.Image = global::FireSystemMonitor.Properties.Resources.trash_9_32;
            this.Cancelar_btn.Location = new System.Drawing.Point(515, 574);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(117, 77);
            this.Cancelar_btn.TabIndex = 86;
            this.Cancelar_btn.Text = "Cancel";
            this.Cancelar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancelar_btn.UseVisualStyleBackColor = false;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // agregarImg_btn
            // 
            this.agregarImg_btn.BackColor = System.Drawing.Color.Transparent;
            this.agregarImg_btn.FlatAppearance.BorderSize = 0;
            this.agregarImg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarImg_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarImg_btn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.agregarImg_btn.Image = global::FireSystemMonitor.Properties.Resources.png_32;
            this.agregarImg_btn.Location = new System.Drawing.Point(414, 468);
            this.agregarImg_btn.Name = "agregarImg_btn";
            this.agregarImg_btn.Size = new System.Drawing.Size(48, 41);
            this.agregarImg_btn.TabIndex = 85;
            this.agregarImg_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.agregarImg_btn.UseVisualStyleBackColor = false;
            this.agregarImg_btn.Click += new System.EventHandler(this.agregarImg_btn_Click);
            // 
            // estadoZona_chbox
            // 
            this.estadoZona_chbox.AutoSize = true;
            this.estadoZona_chbox.Checked = true;
            this.estadoZona_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estadoZona_chbox.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoZona_chbox.Location = new System.Drawing.Point(52, 521);
            this.estadoZona_chbox.Name = "estadoZona_chbox";
            this.estadoZona_chbox.Size = new System.Drawing.Size(70, 18);
            this.estadoZona_chbox.TabIndex = 84;
            this.estadoZona_chbox.Text = "Enable";
            this.estadoZona_chbox.UseVisualStyleBackColor = true;
            // 
            // descripcion_txt
            // 
            this.descripcion_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_txt.Location = new System.Drawing.Point(146, 487);
            this.descripcion_txt.MaxLength = 100;
            this.descripcion_txt.Name = "descripcion_txt";
            this.descripcion_txt.Size = new System.Drawing.Size(262, 22);
            this.descripcion_txt.TabIndex = 80;
            // 
            // nombre_txt
            // 
            this.nombre_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_txt.Location = new System.Drawing.Point(146, 462);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(262, 22);
            this.nombre_txt.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 14);
            this.label2.TabIndex = 81;
            this.label2.Text = "Description:";
            // 
            // agregarZonas_btn
            // 
            this.agregarZonas_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.agregarZonas_btn.FlatAppearance.BorderSize = 0;
            this.agregarZonas_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarZonas_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarZonas_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregarZonas_btn.Image = global::FireSystemMonitor.Properties.Resources.save_32;
            this.agregarZonas_btn.Location = new System.Drawing.Point(185, 574);
            this.agregarZonas_btn.Name = "agregarZonas_btn";
            this.agregarZonas_btn.Size = new System.Drawing.Size(117, 77);
            this.agregarZonas_btn.TabIndex = 83;
            this.agregarZonas_btn.Text = "Save";
            this.agregarZonas_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregarZonas_btn.UseVisualStyleBackColor = false;
            this.agregarZonas_btn.Click += new System.EventHandler(this.agregarZonas_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 14);
            this.label4.TabIndex = 82;
            this.label4.Text = "Zone name:";
            // 
            // AgregarZona_lbl
            // 
            this.AgregarZona_lbl.AutoSize = true;
            this.AgregarZona_lbl.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarZona_lbl.Location = new System.Drawing.Point(39, 378);
            this.AgregarZona_lbl.Name = "AgregarZona_lbl";
            this.AgregarZona_lbl.Size = new System.Drawing.Size(133, 27);
            this.AgregarZona_lbl.TabIndex = 78;
            this.AgregarZona_lbl.Text = "ADD ZONES";
            // 
            // EliminarFacp_btn
            // 
            this.EliminarFacp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.EliminarFacp_btn.FlatAppearance.BorderSize = 0;
            this.EliminarFacp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarFacp_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarFacp_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EliminarFacp_btn.Image = global::FireSystemMonitor.Properties.Resources.trash_9_32;
            this.EliminarFacp_btn.Location = new System.Drawing.Point(185, 279);
            this.EliminarFacp_btn.Name = "EliminarFacp_btn";
            this.EliminarFacp_btn.Size = new System.Drawing.Size(130, 61);
            this.EliminarFacp_btn.TabIndex = 76;
            this.EliminarFacp_btn.Text = "Delete FACP";
            this.EliminarFacp_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarFacp_btn.UseVisualStyleBackColor = false;
            this.EliminarFacp_btn.Click += new System.EventHandler(this.EliminarFacp_btn_Click);
            // 
            // facp_lbl
            // 
            this.facp_lbl.AutoSize = true;
            this.facp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facp_lbl.Location = new System.Drawing.Point(541, 25);
            this.facp_lbl.Name = "facp_lbl";
            this.facp_lbl.Size = new System.Drawing.Size(0, 12);
            this.facp_lbl.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 12);
            this.label6.TabIndex = 74;
            this.label6.Text = "Double Click to Edit";
            // 
            // AgregarFacp_btn
            // 
            this.AgregarFacp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.AgregarFacp_btn.FlatAppearance.BorderSize = 0;
            this.AgregarFacp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarFacp_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarFacp_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgregarFacp_btn.Image = global::FireSystemMonitor.Properties.Resources.save_32;
            this.AgregarFacp_btn.Location = new System.Drawing.Point(49, 279);
            this.AgregarFacp_btn.Name = "AgregarFacp_btn";
            this.AgregarFacp_btn.Size = new System.Drawing.Size(130, 61);
            this.AgregarFacp_btn.TabIndex = 73;
            this.AgregarFacp_btn.Text = "Add FACP";
            this.AgregarFacp_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgregarFacp_btn.UseVisualStyleBackColor = false;
            this.AgregarFacp_btn.Click += new System.EventHandler(this.AgregarFacp_btn_Click);
            // 
            // NombreFacp_txt
            // 
            this.NombreFacp_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreFacp_txt.Location = new System.Drawing.Point(49, 236);
            this.NombreFacp_txt.Name = "NombreFacp_txt";
            this.NombreFacp_txt.Size = new System.Drawing.Size(266, 22);
            this.NombreFacp_txt.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 72;
            this.label5.Text = "Name:";
            // 
            // facp_dtg
            // 
            this.facp_dtg.AllowUserToAddRows = false;
            this.facp_dtg.AllowUserToDeleteRows = false;
            this.facp_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facp_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facp_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.facp_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facp_dtg.Location = new System.Drawing.Point(49, 39);
            this.facp_dtg.MultiSelect = false;
            this.facp_dtg.Name = "facp_dtg";
            this.facp_dtg.ReadOnly = true;
            this.facp_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.facp_dtg.Size = new System.Drawing.Size(266, 166);
            this.facp_dtg.TabIndex = 67;
            this.facp_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facp_dtg_CellDoubleClick);
            this.facp_dtg.SelectionChanged += new System.EventHandler(this.facp_dtg_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 66;
            this.label1.Text = "FACP";
            // 
            // editarZona_btn
            // 
            this.editarZona_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.editarZona_btn.FlatAppearance.BorderSize = 0;
            this.editarZona_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarZona_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarZona_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editarZona_btn.Image = global::FireSystemMonitor.Properties.Resources.edit_2_32;
            this.editarZona_btn.Location = new System.Drawing.Point(666, 279);
            this.editarZona_btn.Name = "editarZona_btn";
            this.editarZona_btn.Size = new System.Drawing.Size(130, 61);
            this.editarZona_btn.TabIndex = 65;
            this.editarZona_btn.Text = "Edit Map";
            this.editarZona_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editarZona_btn.UseVisualStyleBackColor = false;
            this.editarZona_btn.Click += new System.EventHandler(this.editarZona_btn_Click);
            // 
            // zonas_dtg
            // 
            this.zonas_dtg.AllowUserToAddRows = false;
            this.zonas_dtg.AllowUserToDeleteRows = false;
            this.zonas_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.zonas_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zonas_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.zonas_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zonas_dtg.Location = new System.Drawing.Point(464, 39);
            this.zonas_dtg.MultiSelect = false;
            this.zonas_dtg.Name = "zonas_dtg";
            this.zonas_dtg.ReadOnly = true;
            this.zonas_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zonas_dtg.Size = new System.Drawing.Size(332, 219);
            this.zonas_dtg.TabIndex = 63;
            // 
            // verZona_btn
            // 
            this.verZona_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.verZona_btn.FlatAppearance.BorderSize = 0;
            this.verZona_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verZona_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verZona_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verZona_btn.Image = global::FireSystemMonitor.Properties.Resources.eye_3_32;
            this.verZona_btn.Location = new System.Drawing.Point(464, 279);
            this.verZona_btn.Name = "verZona_btn";
            this.verZona_btn.Size = new System.Drawing.Size(130, 61);
            this.verZona_btn.TabIndex = 62;
            this.verZona_btn.Text = "See Map";
            this.verZona_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.verZona_btn.UseVisualStyleBackColor = false;
            this.verZona_btn.Click += new System.EventHandler(this.verZona_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(459, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 27);
            this.label9.TabIndex = 61;
            this.label9.Text = "ZONES";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(848, 676);
            this.shapeContainer1.TabIndex = 89;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 33;
            this.lineShape2.X2 = 807;
            this.lineShape2.Y1 = 363;
            this.lineShape2.Y2 = 363;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 397;
            this.lineShape1.X2 = 397;
            this.lineShape1.Y1 = 39;
            this.lineShape1.Y2 = 347;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.workArea_panel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(999, 716);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MAP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // workArea_panel
            // 
            this.workArea_panel.Controls.Add(this.pictureBox1);
            this.workArea_panel.Controls.Add(this.panel2);
            this.workArea_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workArea_panel.Location = new System.Drawing.Point(3, 3);
            this.workArea_panel.Name = "workArea_panel";
            this.workArea_panel.Size = new System.Drawing.Size(993, 710);
            this.workArea_panel.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FireSystemMonitor.Properties.Resources.add_image_256;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 668);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.AgregarDetector_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 668);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 42);
            this.panel2.TabIndex = 77;
            // 
            // AgregarDetector_btn
            // 
            this.AgregarDetector_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarDetector_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.AgregarDetector_btn.FlatAppearance.BorderSize = 0;
            this.AgregarDetector_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarDetector_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarDetector_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgregarDetector_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarDetector_btn.Location = new System.Drawing.Point(871, 3);
            this.AgregarDetector_btn.Name = "AgregarDetector_btn";
            this.AgregarDetector_btn.Size = new System.Drawing.Size(117, 36);
            this.AgregarDetector_btn.TabIndex = 78;
            this.AgregarDetector_btn.Text = "Add Device";
            this.AgregarDetector_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgregarDetector_btn.UseVisualStyleBackColor = false;
            this.AgregarDetector_btn.Visible = false;
            this.AgregarDetector_btn.Click += new System.EventHandler(this.AgregarDetector_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ConfigurarZonasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 766);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigurarZonasForm";
            this.Text = "ZONE CONFIGURATION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConfigurarZonasForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.leftAreaPanel.ResumeLayout(false);
            this.leftAreaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facp_dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonas_dtg)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.workArea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NombreZona_lbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel leftAreaPanel;
        private System.Windows.Forms.Button EliminarFacp_btn;
        private System.Windows.Forms.Label facp_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarFacp_btn;
        private System.Windows.Forms.TextBox NombreFacp_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView facp_dtg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editarZona_btn;
        private System.Windows.Forms.DataGridView zonas_dtg;
        private System.Windows.Forms.Button verZona_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox facp_cb;
        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.Button agregarImg_btn;
        private System.Windows.Forms.CheckBox estadoZona_chbox;
        private System.Windows.Forms.TextBox descripcion_txt;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button agregarZonas_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AgregarZona_lbl;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel workArea_panel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AgregarDetector_btn;
    }
}