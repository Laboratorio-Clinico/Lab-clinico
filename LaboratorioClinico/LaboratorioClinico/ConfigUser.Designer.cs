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
            this.Tbc_control = new System.Windows.Forms.TabPage();
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
            this.Tbc_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Tbc_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Tbc_cuerpo.SuspendLayout();
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
            this.Tbc_cuerpo.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbc_cuerpo.Location = new System.Drawing.Point(177, 88);
            this.Tbc_cuerpo.Name = "Tbc_cuerpo";
            this.Tbc_cuerpo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tbc_cuerpo.SelectedIndex = 0;
            this.Tbc_cuerpo.Size = new System.Drawing.Size(418, 364);
            this.Tbc_cuerpo.TabIndex = 1;
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
    }
}