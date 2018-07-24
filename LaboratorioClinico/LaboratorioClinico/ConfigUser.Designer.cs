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
            this.label1 = new System.Windows.Forms.Label();
            this.Tbc_eliminar = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_privilegio = new System.Windows.Forms.TextBox();
            this.Cmb_usuarioEliminar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbc_ingresar = new System.Windows.Forms.TabPage();
            this.Cmb_privilegio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Tbc_cuerpo = new System.Windows.Forms.TabControl();
            this.Tbc_control = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cmb_usuario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_cambiar = new System.Windows.Forms.Button();
            this.Cmb_privi = new System.Windows.Forms.ComboBox();
            this.Tbc_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Tbc_ingresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tbc_cuerpo.SuspendLayout();
            this.Tbc_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LaboratorioClinico.Properties.Resources.eliminar_user;
            this.pictureBox2.Location = new System.Drawing.Point(168, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar1;
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_eliminar.Location = new System.Drawing.Point(311, 244);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(53, 44);
            this.Btn_eliminar.TabIndex = 13;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Privilegio";
            // 
            // Txt_privilegio
            // 
            this.Txt_privilegio.Enabled = false;
            this.Txt_privilegio.Location = new System.Drawing.Point(141, 195);
            this.Txt_privilegio.Name = "Txt_privilegio";
            this.Txt_privilegio.Size = new System.Drawing.Size(172, 29);
            this.Txt_privilegio.TabIndex = 11;
            // 
            // Cmb_usuarioEliminar
            // 
            this.Cmb_usuarioEliminar.FormattingEnabled = true;
            this.Cmb_usuarioEliminar.Location = new System.Drawing.Point(141, 145);
            this.Cmb_usuarioEliminar.Name = "Cmb_usuarioEliminar";
            this.Cmb_usuarioEliminar.Size = new System.Drawing.Size(172, 30);
            this.Cmb_usuarioEliminar.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuario";
            // 
            // Tbc_ingresar
            // 
            this.Tbc_ingresar.Controls.Add(this.Cmb_privilegio);
            this.Tbc_ingresar.Controls.Add(this.label3);
            this.Tbc_ingresar.Controls.Add(this.pictureBox1);
            this.Tbc_ingresar.Controls.Add(this.Btn_guardar);
            this.Tbc_ingresar.Controls.Add(this.label2);
            this.Tbc_ingresar.Controls.Add(this.textBox1);
            this.Tbc_ingresar.Controls.Add(this.Lbl_nombre);
            this.Tbc_ingresar.Controls.Add(this.Txt_usuario);
            this.Tbc_ingresar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbc_ingresar.Location = new System.Drawing.Point(4, 31);
            this.Tbc_ingresar.Name = "Tbc_ingresar";
            this.Tbc_ingresar.Padding = new System.Windows.Forms.Padding(3);
            this.Tbc_ingresar.Size = new System.Drawing.Size(410, 329);
            this.Tbc_ingresar.TabIndex = 0;
            this.Tbc_ingresar.Text = "Ingresar";
            this.Tbc_ingresar.UseVisualStyleBackColor = true;
            // 
            // Cmb_privilegio
            // 
            this.Cmb_privilegio.FormattingEnabled = true;
            this.Cmb_privilegio.Location = new System.Drawing.Point(129, 235);
            this.Cmb_privilegio.Name = "Cmb_privilegio";
            this.Cmb_privilegio.Size = new System.Drawing.Size(172, 30);
            this.Cmb_privilegio.TabIndex = 8;
            this.Cmb_privilegio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Privilegio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaboratorioClinico.Properties.Resources.nuevo_usuario1;
            this.pictureBox1.Location = new System.Drawing.Point(168, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar1;
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guardar.Location = new System.Drawing.Point(315, 264);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 44);
            this.Btn_guardar.TabIndex = 4;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 29);
            this.textBox1.TabIndex = 2;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Location = new System.Drawing.Point(18, 139);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(65, 22);
            this.Lbl_nombre.TabIndex = 1;
            this.Lbl_nombre.Text = "Usuario";
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(129, 132);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(172, 29);
            this.Txt_usuario.TabIndex = 0;
            // 
            // Tbc_cuerpo
            // 
            this.Tbc_cuerpo.Controls.Add(this.Tbc_ingresar);
            this.Tbc_cuerpo.Controls.Add(this.Tbc_eliminar);
            this.Tbc_cuerpo.Controls.Add(this.Tbc_control);
            this.Tbc_cuerpo.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbc_cuerpo.Location = new System.Drawing.Point(177, 88);
            this.Tbc_cuerpo.Name = "Tbc_cuerpo";
            this.Tbc_cuerpo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tbc_cuerpo.SelectedIndex = 0;
            this.Tbc_cuerpo.Size = new System.Drawing.Size(418, 364);
            this.Tbc_cuerpo.TabIndex = 1;
            // 
            // Tbc_control
            // 
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
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LaboratorioClinico.Properties.Resources.administrador;
            this.pictureBox3.Location = new System.Drawing.Point(178, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 204);
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
            this.Cmb_usuario.Size = new System.Drawing.Size(172, 30);
            this.Cmb_usuario.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Otorgar Privilegios a Usuarios";
            // 
            // Btn_cambiar
            // 
            this.Btn_cambiar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar1;
            this.Btn_cambiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cambiar.Location = new System.Drawing.Point(275, 258);
            this.Btn_cambiar.Name = "Btn_cambiar";
            this.Btn_cambiar.Size = new System.Drawing.Size(53, 44);
            this.Btn_cambiar.TabIndex = 16;
            this.Btn_cambiar.UseVisualStyleBackColor = true;
            // 
            // Cmb_privi
            // 
            this.Cmb_privi.FormattingEnabled = true;
            this.Cmb_privi.Location = new System.Drawing.Point(156, 201);
            this.Cmb_privi.Name = "Cmb_privi";
            this.Cmb_privi.Size = new System.Drawing.Size(172, 30);
            this.Cmb_privi.TabIndex = 17;
            // 
            // ConfigUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Tbc_cuerpo);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ConfigUser";
            this.Text = "ConfigUser";
            this.Load += new System.EventHandler(this.ConfigUser_Load);
            this.Tbc_eliminar.ResumeLayout(false);
            this.Tbc_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Tbc_ingresar.ResumeLayout(false);
            this.Tbc_ingresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tbc_cuerpo.ResumeLayout(false);
            this.Tbc_control.ResumeLayout(false);
            this.Tbc_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Tbc_eliminar;
        private System.Windows.Forms.TabPage Tbc_ingresar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TabControl Tbc_cuerpo;
        private System.Windows.Forms.TabPage Tbc_control;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_privilegio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_privilegio;
        private System.Windows.Forms.ComboBox Cmb_usuarioEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cmb_usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_cambiar;
        private System.Windows.Forms.ComboBox Cmb_privi;
    }
}