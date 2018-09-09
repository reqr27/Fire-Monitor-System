namespace DataReceiver.Formularios
{
    partial class ConfiguracionPuertoSerialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracionPuertoSerialForm));
            this.label1 = new System.Windows.Forms.Label();
            this.identificador_txt = new System.Windows.Forms.TextBox();
            this.SerialPortName_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.baudRate_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databit_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paridad_cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stopbit_cb = new System.Windows.Forms.ComboBox();
            this.newLine_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.serialPort_dtg = new System.Windows.Forms.DataGridView();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.UsarConfig_btn = new System.Windows.Forms.Button();
            this.Config_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serialPort_dtg)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifier:";
            // 
            // identificador_txt
            // 
            this.identificador_txt.Location = new System.Drawing.Point(100, 100);
            this.identificador_txt.Name = "identificador_txt";
            this.identificador_txt.Size = new System.Drawing.Size(140, 20);
            this.identificador_txt.TabIndex = 1;
            // 
            // SerialPortName_cb
            // 
            this.SerialPortName_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerialPortName_cb.FormattingEnabled = true;
            this.SerialPortName_cb.Location = new System.Drawing.Point(100, 123);
            this.SerialPortName_cb.Name = "SerialPortName_cb";
            this.SerialPortName_cb.Size = new System.Drawing.Size(140, 21);
            this.SerialPortName_cb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Baud Rate:";
            // 
            // baudRate_cb
            // 
            this.baudRate_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRate_cb.FormattingEnabled = true;
            this.baudRate_cb.Items.AddRange(new object[] {
            "110 ",
            "300",
            "600 ",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudRate_cb.Location = new System.Drawing.Point(100, 147);
            this.baudRate_cb.Name = "baudRate_cb";
            this.baudRate_cb.Size = new System.Drawing.Size(140, 21);
            this.baudRate_cb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Databits:";
            // 
            // databit_cb
            // 
            this.databit_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databit_cb.FormattingEnabled = true;
            this.databit_cb.Items.AddRange(new object[] {
            "7",
            "8"});
            this.databit_cb.Location = new System.Drawing.Point(100, 172);
            this.databit_cb.Name = "databit_cb";
            this.databit_cb.Size = new System.Drawing.Size(140, 21);
            this.databit_cb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity:";
            // 
            // paridad_cb
            // 
            this.paridad_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paridad_cb.FormattingEnabled = true;
            this.paridad_cb.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.paridad_cb.Location = new System.Drawing.Point(100, 196);
            this.paridad_cb.Name = "paridad_cb";
            this.paridad_cb.Size = new System.Drawing.Size(140, 21);
            this.paridad_cb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "StopBits:";
            // 
            // stopbit_cb
            // 
            this.stopbit_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbit_cb.FormattingEnabled = true;
            this.stopbit_cb.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbit_cb.Location = new System.Drawing.Point(100, 220);
            this.stopbit_cb.Name = "stopbit_cb";
            this.stopbit_cb.Size = new System.Drawing.Size(140, 21);
            this.stopbit_cb.TabIndex = 10;
            // 
            // newLine_txt
            // 
            this.newLine_txt.Location = new System.Drawing.Point(100, 244);
            this.newLine_txt.Name = "newLine_txt";
            this.newLine_txt.Size = new System.Drawing.Size(140, 20);
            this.newLine_txt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "New Line:";
            // 
            // serialPort_dtg
            // 
            this.serialPort_dtg.AllowUserToAddRows = false;
            this.serialPort_dtg.AllowUserToDeleteRows = false;
            this.serialPort_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.serialPort_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.serialPort_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serialPort_dtg.Location = new System.Drawing.Point(344, 76);
            this.serialPort_dtg.MultiSelect = false;
            this.serialPort_dtg.Name = "serialPort_dtg";
            this.serialPort_dtg.ReadOnly = true;
            this.serialPort_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serialPort_dtg.Size = new System.Drawing.Size(414, 236);
            this.serialPort_dtg.TabIndex = 64;
            this.serialPort_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serialPort_dtg_CellDoubleClick);
            // 
            // guardar_btn
            // 
            this.guardar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(159)))));
            this.guardar_btn.FlatAppearance.BorderSize = 0;
            this.guardar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar_btn.Location = new System.Drawing.Point(40, 318);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(224, 44);
            this.guardar_btn.TabIndex = 65;
            this.guardar_btn.Text = "Save and Set Configuration";
            this.guardar_btn.UseVisualStyleBackColor = false;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // UsarConfig_btn
            // 
            this.UsarConfig_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(159)))));
            this.UsarConfig_btn.FlatAppearance.BorderSize = 0;
            this.UsarConfig_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsarConfig_btn.Location = new System.Drawing.Point(418, 318);
            this.UsarConfig_btn.Name = "UsarConfig_btn";
            this.UsarConfig_btn.Size = new System.Drawing.Size(277, 44);
            this.UsarConfig_btn.TabIndex = 66;
            this.UsarConfig_btn.Text = "Set Configuration Selected as Default\r\n";
            this.UsarConfig_btn.UseVisualStyleBackColor = false;
            this.UsarConfig_btn.Click += new System.EventHandler(this.UsarConfig_btn_Click);
            // 
            // Config_lbl
            // 
            this.Config_lbl.AutoSize = true;
            this.Config_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config_lbl.Location = new System.Drawing.Point(14, 68);
            this.Config_lbl.Name = "Config_lbl";
            this.Config_lbl.Size = new System.Drawing.Size(35, 13);
            this.Config_lbl.TabIndex = 68;
            this.Config_lbl.Text = "label3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Selected Configuration:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(674, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 12);
            this.label9.TabIndex = 75;
            this.label9.Text = "Double Click to edit";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 35);
            this.panel3.TabIndex = 100;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::DataReceiver.Properties.Resources.minimize_window_24;
            this.button3.Location = new System.Drawing.Point(699, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 26);
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
            this.button2.Image = global::DataReceiver.Properties.Resources.cancel_24;
            this.button2.Location = new System.Drawing.Point(736, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 26);
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
            this.label11.Size = new System.Drawing.Size(361, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "SERIAL PORT CONFIGURATION";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(770, 374);
            this.shapeContainer1.TabIndex = 101;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Silver;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 302;
            this.lineShape1.X2 = 302;
            this.lineShape1.Y1 = 52;
            this.lineShape1.Y2 = 337;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(340, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 102;
            this.label10.Text = "Configuration List";
            // 
            // ConfiguracionPuertoSerialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 374);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Config_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UsarConfig_btn);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.serialPort_dtg);
            this.Controls.Add(this.newLine_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stopbit_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paridad_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.databit_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baudRate_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SerialPortName_cb);
            this.Controls.Add(this.identificador_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfiguracionPuertoSerialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERIAL PORT CONFIGURATION";
            this.Load += new System.EventHandler(this.ConfiguracionPuertoSerialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serialPort_dtg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox identificador_txt;
        private System.Windows.Forms.ComboBox SerialPortName_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox baudRate_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox databit_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox paridad_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stopbit_cb;
        private System.Windows.Forms.TextBox newLine_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView serialPort_dtg;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.Button UsarConfig_btn;
        private System.Windows.Forms.Label Config_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label10;
    }
}