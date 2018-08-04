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
            this.Gpb_examen = new System.Windows.Forms.GroupBox();
            this.Dgv_examen = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpb_examen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_examen)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_examen
            // 
            this.Gpb_examen.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_examen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gpb_examen.Controls.Add(this.Dgv_examen);
            this.Gpb_examen.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_examen.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_examen.Location = new System.Drawing.Point(26, 12);
            this.Gpb_examen.Name = "Gpb_examen";
            this.Gpb_examen.Size = new System.Drawing.Size(731, 491);
            this.Gpb_examen.TabIndex = 12;
            this.Gpb_examen.TabStop = false;
            this.Gpb_examen.Text = "Información Exámenes";
            this.Gpb_examen.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Dgv_examen
            // 
            this.Dgv_examen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Dgv_examen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_examen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Dgv_examen.Location = new System.Drawing.Point(42, 65);
            this.Dgv_examen.Name = "Dgv_examen";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_examen.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_examen.Size = new System.Drawing.Size(392, 245);
            this.Dgv_examen.TabIndex = 7;
            this.Dgv_examen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
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
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_examen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Gpb_examen;
        private System.Windows.Forms.DataGridView Dgv_examen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}