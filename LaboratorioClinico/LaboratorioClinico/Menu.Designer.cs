namespace LaboratorioClinico
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requerimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.cotizaciónToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.pacienteToolStripMenuItem.Text = "Inicio";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo ";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segurToolStripMenuItem,
            this.mantenimientoToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // cotizaciónToolStripMenuItem
            // 
            this.cotizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionesToolStripMenuItem,
            this.resultadosToolStripMenuItem,
            this.muestrasToolStripMenuItem,
            this.requerimientosToolStripMenuItem});
            this.cotizaciónToolStripMenuItem.Name = "cotizaciónToolStripMenuItem";
            this.cotizaciónToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cotizaciónToolStripMenuItem.Text = "Exámenes";
            this.cotizaciónToolStripMenuItem.Click += new System.EventHandler(this.cotizaciónToolStripMenuItem_Click);
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // segurToolStripMenuItem
            // 
            this.segurToolStripMenuItem.Name = "segurToolStripMenuItem";
            this.segurToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.segurToolStripMenuItem.Text = "Seguridad";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resultadosToolStripMenuItem.Text = "Resultados";
            // 
            // muestrasToolStripMenuItem
            // 
            this.muestrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leerCódigoToolStripMenuItem,
            this.crearCódigoToolStripMenuItem});
            this.muestrasToolStripMenuItem.Name = "muestrasToolStripMenuItem";
            this.muestrasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.muestrasToolStripMenuItem.Text = "Muestras";
            // 
            // requerimientosToolStripMenuItem
            // 
            this.requerimientosToolStripMenuItem.Name = "requerimientosToolStripMenuItem";
            this.requerimientosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.requerimientosToolStripMenuItem.Text = "Requerimientos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // leerCódigoToolStripMenuItem
            // 
            this.leerCódigoToolStripMenuItem.Name = "leerCódigoToolStripMenuItem";
            this.leerCódigoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.leerCódigoToolStripMenuItem.Text = "Leer código";
            // 
            // crearCódigoToolStripMenuItem
            // 
            this.crearCódigoToolStripMenuItem.Name = "crearCódigoToolStripMenuItem";
            this.crearCódigoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearCódigoToolStripMenuItem.Text = "Crear código";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 384);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requerimientosToolStripMenuItem;
    }
}