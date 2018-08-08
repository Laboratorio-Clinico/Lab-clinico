namespace LaboratorioClinico
{
    partial class ConfigUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigUser));
            this.label1 = new System.Windows.Forms.Label();
            this.Tbc_control = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.Cmb_privi = new System.Windows.Forms.ComboBox();
            this.Btn_cambiar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cmb_usuario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tbc_eliminar = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_privilegio = new System.Windows.Forms.TextBox();
            this.Cmb_usuarioEliminar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbc_cuerpo = new System.Windows.Forms.TabControl();
            this.Tbc_cambio = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.Pbx_incorrecto = new System.Windows.Forms.PictureBox();
            this.Btn_verificar = new System.Windows.Forms.Button();
            this.Pbx_correcto = new System.Windows.Forms.PictureBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gpb_contraseña = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_actual = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_nueva = new System.Windows.Forms.TextBox();
            this.Cmb_usuarioCambio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Tbc_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Tbc_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Tbc_cuerpo.SuspendLayout();
            this.Tbc_cambio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_incorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_correcto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Gpb_contraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración de Usuarios";
            // 
            // Tbc_control
            // 
            this.Tbc_control.Controls.Add(this.button2);
            this.Tbc_control.Controls.Add(this.Cmb_privi);
            this.Tbc_control.Controls.Add(this.Btn_cambiar);
            this.Tbc_control.Controls.Add(this.pictureBox3);
            this.Tbc_control.Controls.Add(this.label8);
            this.Tbc_control.Controls.Add(this.Cmb_usuario);
            this.Tbc_control.Controls.Add(this.label7);
            this.Tbc_control.Controls.Add(this.label6);
            this.Tbc_control.Location = new System.Drawing.Point(4, 31);
            this.Tbc_control.Name = "Tbc_control";
            this.Tbc_control.Padding = new System.Windows.Forms.Padding(3);
            this.Tbc_control.Size = new System.Drawing.Size(410, 329);
            this.Tbc_control.TabIndex = 2;
            this.Tbc_control.Text = "Privilegios";
            this.Tbc_control.UseVisualStyleBackColor = true;
            this.Tbc_control.Click += new System.EventHandler(this.Tbc_control_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(25, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 44);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Cmb_privi
            // 
            this.Cmb_privi.FormattingEnabled = true;
            this.Cmb_privi.Location = new System.Drawing.Point(156, 195);
            this.Cmb_privi.Name = "Cmb_privi";
            this.Cmb_privi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cmb_privi.Size = new System.Drawing.Size(172, 30);
            this.Cmb_privi.TabIndex = 17;
            this.Cmb_privi.SelectedIndexChanged += new System.EventHandler(this.Cmb_privi_SelectedIndexChanged);
            // 
            // Btn_cambiar
            // 
            this.Btn_cambiar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar1;
            this.Btn_cambiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cambiar.Location = new System.Drawing.Point(315, 264);
            this.Btn_cambiar.Name = "Btn_cambiar";
            this.Btn_cambiar.Size = new System.Drawing.Size(53, 44);
            this.Btn_cambiar.TabIndex = 16;
            this.Btn_cambiar.UseVisualStyleBackColor = true;
            this.Btn_cambiar.Click += new System.EventHandler(this.Btn_cambiar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::LaboratorioClinico.Properties.Resources.administrador;
            this.pictureBox3.Location = new System.Drawing.Point(168, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Privilegio";
            // 
            // Cmb_usuario
            // 
            this.Cmb_usuario.FormattingEnabled = true;
            this.Cmb_usuario.Location = new System.Drawing.Point(156, 156);
            this.Cmb_usuario.Name = "Cmb_usuario";
            this.Cmb_usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cmb_usuario.Size = new System.Drawing.Size(172, 30);
            this.Cmb_usuario.TabIndex = 12;
            this.Cmb_usuario.SelectedIndexChanged += new System.EventHandler(this.Cmb_usuario_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Otorgar Privilegios a Usuarios";
            // 
            // Tbc_eliminar
            // 
            this.Tbc_eliminar.Controls.Add(this.pictureBox2);
            this.Tbc_eliminar.Controls.Add(this.Btn_eliminar);
            this.Tbc_eliminar.Controls.Add(this.label5);
            this.Tbc_eliminar.Controls.Add(this.Txt_privilegio);
            this.Tbc_eliminar.Controls.Add(this.Cmb_usuarioEliminar);
            this.Tbc_eliminar.Controls.Add(this.label4);
            this.Tbc_eliminar.Location = new System.Drawing.Point(4, 31);
            this.Tbc_eliminar.Name = "Tbc_eliminar";
            this.Tbc_eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.Tbc_eliminar.Size = new System.Drawing.Size(410, 329);
            this.Tbc_eliminar.TabIndex = 1;
            this.Tbc_eliminar.Text = "Eliminar";
            this.Tbc_eliminar.UseVisualStyleBackColor = true;
            this.Tbc_eliminar.Click += new System.EventHandler(this.Tbc_eliminar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LaboratorioClinico.Properties.Resources.eliminar_user;
            this.pictureBox2.Location = new System.Drawing.Point(168, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.cubo_de_basura;
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_eliminar.Location = new System.Drawing.Point(315, 264);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(53, 44);
            this.Btn_eliminar.TabIndex = 13;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Privilegio";
            // 
            // Txt_privilegio
            // 
            this.Txt_privilegio.Enabled = false;
            this.Txt_privilegio.Location = new System.Drawing.Point(141, 186);
            this.Txt_privilegio.Name = "Txt_privilegio";
            this.Txt_privilegio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_privilegio.Size = new System.Drawing.Size(172, 29);
            this.Txt_privilegio.TabIndex = 11;
            this.Txt_privilegio.TextChanged += new System.EventHandler(this.Txt_privilegio_TextChanged);
            // 
            // Cmb_usuarioEliminar
            // 
            this.Cmb_usuarioEliminar.FormattingEnabled = true;
            this.Cmb_usuarioEliminar.Location = new System.Drawing.Point(141, 145);
            this.Cmb_usuarioEliminar.Name = "Cmb_usuarioEliminar";
            this.Cmb_usuarioEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cmb_usuarioEliminar.Size = new System.Drawing.Size(172, 30);
            this.Cmb_usuarioEliminar.TabIndex = 10;
            this.Cmb_usuarioEliminar.SelectedIndexChanged += new System.EventHandler(this.Cmb_usuarioEliminar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuario";
            // 
            // Tbc_cuerpo
            // 
            this.Tbc_cuerpo.Controls.Add(this.Tbc_eliminar);
            this.Tbc_cuerpo.Controls.Add(this.Tbc_control);
            this.Tbc_cuerpo.Controls.Add(this.Tbc_cambio);
            this.Tbc_cuerpo.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbc_cuerpo.Location = new System.Drawing.Point(177, 88);
            this.Tbc_cuerpo.Name = "Tbc_cuerpo";
            this.Tbc_cuerpo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tbc_cuerpo.SelectedIndex = 0;
            this.Tbc_cuerpo.Size = new System.Drawing.Size(418, 364);
            this.Tbc_cuerpo.TabIndex = 1;
            // 
            // Tbc_cambio
            // 
            this.Tbc_cambio.Controls.Add(this.button3);
            this.Tbc_cambio.Controls.Add(this.Pbx_incorrecto);
            this.Tbc_cambio.Controls.Add(this.Btn_verificar);
            this.Tbc_cambio.Controls.Add(this.Pbx_correcto);
            this.Tbc_cambio.Controls.Add(this.Btn_guardar);
            this.Tbc_cambio.Controls.Add(this.pictureBox1);
            this.Tbc_cambio.Controls.Add(this.Gpb_contraseña);
            this.Tbc_cambio.Controls.Add(this.Cmb_usuarioCambio);
            this.Tbc_cambio.Controls.Add(this.label2);
            this.Tbc_cambio.Location = new System.Drawing.Point(4, 31);
            this.Tbc_cambio.Name = "Tbc_cambio";
            this.Tbc_cambio.Padding = new System.Windows.Forms.Padding(3);
            this.Tbc_cambio.Size = new System.Drawing.Size(410, 329);
            this.Tbc_cambio.TabIndex = 3;
            this.Tbc_cambio.Text = "Cambiar Contraseña";
            this.Tbc_cambio.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 44);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Pbx_incorrecto
            // 
            this.Pbx_incorrecto.Image = global::LaboratorioClinico.Properties.Resources.boton_x;
            this.Pbx_incorrecto.Location = new System.Drawing.Point(348, 167);
            this.Pbx_incorrecto.Name = "Pbx_incorrecto";
            this.Pbx_incorrecto.Size = new System.Drawing.Size(39, 34);
            this.Pbx_incorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_incorrecto.TabIndex = 24;
            this.Pbx_incorrecto.TabStop = false;
            this.Pbx_incorrecto.Visible = false;
            // 
            // Btn_verificar
            // 
            this.Btn_verificar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btn_verificar.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_verificar.Location = new System.Drawing.Point(335, 207);
            this.Btn_verificar.Name = "Btn_verificar";
            this.Btn_verificar.Size = new System.Drawing.Size(62, 27);
            this.Btn_verificar.TabIndex = 23;
            this.Btn_verificar.Text = "Verificar";
            this.Btn_verificar.UseVisualStyleBackColor = false;
            this.Btn_verificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pbx_correcto
            // 
            this.Pbx_correcto.Image = global::LaboratorioClinico.Properties.Resources.comprobado;
            this.Pbx_correcto.Location = new System.Drawing.Point(348, 168);
            this.Pbx_correcto.Name = "Pbx_correcto";
            this.Pbx_correcto.Size = new System.Drawing.Size(35, 33);
            this.Pbx_correcto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_correcto.TabIndex = 22;
            this.Pbx_correcto.TabStop = false;
            this.Pbx_correcto.Visible = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar1;
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guardar.Location = new System.Drawing.Point(344, 265);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 44);
            this.Btn_guardar.TabIndex = 21;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaboratorioClinico.Properties.Resources.bloqueado1;
            this.pictureBox1.Location = new System.Drawing.Point(158, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Gpb_contraseña
            // 
            this.Gpb_contraseña.Controls.Add(this.label3);
            this.Gpb_contraseña.Controls.Add(this.Txt_actual);
            this.Gpb_contraseña.Controls.Add(this.label9);
            this.Gpb_contraseña.Controls.Add(this.Txt_nueva);
            this.Gpb_contraseña.Enabled = false;
            this.Gpb_contraseña.Location = new System.Drawing.Point(36, 158);
            this.Gpb_contraseña.Name = "Gpb_contraseña";
            this.Gpb_contraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Gpb_contraseña.Size = new System.Drawing.Size(293, 141);
            this.Gpb_contraseña.TabIndex = 19;
            this.Gpb_contraseña.TabStop = false;
            this.Gpb_contraseña.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = " Actual";
            // 
            // Txt_actual
            // 
            this.Txt_actual.Enabled = false;
            this.Txt_actual.Location = new System.Drawing.Point(115, 43);
            this.Txt_actual.Name = "Txt_actual";
            this.Txt_actual.PasswordChar = '*';
            this.Txt_actual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_actual.Size = new System.Drawing.Size(172, 29);
            this.Txt_actual.TabIndex = 13;
            this.Txt_actual.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nueva";
            // 
            // Txt_nueva
            // 
            this.Txt_nueva.Enabled = false;
            this.Txt_nueva.Location = new System.Drawing.Point(115, 87);
            this.Txt_nueva.Name = "Txt_nueva";
            this.Txt_nueva.PasswordChar = '*';
            this.Txt_nueva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_nueva.Size = new System.Drawing.Size(172, 29);
            this.Txt_nueva.TabIndex = 15;
            // 
            // Cmb_usuarioCambio
            // 
            this.Cmb_usuarioCambio.FormattingEnabled = true;
            this.Cmb_usuarioCambio.Location = new System.Drawing.Point(145, 112);
            this.Cmb_usuarioCambio.Name = "Cmb_usuarioCambio";
            this.Cmb_usuarioCambio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cmb_usuarioCambio.Size = new System.Drawing.Size(178, 30);
            this.Cmb_usuarioCambio.TabIndex = 12;
            this.Cmb_usuarioCambio.SelectedIndexChanged += new System.EventHandler(this.Cmb_usuarioCambio_SelectedIndexChanged);
            this.Cmb_usuarioCambio.Click += new System.EventHandler(this.Cmb_usuarioCambio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(739, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 123;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ConfigUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tbc_cuerpo);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigUser";
            this.Load += new System.EventHandler(this.ConfigUser_Load);
            this.Tbc_control.ResumeLayout(false);
            this.Tbc_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Tbc_eliminar.ResumeLayout(false);
            this.Tbc_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Tbc_cuerpo.ResumeLayout(false);
            this.Tbc_cambio.ResumeLayout(false);
            this.Tbc_cambio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_incorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_correcto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Gpb_contraseña.ResumeLayout(false);
            this.Gpb_contraseña.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Tbc_control;
        private System.Windows.Forms.ComboBox Cmb_privi;
        private System.Windows.Forms.Button Btn_cambiar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cmb_usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage Tbc_eliminar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_privilegio;
        private System.Windows.Forms.ComboBox Cmb_usuarioEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl Tbc_cuerpo;
        private System.Windows.Forms.TabPage Tbc_cambio;
        private System.Windows.Forms.GroupBox Gpb_contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_actual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_nueva;
        private System.Windows.Forms.ComboBox Cmb_usuarioCambio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.PictureBox Pbx_correcto;
        private System.Windows.Forms.PictureBox Pbx_incorrecto;
        private System.Windows.Forms.Button Btn_verificar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}