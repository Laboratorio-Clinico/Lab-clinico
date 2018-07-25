namespace LaboratorioClinico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_contraseña = new System.Windows.Forms.TextBox();
            this.Er_validar = new System.Windows.Forms.ErrorProvider(this.components);
            this.Pnl_nombre = new System.Windows.Forms.Panel();
            this.Lbl_lab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Er_validar)).BeginInit();
            this.Pnl_nombre.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.Btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ingresar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.Btn_ingresar.Location = new System.Drawing.Point(42, 131);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(262, 39);
            this.Btn_ingresar.TabIndex = 0;
            this.Btn_ingresar.Text = "LOGIN";
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.Txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_usuario.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Txt_usuario.Location = new System.Drawing.Point(78, 32);
            this.Txt_usuario.Multiline = true;
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_usuario.Size = new System.Drawing.Size(226, 32);
            this.Txt_usuario.TabIndex = 3;
            this.Txt_usuario.TextChanged += new System.EventHandler(this.Txt_usuario_TextChanged);
            // 
            // Txt_contraseña
            // 
            this.Txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.Txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_contraseña.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_contraseña.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Txt_contraseña.Location = new System.Drawing.Point(78, 82);
            this.Txt_contraseña.Multiline = true;
            this.Txt_contraseña.Name = "Txt_contraseña";
            this.Txt_contraseña.PasswordChar = '*';
            this.Txt_contraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_contraseña.Size = new System.Drawing.Size(226, 32);
            this.Txt_contraseña.TabIndex = 4;
            this.Txt_contraseña.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_contraseña_Validating);
            // 
            // Er_validar
            // 
            this.Er_validar.ContainerControl = this;
            // 
            // Pnl_nombre
            // 
            this.Pnl_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.Pnl_nombre.Controls.Add(this.Lbl_lab);
            this.Pnl_nombre.Location = new System.Drawing.Point(62, 36);
            this.Pnl_nombre.Name = "Pnl_nombre";
            this.Pnl_nombre.Size = new System.Drawing.Size(340, 46);
            this.Pnl_nombre.TabIndex = 10;
            // 
            // Lbl_lab
            // 
            this.Lbl_lab.AutoSize = true;
            this.Lbl_lab.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_lab.ForeColor = System.Drawing.Color.White;
            this.Lbl_lab.Location = new System.Drawing.Point(35, 9);
            this.Lbl_lab.Name = "Lbl_lab";
            this.Lbl_lab.Size = new System.Drawing.Size(256, 37);
            this.Lbl_lab.TabIndex = 0;
            this.Lbl_lab.Text = "LABORATORIO CLINICO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Txt_contraseña);
            this.panel1.Controls.Add(this.Btn_ingresar);
            this.panel1.Controls.Add(this.Txt_usuario);
            this.panel1.Location = new System.Drawing.Point(62, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 200);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.pictureBox2.Image = global::LaboratorioClinico.Properties.Resources.bl;
            this.pictureBox2.Location = new System.Drawing.Point(42, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.pictureBox1.Image = global::LaboratorioClinico.Properties.Resources.usuario_hombre;
            this.pictureBox1.Location = new System.Drawing.Point(42, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_nombre);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.AliceBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Er_validar)).EndInit();
            this.Pnl_nombre.ResumeLayout(false);
            this.Pnl_nombre.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox Txt_contraseña;
        private System.Windows.Forms.ErrorProvider Er_validar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Pnl_nombre;
        private System.Windows.Forms.Label Lbl_lab;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

