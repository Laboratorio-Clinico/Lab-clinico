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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exámen));
            this.Dgv_examen = new System.Windows.Forms.DataGridView();
            this.Lbl_examen = new System.Windows.Forms.Label();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_precio = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_quetzal = new System.Windows.Forms.Label();
            this.Txt_precio = new System.Windows.Forms.TextBox();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Btn_confirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_examen)).BeginInit();
            this.Gpb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_examen
            // 
            this.Dgv_examen.AllowUserToOrderColumns = true;
            this.Dgv_examen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_examen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_examen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Dgv_examen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_examen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_examen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_examen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_examen.ColumnHeadersHeight = 27;
            this.Dgv_examen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_examen.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_examen.EnableHeadersVisualStyles = false;
            this.Dgv_examen.Location = new System.Drawing.Point(38, 68);
            this.Dgv_examen.Name = "Dgv_examen";
            this.Dgv_examen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_examen.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_examen.Size = new System.Drawing.Size(372, 435);
            this.Dgv_examen.TabIndex = 10;
            this.Dgv_examen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_examen_CellContentClick);
            // 
            // Lbl_examen
            // 
            this.Lbl_examen.AutoSize = true;
            this.Lbl_examen.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_examen.Font = new System.Drawing.Font("Perpetua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_examen.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Lbl_examen.Location = new System.Drawing.Point(319, 22);
            this.Lbl_examen.Name = "Lbl_examen";
            this.Lbl_examen.Size = new System.Drawing.Size(150, 36);
            this.Lbl_examen.TabIndex = 13;
            this.Lbl_examen.Text = "Exámenes";
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_editar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.editar2;
            this.Btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_editar.Location = new System.Drawing.Point(427, 68);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(53, 44);
            this.Btn_editar.TabIndex = 96;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_eliminar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.boton_x;
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_eliminar.Location = new System.Drawing.Point(486, 68);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(53, 44);
            this.Btn_eliminar.TabIndex = 97;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_codigo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Txt_codigo.Location = new System.Drawing.Point(32, 49);
            this.Txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(127, 26);
            this.Txt_codigo.TabIndex = 98;
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_codigo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo.ForeColor = System.Drawing.Color.White;
            this.Lbl_codigo.Location = new System.Drawing.Point(14, 33);
            this.Lbl_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(100, 18);
            this.Lbl_codigo.TabIndex = 99;
            this.Lbl_codigo.Text = "Código exámen";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nombre.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.Lbl_nombre.Location = new System.Drawing.Point(17, 80);
            this.Lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(58, 18);
            this.Lbl_nombre.TabIndex = 100;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Lbl_precio
            // 
            this.Lbl_precio.AutoSize = true;
            this.Lbl_precio.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_precio.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_precio.ForeColor = System.Drawing.Color.White;
            this.Lbl_precio.Location = new System.Drawing.Point(180, 33);
            this.Lbl_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_precio.Name = "Lbl_precio";
            this.Lbl_precio.Size = new System.Drawing.Size(46, 18);
            this.Lbl_precio.TabIndex = 101;
            this.Lbl_precio.Text = "Precio";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nombre.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Txt_nombre.Location = new System.Drawing.Point(32, 96);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(253, 26);
            this.Txt_nombre.TabIndex = 102;
            // 
            // Lbl_quetzal
            // 
            this.Lbl_quetzal.AutoSize = true;
            this.Lbl_quetzal.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_quetzal.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_quetzal.ForeColor = System.Drawing.Color.White;
            this.Lbl_quetzal.Location = new System.Drawing.Point(167, 52);
            this.Lbl_quetzal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_quetzal.Name = "Lbl_quetzal";
            this.Lbl_quetzal.Size = new System.Drawing.Size(25, 18);
            this.Lbl_quetzal.TabIndex = 103;
            this.Lbl_quetzal.Text = "Q.";
            // 
            // Txt_precio
            // 
            this.Txt_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_precio.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precio.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Txt_precio.Location = new System.Drawing.Point(192, 49);
            this.Txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_precio.Name = "Txt_precio";
            this.Txt_precio.Size = new System.Drawing.Size(74, 26);
            this.Txt_precio.TabIndex = 104;
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_datos.Controls.Add(this.Txt_precio);
            this.Gpb_datos.Controls.Add(this.Txt_codigo);
            this.Gpb_datos.Controls.Add(this.Lbl_quetzal);
            this.Gpb_datos.Controls.Add(this.Lbl_codigo);
            this.Gpb_datos.Controls.Add(this.Txt_nombre);
            this.Gpb_datos.Controls.Add(this.Lbl_nombre);
            this.Gpb_datos.Controls.Add(this.Lbl_precio);
            this.Gpb_datos.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gpb_datos.Location = new System.Drawing.Point(437, 194);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Size = new System.Drawing.Size(304, 141);
            this.Gpb_datos.TabIndex = 119;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            this.Gpb_datos.Visible = false;
            // 
            // Btn_confirmar
            // 
            this.Btn_confirmar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_confirmar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.comprobado;
            this.Btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_confirmar.Location = new System.Drawing.Point(688, 341);
            this.Btn_confirmar.Name = "Btn_confirmar";
            this.Btn_confirmar.Size = new System.Drawing.Size(53, 44);
            this.Btn_confirmar.TabIndex = 105;
            this.Btn_confirmar.UseVisualStyleBackColor = false;
            // 
            // Exámen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 528);
            this.Controls.Add(this.Btn_confirmar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Lbl_examen);
            this.Controls.Add(this.Dgv_examen);
            this.Controls.Add(this.Gpb_datos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exámen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Exámen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_examen)).EndInit();
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_examen;
        private System.Windows.Forms.Label Lbl_examen;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_precio;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_quetzal;
        private System.Windows.Forms.TextBox Txt_precio;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.Button Btn_confirmar;
    }
}