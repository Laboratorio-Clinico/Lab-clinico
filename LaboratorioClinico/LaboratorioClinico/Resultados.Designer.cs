namespace LaboratorioClinico
{
    partial class Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_resultados = new System.Windows.Forms.DataGridView();
            this.Lbl_expe = new System.Windows.Forms.Label();
            this.Txtx_expe = new System.Windows.Forms.TextBox();
            this.Gpb_resultado = new System.Windows.Forms.GroupBox();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_enviar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_resultados)).BeginInit();
            this.Gpb_resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // Dgv_resultados
            // 
            this.Dgv_resultados.BackgroundColor = System.Drawing.Color.LightBlue;
            this.Dgv_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_resultados.Location = new System.Drawing.Point(19, 120);
            this.Dgv_resultados.Name = "Dgv_resultados";
            this.Dgv_resultados.Size = new System.Drawing.Size(538, 208);
            this.Dgv_resultados.TabIndex = 4;
            // 
            // Lbl_expe
            // 
            this.Lbl_expe.AutoSize = true;
            this.Lbl_expe.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_expe.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_expe.ForeColor = System.Drawing.Color.White;
            this.Lbl_expe.Location = new System.Drawing.Point(97, 71);
            this.Lbl_expe.Name = "Lbl_expe";
            this.Lbl_expe.Size = new System.Drawing.Size(136, 22);
            this.Lbl_expe.TabIndex = 13;
            this.Lbl_expe.Text = "No.Expediente:";
            // 
            // Txtx_expe
            // 
            this.Txtx_expe.BackColor = System.Drawing.Color.LightBlue;
            this.Txtx_expe.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtx_expe.Location = new System.Drawing.Point(239, 67);
            this.Txtx_expe.Name = "Txtx_expe";
            this.Txtx_expe.Size = new System.Drawing.Size(145, 26);
            this.Txtx_expe.TabIndex = 14;
            // 
            // Gpb_resultado
            // 
            this.Gpb_resultado.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.Gpb_resultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gpb_resultado.Controls.Add(this.Lbl_correo);
            this.Gpb_resultado.Controls.Add(this.Btn_buscar);
            this.Gpb_resultado.Controls.Add(this.Dgv_resultados);
            this.Gpb_resultado.Controls.Add(this.Txtx_expe);
            this.Gpb_resultado.Controls.Add(this.Lbl_expe);
            this.Gpb_resultado.Controls.Add(this.Btn_enviar);
            this.Gpb_resultado.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_resultado.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_resultado.Location = new System.Drawing.Point(12, 12);
            this.Gpb_resultado.Name = "Gpb_resultado";
            this.Gpb_resultado.Size = new System.Drawing.Size(582, 399);
            this.Gpb_resultado.TabIndex = 16;
            this.Gpb_resultado.TabStop = false;
            this.Gpb_resultado.Text = "Resultados Exámen";
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_correo.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.ForeColor = System.Drawing.Color.White;
            this.Lbl_correo.Location = new System.Drawing.Point(477, 384);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(104, 15);
            this.Lbl_correo.TabIndex = 16;
            this.Lbl_correo.Text = "Enviar por correo";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.file;
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_buscar.Location = new System.Drawing.Point(390, 59);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(53, 44);
            this.Btn_buscar.TabIndex = 15;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_enviar
            // 
            this.Btn_enviar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.correo;
            this.Btn_enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_enviar.Location = new System.Drawing.Point(506, 342);
            this.Btn_enviar.Name = "Btn_enviar";
            this.Btn_enviar.Size = new System.Drawing.Size(53, 44);
            this.Btn_enviar.TabIndex = 5;
            this.Btn_enviar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(593, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 123;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gpb_resultado);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_resultados)).EndInit();
            this.Gpb_resultado.ResumeLayout(false);
            this.Gpb_resultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_resultados;
        private System.Windows.Forms.Button Btn_enviar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_expe;
        private System.Windows.Forms.TextBox Txtx_expe;
        private System.Windows.Forms.GroupBox Gpb_resultado;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.Button button2;
    }
}