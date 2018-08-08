namespace LaboratorioClinico
{
    partial class Comprobacion
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
            this.Gpb_buscarCita = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Dgv_verBeneficios = new System.Windows.Forms.DataGridView();
            this.Gpb_datosPersonales = new System.Windows.Forms.GroupBox();
            this.Txt_nit = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nit = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_DPI = new System.Windows.Forms.TextBox();
            this.Gpb_buscarCita.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_verBeneficios)).BeginInit();
            this.Gpb_datosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_buscarCita
            // 
            this.Gpb_buscarCita.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_buscarCita.Controls.Add(this.label3);
            this.Gpb_buscarCita.Controls.Add(this.Lbl_fecha);
            this.Gpb_buscarCita.Controls.Add(this.Dtp_fecha);
            this.Gpb_buscarCita.Controls.Add(this.groupBox1);
            this.Gpb_buscarCita.Controls.Add(this.Dgv_verBeneficios);
            this.Gpb_buscarCita.Controls.Add(this.Gpb_datosPersonales);
            this.Gpb_buscarCita.Controls.Add(this.Btn_buscar);
            this.Gpb_buscarCita.Controls.Add(this.label5);
            this.Gpb_buscarCita.Controls.Add(this.Txt_DPI);
            this.Gpb_buscarCita.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_buscarCita.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_buscarCita.Location = new System.Drawing.Point(27, 33);
            this.Gpb_buscarCita.Name = "Gpb_buscarCita";
            this.Gpb_buscarCita.Size = new System.Drawing.Size(715, 444);
            this.Gpb_buscarCita.TabIndex = 0;
            this.Gpb_buscarCita.TabStop = false;
            this.Gpb_buscarCita.Text = "Comprobar Citas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(539, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Buscar";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_fecha.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.Lbl_fecha.Location = new System.Drawing.Point(308, 56);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(89, 18);
            this.Lbl_fecha.TabIndex = 42;
            this.Lbl_fecha.Text = "Fecha de citas";
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.CustomFormat = "yy-MM-dd";
            this.Dtp_fecha.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fecha.Location = new System.Drawing.Point(403, 53);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(88, 26);
            this.Dtp_fecha.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(579, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 200);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PowderBlue;
            this.label1.Location = new System.Drawing.Point(31, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cancelar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Confirmar";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::LaboratorioClinico.Properties.Resources.cancelar1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(26, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 44);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LaboratorioClinico.Properties.Resources.confirm;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(26, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 44);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Dgv_verBeneficios
            // 
            this.Dgv_verBeneficios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_verBeneficios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_verBeneficios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_verBeneficios.Location = new System.Drawing.Point(19, 236);
            this.Dgv_verBeneficios.Name = "Dgv_verBeneficios";
            this.Dgv_verBeneficios.Size = new System.Drawing.Size(537, 188);
            this.Dgv_verBeneficios.TabIndex = 38;
            // 
            // Gpb_datosPersonales
            // 
            this.Gpb_datosPersonales.Controls.Add(this.Txt_nit);
            this.Gpb_datosPersonales.Controls.Add(this.Txt_nombre);
            this.Gpb_datosPersonales.Controls.Add(this.Lbl_nit);
            this.Gpb_datosPersonales.Controls.Add(this.Lbl_nombre);
            this.Gpb_datosPersonales.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosPersonales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gpb_datosPersonales.Location = new System.Drawing.Point(19, 115);
            this.Gpb_datosPersonales.Name = "Gpb_datosPersonales";
            this.Gpb_datosPersonales.Size = new System.Drawing.Size(665, 103);
            this.Gpb_datosPersonales.TabIndex = 37;
            this.Gpb_datosPersonales.TabStop = false;
            this.Gpb_datosPersonales.Text = "Datos Personales";
            // 
            // Txt_nit
            // 
            this.Txt_nit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nit.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nit.ForeColor = System.Drawing.Color.Black;
            this.Txt_nit.Location = new System.Drawing.Point(118, 47);
            this.Txt_nit.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nit.Name = "Txt_nit";
            this.Txt_nit.Size = new System.Drawing.Size(197, 26);
            this.Txt_nit.TabIndex = 15;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nombre.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.Txt_nombre.Location = new System.Drawing.Point(400, 47);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(197, 26);
            this.Txt_nombre.TabIndex = 13;
            // 
            // Lbl_nit
            // 
            this.Lbl_nit.AutoSize = true;
            this.Lbl_nit.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nit.ForeColor = System.Drawing.Color.White;
            this.Lbl_nit.Location = new System.Drawing.Point(82, 50);
            this.Lbl_nit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nit.Name = "Lbl_nit";
            this.Lbl_nit.Size = new System.Drawing.Size(28, 18);
            this.Lbl_nit.TabIndex = 14;
            this.Lbl_nit.Text = "Nit";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.Lbl_nombre.Location = new System.Drawing.Point(339, 50);
            this.Lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(58, 18);
            this.Lbl_nombre.TabIndex = 10;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.file;
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_buscar.Location = new System.Drawing.Point(533, 44);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(53, 44);
            this.Btn_buscar.TabIndex = 36;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "DPI";
            // 
            // Txt_DPI
            // 
            this.Txt_DPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_DPI.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DPI.ForeColor = System.Drawing.Color.Black;
            this.Txt_DPI.Location = new System.Drawing.Point(87, 53);
            this.Txt_DPI.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DPI.Name = "Txt_DPI";
            this.Txt_DPI.Size = new System.Drawing.Size(197, 26);
            this.Txt_DPI.TabIndex = 34;
            // 
            // Comprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Gpb_buscarCita);
            this.DoubleBuffered = true;
            this.Name = "Comprobacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Gpb_buscarCita.ResumeLayout(false);
            this.Gpb_buscarCita.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_verBeneficios)).EndInit();
            this.Gpb_datosPersonales.ResumeLayout(false);
            this.Gpb_datosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_buscarCita;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_DPI;
        private System.Windows.Forms.GroupBox Gpb_datosPersonales;
        private System.Windows.Forms.TextBox Txt_nit;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_nit;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Dgv_verBeneficios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
    }
}