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
            this.Gpb_llenador = new System.Windows.Forms.GroupBox();
            this.Txt_requerimientos = new System.Windows.Forms.TextBox();
            this.Lbl_nombrer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_buscarr = new System.Windows.Forms.Label();
            this.Gpb_requisitos = new System.Windows.Forms.GroupBox();
            this.Cmb_examen = new System.Windows.Forms.ComboBox();
            this.Gpb_llenador.SuspendLayout();
            this.Gpb_requisitos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_llenador
            // 
            this.Gpb_llenador.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_llenador.Controls.Add(this.Txt_requerimientos);
            this.Gpb_llenador.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_llenador.Location = new System.Drawing.Point(75, 150);
            this.Gpb_llenador.Name = "Gpb_llenador";
            this.Gpb_llenador.Size = new System.Drawing.Size(542, 239);
            this.Gpb_llenador.TabIndex = 0;
            this.Gpb_llenador.TabStop = false;
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
            // Lbl_nombrer
            // 
            this.Lbl_nombrer.AllowDrop = true;
            this.Lbl_nombrer.AutoSize = true;
            this.Lbl_nombrer.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nombrer.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombrer.ForeColor = System.Drawing.Color.White;
            this.Lbl_nombrer.Location = new System.Drawing.Point(76, 82);
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
            this.button1.Location = new System.Drawing.Point(499, 72);
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
            this.Lbl_buscarr.Location = new System.Drawing.Point(514, 119);
            this.Lbl_buscarr.Name = "Lbl_buscarr";
            this.Lbl_buscarr.Size = new System.Drawing.Size(24, 15);
            this.Lbl_buscarr.TabIndex = 4;
            this.Lbl_buscarr.Text = "Ver";
            // 
            // Gpb_requisitos
            // 
            this.Gpb_requisitos.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_requisitos.Controls.Add(this.button1);
            this.Gpb_requisitos.Controls.Add(this.Cmb_examen);
            this.Gpb_requisitos.Controls.Add(this.Gpb_llenador);
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
            // Cmb_examen
            // 
            this.Cmb_examen.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_examen.FormattingEnabled = true;
            this.Cmb_examen.Location = new System.Drawing.Point(213, 81);
            this.Cmb_examen.Name = "Cmb_examen";
            this.Cmb_examen.Size = new System.Drawing.Size(267, 26);
            this.Cmb_examen.TabIndex = 3;
            this.Cmb_examen.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.Cmb_examen.Click += new System.EventHandler(this.Cmb_examen_Click);
            // 
            // Requerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Gpb_requisitos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Requerimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Requerimientos_Load);
            this.Gpb_llenador.ResumeLayout(false);
            this.Gpb_llenador.PerformLayout();
            this.Gpb_requisitos.ResumeLayout(false);
            this.Gpb_requisitos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_llenador;
        private System.Windows.Forms.Label Lbl_nombrer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_buscarr;
        private System.Windows.Forms.GroupBox Gpb_requisitos;
        private System.Windows.Forms.ComboBox Cmb_examen;
        private System.Windows.Forms.TextBox Txt_requerimientos;
    }
}