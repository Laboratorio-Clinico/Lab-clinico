namespace LaboratorioClinico
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.Gpb_nuevoUsuario = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn = new System.Windows.Forms.Button();
            this.Pnl_usuario = new System.Windows.Forms.Panel();
            this.Cmb_privelegio = new System.Windows.Forms.ComboBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Lbl_privilegio = new System.Windows.Forms.Label();
            this.Lbl_contrasena = new System.Windows.Forms.Label();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.Txt_codigoDeEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_codigoDeEmpleado = new System.Windows.Forms.Label();
            this.Picb_Imagen = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Gpb_nuevoUsuario.SuspendLayout();
            this.Pnl_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picb_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_nuevoUsuario
            // 
            this.Gpb_nuevoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_nuevoUsuario.Controls.Add(this.Btn);
            this.Gpb_nuevoUsuario.Controls.Add(this.Pnl_usuario);
            this.Gpb_nuevoUsuario.Controls.Add(this.Txt_codigoDeEmpleado);
            this.Gpb_nuevoUsuario.Controls.Add(this.Lbl_codigoDeEmpleado);
            this.Gpb_nuevoUsuario.Controls.Add(this.Picb_Imagen);
            this.Gpb_nuevoUsuario.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_nuevoUsuario.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_nuevoUsuario.Location = new System.Drawing.Point(28, 23);
            this.Gpb_nuevoUsuario.Name = "Gpb_nuevoUsuario";
            this.Gpb_nuevoUsuario.Size = new System.Drawing.Size(717, 441);
            this.Gpb_nuevoUsuario.TabIndex = 14;
            this.Gpb_nuevoUsuario.TabStop = false;
            this.Gpb_nuevoUsuario.Text = "Nuevo Usuario";
            this.Gpb_nuevoUsuario.Enter += new System.EventHandler(this.Gpb_nuevoUsuario_Enter);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(6, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 44);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btn
            // 
            this.Btn.BackColor = System.Drawing.Color.Transparent;
            this.Btn.BackgroundImage = global::LaboratorioClinico.Properties.Resources.file;
            this.Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn.Location = new System.Drawing.Point(628, 90);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(53, 44);
            this.Btn.TabIndex = 111;
            this.Btn.UseVisualStyleBackColor = false;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Pnl_usuario
            // 
            this.Pnl_usuario.Controls.Add(this.Cmb_privelegio);
            this.Pnl_usuario.Controls.Add(this.Btn_guardar);
            this.Pnl_usuario.Controls.Add(this.Lbl_usuario);
            this.Pnl_usuario.Controls.Add(this.Lbl_privilegio);
            this.Pnl_usuario.Controls.Add(this.Lbl_contrasena);
            this.Pnl_usuario.Controls.Add(this.Txt_usuario);
            this.Pnl_usuario.Controls.Add(this.Txt_password);
            this.Pnl_usuario.Location = new System.Drawing.Point(263, 140);
            this.Pnl_usuario.Name = "Pnl_usuario";
            this.Pnl_usuario.Size = new System.Drawing.Size(384, 213);
            this.Pnl_usuario.TabIndex = 38;
            this.Pnl_usuario.Visible = false;
            // 
            // Cmb_privelegio
            // 
            this.Cmb_privelegio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Cmb_privelegio.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_privelegio.FormattingEnabled = true;
            this.Cmb_privelegio.Items.AddRange(new object[] {
            "Administrador",
            "UsuarioL",
            "Usuario"});
            this.Cmb_privelegio.Location = new System.Drawing.Point(167, 107);
            this.Cmb_privelegio.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_privelegio.Name = "Cmb_privelegio";
            this.Cmb_privelegio.Size = new System.Drawing.Size(185, 26);
            this.Cmb_privelegio.TabIndex = 35;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar;
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guardar.Location = new System.Drawing.Point(299, 150);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 44);
            this.Btn_guardar.TabIndex = 37;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.Lbl_usuario.Location = new System.Drawing.Point(76, 26);
            this.Lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(54, 18);
            this.Lbl_usuario.TabIndex = 27;
            this.Lbl_usuario.Text = "Usuario";
            // 
            // Lbl_privilegio
            // 
            this.Lbl_privilegio.AutoSize = true;
            this.Lbl_privilegio.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_privilegio.ForeColor = System.Drawing.Color.White;
            this.Lbl_privilegio.Location = new System.Drawing.Point(76, 114);
            this.Lbl_privilegio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_privilegio.Name = "Lbl_privilegio";
            this.Lbl_privilegio.Size = new System.Drawing.Size(66, 18);
            this.Lbl_privilegio.TabIndex = 36;
            this.Lbl_privilegio.Text = "Privilegio";
            // 
            // Lbl_contrasena
            // 
            this.Lbl_contrasena.AutoSize = true;
            this.Lbl_contrasena.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contrasena.ForeColor = System.Drawing.Color.White;
            this.Lbl_contrasena.Location = new System.Drawing.Point(76, 70);
            this.Lbl_contrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_contrasena.Name = "Lbl_contrasena";
            this.Lbl_contrasena.Size = new System.Drawing.Size(74, 18);
            this.Lbl_contrasena.TabIndex = 28;
            this.Lbl_contrasena.Text = "Contraseña";
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_usuario.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usuario.Location = new System.Drawing.Point(167, 18);
            this.Txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(185, 26);
            this.Txt_usuario.TabIndex = 32;
            // 
            // Txt_password
            // 
            this.Txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_password.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_password.Location = new System.Drawing.Point(167, 63);
            this.Txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.Size = new System.Drawing.Size(185, 26);
            this.Txt_password.TabIndex = 33;
            // 
            // Txt_codigoDeEmpleado
            // 
            this.Txt_codigoDeEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_codigoDeEmpleado.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigoDeEmpleado.Location = new System.Drawing.Point(432, 99);
            this.Txt_codigoDeEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_codigoDeEmpleado.MaxLength = 13;
            this.Txt_codigoDeEmpleado.Name = "Txt_codigoDeEmpleado";
            this.Txt_codigoDeEmpleado.Size = new System.Drawing.Size(185, 26);
            this.Txt_codigoDeEmpleado.TabIndex = 31;
            this.Txt_codigoDeEmpleado.TextChanged += new System.EventHandler(this.Txt_codigoDeEmpleado_TextChanged);
            // 
            // Lbl_codigoDeEmpleado
            // 
            this.Lbl_codigoDeEmpleado.AutoSize = true;
            this.Lbl_codigoDeEmpleado.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoDeEmpleado.ForeColor = System.Drawing.Color.White;
            this.Lbl_codigoDeEmpleado.Location = new System.Drawing.Point(331, 102);
            this.Lbl_codigoDeEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codigoDeEmpleado.Name = "Lbl_codigoDeEmpleado";
            this.Lbl_codigoDeEmpleado.Size = new System.Drawing.Size(93, 18);
            this.Lbl_codigoDeEmpleado.TabIndex = 29;
            this.Lbl_codigoDeEmpleado.Text = "DPI Empleado";
            // 
            // Picb_Imagen
            // 
            this.Picb_Imagen.Image = global::LaboratorioClinico.Properties.Resources.imagen_monografico_que_deberias_saber_cuentas_de_usuario;
            this.Picb_Imagen.Location = new System.Drawing.Point(32, 102);
            this.Picb_Imagen.Name = "Picb_Imagen";
            this.Picb_Imagen.Size = new System.Drawing.Size(216, 205);
            this.Picb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picb_Imagen.TabIndex = 25;
            this.Picb_Imagen.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(740, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 123;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Gpb_nuevoUsuario);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.Gpb_nuevoUsuario.ResumeLayout(false);
            this.Gpb_nuevoUsuario.PerformLayout();
            this.Pnl_usuario.ResumeLayout(false);
            this.Pnl_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picb_Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_nuevoUsuario;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_privilegio;
        private System.Windows.Forms.ComboBox Cmb_privelegio;
        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox Txt_codigoDeEmpleado;
        private System.Windows.Forms.Label Lbl_codigoDeEmpleado;
        private System.Windows.Forms.Label Lbl_contrasena;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.PictureBox Picb_Imagen;
        private System.Windows.Forms.Panel Pnl_usuario;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Button button2;
    }
}