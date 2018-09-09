namespace FireSystemMonitor.Classes
{
    partial class MonitoreoZonaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoreoZonaForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NombreZona_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TimerLeerStatusDetector = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lastFacpStatus_lbl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.next_btn = new System.Windows.Forms.Button();
            this.pausePlay_btn = new System.Windows.Forms.Button();
            this.previous_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.border_timer = new System.Windows.Forms.Timer(this.components);
            this.LeerStatusWorker = new System.ComponentModel.BackgroundWorker();
            this.BorderColorWorker = new System.ComponentModel.BackgroundWorker();
            this.SlideShowTimer = new System.Windows.Forms.Timer(this.components);
            this.evac_lbl = new System.Windows.Forms.Label();
            this.Evac_timer = new System.Windows.Forms.Timer(this.components);
            this.Evac_Worker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.NombreZona_lbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1146, 47);
            this.panel3.TabIndex = 51;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::FireSystemMonitor.Properties.Resources.maximize_window_24;
            this.button1.Location = new System.Drawing.Point(1076, 7);
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
            this.button3.Image = global::FireSystemMonitor.Properties.Resources.minimize_window_24;
            this.button3.Location = new System.Drawing.Point(1040, 7);
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
            this.button2.Location = new System.Drawing.Point(1108, 7);
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
            this.NombreZona_lbl.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreZona_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.NombreZona_lbl.Location = new System.Drawing.Point(11, 9);
            this.NombreZona_lbl.Name = "NombreZona_lbl";
            this.NombreZona_lbl.Size = new System.Drawing.Size(235, 24);
            this.NombreZona_lbl.TabIndex = 26;
            this.NombreZona_lbl.Text = "Fire System Monitor";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "MISSING";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "WARNING";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ALARM";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "OK";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "LEGEND:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            // 
            // TimerLeerStatusDetector
            // 
            this.TimerLeerStatusDetector.Interval = 5000;
            this.TimerLeerStatusDetector.Tick += new System.EventHandler(this.TimerLeerStatusDetector_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lastFacpStatus_lbl);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.next_btn);
            this.panel2.Controls.Add(this.pausePlay_btn);
            this.panel2.Controls.Add(this.previous_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 42);
            this.panel2.TabIndex = 76;
            // 
            // lastFacpStatus_lbl
            // 
            this.lastFacpStatus_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastFacpStatus_lbl.Location = new System.Drawing.Point(439, 19);
            this.lastFacpStatus_lbl.Name = "lastFacpStatus_lbl";
            this.lastFacpStatus_lbl.ReadOnly = true;
            this.lastFacpStatus_lbl.Size = new System.Drawing.Size(388, 20);
            this.lastFacpStatus_lbl.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "ULTIMO ESTADO:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(846, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 81;
            this.label7.Text = "Intervalo(Segs):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(970, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 80;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // next_btn
            // 
            this.next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.next_btn.Enabled = false;
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Image = global::FireSystemMonitor.Properties.Resources.next_24;
            this.next_btn.Location = new System.Drawing.Point(1108, 9);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(26, 26);
            this.next_btn.TabIndex = 79;
            this.next_btn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // pausePlay_btn
            // 
            this.pausePlay_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pausePlay_btn.FlatAppearance.BorderSize = 0;
            this.pausePlay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pausePlay_btn.Image = global::FireSystemMonitor.Properties.Resources.pause_24;
            this.pausePlay_btn.Location = new System.Drawing.Point(1072, 9);
            this.pausePlay_btn.Name = "pausePlay_btn";
            this.pausePlay_btn.Size = new System.Drawing.Size(26, 26);
            this.pausePlay_btn.TabIndex = 78;
            this.pausePlay_btn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.pausePlay_btn.UseVisualStyleBackColor = true;
            this.pausePlay_btn.Click += new System.EventHandler(this.pausePlay_btn_Click);
            // 
            // previous_btn
            // 
            this.previous_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previous_btn.Enabled = false;
            this.previous_btn.FlatAppearance.BorderSize = 0;
            this.previous_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous_btn.Image = global::FireSystemMonitor.Properties.Resources.previous_24;
            this.previous_btn.Location = new System.Drawing.Point(1040, 9);
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Size = new System.Drawing.Size(26, 26);
            this.previous_btn.TabIndex = 76;
            this.previous_btn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.previous_btn.UseVisualStyleBackColor = true;
            this.previous_btn.Click += new System.EventHandler(this.previous_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.Image = global::FireSystemMonitor.Properties.Resources.DetectorOK;
            this.pictureBox2.Location = new System.Drawing.Point(68, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox5.Image = global::FireSystemMonitor.Properties.Resources.DetectorFalta;
            this.pictureBox5.Location = new System.Drawing.Point(329, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 25);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.Image = global::FireSystemMonitor.Properties.Resources.DetectorFuego;
            this.pictureBox3.Location = new System.Drawing.Point(131, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.Image = global::FireSystemMonitor.Properties.Resources.DetectorWarning;
            this.pictureBox4.Location = new System.Drawing.Point(227, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 25);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // border_timer
            // 
            this.border_timer.Interval = 1100;
            this.border_timer.Tick += new System.EventHandler(this.border_timer_Tick);
            // 
            // LeerStatusWorker
            // 
            this.LeerStatusWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LeerStatusWorker_DoWork);
            this.LeerStatusWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LeerStatusWorker_RunWorkerCompleted);
            // 
            // BorderColorWorker
            // 
            this.BorderColorWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BorderColorWorker_DoWork);
            this.BorderColorWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BorderColorWorker_RunWorkerCompleted);
            // 
            // SlideShowTimer
            // 
            this.SlideShowTimer.Tick += new System.EventHandler(this.SlideShowTimer_Tick);
            // 
            // evac_lbl
            // 
            this.evac_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.evac_lbl.BackColor = System.Drawing.Color.Transparent;
            this.evac_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evac_lbl.ForeColor = System.Drawing.Color.Red;
            this.evac_lbl.Location = new System.Drawing.Point(0, 215);
            this.evac_lbl.Name = "evac_lbl";
            this.evac_lbl.Size = new System.Drawing.Size(1146, 134);
            this.evac_lbl.TabIndex = 77;
            this.evac_lbl.Text = "EVACUATE";
            this.evac_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.evac_lbl.Visible = false;
            // 
            // Evac_timer
            // 
            this.Evac_timer.Interval = 600;
            this.Evac_timer.Tick += new System.EventHandler(this.Evac_timer_Tick);
            // 
            // Evac_Worker
            // 
            this.Evac_Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Evac_Worker_DoWork);
            this.Evac_Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Evac_Worker_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 557);
            this.panel1.TabIndex = 78;
            // 
            // MonitoreoZonaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 646);
            this.Controls.Add(this.evac_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonitoreoZonaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MONITOREO ZONA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MonitoreoZonaForm_Load);
            this.Resize += new System.EventHandler(this.MonitoreoZonaForm_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NombreZona_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer TimerLeerStatusDetector;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer border_timer;
        private System.Windows.Forms.Button previous_btn;
        private System.Windows.Forms.Button pausePlay_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.ComponentModel.BackgroundWorker LeerStatusWorker;
        private System.ComponentModel.BackgroundWorker BorderColorWorker;
        private System.Windows.Forms.Timer SlideShowTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label evac_lbl;
        private System.Windows.Forms.Timer Evac_timer;
        private System.ComponentModel.BackgroundWorker Evac_Worker;
        private System.Windows.Forms.TextBox lastFacpStatus_lbl;
        private System.Windows.Forms.Panel panel1;
    }
}