namespace LaboratorioClinico
{
    partial class CrearCodigo
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
            this.Txt_texto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.Pic_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_img)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_texto
            // 
            this.Txt_texto.Location = new System.Drawing.Point(130, 326);
            this.Txt_texto.Name = "Txt_texto";
            this.Txt_texto.Size = new System.Drawing.Size(320, 20);
            this.Txt_texto.TabIndex = 0;
            this.Txt_texto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código para código de barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Crear Código";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar;
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guardar.Location = new System.Drawing.Point(466, 83);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 44);
            this.Btn_guardar.TabIndex = 3;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_crear
            // 
            this.Btn_crear.BackgroundImage = global::LaboratorioClinico.Properties.Resources.anadir;
            this.Btn_crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_crear.Location = new System.Drawing.Point(466, 148);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(53, 44);
            this.Btn_crear.TabIndex = 2;
            this.Btn_crear.UseVisualStyleBackColor = true;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // Pic_img
            // 
            this.Pic_img.Location = new System.Drawing.Point(130, 83);
            this.Pic_img.Name = "Pic_img";
            this.Pic_img.Size = new System.Drawing.Size(320, 175);
            this.Pic_img.TabIndex = 6;
            this.Pic_img.TabStop = false;
            // 
            // CrearCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 423);
            this.Controls.Add(this.Pic_img);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_crear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_texto);
            this.Name = "CrearCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CrearCodigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pic_img;
    }
}