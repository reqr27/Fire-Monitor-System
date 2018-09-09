namespace DataReceiver
{
    partial class DataReceiver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataReceiver));
            this.estatus_txt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Config_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.facp_cb = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ProcessDataTimer = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.info_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Email_timer = new System.Windows.Forms.Timer(this.components);
            this.msjActivado_lbl = new System.Windows.Forms.Label();
            this.activar_btn = new System.Windows.Forms.Button();
            this.limpiarEstados_btn = new System.Windows.Forms.Button();
            this.Config_btn = new System.Windows.Forms.Button();
            this.checkSoftware_timer = new System.Windows.Forms.Timer(this.components);
            this.configDescription_lbl = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // estatus_txt
            // 
            this.estatus_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estatus_txt.Location = new System.Drawing.Point(190, 77);
            this.estatus_txt.Name = "estatus_txt";
            this.estatus_txt.ReadOnly = true;
            this.estatus_txt.Size = new System.Drawing.Size(210, 22);
            this.estatus_txt.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.textBox1.Location = new System.Drawing.Point(12, 137);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(677, 301);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Serial Port Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selected Configuration:";
            // 
            // Config_lbl
            // 
            this.Config_lbl.AutoSize = true;
            this.Config_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Config_lbl.Location = new System.Drawing.Point(195, 104);
            this.Config_lbl.Name = "Config_lbl";
            this.Config_lbl.Size = new System.Drawing.Size(45, 16);
            this.Config_lbl.TabIndex = 9;
            this.Config_lbl.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "FACP:";
            // 
            // facp_cb
            // 
            this.facp_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facp_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facp_cb.FormattingEnabled = true;
            this.facp_cb.Location = new System.Drawing.Point(69, 47);
            this.facp_cb.Name = "facp_cb";
            this.facp_cb.Size = new System.Drawing.Size(331, 24);
            this.facp_cb.TabIndex = 77;
            this.facp_cb.DropDown += new System.EventHandler(this.facp_cb_DropDown);
            this.facp_cb.SelectionChangeCommitted += new System.EventHandler(this.facp_cb_SelectionChangeCommitted);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ProcessDataTimer
            // 
            this.ProcessDataTimer.Interval = 1500;
            this.ProcessDataTimer.Tick += new System.EventHandler(this.ProcessDataTimer_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.Controls.Add(this.info_btn);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 35);
            this.panel3.TabIndex = 99;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
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
            this.info_btn.Image = global::DataReceiver.Properties.Resources.info_24;
            this.info_btn.Location = new System.Drawing.Point(657, -1);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(47, 36);
            this.info_btn.TabIndex = 86;
            this.info_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.info_btn.UseVisualStyleBackColor = false;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::DataReceiver.Properties.Resources.minimize_window_24;
            this.button3.Location = new System.Drawing.Point(643, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 33;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::DataReceiver.Properties.Resources.cancel_24;
            this.button2.Location = new System.Drawing.Point(675, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 32;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "FACP DATA RECEIVER";
            // 
            // Email_timer
            // 
            this.Email_timer.Interval = 3000;
            this.Email_timer.Tick += new System.EventHandler(this.Email_timer_Tick);
            // 
            // msjActivado_lbl
            // 
            this.msjActivado_lbl.AutoSize = true;
            this.msjActivado_lbl.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msjActivado_lbl.ForeColor = System.Drawing.Color.Red;
            this.msjActivado_lbl.Location = new System.Drawing.Point(9, 444);
            this.msjActivado_lbl.Name = "msjActivado_lbl";
            this.msjActivado_lbl.Size = new System.Drawing.Size(358, 24);
            this.msjActivado_lbl.TabIndex = 100;
            this.msjActivado_lbl.Text = "SOFTWARE IS NOT ACTIVATED";
            // 
            // activar_btn
            // 
            this.activar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activar_btn.BackColor = System.Drawing.Color.Transparent;
            this.activar_btn.FlatAppearance.BorderSize = 0;
            this.activar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.activar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.activar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.activar_btn.Image = global::DataReceiver.Properties.Resources.key_2_48;
            this.activar_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.activar_btn.Location = new System.Drawing.Point(435, 47);
            this.activar_btn.Name = "activar_btn";
            this.activar_btn.Size = new System.Drawing.Size(121, 89);
            this.activar_btn.TabIndex = 101;
            this.activar_btn.Text = "Activate";
            this.activar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.activar_btn.UseVisualStyleBackColor = false;
            this.activar_btn.Click += new System.EventHandler(this.activar_btn_Click);
            // 
            // limpiarEstados_btn
            // 
            this.limpiarEstados_btn.FlatAppearance.BorderSize = 0;
            this.limpiarEstados_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarEstados_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarEstados_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.limpiarEstados_btn.Image = global::DataReceiver.Properties.Resources.trash_9_32;
            this.limpiarEstados_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.limpiarEstados_btn.Location = new System.Drawing.Point(562, 444);
            this.limpiarEstados_btn.Name = "limpiarEstados_btn";
            this.limpiarEstados_btn.Size = new System.Drawing.Size(127, 59);
            this.limpiarEstados_btn.TabIndex = 7;
            this.limpiarEstados_btn.Text = "Clear Screen";
            this.limpiarEstados_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.limpiarEstados_btn.UseVisualStyleBackColor = true;
            this.limpiarEstados_btn.Click += new System.EventHandler(this.limpiarEstados_btn_Click);
            // 
            // Config_btn
            // 
            this.Config_btn.FlatAppearance.BorderSize = 0;
            this.Config_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Config_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Config_btn.Image = global::DataReceiver.Properties.Resources.settings_22_48;
            this.Config_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Config_btn.Location = new System.Drawing.Point(562, 47);
            this.Config_btn.Name = "Config_btn";
            this.Config_btn.Size = new System.Drawing.Size(127, 89);
            this.Config_btn.TabIndex = 1;
            this.Config_btn.Text = "Serial Port Configuration";
            this.Config_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Config_btn.UseVisualStyleBackColor = true;
            this.Config_btn.Click += new System.EventHandler(this.Config_btn_Click);
            // 
            // checkSoftware_timer
            // 
            this.checkSoftware_timer.Interval = 60000;
            this.checkSoftware_timer.Tick += new System.EventHandler(this.checkSoftware_timer_Tick);
            // 
            // configDescription_lbl
            // 
            this.configDescription_lbl.AutoSize = true;
            this.configDescription_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configDescription_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.configDescription_lbl.Location = new System.Drawing.Point(197, 120);
            this.configDescription_lbl.Name = "configDescription_lbl";
            this.configDescription_lbl.Size = new System.Drawing.Size(29, 12);
            this.configDescription_lbl.TabIndex = 102;
            this.configDescription_lbl.Text = "label4";
            // 
            // DataReceiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(704, 515);
            this.Controls.Add(this.configDescription_lbl);
            this.Controls.Add(this.activar_btn);
            this.Controls.Add(this.msjActivado_lbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.facp_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Config_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limpiarEstados_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.estatus_txt);
            this.Controls.Add(this.Config_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataReceiver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fire Control Data Receiver";
            this.Load += new System.EventHandler(this.DataReceiver_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Config_btn;
        private System.Windows.Forms.TextBox estatus_txt;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button limpiarEstados_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Config_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox facp_cb;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer ProcessDataTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer Email_timer;
        private System.Windows.Forms.Label msjActivado_lbl;
        private System.Windows.Forms.Button activar_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Timer checkSoftware_timer;
        private System.Windows.Forms.Label configDescription_lbl;
    }
}

