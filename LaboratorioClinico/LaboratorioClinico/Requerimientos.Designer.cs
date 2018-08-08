namespace LaboratorioClinico
{
    partial class Requerimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requerimientos));
            this.Gpb_llenador = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Lbl_nombrer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_buscarr = new System.Windows.Forms.Label();
            this.Lbl_imprimirr = new System.Windows.Forms.Label();
            this.Gpb_fechar = new System.Windows.Forms.GroupBox();
            this.Dtp_fechar = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fechar = new System.Windows.Forms.Label();
            this.Gpb_imprimirr = new System.Windows.Forms.GroupBox();
            this.Gpb_requisitos = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Cmb_examen = new System.Windows.Forms.ComboBox();
            this.Txt_requerimientos = new System.Windows.Forms.TextBox();
            this.Gpb_llenador.SuspendLayout();
            this.Gpb_fechar.SuspendLayout();
            this.Gpb_imprimirr.SuspendLayout();
            this.Gpb_requisitos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_llenador
            // 
            this.Gpb_llenador.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_llenador.Controls.Add(this.Txt_requerimientos);
            this.Gpb_llenador.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_llenador.Location = new System.Drawing.Point(94, 124);
            this.Gpb_llenador.Name = "Gpb_llenador";
            this.Gpb_llenador.Size = new System.Drawing.Size(542, 239);
            this.Gpb_llenador.TabIndex = 0;
            this.Gpb_llenador.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(203, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 44);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbl_nombrer
            // 
            this.Lbl_nombrer.AllowDrop = true;
            this.Lbl_nombrer.AutoSize = true;
            this.Lbl_nombrer.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nombrer.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombrer.ForeColor = System.Drawing.Color.White;
            this.Lbl_nombrer.Location = new System.Drawing.Point(71, 50);
            this.Lbl_nombrer.Name = "Lbl_nombrer";
            this.Lbl_nombrer.Size = new System.Drawing.Size(131, 22);
            this.Lbl_nombrer.TabIndex = 2;
            this.Lbl_nombrer.Text = "Nombre Examen";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LaboratorioClinico.Properties.Resources.file;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(525, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 44);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_buscarr
            // 
            this.Lbl_buscarr.AutoSize = true;
            this.Lbl_buscarr.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_buscarr.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_buscarr.ForeColor = System.Drawing.Color.White;
            this.Lbl_buscarr.Location = new System.Drawing.Point(511, 80);
            this.Lbl_buscarr.Name = "Lbl_buscarr";
            this.Lbl_buscarr.Size = new System.Drawing.Size(24, 15);
            this.Lbl_buscarr.TabIndex = 4;
            this.Lbl_buscarr.Text = "Ver";
            // 
            // Lbl_imprimirr
            // 
            this.Lbl_imprimirr.AutoSize = true;
            this.Lbl_imprimirr.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_imprimirr.ForeColor = System.Drawing.Color.White;
            this.Lbl_imprimirr.Location = new System.Drawing.Point(208, 66);
            this.Lbl_imprimirr.Name = "Lbl_imprimirr";
            this.Lbl_imprimirr.Size = new System.Drawing.Size(48, 15);
            this.Lbl_imprimirr.TabIndex = 5;
            this.Lbl_imprimirr.Text = "Imprimir";
            // 
            // Gpb_fechar
            // 
            this.Gpb_fechar.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_fechar.Controls.Add(this.Dtp_fechar);
            this.Gpb_fechar.Controls.Add(this.Lbl_fechar);
            this.Gpb_fechar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_fechar.Location = new System.Drawing.Point(94, 369);
            this.Gpb_fechar.Name = "Gpb_fechar";
            this.Gpb_fechar.Size = new System.Drawing.Size(268, 84);
            this.Gpb_fechar.TabIndex = 1;
            this.Gpb_fechar.TabStop = false;
            this.Gpb_fechar.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Dtp_fechar
            // 
            this.Dtp_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtp_fechar.CustomFormat = "dd-MM-yy";
            this.Dtp_fechar.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Dtp_fechar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechar.Location = new System.Drawing.Point(132, 35);
            this.Dtp_fechar.Name = "Dtp_fechar";
            this.Dtp_fechar.Size = new System.Drawing.Size(104, 26);
            this.Dtp_fechar.TabIndex = 22;
            // 
            // Lbl_fechar
            // 
            this.Lbl_fechar.AutoSize = true;
            this.Lbl_fechar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechar.ForeColor = System.Drawing.Color.White;
            this.Lbl_fechar.Location = new System.Drawing.Point(18, 41);
            this.Lbl_fechar.Name = "Lbl_fechar";
            this.Lbl_fechar.Size = new System.Drawing.Size(107, 22);
            this.Lbl_fechar.TabIndex = 5;
            this.Lbl_fechar.Text = "Fecha emisión";
            this.Lbl_fechar.Click += new System.EventHandler(this.label4_Click);
            // 
            // Gpb_imprimirr
            // 
            this.Gpb_imprimirr.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_imprimirr.Controls.Add(this.button2);
            this.Gpb_imprimirr.Controls.Add(this.Lbl_imprimirr);
            this.Gpb_imprimirr.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_imprimirr.Location = new System.Drawing.Point(368, 369);
            this.Gpb_imprimirr.Name = "Gpb_imprimirr";
            this.Gpb_imprimirr.Size = new System.Drawing.Size(268, 84);
            this.Gpb_imprimirr.TabIndex = 23;
            this.Gpb_imprimirr.TabStop = false;
            // 
            // Gpb_requisitos
            // 
            this.Gpb_requisitos.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_requisitos.Controls.Add(this.button3);
            this.Gpb_requisitos.Controls.Add(this.Cmb_examen);
            this.Gpb_requisitos.Controls.Add(this.Lbl_nombrer);
            this.Gpb_requisitos.Controls.Add(this.Lbl_buscarr);
            this.Gpb_requisitos.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_requisitos.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_requisitos.Location = new System.Drawing.Point(31, 12);
            this.Gpb_requisitos.Name = "Gpb_requisitos";
            this.Gpb_requisitos.Size = new System.Drawing.Size(723, 465);
            this.Gpb_requisitos.TabIndex = 24;
            this.Gpb_requisitos.TabStop = false;
            this.Gpb_requisitos.Text = "Requisitos";
            this.Gpb_requisitos.Enter += new System.EventHandler(this.Gpb_requisitos_Enter);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(664, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 44);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Cmb_examen
            // 
            this.Cmb_examen.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_examen.FormattingEnabled = true;
            this.Cmb_examen.Location = new System.Drawing.Point(208, 49);
            this.Cmb_examen.Name = "Cmb_examen";
            this.Cmb_examen.Size = new System.Drawing.Size(267, 26);
            this.Cmb_examen.TabIndex = 3;
            this.Cmb_examen.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Txt_requerimientos
            // 
            this.Txt_requerimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_requerimientos.Location = new System.Drawing.Point(3, 22);
            this.Txt_requerimientos.Multiline = true;
            this.Txt_requerimientos.Name = "Txt_requerimientos";
            this.Txt_requerimientos.Size = new System.Drawing.Size(536, 214);
            this.Txt_requerimientos.TabIndex = 1;
            // 
            // Requerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Gpb_imprimirr);
            this.Controls.Add(this.Gpb_fechar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gpb_llenador);
            this.Controls.Add(this.Gpb_requisitos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Requerimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Requerimientos_Load);
            this.Gpb_llenador.ResumeLayout(false);
            this.Gpb_llenador.PerformLayout();
            this.Gpb_fechar.ResumeLayout(false);
            this.Gpb_fechar.PerformLayout();
            this.Gpb_imprimirr.ResumeLayout(false);
            this.Gpb_imprimirr.PerformLayout();
            this.Gpb_requisitos.ResumeLayout(false);
            this.Gpb_requisitos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_llenador;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Lbl_nombrer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Gpb_fechar;
        private System.Windows.Forms.Label Lbl_buscarr;
        private System.Windows.Forms.Label Lbl_imprimirr;
        private System.Windows.Forms.Label Lbl_fechar;
        private System.Windows.Forms.DateTimePicker Dtp_fechar;
        private System.Windows.Forms.GroupBox Gpb_imprimirr;
        private System.Windows.Forms.GroupBox Gpb_requisitos;
        private System.Windows.Forms.ComboBox Cmb_examen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Txt_requerimientos;
    }
}