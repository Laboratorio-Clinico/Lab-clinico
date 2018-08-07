﻿namespace LaboratorioClinico
{
    partial class LeerCode
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Dgv_data = new System.Windows.Forms.DataGridView();
            this.Lbl_error = new System.Windows.Forms.Label();
            this.Lbl_error2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label2.Location = new System.Drawing.Point(210, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leer Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.BackColor = System.Drawing.Color.LightGray;
            this.Txt_codigo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(231, 113);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(162, 26);
            this.Txt_codigo.TabIndex = 6;
            this.Txt_codigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Dgv_data
            // 
            this.Dgv_data.BackgroundColor = System.Drawing.Color.LightBlue;
            this.Dgv_data.ColumnHeadersHeight = 22;
            this.Dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_data.Location = new System.Drawing.Point(34, 160);
            this.Dgv_data.Name = "Dgv_data";
            this.Dgv_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_data.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_data.Size = new System.Drawing.Size(538, 208);
            this.Dgv_data.TabIndex = 7;
            this.Dgv_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_data_CellContentClick);
            // 
            // Lbl_error
            // 
            this.Lbl_error.AutoSize = true;
            this.Lbl_error.BackColor = System.Drawing.Color.LightBlue;
            this.Lbl_error.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_error.Location = new System.Drawing.Point(210, 246);
            this.Lbl_error.Name = "Lbl_error";
            this.Lbl_error.Size = new System.Drawing.Size(175, 31);
            this.Lbl_error.TabIndex = 8;
            this.Lbl_error.Text = "No existe código";
            this.Lbl_error.Visible = false;
            // 
            // Lbl_error2
            // 
            this.Lbl_error2.AutoSize = true;
            this.Lbl_error2.BackColor = System.Drawing.Color.LightBlue;
            this.Lbl_error2.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_error2.Location = new System.Drawing.Point(162, 246);
            this.Lbl_error2.Name = "Lbl_error2";
            this.Lbl_error2.Size = new System.Drawing.Size(279, 31);
            this.Lbl_error2.TabIndex = 9;
            this.Lbl_error2.Text = "Escriba o escanee un código";
            this.Lbl_error2.Visible = false;
            // 
            // LeerCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 419);
            this.Controls.Add(this.Lbl_error2);
            this.Controls.Add(this.Lbl_error);
            this.Controls.Add(this.Dgv_data);
            this.Controls.Add(this.Txt_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LeerCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeerCode";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.DataGridView Dgv_data;
        private System.Windows.Forms.Label Lbl_error;
        private System.Windows.Forms.Label Lbl_error2;
    }
}