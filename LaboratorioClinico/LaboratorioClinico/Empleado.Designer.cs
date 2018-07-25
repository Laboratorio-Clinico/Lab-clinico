namespace LaboratorioClinico
{
    partial class Empleado
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
            this.Gpb_datosEmpleado = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Gpb_contacto = new System.Windows.Forms.GroupBox();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.Lbl_telefono = new System.Windows.Forms.Label();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.Gpb_puesto = new System.Windows.Forms.GroupBox();
            this.Cmb_cargo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_sueldo = new System.Windows.Forms.TextBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Picb_imagen = new System.Windows.Forms.PictureBox();
            this.Gpb_datosPersonales = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_DPIEmpleado = new System.Windows.Forms.TextBox();
            this.Dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fechaDeNacimiento = new System.Windows.Forms.Label();
            this.Txt_apellido = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_apellido = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Gpb_datosEmpleado.SuspendLayout();
            this.Gpb_contacto.SuspendLayout();
            this.Gpb_puesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picb_imagen)).BeginInit();
            this.Gpb_datosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_datosEmpleado
            // 
            this.Gpb_datosEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_datosEmpleado.Controls.Add(this.label4);
            this.Gpb_datosEmpleado.Controls.Add(this.Gpb_contacto);
            this.Gpb_datosEmpleado.Controls.Add(this.Gpb_puesto);
            this.Gpb_datosEmpleado.Controls.Add(this.Btn_guardar);
            this.Gpb_datosEmpleado.Controls.Add(this.Picb_imagen);
            this.Gpb_datosEmpleado.Controls.Add(this.Gpb_datosPersonales);
            this.Gpb_datosEmpleado.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosEmpleado.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_datosEmpleado.Location = new System.Drawing.Point(25, 22);
            this.Gpb_datosEmpleado.Name = "Gpb_datosEmpleado";
            this.Gpb_datosEmpleado.Size = new System.Drawing.Size(729, 455);
            this.Gpb_datosEmpleado.TabIndex = 0;
            this.Gpb_datosEmpleado.TabStop = false;
            this.Gpb_datosEmpleado.Text = "Datos de Empleados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(519, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Guardar";
            // 
            // Gpb_contacto
            // 
            this.Gpb_contacto.Controls.Add(this.Txt_telefono);
            this.Gpb_contacto.Controls.Add(this.Lbl_telefono);
            this.Gpb_contacto.Controls.Add(this.Txt_correo);
            this.Gpb_contacto.Controls.Add(this.label3);
            this.Gpb_contacto.Controls.Add(this.Txt_direccion);
            this.Gpb_contacto.Controls.Add(this.Lbl_direccion);
            this.Gpb_contacto.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_contacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gpb_contacto.Location = new System.Drawing.Point(26, 255);
            this.Gpb_contacto.Name = "Gpb_contacto";
            this.Gpb_contacto.Size = new System.Drawing.Size(322, 172);
            this.Gpb_contacto.TabIndex = 48;
            this.Gpb_contacto.TabStop = false;
            this.Gpb_contacto.Text = "Contacto";
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_telefono.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono.ForeColor = System.Drawing.Color.Black;
            this.Txt_telefono.Location = new System.Drawing.Point(83, 53);
            this.Txt_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(197, 26);
            this.Txt_telefono.TabIndex = 16;
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_telefono.ForeColor = System.Drawing.Color.White;
            this.Lbl_telefono.Location = new System.Drawing.Point(9, 54);
            this.Lbl_telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(60, 18);
            this.Lbl_telefono.TabIndex = 11;
            this.Lbl_telefono.Text = "Telefono";
            // 
            // Txt_correo
            // 
            this.Txt_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_correo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_correo.ForeColor = System.Drawing.Color.Black;
            this.Txt_correo.Location = new System.Drawing.Point(83, 88);
            this.Txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(197, 26);
            this.Txt_correo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Correo";
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_direccion.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion.ForeColor = System.Drawing.Color.Black;
            this.Txt_direccion.Location = new System.Drawing.Point(83, 122);
            this.Txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(197, 26);
            this.Txt_direccion.TabIndex = 17;
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_direccion.ForeColor = System.Drawing.Color.White;
            this.Lbl_direccion.Location = new System.Drawing.Point(9, 125);
            this.Lbl_direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(66, 18);
            this.Lbl_direccion.TabIndex = 12;
            this.Lbl_direccion.Text = "Dirección";
            // 
            // Gpb_puesto
            // 
            this.Gpb_puesto.Controls.Add(this.Cmb_cargo);
            this.Gpb_puesto.Controls.Add(this.label1);
            this.Gpb_puesto.Controls.Add(this.label2);
            this.Gpb_puesto.Controls.Add(this.Txt_sueldo);
            this.Gpb_puesto.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_puesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gpb_puesto.Location = new System.Drawing.Point(390, 47);
            this.Gpb_puesto.Name = "Gpb_puesto";
            this.Gpb_puesto.Size = new System.Drawing.Size(310, 118);
            this.Gpb_puesto.TabIndex = 47;
            this.Gpb_puesto.TabStop = false;
            this.Gpb_puesto.Text = "Puesto";
            // 
            // Cmb_cargo
            // 
            this.Cmb_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Cmb_cargo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_cargo.FormattingEnabled = true;
            this.Cmb_cargo.Location = new System.Drawing.Point(83, 40);
            this.Cmb_cargo.Name = "Cmb_cargo";
            this.Cmb_cargo.Size = new System.Drawing.Size(197, 26);
            this.Cmb_cargo.TabIndex = 20;
            this.Cmb_cargo.SelectedIndexChanged += new System.EventHandler(this.Cmb_cargo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sueldo";
            // 
            // Txt_sueldo
            // 
            this.Txt_sueldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_sueldo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sueldo.ForeColor = System.Drawing.Color.Black;
            this.Txt_sueldo.Location = new System.Drawing.Point(83, 75);
            this.Txt_sueldo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_sueldo.Name = "Txt_sueldo";
            this.Txt_sueldo.Size = new System.Drawing.Size(197, 26);
            this.Txt_sueldo.TabIndex = 22;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar;
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guardar.Location = new System.Drawing.Point(512, 383);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 44);
            this.Btn_guardar.TabIndex = 45;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Picb_imagen
            // 
            this.Picb_imagen.Image = global::LaboratorioClinico.Properties.Resources.laboratorio3;
            this.Picb_imagen.Location = new System.Drawing.Point(390, 194);
            this.Picb_imagen.Name = "Picb_imagen";
            this.Picb_imagen.Size = new System.Drawing.Size(310, 150);
            this.Picb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picb_imagen.TabIndex = 1;
            this.Picb_imagen.TabStop = false;
            // 
            // Gpb_datosPersonales
            // 
            this.Gpb_datosPersonales.Controls.Add(this.label5);
            this.Gpb_datosPersonales.Controls.Add(this.Txt_DPIEmpleado);
            this.Gpb_datosPersonales.Controls.Add(this.Dtp_fechaNacimiento);
            this.Gpb_datosPersonales.Controls.Add(this.Lbl_fechaDeNacimiento);
            this.Gpb_datosPersonales.Controls.Add(this.Txt_apellido);
            this.Gpb_datosPersonales.Controls.Add(this.Txt_nombre);
            this.Gpb_datosPersonales.Controls.Add(this.Lbl_apellido);
            this.Gpb_datosPersonales.Controls.Add(this.Lbl_nombre);
            this.Gpb_datosPersonales.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosPersonales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gpb_datosPersonales.Location = new System.Drawing.Point(26, 47);
            this.Gpb_datosPersonales.Name = "Gpb_datosPersonales";
            this.Gpb_datosPersonales.Size = new System.Drawing.Size(322, 189);
            this.Gpb_datosPersonales.TabIndex = 0;
            this.Gpb_datosPersonales.TabStop = false;
            this.Gpb_datosPersonales.Text = "Datos Personales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "DPI";
            // 
            // Txt_DPIEmpleado
            // 
            this.Txt_DPIEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_DPIEmpleado.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DPIEmpleado.ForeColor = System.Drawing.Color.Black;
            this.Txt_DPIEmpleado.Location = new System.Drawing.Point(99, 41);
            this.Txt_DPIEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DPIEmpleado.Name = "Txt_DPIEmpleado";
            this.Txt_DPIEmpleado.Size = new System.Drawing.Size(197, 26);
            this.Txt_DPIEmpleado.TabIndex = 28;
            // 
            // Dtp_fechaNacimiento
            // 
            this.Dtp_fechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.Dtp_fechaNacimiento.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechaNacimiento.Location = new System.Drawing.Point(176, 146);
            this.Dtp_fechaNacimiento.Name = "Dtp_fechaNacimiento";
            this.Dtp_fechaNacimiento.Size = new System.Drawing.Size(120, 26);
            this.Dtp_fechaNacimiento.TabIndex = 27;
            // 
            // Lbl_fechaDeNacimiento
            // 
            this.Lbl_fechaDeNacimiento.AutoSize = true;
            this.Lbl_fechaDeNacimiento.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechaDeNacimiento.ForeColor = System.Drawing.Color.White;
            this.Lbl_fechaDeNacimiento.Location = new System.Drawing.Point(25, 152);
            this.Lbl_fechaDeNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fechaDeNacimiento.Name = "Lbl_fechaDeNacimiento";
            this.Lbl_fechaDeNacimiento.Size = new System.Drawing.Size(128, 18);
            this.Lbl_fechaDeNacimiento.TabIndex = 26;
            this.Lbl_fechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_apellido.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellido.ForeColor = System.Drawing.Color.Black;
            this.Txt_apellido.Location = new System.Drawing.Point(99, 109);
            this.Txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(197, 26);
            this.Txt_apellido.TabIndex = 15;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nombre.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.Txt_nombre.Location = new System.Drawing.Point(99, 75);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(197, 26);
            this.Txt_nombre.TabIndex = 13;
            // 
            // Lbl_apellido
            // 
            this.Lbl_apellido.AutoSize = true;
            this.Lbl_apellido.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_apellido.ForeColor = System.Drawing.Color.White;
            this.Lbl_apellido.Location = new System.Drawing.Point(25, 110);
            this.Lbl_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_apellido.Name = "Lbl_apellido";
            this.Lbl_apellido.Size = new System.Drawing.Size(58, 18);
            this.Lbl_apellido.TabIndex = 14;
            this.Lbl_apellido.Text = "Apellido";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.Lbl_nombre.Location = new System.Drawing.Point(25, 74);
            this.Lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(58, 18);
            this.Lbl_nombre.TabIndex = 10;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Gpb_datosEmpleado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Gpb_datosEmpleado.ResumeLayout(false);
            this.Gpb_datosEmpleado.PerformLayout();
            this.Gpb_contacto.ResumeLayout(false);
            this.Gpb_contacto.PerformLayout();
            this.Gpb_puesto.ResumeLayout(false);
            this.Gpb_puesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picb_imagen)).EndInit();
            this.Gpb_datosPersonales.ResumeLayout(false);
            this.Gpb_datosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_datosEmpleado;
        private System.Windows.Forms.PictureBox Picb_imagen;
        private System.Windows.Forms.GroupBox Gpb_datosPersonales;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_apellido;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_telefono;
        private System.Windows.Forms.Label Lbl_apellido;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.Label Lbl_direccion;
        private System.Windows.Forms.TextBox Txt_sueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_cargo;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dtp_fechaNacimiento;
        private System.Windows.Forms.Label Lbl_fechaDeNacimiento;
        private System.Windows.Forms.GroupBox Gpb_contacto;
        private System.Windows.Forms.GroupBox Gpb_puesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_DPIEmpleado;
    }
}