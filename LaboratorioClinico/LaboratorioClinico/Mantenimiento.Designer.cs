namespace LaboratorioClinico
{
    partial class Mantenimiento
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
            this.Tbc_control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Lbl_tabla = new System.Windows.Forms.Label();
            this.Cmb_tabla = new System.Windows.Forms.ComboBox();
            this.Gpb_mantenimiento = new System.Windows.Forms.GroupBox();
            this.Tbc_control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Gpb_mantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_control
            // 
            this.Tbc_control.Controls.Add(this.tabPage1);
            this.Tbc_control.Controls.Add(this.tabPage2);
            this.Tbc_control.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbc_control.Location = new System.Drawing.Point(21, 104);
            this.Tbc_control.Margin = new System.Windows.Forms.Padding(4);
            this.Tbc_control.Name = "Tbc_control";
            this.Tbc_control.SelectedIndex = 0;
            this.Tbc_control.Size = new System.Drawing.Size(708, 354);
            this.Tbc_control.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_Editar);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(690, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modificar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.editar;
            this.Btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Editar.Location = new System.Drawing.Point(612, 7);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(53, 44);
            this.Btn_Editar.TabIndex = 4;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_borrar);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(700, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.goma_de_borrar;
            this.Btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_borrar.Location = new System.Drawing.Point(630, 7);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(53, 44);
            this.Btn_borrar.TabIndex = 4;
            this.Btn_borrar.UseVisualStyleBackColor = true;
            // 
            // Lbl_tabla
            // 
            this.Lbl_tabla.AutoSize = true;
            this.Lbl_tabla.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_tabla.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tabla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_tabla.Location = new System.Drawing.Point(193, 60);
            this.Lbl_tabla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_tabla.Name = "Lbl_tabla";
            this.Lbl_tabla.Size = new System.Drawing.Size(147, 22);
            this.Lbl_tabla.TabIndex = 1;
            this.Lbl_tabla.Text = "Seleccione tabla:";
            // 
            // Cmb_tabla
            // 
            this.Cmb_tabla.BackColor = System.Drawing.Color.LightBlue;
            this.Cmb_tabla.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_tabla.FormattingEnabled = true;
            this.Cmb_tabla.Location = new System.Drawing.Point(348, 56);
            this.Cmb_tabla.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_tabla.Name = "Cmb_tabla";
            this.Cmb_tabla.Size = new System.Drawing.Size(160, 26);
            this.Cmb_tabla.TabIndex = 0;
            // 
            // Gpb_mantenimiento
            // 
            this.Gpb_mantenimiento.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.Gpb_mantenimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gpb_mantenimiento.Controls.Add(this.Lbl_tabla);
            this.Gpb_mantenimiento.Controls.Add(this.Cmb_tabla);
            this.Gpb_mantenimiento.Controls.Add(this.Tbc_control);
            this.Gpb_mantenimiento.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_mantenimiento.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_mantenimiento.Location = new System.Drawing.Point(9, -2);
            this.Gpb_mantenimiento.Name = "Gpb_mantenimiento";
            this.Gpb_mantenimiento.Size = new System.Drawing.Size(745, 479);
            this.Gpb_mantenimiento.TabIndex = 3;
            this.Gpb_mantenimiento.TabStop = false;
            this.Gpb_mantenimiento.Text = "Mantenimiento";
            this.Gpb_mantenimiento.Enter += new System.EventHandler(this.Gpb_mantenimiento_Enter);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Gpb_mantenimiento);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            this.Tbc_control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.Gpb_mantenimiento.ResumeLayout(false);
            this.Gpb_mantenimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Lbl_tabla;
        private System.Windows.Forms.ComboBox Cmb_tabla;
        private System.Windows.Forms.GroupBox Gpb_mantenimiento;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_borrar;
    }
}