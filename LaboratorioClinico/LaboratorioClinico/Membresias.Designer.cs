namespace LaboratorioClinico
{
    partial class Membresias
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
            this.Dgv_verBeneficios = new System.Windows.Forms.DataGridView();
            this.Lbl_buscar = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Gpb_datosPersonales = new System.Windows.Forms.GroupBox();
            this.Btn_Beneficios = new System.Windows.Forms.Button();
            this.Lbl_beneficios = new System.Windows.Forms.Label();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_membresia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_nit = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nit = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Txt_DPI = new System.Windows.Forms.TextBox();
            this.Gpb_datosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_verBeneficios)).BeginInit();
            this.Gpb_datosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_datosEmpleado
            // 
            this.Gpb_datosEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_datosEmpleado.Controls.Add(this.Dgv_verBeneficios);
            this.Gpb_datosEmpleado.Controls.Add(this.Lbl_buscar);
            this.Gpb_datosEmpleado.Controls.Add(this.Btn_buscar);
            this.Gpb_datosEmpleado.Controls.Add(this.label5);
            this.Gpb_datosEmpleado.Controls.Add(this.Gpb_datosPersonales);
            this.Gpb_datosEmpleado.Controls.Add(this.Txt_DPI);
            this.Gpb_datosEmpleado.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosEmpleado.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_datosEmpleado.Location = new System.Drawing.Point(12, 12);
            this.Gpb_datosEmpleado.Name = "Gpb_datosEmpleado";
            this.Gpb_datosEmpleado.Size = new System.Drawing.Size(736, 460);
            this.Gpb_datosEmpleado.TabIndex = 1;
            this.Gpb_datosEmpleado.TabStop = false;
            this.Gpb_datosEmpleado.Text = "Solicitud de membresía";
            // 
            // Dgv_verBeneficios
            // 
            this.Dgv_verBeneficios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_verBeneficios.Location = new System.Drawing.Point(26, 269);
            this.Dgv_verBeneficios.Name = "Dgv_verBeneficios";
            this.Dgv_verBeneficios.Size = new System.Drawing.Size(684, 171);
            this.Dgv_verBeneficios.TabIndex = 35;
            // 
            // Lbl_buscar
            // 
            this.Lbl_buscar.AutoSize = true;
            this.Lbl_buscar.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_buscar.ForeColor = System.Drawing.Color.PowderBlue;
            this.Lbl_buscar.Location = new System.Drawing.Point(306, 81);
            this.Lbl_buscar.Name = "Lbl_buscar";
            this.Lbl_buscar.Size = new System.Drawing.Size(38, 15);
            this.Lbl_buscar.TabIndex = 34;
            this.Lbl_buscar.Text = "Buscar";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.file;
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_buscar.Location = new System.Drawing.Point(301, 34);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(53, 44);
            this.Btn_buscar.TabIndex = 33;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "DPI";
            // 
            // Gpb_datosPersonales
            // 
            this.Gpb_datosPersonales.Controls.Add(this.Btn_Beneficios);
            this.Gpb_datosPersonales.Controls.Add(this.Lbl_beneficios);
            this.Gpb_datosPersonales.Controls.Add(this.Btn_agregar);
            this.Gpb_datosPersonales.Controls.Add(this.label2);
            this.Gpb_datosPersonales.Controls.Add(this.Cmb_membresia);
            this.Gpb_datosPersonales.Controls.Add(this.label1);
            this.Gpb_datosPersonales.Controls.Add(this.Txt_nit);
            this.Gpb_datosPersonales.Controls.Add(this.Txt_nombre);
            this.Gpb_datosPersonales.Controls.Add(this.Lbl_nit);
            this.Gpb_datosPersonales.Controls.Add(this.Lbl_nombre);
            this.Gpb_datosPersonales.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosPersonales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gpb_datosPersonales.Location = new System.Drawing.Point(26, 99);
            this.Gpb_datosPersonales.Name = "Gpb_datosPersonales";
            this.Gpb_datosPersonales.Size = new System.Drawing.Size(684, 164);
            this.Gpb_datosPersonales.TabIndex = 0;
            this.Gpb_datosPersonales.TabStop = false;
            this.Gpb_datosPersonales.Text = "Datos Personales";
            // 
            // Btn_Beneficios
            // 
            this.Btn_Beneficios.BackgroundImage = global::LaboratorioClinico.Properties.Resources.requerimientos;
            this.Btn_Beneficios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Beneficios.Location = new System.Drawing.Point(464, 95);
            this.Btn_Beneficios.Name = "Btn_Beneficios";
            this.Btn_Beneficios.Size = new System.Drawing.Size(53, 44);
            this.Btn_Beneficios.TabIndex = 38;
            this.Btn_Beneficios.UseVisualStyleBackColor = true;
            this.Btn_Beneficios.Click += new System.EventHandler(this.Btn_Beneficios_Click);
            // 
            // Lbl_beneficios
            // 
            this.Lbl_beneficios.AutoSize = true;
            this.Lbl_beneficios.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_beneficios.ForeColor = System.Drawing.Color.PowderBlue;
            this.Lbl_beneficios.Location = new System.Drawing.Point(461, 142);
            this.Lbl_beneficios.Name = "Lbl_beneficios";
            this.Lbl_beneficios.Size = new System.Drawing.Size(54, 15);
            this.Lbl_beneficios.TabIndex = 39;
            this.Lbl_beneficios.Text = "Beneficios";
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.anadir;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_agregar.Location = new System.Drawing.Point(541, 95);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(53, 44);
            this.Btn_agregar.TabIndex = 37;
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(546, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Agregar";
            // 
            // Cmb_membresia
            // 
            this.Cmb_membresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Cmb_membresia.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_membresia.FormattingEnabled = true;
            this.Cmb_membresia.Location = new System.Drawing.Point(428, 49);
            this.Cmb_membresia.Name = "Cmb_membresia";
            this.Cmb_membresia.Size = new System.Drawing.Size(197, 26);
            this.Cmb_membresia.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Membresía";
            // 
            // Txt_nit
            // 
            this.Txt_nit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nit.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nit.ForeColor = System.Drawing.Color.Black;
            this.Txt_nit.Location = new System.Drawing.Point(90, 83);
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
            this.Txt_nombre.Location = new System.Drawing.Point(90, 49);
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
            this.Lbl_nit.Location = new System.Drawing.Point(16, 84);
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
            this.Lbl_nombre.Location = new System.Drawing.Point(16, 48);
            this.Lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(58, 18);
            this.Lbl_nombre.TabIndex = 10;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Txt_DPI
            // 
            this.Txt_DPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_DPI.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DPI.ForeColor = System.Drawing.Color.Black;
            this.Txt_DPI.Location = new System.Drawing.Point(97, 46);
            this.Txt_DPI.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DPI.Name = "Txt_DPI";
            this.Txt_DPI.Size = new System.Drawing.Size(197, 26);
            this.Txt_DPI.TabIndex = 28;
            // 
            // Membresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Gpb_datosEmpleado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Membresias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Gpb_datosEmpleado.ResumeLayout(false);
            this.Gpb_datosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_verBeneficios)).EndInit();
            this.Gpb_datosPersonales.ResumeLayout(false);
            this.Gpb_datosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_datosEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Gpb_datosPersonales;
        private System.Windows.Forms.TextBox Txt_nit;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.TextBox Txt_DPI;
        private System.Windows.Forms.Label Lbl_buscar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_nit;
        private System.Windows.Forms.ComboBox Cmb_membresia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Beneficios;
        private System.Windows.Forms.Label Lbl_beneficios;
        private System.Windows.Forms.DataGridView Dgv_verBeneficios;
    }
}