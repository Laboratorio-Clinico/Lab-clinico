namespace LaboratorioClinico
{
    partial class SolicitudDeMembresia
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
            this.Gpb_membresía = new System.Windows.Forms.GroupBox();
            this.Dgv_mostrarBeneficios = new System.Windows.Forms.DataGridView();
            this.Txt_DPI = new System.Windows.Forms.TextBox();
            this.Lbl_buscar = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Gpb_Datos = new System.Windows.Forms.GroupBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_membresia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_nit = new System.Windows.Forms.TextBox();
            this.Btn_beneficios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_apellido = new System.Windows.Forms.Label();
            this.Lbl_DPI = new System.Windows.Forms.Label();
            this.Gpb_membresía.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarBeneficios)).BeginInit();
            this.Gpb_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_membresía
            // 
            this.Gpb_membresía.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_membresía.Controls.Add(this.Dgv_mostrarBeneficios);
            this.Gpb_membresía.Controls.Add(this.Txt_DPI);
            this.Gpb_membresía.Controls.Add(this.Lbl_buscar);
            this.Gpb_membresía.Controls.Add(this.Btn_buscar);
            this.Gpb_membresía.Controls.Add(this.Gpb_Datos);
            this.Gpb_membresía.Controls.Add(this.Lbl_DPI);
            this.Gpb_membresía.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_membresía.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_membresía.Location = new System.Drawing.Point(22, 12);
            this.Gpb_membresía.Name = "Gpb_membresía";
            this.Gpb_membresía.Size = new System.Drawing.Size(716, 465);
            this.Gpb_membresía.TabIndex = 0;
            this.Gpb_membresía.TabStop = false;
            this.Gpb_membresía.Text = "Solicitud de membresía";
            // 
            // Dgv_mostrarBeneficios
            // 
            this.Dgv_mostrarBeneficios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_mostrarBeneficios.Location = new System.Drawing.Point(29, 275);
            this.Dgv_mostrarBeneficios.Name = "Dgv_mostrarBeneficios";
            this.Dgv_mostrarBeneficios.Size = new System.Drawing.Size(653, 168);
            this.Dgv_mostrarBeneficios.TabIndex = 35;
            // 
            // Txt_DPI
            // 
            this.Txt_DPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_DPI.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DPI.ForeColor = System.Drawing.Color.Black;
            this.Txt_DPI.Location = new System.Drawing.Point(109, 41);
            this.Txt_DPI.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DPI.Name = "Txt_DPI";
            this.Txt_DPI.Size = new System.Drawing.Size(197, 26);
            this.Txt_DPI.TabIndex = 14;
            // 
            // Lbl_buscar
            // 
            this.Lbl_buscar.AutoSize = true;
            this.Lbl_buscar.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_buscar.ForeColor = System.Drawing.Color.PowderBlue;
            this.Lbl_buscar.Location = new System.Drawing.Point(336, 76);
            this.Lbl_buscar.Name = "Lbl_buscar";
            this.Lbl_buscar.Size = new System.Drawing.Size(38, 15);
            this.Lbl_buscar.TabIndex = 34;
            this.Lbl_buscar.Text = "Buscar";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.file;
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_buscar.Location = new System.Drawing.Point(330, 29);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(53, 44);
            this.Btn_buscar.TabIndex = 33;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Gpb_Datos
            // 
            this.Gpb_Datos.Controls.Add(this.Btn_agregar);
            this.Gpb_Datos.Controls.Add(this.label2);
            this.Gpb_Datos.Controls.Add(this.Cmb_membresia);
            this.Gpb_Datos.Controls.Add(this.label3);
            this.Gpb_Datos.Controls.Add(this.Txt_nit);
            this.Gpb_Datos.Controls.Add(this.Btn_beneficios);
            this.Gpb_Datos.Controls.Add(this.label1);
            this.Gpb_Datos.Controls.Add(this.Lbl_nombre);
            this.Gpb_Datos.Controls.Add(this.Txt_nombre);
            this.Gpb_Datos.Controls.Add(this.Lbl_apellido);
            this.Gpb_Datos.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Datos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gpb_Datos.Location = new System.Drawing.Point(29, 94);
            this.Gpb_Datos.Name = "Gpb_Datos";
            this.Gpb_Datos.Size = new System.Drawing.Size(653, 162);
            this.Gpb_Datos.TabIndex = 15;
            this.Gpb_Datos.TabStop = false;
            this.Gpb_Datos.Text = "Datos Personales";
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.anadir;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_agregar.Location = new System.Drawing.Point(533, 91);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(53, 44);
            this.Btn_agregar.TabIndex = 37;
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Visible = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(543, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Agregar";
            this.label2.Visible = false;
            // 
            // Cmb_membresia
            // 
            this.Cmb_membresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Cmb_membresia.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_membresia.FormattingEnabled = true;
            this.Cmb_membresia.Location = new System.Drawing.Point(426, 45);
            this.Cmb_membresia.Name = "Cmb_membresia";
            this.Cmb_membresia.Size = new System.Drawing.Size(197, 26);
            this.Cmb_membresia.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(464, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Beneficios";
            this.label3.Visible = false;
            // 
            // Txt_nit
            // 
            this.Txt_nit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nit.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nit.ForeColor = System.Drawing.Color.Black;
            this.Txt_nit.Location = new System.Drawing.Point(98, 79);
            this.Txt_nit.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nit.Name = "Txt_nit";
            this.Txt_nit.Size = new System.Drawing.Size(197, 26);
            this.Txt_nit.TabIndex = 13;
            // 
            // Btn_beneficios
            // 
            this.Btn_beneficios.BackgroundImage = global::LaboratorioClinico.Properties.Resources.requerimientos;
            this.Btn_beneficios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_beneficios.Location = new System.Drawing.Point(465, 91);
            this.Btn_beneficios.Name = "Btn_beneficios";
            this.Btn_beneficios.Size = new System.Drawing.Size(53, 44);
            this.Btn_beneficios.TabIndex = 38;
            this.Btn_beneficios.UseVisualStyleBackColor = true;
            this.Btn_beneficios.Visible = false;
            this.Btn_beneficios.Click += new System.EventHandler(this.Btn_beneficios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Membresía";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.Lbl_nombre.Location = new System.Drawing.Point(22, 47);
            this.Lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(58, 18);
            this.Lbl_nombre.TabIndex = 9;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nombre.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.Txt_nombre.Location = new System.Drawing.Point(98, 45);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(197, 26);
            this.Txt_nombre.TabIndex = 11;
            // 
            // Lbl_apellido
            // 
            this.Lbl_apellido.AutoSize = true;
            this.Lbl_apellido.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_apellido.ForeColor = System.Drawing.Color.White;
            this.Lbl_apellido.Location = new System.Drawing.Point(22, 80);
            this.Lbl_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_apellido.Name = "Lbl_apellido";
            this.Lbl_apellido.Size = new System.Drawing.Size(28, 18);
            this.Lbl_apellido.TabIndex = 12;
            this.Lbl_apellido.Text = "Nit";
            // 
            // Lbl_DPI
            // 
            this.Lbl_DPI.AutoSize = true;
            this.Lbl_DPI.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DPI.ForeColor = System.Drawing.Color.White;
            this.Lbl_DPI.Location = new System.Drawing.Point(33, 44);
            this.Lbl_DPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DPI.Name = "Lbl_DPI";
            this.Lbl_DPI.Size = new System.Drawing.Size(31, 18);
            this.Lbl_DPI.TabIndex = 10;
            this.Lbl_DPI.Text = "DPI";
            // 
            // SolicitudDeMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Gpb_membresía);
            this.DoubleBuffered = true;
            this.Name = "SolicitudDeMembresia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Gpb_membresía.ResumeLayout(false);
            this.Gpb_membresía.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarBeneficios)).EndInit();
            this.Gpb_Datos.ResumeLayout(false);
            this.Gpb_Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_membresía;
        private System.Windows.Forms.TextBox Txt_nit;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_DPI;
        private System.Windows.Forms.Label Lbl_apellido;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.TextBox Txt_DPI;
        private System.Windows.Forms.GroupBox Gpb_Datos;
        private System.Windows.Forms.Label Lbl_buscar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.ComboBox Cmb_membresia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_mostrarBeneficios;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_beneficios;
    }
}