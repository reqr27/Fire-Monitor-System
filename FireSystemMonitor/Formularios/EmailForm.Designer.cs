namespace FireSystemMonitor.Formularios
{
    partial class EmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailForm));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.conexion_chbox = new System.Windows.Forms.CheckBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.warning_chbox = new System.Windows.Forms.CheckBox();
            this.alarm_chbox = new System.Windows.Forms.CheckBox();
            this.agregarEmail_btn = new System.Windows.Forms.Button();
            this.Eliminar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailRemitente_txt = new System.Windows.Forms.TextBox();
            this.host_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.email_dtg = new System.Windows.Forms.DataGridView();
            this.desde_dtp = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_dtg)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(708, 485);
            this.shapeContainer1.TabIndex = 70;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 355;
            this.lineShape1.X2 = 355;
            this.lineShape1.Y1 = 60;
            this.lineShape1.Y2 = 465;
            // 
            // conexion_chbox
            // 
            this.conexion_chbox.AutoSize = true;
            this.conexion_chbox.Checked = true;
            this.conexion_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.conexion_chbox.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conexion_chbox.Location = new System.Drawing.Point(12, 150);
            this.conexion_chbox.Name = "conexion_chbox";
            this.conexion_chbox.Size = new System.Drawing.Size(89, 18);
            this.conexion_chbox.TabIndex = 79;
            this.conexion_chbox.Text = "Conexión";
            this.conexion_chbox.UseVisualStyleBackColor = true;
            this.conexion_chbox.Visible = false;
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(108, 118);
            this.email_txt.MaxLength = 100;
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(212, 22);
            this.email_txt.TabIndex = 76;
            // 
            // nombre_txt
            // 
            this.nombre_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_txt.Location = new System.Drawing.Point(108, 93);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(212, 22);
            this.nombre_txt.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 77;
            this.label2.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 78;
            this.label4.Text = "Name:";
            // 
            // warning_chbox
            // 
            this.warning_chbox.AutoSize = true;
            this.warning_chbox.Checked = true;
            this.warning_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.warning_chbox.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_chbox.Location = new System.Drawing.Point(119, 150);
            this.warning_chbox.Name = "warning_chbox";
            this.warning_chbox.Size = new System.Drawing.Size(82, 18);
            this.warning_chbox.TabIndex = 80;
            this.warning_chbox.Text = "Warning";
            this.warning_chbox.UseVisualStyleBackColor = true;
            this.warning_chbox.Visible = false;
            // 
            // alarm_chbox
            // 
            this.alarm_chbox.AutoSize = true;
            this.alarm_chbox.Checked = true;
            this.alarm_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alarm_chbox.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_chbox.Location = new System.Drawing.Point(227, 150);
            this.alarm_chbox.Name = "alarm_chbox";
            this.alarm_chbox.Size = new System.Drawing.Size(72, 18);
            this.alarm_chbox.TabIndex = 81;
            this.alarm_chbox.Text = "Alarma";
            this.alarm_chbox.UseVisualStyleBackColor = true;
            this.alarm_chbox.Visible = false;
            // 
            // agregarEmail_btn
            // 
            this.agregarEmail_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.agregarEmail_btn.FlatAppearance.BorderSize = 0;
            this.agregarEmail_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarEmail_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarEmail_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregarEmail_btn.Image = global::FireSystemMonitor.Properties.Resources.save_32;
            this.agregarEmail_btn.Location = new System.Drawing.Point(12, 174);
            this.agregarEmail_btn.Name = "agregarEmail_btn";
            this.agregarEmail_btn.Size = new System.Drawing.Size(144, 54);
            this.agregarEmail_btn.TabIndex = 82;
            this.agregarEmail_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregarEmail_btn.UseVisualStyleBackColor = false;
            this.agregarEmail_btn.Click += new System.EventHandler(this.agregarEmail_btn_Click);
            // 
            // Eliminar_btn
            // 
            this.Eliminar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.Eliminar_btn.FlatAppearance.BorderSize = 0;
            this.Eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Eliminar_btn.Image = global::FireSystemMonitor.Properties.Resources.trash_9_32;
            this.Eliminar_btn.Location = new System.Drawing.Point(194, 174);
            this.Eliminar_btn.Name = "Eliminar_btn";
            this.Eliminar_btn.Size = new System.Drawing.Size(141, 53);
            this.Eliminar_btn.TabIndex = 83;
            this.Eliminar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminar_btn.UseVisualStyleBackColor = false;
            this.Eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 84;
            this.label1.Text = "Add Recipents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 14);
            this.label3.TabIndex = 85;
            this.label3.Text = "Sender Configuration";
            // 
            // emailRemitente_txt
            // 
            this.emailRemitente_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRemitente_txt.Location = new System.Drawing.Point(451, 216);
            this.emailRemitente_txt.MaxLength = 100;
            this.emailRemitente_txt.Name = "emailRemitente_txt";
            this.emailRemitente_txt.Size = new System.Drawing.Size(212, 22);
            this.emailRemitente_txt.TabIndex = 87;
            // 
            // host_txt
            // 
            this.host_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.host_txt.Location = new System.Drawing.Point(451, 164);
            this.host_txt.Name = "host_txt";
            this.host_txt.Size = new System.Drawing.Size(212, 22);
            this.host_txt.TabIndex = 86;
            this.host_txt.Text = "smtp.gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 88;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 89;
            this.label6.Text = "Host:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(385, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 14);
            this.label7.TabIndex = 90;
            this.label7.Text = "Port:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(451, 118);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown1.TabIndex = 91;
            this.numericUpDown1.Value = new decimal(new int[] {
            587,
            0,
            0,
            0});
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.Location = new System.Drawing.Point(463, 269);
            this.pass_txt.MaxLength = 100;
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(200, 22);
            this.pass_txt.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 14);
            this.label8.TabIndex = 93;
            this.label8.Text = "Password:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::FireSystemMonitor.Properties.Resources.save_32;
            this.button1.Location = new System.Drawing.Point(388, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 58);
            this.button1.TabIndex = 94;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // email_dtg
            // 
            this.email_dtg.AllowUserToAddRows = false;
            this.email_dtg.AllowUserToDeleteRows = false;
            this.email_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.email_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.email_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.email_dtg.Location = new System.Drawing.Point(12, 234);
            this.email_dtg.Name = "email_dtg";
            this.email_dtg.ReadOnly = true;
            this.email_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.email_dtg.Size = new System.Drawing.Size(323, 239);
            this.email_dtg.TabIndex = 95;
            // 
            // desde_dtp
            // 
            this.desde_dtp.CustomFormat = "hh:mm tt";
            this.desde_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desde_dtp.Location = new System.Drawing.Point(491, 319);
            this.desde_dtp.Name = "desde_dtp";
            this.desde_dtp.Size = new System.Drawing.Size(95, 20);
            this.desde_dtp.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 14);
            this.label9.TabIndex = 97;
            this.label9.Text = "Daily Email:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 35);
            this.panel3.TabIndex = 98;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::FireSystemMonitor.Properties.Resources.minimize_window_24;
            this.button3.Location = new System.Drawing.Point(647, 3);
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
            this.button2.Location = new System.Drawing.Point(679, 4);
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
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "MAIL CONFIGURATION";
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(708, 485);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.desde_dtp);
            this.Controls.Add(this.email_dtg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailRemitente_txt);
            this.Controls.Add(this.host_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminar_btn);
            this.Controls.Add(this.agregarEmail_btn);
            this.Controls.Add(this.alarm_chbox);
            this.Controls.Add(this.warning_chbox);
            this.Controls.Add(this.conexion_chbox);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIL CONFIGURATION";
            this.Load += new System.EventHandler(this.EmailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_dtg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.CheckBox conexion_chbox;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox warning_chbox;
        private System.Windows.Forms.CheckBox alarm_chbox;
        private System.Windows.Forms.Button agregarEmail_btn;
        private System.Windows.Forms.Button Eliminar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailRemitente_txt;
        private System.Windows.Forms.TextBox host_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView email_dtg;
        private System.Windows.Forms.DateTimePicker desde_dtp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
    }
}