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
            this.Lbl_verb = new System.Windows.Forms.Label();
            this.Lbl_Bitacora = new System.Windows.Forms.Label();
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
            this.Gpb_bitacora.Location = new System.Drawing.Point(12, 149);
            this.Gpb_bitacora.Name = "Gpb_bitacora";
            this.Gpb_bitacora.Size = new System.Drawing.Size(725, 291);
            this.Gpb_bitacora.TabIndex = 10;
            this.Gpb_bitacora.TabStop = false;
            // 
            // Dgv_bitacora
            // 
            this.Dgv_bitacora.AllowUserToOrderColumns = true;
            this.Dgv_bitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_bitacora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_bitacora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Dgv_bitacora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_bitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.Dgv_bitacora.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgv_bitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_bitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_bitacora.ColumnHeadersHeight = 27;
            this.Dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_bitacora.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_bitacora.EnableHeadersVisualStyles = false;
            this.Dgv_bitacora.Location = new System.Drawing.Point(6, 34);
            this.Dgv_bitacora.Name = "Dgv_bitacora";
            this.Dgv_bitacora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_bitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_bitacora.Size = new System.Drawing.Size(713, 244);
            this.Dgv_bitacora.TabIndex = 11;
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
            // Lbl_Bitacora
            // 
            this.Lbl_Bitacora.AutoSize = true;
            this.Lbl_Bitacora.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Bitacora.Font = new System.Drawing.Font("Perpetua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bitacora.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Lbl_Bitacora.Location = new System.Drawing.Point(62, 63);
            this.Lbl_Bitacora.Name = "Lbl_Bitacora";
            this.Lbl_Bitacora.Size = new System.Drawing.Size(256, 36);
            this.Lbl_Bitacora.TabIndex = 129;
            this.Lbl_Bitacora.Text = "Bitacora Usuarios";
            // 
            // Bitácora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Lbl_Bitacora);
            this.Controls.Add(this.Lbl_verb);
            this.Controls.Add(this.Gpb_bitacora);
            this.Controls.Add(this.Btn_verb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Label Lbl_verb;
        private System.Windows.Forms.DataGridView Dgv_bitacora;
        private System.Windows.Forms.Label Lbl_Bitacora;
    }
}