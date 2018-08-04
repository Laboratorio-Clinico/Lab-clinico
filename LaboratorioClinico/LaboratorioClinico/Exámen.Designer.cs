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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exámen));
            this.Btn_mantenimiento = new System.Windows.Forms.Button();
            this.Dgv_examen = new System.Windows.Forms.DataGridView();
            this.Pcb_lab = new System.Windows.Forms.PictureBox();
            this.Lbl_examen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_examen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_lab)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_mantenimiento
            // 
            this.Btn_mantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Btn_mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_mantenimiento.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mantenimiento.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Btn_mantenimiento.Location = new System.Drawing.Point(519, 135);
            this.Btn_mantenimiento.Name = "Btn_mantenimiento";
            this.Btn_mantenimiento.Size = new System.Drawing.Size(180, 52);
            this.Btn_mantenimiento.TabIndex = 12;
            this.Btn_mantenimiento.Text = "Ir a mantenimiento";
            this.Btn_mantenimiento.UseVisualStyleBackColor = false;
            this.Btn_mantenimiento.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dgv_examen
            // 
            this.Dgv_examen.AllowUserToOrderColumns = true;
            this.Dgv_examen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_examen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_examen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Dgv_examen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_examen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_examen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_examen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_examen.ColumnHeadersHeight = 27;
            this.Dgv_examen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_examen.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_examen.EnableHeadersVisualStyles = false;
            this.Dgv_examen.Location = new System.Drawing.Point(38, 68);
            this.Dgv_examen.Name = "Dgv_examen";
            this.Dgv_examen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_examen.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_examen.Size = new System.Drawing.Size(404, 435);
            this.Dgv_examen.TabIndex = 10;
            this.Dgv_examen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_examen_CellContentClick);
            // 
            // Pcb_lab
            // 
            this.Pcb_lab.BackColor = System.Drawing.Color.Transparent;
            this.Pcb_lab.Image = global::LaboratorioClinico.Properties.Resources.loginI_;
            this.Pcb_lab.Location = new System.Drawing.Point(496, 206);
            this.Pcb_lab.Name = "Pcb_lab";
            this.Pcb_lab.Size = new System.Drawing.Size(232, 209);
            this.Pcb_lab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcb_lab.TabIndex = 11;
            this.Pcb_lab.TabStop = false;
            // 
            // Lbl_examen
            // 
            this.Lbl_examen.AutoSize = true;
            this.Lbl_examen.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_examen.Font = new System.Drawing.Font("Perpetua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_examen.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Lbl_examen.Location = new System.Drawing.Point(319, 22);
            this.Lbl_examen.Name = "Lbl_examen";
            this.Lbl_examen.Size = new System.Drawing.Size(150, 36);
            this.Lbl_examen.TabIndex = 13;
            this.Lbl_examen.Text = "Exámenes";
            // 
            // Exámen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 528);
            this.Controls.Add(this.Lbl_examen);
            this.Controls.Add(this.Btn_mantenimiento);
            this.Controls.Add(this.Dgv_examen);
            this.Controls.Add(this.Pcb_lab);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exámen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Exámen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_examen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_lab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_mantenimiento;
        private System.Windows.Forms.DataGridView Dgv_examen;
        private System.Windows.Forms.PictureBox Pcb_lab;
        private System.Windows.Forms.Label Lbl_examen;
    }
}