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
            this.Gpb_examen = new System.Windows.Forms.GroupBox();
            this.Lbl_precioHemogramaC = new System.Windows.Forms.Label();
            this.Lbl_qHemogramaC = new System.Windows.Forms.Label();
            this.Lbl_hemogramaC = new System.Windows.Forms.Label();
            this.Pcb_hemogramaC = new System.Windows.Forms.PictureBox();
            this.Gpb_examen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_hemogramaC)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_examen
            // 
            this.Gpb_examen.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_examen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gpb_examen.Controls.Add(this.Lbl_precioHemogramaC);
            this.Gpb_examen.Controls.Add(this.Lbl_qHemogramaC);
            this.Gpb_examen.Controls.Add(this.Lbl_hemogramaC);
            this.Gpb_examen.Controls.Add(this.Pcb_hemogramaC);
            this.Gpb_examen.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_examen.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_examen.Location = new System.Drawing.Point(21, 12);
            this.Gpb_examen.Name = "Gpb_examen";
            this.Gpb_examen.Size = new System.Drawing.Size(732, 504);
            this.Gpb_examen.TabIndex = 12;
            this.Gpb_examen.TabStop = false;
            this.Gpb_examen.Text = "Información Exámenes";
            this.Gpb_examen.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Lbl_precioHemogramaC
            // 
            this.Lbl_precioHemogramaC.AutoSize = true;
            this.Lbl_precioHemogramaC.ForeColor = System.Drawing.Color.Honeydew;
            this.Lbl_precioHemogramaC.Location = new System.Drawing.Point(511, 174);
            this.Lbl_precioHemogramaC.Name = "Lbl_precioHemogramaC";
            this.Lbl_precioHemogramaC.Size = new System.Drawing.Size(62, 33);
            this.Lbl_precioHemogramaC.TabIndex = 3;
            this.Lbl_precioHemogramaC.Text = "0.00";
            // 
            // Lbl_qHemogramaC
            // 
            this.Lbl_qHemogramaC.AutoSize = true;
            this.Lbl_qHemogramaC.ForeColor = System.Drawing.Color.Honeydew;
            this.Lbl_qHemogramaC.Location = new System.Drawing.Point(477, 174);
            this.Lbl_qHemogramaC.Name = "Lbl_qHemogramaC";
            this.Lbl_qHemogramaC.Size = new System.Drawing.Size(44, 33);
            this.Lbl_qHemogramaC.TabIndex = 2;
            this.Lbl_qHemogramaC.Text = "Q.";
            // 
            // Lbl_hemogramaC
            // 
            this.Lbl_hemogramaC.AutoSize = true;
            this.Lbl_hemogramaC.ForeColor = System.Drawing.Color.Honeydew;
            this.Lbl_hemogramaC.Location = new System.Drawing.Point(390, 128);
            this.Lbl_hemogramaC.Name = "Lbl_hemogramaC";
            this.Lbl_hemogramaC.Size = new System.Drawing.Size(295, 33);
            this.Lbl_hemogramaC.TabIndex = 1;
            this.Lbl_hemogramaC.Text = "Hemograma Completo";
            // 
            // Pcb_hemogramaC
            // 
            this.Pcb_hemogramaC.Image = global::LaboratorioClinico.Properties.Resources.hemograma;
            this.Pcb_hemogramaC.Location = new System.Drawing.Point(35, 63);
            this.Pcb_hemogramaC.Name = "Pcb_hemogramaC";
            this.Pcb_hemogramaC.Size = new System.Drawing.Size(310, 217);
            this.Pcb_hemogramaC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcb_hemogramaC.TabIndex = 0;
            this.Pcb_hemogramaC.TabStop = false;
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
            this.Gpb_examen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_hemogramaC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Gpb_examen;
        private System.Windows.Forms.Label Lbl_precioHemogramaC;
        private System.Windows.Forms.Label Lbl_qHemogramaC;
        private System.Windows.Forms.Label Lbl_hemogramaC;
        private System.Windows.Forms.PictureBox Pcb_hemogramaC;
    }
}