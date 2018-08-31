namespace FireSystemMonitor.Formularios
{
    partial class SuperUserLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperUserLoginForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salir_btn = new System.Windows.Forms.Button();
            this.entrar_btn = new System.Windows.Forms.Button();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Usuario_txt = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tipoUsuario_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FireSystemMonitor.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(21, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FireSystemMonitor.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(21, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "SUPER USER LOGIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(-12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "___________________________________________";
            // 
            // salir_btn
            // 
            this.salir_btn.BackColor = System.Drawing.SystemColors.Info;
            this.salir_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir_btn.FlatAppearance.BorderSize = 2;
            this.salir_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.salir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.salir_btn.Image = global::FireSystemMonitor.Properties.Resources.exit;
            this.salir_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.salir_btn.Location = new System.Drawing.Point(172, 188);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(72, 63);
            this.salir_btn.TabIndex = 13;
            this.salir_btn.Text = "SALIR";
            this.salir_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salir_btn.UseVisualStyleBackColor = false;
            this.salir_btn.Click += new System.EventHandler(this.salir_btn_Click);
            // 
            // entrar_btn
            // 
            this.entrar_btn.BackColor = System.Drawing.SystemColors.Info;
            this.entrar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.entrar_btn.FlatAppearance.BorderSize = 2;
            this.entrar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.entrar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.entrar_btn.Image = global::FireSystemMonitor.Properties.Resources.forward;
            this.entrar_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.entrar_btn.Location = new System.Drawing.Point(41, 188);
            this.entrar_btn.Name = "entrar_btn";
            this.entrar_btn.Size = new System.Drawing.Size(72, 63);
            this.entrar_btn.TabIndex = 12;
            this.entrar_btn.Text = "ENTRAR";
            this.entrar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.entrar_btn.UseVisualStyleBackColor = false;
            this.entrar_btn.Click += new System.EventHandler(this.entrar_btn_Click);
            this.entrar_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entrar_btn_KeyDown);
            // 
            // Password_txt
            // 
            this.Password_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(78, 129);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(186, 24);
            this.Password_txt.TabIndex = 11;
            this.Password_txt.UseSystemPasswordChar = true;
            this.Password_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_txt_KeyDown);
            // 
            // Usuario_txt
            // 
            this.Usuario_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Usuario_txt.Enabled = false;
            this.Usuario_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_txt.Location = new System.Drawing.Point(78, 79);
            this.Usuario_txt.Multiline = true;
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.Size = new System.Drawing.Size(186, 34);
            this.Usuario_txt.TabIndex = 10;
            this.Usuario_txt.Text = "Superuser";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.panel5.Controls.Add(this.tipoUsuario_lbl);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 53);
            this.panel5.TabIndex = 24;
            // 
            // tipoUsuario_lbl
            // 
            this.tipoUsuario_lbl.AutoSize = true;
            this.tipoUsuario_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tipoUsuario_lbl.Location = new System.Drawing.Point(815, 42);
            this.tipoUsuario_lbl.Name = "tipoUsuario_lbl";
            this.tipoUsuario_lbl.Size = new System.Drawing.Size(11, 13);
            this.tipoUsuario_lbl.TabIndex = 9;
            this.tipoUsuario_lbl.Text = "t";
            // 
            // SuperUserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.entrar_btn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Usuario_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuperUserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super User Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SuperUserLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button salir_btn;
        private System.Windows.Forms.Button entrar_btn;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox Usuario_txt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label tipoUsuario_lbl;
    }
}