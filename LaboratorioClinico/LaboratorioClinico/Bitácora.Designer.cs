namespace LaboratorioClinico
{
    partial class Bitácora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitácora));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_verb = new System.Windows.Forms.Button();
            this.Gpb_bitacora = new System.Windows.Forms.GroupBox();
            this.Dgv_bitacora = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_verb = new System.Windows.Forms.Label();
            this.Gpb_bitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_verb
            // 
            this.Btn_verb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_verb.BackgroundImage")));
            this.Btn_verb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_verb.Location = new System.Drawing.Point(630, 88);
            this.Btn_verb.Name = "Btn_verb";
            this.Btn_verb.Size = new System.Drawing.Size(53, 44);
            this.Btn_verb.TabIndex = 9;
            this.Btn_verb.UseVisualStyleBackColor = true;
            this.Btn_verb.Click += new System.EventHandler(this.Btn_verb_Click);
            // 
            // Gpb_bitacora
            // 
            this.Gpb_bitacora.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_bitacora.Controls.Add(this.Dgv_bitacora);
            this.Gpb_bitacora.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_bitacora.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_bitacora.Location = new System.Drawing.Point(64, 149);
            this.Gpb_bitacora.Name = "Gpb_bitacora";
            this.Gpb_bitacora.Size = new System.Drawing.Size(626, 196);
            this.Gpb_bitacora.TabIndex = 10;
            this.Gpb_bitacora.TabStop = false;
            this.Gpb_bitacora.Text = "Bitacora Usuarios";
            // 
            // Dgv_bitacora
            // 
            this.Dgv_bitacora.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_bitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_bitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Column1,
            this.Column2,
            this.PC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_bitacora.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_bitacora.Location = new System.Drawing.Point(7, 34);
            this.Dgv_bitacora.Name = "Dgv_bitacora";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_bitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_bitacora.Size = new System.Drawing.Size(613, 141);
            this.Dgv_bitacora.TabIndex = 0;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Acción";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha/Hora";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // PC
            // 
            this.PC.HeaderText = "PC";
            this.PC.Name = "PC";
            this.PC.Width = 150;
            // 
            // Lbl_verb
            // 
            this.Lbl_verb.AutoSize = true;
            this.Lbl_verb.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_verb.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_verb.Location = new System.Drawing.Point(627, 135);
            this.Lbl_verb.Name = "Lbl_verb";
            this.Lbl_verb.Size = new System.Drawing.Size(66, 15);
            this.Lbl_verb.TabIndex = 1;
            this.Lbl_verb.Text = "Ver Bitácora";
            // 
            // Bitácora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Lbl_verb);
            this.Controls.Add(this.Gpb_bitacora);
            this.Controls.Add(this.Btn_verb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bitácora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Gpb_bitacora.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_verb;
        private System.Windows.Forms.GroupBox Gpb_bitacora;
        private System.Windows.Forms.DataGridView Dgv_bitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC;
        private System.Windows.Forms.Label Lbl_verb;
    }
}