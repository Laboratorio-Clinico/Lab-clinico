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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCodigo));
            this.Txt_texto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_img = new System.Windows.Forms.PictureBox();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Er_validar = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Er_validar)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_texto
            // 
            this.Txt_texto.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_texto.Location = new System.Drawing.Point(130, 330);
            this.Txt_texto.Name = "Txt_texto";
            this.Txt_texto.Size = new System.Drawing.Size(122, 38);
            this.Txt_texto.TabIndex = 0;
            this.Txt_texto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Txt_texto.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_texto_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código para código de barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label2.Location = new System.Drawing.Point(210, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Crear Código";
            // 
            // Pic_img
            // 
            this.Pic_img.BackColor = System.Drawing.Color.Transparent;
            this.Pic_img.Image = global::LaboratorioClinico.Properties.Resources.health;
            this.Pic_img.Location = new System.Drawing.Point(130, 83);
            this.Pic_img.Name = "Pic_img";
            this.Pic_img.Size = new System.Drawing.Size(320, 175);
            this.Pic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_img.TabIndex = 6;
            this.Pic_img.TabStop = false;
            // 
            // Btn_crear
            // 
            this.Btn_crear.BackgroundImage = global::LaboratorioClinico.Properties.Resources.anadir;
            this.Btn_crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_crear.Location = new System.Drawing.Point(511, 306);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(53, 44);
            this.Btn_crear.TabIndex = 2;
            this.Btn_crear.UseVisualStyleBackColor = true;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_guardar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar;
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guardar.Location = new System.Drawing.Point(511, 238);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 44);
            this.Btn_guardar.TabIndex = 3;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(512, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Guardar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(520, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Crear";
            // 
            // Er_validar
            // 
            this.Er_validar.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 44);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CrearCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_crear);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Pic_img);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_texto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrearCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CrearCodigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Er_validar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pic_img;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider Er_validar;
        private System.Windows.Forms.Button button1;
    }
}