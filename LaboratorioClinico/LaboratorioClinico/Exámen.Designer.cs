namespace LaboratorioClinico
{
    partial class Exámen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtx_expe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Gpb_examen = new System.Windows.Forms.GroupBox();
            this.Gpb_guardar = new System.Windows.Forms.GroupBox();
            this.Lbl_precio = new System.Windows.Forms.Label();
            this.Lbl_quetzal = new System.Windows.Forms.Label();
            this.Cmb_examen = new System.Windows.Forms.ComboBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Txtx_cod = new System.Windows.Forms.TextBox();
            this.Gpb_paciente = new System.Windows.Forms.GroupBox();
            this.Picb_paciente = new System.Windows.Forms.PictureBox();
            this.Txtx_nit = new System.Windows.Forms.TextBox();
            this.Txtx_tel = new System.Windows.Forms.TextBox();
            this.Txtx_nombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Gpb_examen.SuspendLayout();
            this.Gpb_guardar.SuspendLayout();
            this.Gpb_paciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picb_paciente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod. Exámen:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Txtx_expe
            // 
            this.Txtx_expe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txtx_expe.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtx_expe.Location = new System.Drawing.Point(126, 39);
            this.Txtx_expe.Name = "Txtx_expe";
            this.Txtx_expe.Size = new System.Drawing.Size(145, 26);
            this.Txtx_expe.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "No.Expediente:";
            // 
            // Gpb_examen
            // 
            this.Gpb_examen.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_examen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gpb_examen.Controls.Add(this.Gpb_guardar);
            this.Gpb_examen.Controls.Add(this.Gpb_paciente);
            this.Gpb_examen.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_examen.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_examen.Location = new System.Drawing.Point(21, 12);
            this.Gpb_examen.Name = "Gpb_examen";
            this.Gpb_examen.Size = new System.Drawing.Size(732, 504);
            this.Gpb_examen.TabIndex = 12;
            this.Gpb_examen.TabStop = false;
            this.Gpb_examen.Text = "Exámenes";
            this.Gpb_examen.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Gpb_guardar
            // 
            this.Gpb_guardar.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_guardar.Controls.Add(this.Lbl_precio);
            this.Gpb_guardar.Controls.Add(this.Lbl_quetzal);
            this.Gpb_guardar.Controls.Add(this.Cmb_examen);
            this.Gpb_guardar.Controls.Add(this.Btn_Guardar);
            this.Gpb_guardar.Controls.Add(this.label1);
            this.Gpb_guardar.Controls.Add(this.Txtx_cod);
            this.Gpb_guardar.Controls.Add(this.label4);
            this.Gpb_guardar.Controls.Add(this.label3);
            this.Gpb_guardar.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gpb_guardar.Location = new System.Drawing.Point(20, 274);
            this.Gpb_guardar.Name = "Gpb_guardar";
            this.Gpb_guardar.Size = new System.Drawing.Size(695, 187);
            this.Gpb_guardar.TabIndex = 12;
            this.Gpb_guardar.TabStop = false;
            this.Gpb_guardar.Text = "Guardar Exámen";
            // 
            // Lbl_precio
            // 
            this.Lbl_precio.AutoSize = true;
            this.Lbl_precio.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_precio.ForeColor = System.Drawing.Color.White;
            this.Lbl_precio.Location = new System.Drawing.Point(292, 107);
            this.Lbl_precio.Name = "Lbl_precio";
            this.Lbl_precio.Size = new System.Drawing.Size(33, 18);
            this.Lbl_precio.TabIndex = 16;
            this.Lbl_precio.Text = "0.00";
            // 
            // Lbl_quetzal
            // 
            this.Lbl_quetzal.AutoSize = true;
            this.Lbl_quetzal.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_quetzal.ForeColor = System.Drawing.Color.White;
            this.Lbl_quetzal.Location = new System.Drawing.Point(272, 107);
            this.Lbl_quetzal.Name = "Lbl_quetzal";
            this.Lbl_quetzal.Size = new System.Drawing.Size(24, 18);
            this.Lbl_quetzal.TabIndex = 15;
            this.Lbl_quetzal.Text = "Q.";
            // 
            // Cmb_examen
            // 
            this.Cmb_examen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Cmb_examen.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_examen.FormattingEnabled = true;
            this.Cmb_examen.Location = new System.Drawing.Point(126, 69);
            this.Cmb_examen.Name = "Cmb_examen";
            this.Cmb_examen.Size = new System.Drawing.Size(231, 26);
            this.Cmb_examen.TabIndex = 14;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar;
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Guardar.Location = new System.Drawing.Point(626, 34);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(53, 44);
            this.Btn_Guardar.TabIndex = 13;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Txtx_cod
            // 
            this.Txtx_cod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txtx_cod.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtx_cod.Location = new System.Drawing.Point(126, 104);
            this.Txtx_cod.Name = "Txtx_cod";
            this.Txtx_cod.Size = new System.Drawing.Size(65, 26);
            this.Txtx_cod.TabIndex = 4;
            // 
            // Gpb_paciente
            // 
            this.Gpb_paciente.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_paciente.Controls.Add(this.Picb_paciente);
            this.Gpb_paciente.Controls.Add(this.Txtx_nit);
            this.Gpb_paciente.Controls.Add(this.Txtx_tel);
            this.Gpb_paciente.Controls.Add(this.Txtx_nombre);
            this.Gpb_paciente.Controls.Add(this.label8);
            this.Gpb_paciente.Controls.Add(this.label7);
            this.Gpb_paciente.Controls.Add(this.label6);
            this.Gpb_paciente.Controls.Add(this.label2);
            this.Gpb_paciente.Controls.Add(this.Btn_buscar);
            this.Gpb_paciente.Controls.Add(this.label5);
            this.Gpb_paciente.Controls.Add(this.Txtx_expe);
            this.Gpb_paciente.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_paciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gpb_paciente.Location = new System.Drawing.Point(20, 55);
            this.Gpb_paciente.Name = "Gpb_paciente";
            this.Gpb_paciente.Size = new System.Drawing.Size(695, 168);
            this.Gpb_paciente.TabIndex = 11;
            this.Gpb_paciente.TabStop = false;
            this.Gpb_paciente.Text = "Buscar Paciente";
            // 
            // Picb_paciente
            // 
            this.Picb_paciente.Image = global::LaboratorioClinico.Properties.Resources.examen;
            this.Picb_paciente.Location = new System.Drawing.Point(599, 27);
            this.Picb_paciente.Name = "Picb_paciente";
            this.Picb_paciente.Size = new System.Drawing.Size(83, 69);
            this.Picb_paciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picb_paciente.TabIndex = 21;
            this.Picb_paciente.TabStop = false;
            this.Picb_paciente.Click += new System.EventHandler(this.Picb_paciente_Click);
            // 
            // Txtx_nit
            // 
            this.Txtx_nit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txtx_nit.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtx_nit.Location = new System.Drawing.Point(363, 115);
            this.Txtx_nit.Name = "Txtx_nit";
            this.Txtx_nit.Size = new System.Drawing.Size(145, 26);
            this.Txtx_nit.TabIndex = 19;
            // 
            // Txtx_tel
            // 
            this.Txtx_tel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txtx_tel.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtx_tel.Location = new System.Drawing.Point(126, 115);
            this.Txtx_tel.Name = "Txtx_tel";
            this.Txtx_tel.Size = new System.Drawing.Size(168, 26);
            this.Txtx_tel.TabIndex = 18;
            // 
            // Txtx_nombre
            // 
            this.Txtx_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txtx_nombre.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtx_nombre.Location = new System.Drawing.Point(126, 77);
            this.Txtx_nombre.Name = "Txtx_nombre";
            this.Txtx_nombre.Size = new System.Drawing.Size(382, 26);
            this.Txtx_nombre.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(320, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "NIT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(18, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 13;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.file;
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_buscar.Location = new System.Drawing.Point(290, 27);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(53, 44);
            this.Btn_buscar.TabIndex = 12;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Exámen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 528);
            this.Controls.Add(this.Gpb_examen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exámen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Exámen_Load);
            this.Gpb_examen.ResumeLayout(false);
            this.Gpb_guardar.ResumeLayout(false);
            this.Gpb_guardar.PerformLayout();
            this.Gpb_paciente.ResumeLayout(false);
            this.Gpb_paciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picb_paciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtx_expe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Gpb_examen;
        private System.Windows.Forms.GroupBox Gpb_guardar;
        private System.Windows.Forms.GroupBox Gpb_paciente;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox Txtx_cod;
        private System.Windows.Forms.TextBox Txtx_nit;
        private System.Windows.Forms.TextBox Txtx_tel;
        private System.Windows.Forms.TextBox Txtx_nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cmb_examen;
        private System.Windows.Forms.Label Lbl_precio;
        private System.Windows.Forms.Label Lbl_quetzal;
        private System.Windows.Forms.PictureBox Picb_paciente;
    }
}