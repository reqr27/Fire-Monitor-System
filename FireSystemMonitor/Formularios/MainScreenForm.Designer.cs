namespace FireSystemMonitor.Formularios
{
    partial class MainScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.msjActivado_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.activar_btn = new System.Windows.Forms.Button();
            this.historial_btn = new System.Windows.Forms.Button();
            this.onlineStatus_lbl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.facp_cb = new System.Windows.Forms.ComboBox();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.Settings_btn = new System.Windows.Forms.Button();
            this.ConfigMail_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RefrescarTimer = new System.Windows.Forms.Timer(this.components);
            this.EstadoZona_timer = new System.Windows.Forms.Timer(this.components);
            this.RefrescarWorker = new System.ComponentModel.BackgroundWorker();
            this.EstadoZonaWorker = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.msjActivado_lbl);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 126);
            this.panel3.TabIndex = 50;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::FireSystemMonitor.Properties.Resources.maximize_window_24;
            this.button1.Location = new System.Drawing.Point(946, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 36;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msjActivado_lbl
            // 
            this.msjActivado_lbl.AutoSize = true;
            this.msjActivado_lbl.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msjActivado_lbl.ForeColor = System.Drawing.Color.Red;
            this.msjActivado_lbl.Location = new System.Drawing.Point(311, 8);
            this.msjActivado_lbl.Name = "msjActivado_lbl";
            this.msjActivado_lbl.Size = new System.Drawing.Size(402, 24);
            this.msjActivado_lbl.TabIndex = 35;
            this.msjActivado_lbl.Text = "SOFTWARE NO HA SIDO ACTIVADO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.info_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.activar_btn);
            this.panel1.Controls.Add(this.historial_btn);
            this.panel1.Controls.Add(this.onlineStatus_lbl);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.facp_cb);
            this.panel1.Controls.Add(this.Refresh_btn);
            this.panel1.Controls.Add(this.Settings_btn);
            this.panel1.Controls.Add(this.ConfigMail_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 84);
            this.panel1.TabIndex = 34;
            // 
            // info_btn
            // 
            this.info_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.info_btn.BackColor = System.Drawing.Color.Transparent;
            this.info_btn.FlatAppearance.BorderSize = 0;
            this.info_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.info_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.info_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.info_btn.Image = global::FireSystemMonitor.Properties.Resources.info_48;
            this.info_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.info_btn.Location = new System.Drawing.Point(910, 4);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(102, 79);
            this.info_btn.TabIndex = 85;
            this.info_btn.Text = "Info";
            this.info_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.info_btn.UseVisualStyleBackColor = false;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Conexión:";
            // 
            // activar_btn
            // 
            this.activar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activar_btn.BackColor = System.Drawing.Color.Transparent;
            this.activar_btn.FlatAppearance.BorderSize = 0;
            this.activar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.activar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.activar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.activar_btn.Image = global::FireSystemMonitor.Properties.Resources.key_2_48;
            this.activar_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.activar_btn.Location = new System.Drawing.Point(374, 3);
            this.activar_btn.Name = "activar_btn";
            this.activar_btn.Size = new System.Drawing.Size(102, 79);
            this.activar_btn.TabIndex = 83;
            this.activar_btn.Text = "Activar";
            this.activar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.activar_btn.UseVisualStyleBackColor = false;
            this.activar_btn.Click += new System.EventHandler(this.activar_btn_Click);
            // 
            // historial_btn
            // 
            this.historial_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.historial_btn.BackColor = System.Drawing.Color.Transparent;
            this.historial_btn.FlatAppearance.BorderSize = 0;
            this.historial_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.historial_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.historial_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historial_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.historial_btn.Image = global::FireSystemMonitor.Properties.Resources.data_backup_48;
            this.historial_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.historial_btn.Location = new System.Drawing.Point(482, 3);
            this.historial_btn.Name = "historial_btn";
            this.historial_btn.Size = new System.Drawing.Size(102, 79);
            this.historial_btn.TabIndex = 82;
            this.historial_btn.Text = "Historial";
            this.historial_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.historial_btn.UseVisualStyleBackColor = false;
            this.historial_btn.Click += new System.EventHandler(this.historial_btn_Click);
            // 
            // onlineStatus_lbl
            // 
            this.onlineStatus_lbl.AutoSize = true;
            this.onlineStatus_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineStatus_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.onlineStatus_lbl.Location = new System.Drawing.Point(83, 23);
            this.onlineStatus_lbl.Name = "onlineStatus_lbl";
            this.onlineStatus_lbl.Size = new System.Drawing.Size(45, 16);
            this.onlineStatus_lbl.TabIndex = 81;
            this.onlineStatus_lbl.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(271, 64);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 13);
            this.linkLabel1.TabIndex = 80;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver Estado FACP";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 79;
            this.label3.Text = "FACP:";
            // 
            // facp_cb
            // 
            this.facp_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facp_cb.FormattingEnabled = true;
            this.facp_cb.Location = new System.Drawing.Point(86, 57);
            this.facp_cb.Name = "facp_cb";
            this.facp_cb.Size = new System.Drawing.Size(181, 21);
            this.facp_cb.TabIndex = 78;
            this.facp_cb.DropDown += new System.EventHandler(this.facp_cb_DropDown);
            this.facp_cb.SelectionChangeCommitted += new System.EventHandler(this.facp_cb_SelectionChangeCommitted);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh_btn.BackColor = System.Drawing.Color.Transparent;
            this.Refresh_btn.FlatAppearance.BorderSize = 0;
            this.Refresh_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Refresh_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Refresh_btn.Image = global::FireSystemMonitor.Properties.Resources.available_updates_48;
            this.Refresh_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Refresh_btn.Location = new System.Drawing.Point(590, 3);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(102, 79);
            this.Refresh_btn.TabIndex = 2;
            this.Refresh_btn.Text = "Actualizar";
            this.Refresh_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Settings_btn
            // 
            this.Settings_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings_btn.BackColor = System.Drawing.Color.Transparent;
            this.Settings_btn.FlatAppearance.BorderSize = 0;
            this.Settings_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Settings_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.Settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Settings_btn.Image = global::FireSystemMonitor.Properties.Resources.settings_22_48;
            this.Settings_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Settings_btn.Location = new System.Drawing.Point(806, 3);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(102, 79);
            this.Settings_btn.TabIndex = 1;
            this.Settings_btn.Text = "Settings";
            this.Settings_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Settings_btn.UseVisualStyleBackColor = false;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // ConfigMail_btn
            // 
            this.ConfigMail_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigMail_btn.BackColor = System.Drawing.Color.Transparent;
            this.ConfigMail_btn.FlatAppearance.BorderSize = 0;
            this.ConfigMail_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConfigMail_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.ConfigMail_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigMail_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigMail_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfigMail_btn.Image = global::FireSystemMonitor.Properties.Resources.email_5_48;
            this.ConfigMail_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConfigMail_btn.Location = new System.Drawing.Point(698, 3);
            this.ConfigMail_btn.Name = "ConfigMail_btn";
            this.ConfigMail_btn.Size = new System.Drawing.Size(102, 79);
            this.ConfigMail_btn.TabIndex = 0;
            this.ConfigMail_btn.Text = "Config. Email";
            this.ConfigMail_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConfigMail_btn.UseVisualStyleBackColor = false;
            this.ConfigMail_btn.Click += new System.EventHandler(this.ConfigMail_btn_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::FireSystemMonitor.Properties.Resources.minimize_window_24;
            this.button3.Location = new System.Drawing.Point(910, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 33;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::FireSystemMonitor.Properties.Resources.cancel_24;
            this.button2.Location = new System.Drawing.Point(978, 6);
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
            this.label11.Size = new System.Drawing.Size(235, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "Fire System Monitor";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1012, 421);
            this.flowLayoutPanel1.TabIndex = 51;
            // 
            // RefrescarTimer
            // 
            this.RefrescarTimer.Interval = 300000;
            this.RefrescarTimer.Tick += new System.EventHandler(this.RefrescarTimer_Tick);
            // 
            // EstadoZona_timer
            // 
            this.EstadoZona_timer.Interval = 3000;
            this.EstadoZona_timer.Tick += new System.EventHandler(this.EstadoZona_timer_Tick);
            // 
            // RefrescarWorker
            // 
            this.RefrescarWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RefrescarWorker_DoWork);
            this.RefrescarWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RefrescarWorker_RunWorkerCompleted);
            // 
            // EstadoZonaWorker
            // 
            this.EstadoZonaWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.EstadoZonaWorker_DoWork);
            this.EstadoZonaWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EstadoZonaWorker_RunWorkerCompleted);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 547);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIRE SYSTEM MONITOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            this.Resize += new System.EventHandler(this.MainScreenForm_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConfigMail_btn;
        private System.Windows.Forms.Button Settings_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Timer RefrescarTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox facp_cb;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label onlineStatus_lbl;
        private System.Windows.Forms.Button historial_btn;
        private System.Windows.Forms.Label msjActivado_lbl;
        private System.Windows.Forms.Button activar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Timer EstadoZona_timer;
        private System.ComponentModel.BackgroundWorker RefrescarWorker;
        private System.ComponentModel.BackgroundWorker EstadoZonaWorker;
        private System.Windows.Forms.Button button1;
    }
}