﻿namespace LaboratorioClinico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.segurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_Examen = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_citas = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_informacion = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_cotizaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_resultados = new System.Windows.Forms.ToolStripMenuItem();
            this.muestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_crearCodigo = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_Erequerimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_constancias = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_comprobacion = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_Control = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tm_Factura = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Pnl_menudespegable = new System.Windows.Forms.Panel();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.tm_menu = new System.Windows.Forms.Timer(this.components);
            this.tm_menu2 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Pnl_menudespegable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.Tm_admin,
            this.Tm_reportes,
            this.Tm_Examen,
            this.Tm_Control,
            this.Tm_Factura});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(65, 28);
            this.pacienteToolStripMenuItem.Text = "Inicio";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // Tm_admin
            // 
            this.Tm_admin.BackColor = System.Drawing.Color.DarkCyan;
            this.Tm_admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segurToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.médicosToolStripMenuItem});
            this.Tm_admin.Name = "Tm_admin";
            this.Tm_admin.Size = new System.Drawing.Size(140, 28);
            this.Tm_admin.Text = "Administración";
            // 
            // segurToolStripMenuItem
            // 
            this.segurToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.segurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.bitácoraToolStripMenuItem,
            this.cambioDeContraseñaToolStripMenuItem});
            this.segurToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segurToolStripMenuItem.Image = global::LaboratorioClinico.Properties.Resources.bloqueado;
            this.segurToolStripMenuItem.Name = "segurToolStripMenuItem";
            this.segurToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.segurToolStripMenuItem.Text = "Seguridad";
            this.segurToolStripMenuItem.Click += new System.EventHandler(this.segurToolStripMenuItem_Click);
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.nuevoUsuarioToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoUsuarioToolStripMenuItem.Image = global::LaboratorioClinico.Properties.Resources.nuevo_usuario;
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // bitácoraToolStripMenuItem
            // 
            this.bitácoraToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.bitácoraToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitácoraToolStripMenuItem.Image = global::LaboratorioClinico.Properties.Resources.registro;
            this.bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            this.bitácoraToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.bitácoraToolStripMenuItem.Text = "Bitácora";
            this.bitácoraToolStripMenuItem.Click += new System.EventHandler(this.bitácoraToolStripMenuItem_Click);
            // 
            // cambioDeContraseñaToolStripMenuItem
            // 
            this.cambioDeContraseñaToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.cambioDeContraseñaToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioDeContraseñaToolStripMenuItem.Image = global::LaboratorioClinico.Properties.Resources.configuracion_de_usuario;
            this.cambioDeContraseñaToolStripMenuItem.Name = "cambioDeContraseñaToolStripMenuItem";
            this.cambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.cambioDeContraseñaToolStripMenuItem.Text = "Configuración de Usuarios";
            this.cambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambioDeContraseñaToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.mantenimientoToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientoToolStripMenuItem.Image = global::LaboratorioClinico.Properties.Resources.ajustes;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.médicosToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.médicosToolStripMenuItem.Image = global::LaboratorioClinico.Properties.Resources.doctor1;
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.médicosToolStripMenuItem.Text = "Médicos";
            this.médicosToolStripMenuItem.Click += new System.EventHandler(this.médicosToolStripMenuItem_Click);
            // 
            // Tm_reportes
            // 
            this.Tm_reportes.Name = "Tm_reportes";
            this.Tm_reportes.Size = new System.Drawing.Size(92, 28);
            this.Tm_reportes.Text = "Reportes";
            this.Tm_reportes.Click += new System.EventHandler(this.Tm_reportes_Click);
            // 
            // Tm_Examen
            // 
            this.Tm_Examen.BackColor = System.Drawing.Color.DarkCyan;
            this.Tm_Examen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tm_citas,
            this.Tm_informacion,
            this.Tm_cotizaciones,
            this.Tm_resultados,
            this.muestrasToolStripMenuItem,
            this.Tm_Erequerimientos,
            this.Tm_constancias,
            this.Tm_comprobacion});
            this.Tm_Examen.Name = "Tm_Examen";
            this.Tm_Examen.Size = new System.Drawing.Size(101, 28);
            this.Tm_Examen.Text = "Exámenes";
            this.Tm_Examen.Click += new System.EventHandler(this.cotizaciónToolStripMenuItem_Click);
            // 
            // Tm_citas
            // 
            this.Tm_citas.BackColor = System.Drawing.Color.PowderBlue;
            this.Tm_citas.Image = global::LaboratorioClinico.Properties.Resources.fecha_de_cita_medica_recordatorio_en_pagina_diaria_de_calendario_de_simbolo_de_interfaz_con_cruz_de_primeros_auxilios;
            this.Tm_citas.Name = "Tm_citas";
            this.Tm_citas.Size = new System.Drawing.Size(263, 28);
            this.Tm_citas.Text = "Citas";
            this.Tm_citas.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // Tm_informacion
            // 
            this.Tm_informacion.BackColor = System.Drawing.Color.PowderBlue;
            this.Tm_informacion.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tm_informacion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Tm_informacion.Image = global::LaboratorioClinico.Properties.Resources.info;
            this.Tm_informacion.Name = "Tm_informacion";
            this.Tm_informacion.Size = new System.Drawing.Size(263, 28);
            this.Tm_informacion.Text = "Información";
            this.Tm_informacion.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // Tm_cotizaciones
            // 
            this.Tm_cotizaciones.BackColor = System.Drawing.Color.PowderBlue;
            this.Tm_cotizaciones.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tm_cotizaciones.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Tm_cotizaciones.Image = global::LaboratorioClinico.Properties.Resources.banco;
            this.Tm_cotizaciones.Name = "Tm_cotizaciones";
            this.Tm_cotizaciones.Size = new System.Drawing.Size(263, 28);
            this.Tm_cotizaciones.Text = "Cotizaciones";
            this.Tm_cotizaciones.Click += new System.EventHandler(this.cotizacionesToolStripMenuItem_Click);
            // 
            // Tm_resultados
            // 
            this.Tm_resultados.BackColor = System.Drawing.Color.PowderBlue;
            this.Tm_resultados.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tm_resultados.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Tm_resultados.Image = global::LaboratorioClinico.Properties.Resources.prueba;
            this.Tm_resultados.Name = "Tm_resultados";
            this.Tm_resultados.Size = new System.Drawing.Size(263, 28);
            this.Tm_resultados.Text = "Resultados";
            this.Tm_resultados.Click += new System.EventHandler(this.resultadosToolStripMenuItem_Click);
            // 
            // muestrasToolStripMenuItem
            // 
            this.muestrasToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.muestrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leerCódigoToolStripMenuItem,
            this.Tm_crearCodigo});
            this.muestrasToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muestrasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.muestrasToolStripMenuItem.Image = global::LaboratorioClinico.Properties.Resources.frascos1;
            this.muestrasToolStripMenuItem.Name = "muestrasToolStripMenuItem";
            this.muestrasToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.muestrasToolStripMenuItem.Text = "Muestras";
            // 
            // leerCódigoToolStripMenuItem
            // 
            this.leerCódigoToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.leerCódigoToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leerCódigoToolStripMenuItem.Image = global::LaboratorioClinico.Properties.Resources.codigo_qr;
            this.leerCódigoToolStripMenuItem.Name = "leerCódigoToolStripMenuItem";
            this.leerCódigoToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.leerCódigoToolStripMenuItem.Text = "Leer código";
            this.leerCódigoToolStripMenuItem.Click += new System.EventHandler(this.leerCódigoToolStripMenuItem_Click);
            // 
            // Tm_crearCodigo
            // 
            this.Tm_crearCodigo.BackColor = System.Drawing.Color.PowderBlue;
            this.Tm_crearCodigo.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tm_crearCodigo.Image = global::LaboratorioClinico.Properties.Resources.codigo_de_seguridad;
            this.Tm_crearCodigo.Name = "Tm_crearCodigo";
            this.Tm_crearCodigo.Size = new System.Drawing.Size(188, 26);
            this.Tm_crearCodigo.Text = "Generar código";
            this.Tm_crearCodigo.Click += new System.EventHandler(this.crearCódigoToolStripMenuItem_Click);
            // 
            // Tm_Erequerimientos
            // 
            this.Tm_Erequerimientos.BackColor = System.Drawing.Color.PowderBlue;
            this.Tm_Erequerimientos.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tm_Erequerimientos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Tm_Erequerimientos.Image = global::LaboratorioClinico.Properties.Resources.pregunta;
            this.Tm_Erequerimientos.Name = "Tm_Erequerimientos";
            this.Tm_Erequerimientos.Size = new System.Drawing.Size(263, 28);
            this.Tm_Erequerimientos.Text = "Requerimientos";
            this.Tm_Erequerimientos.Click += new System.EventHandler(this.requerimientosToolStripMenuItem_Click);
            // 
            // Tm_constancias
            // 
            this.Tm_constancias.BackColor = System.Drawing.Color.PowderBlue;
            this.Tm_constancias.Image = global::LaboratorioClinico.Properties.Resources.file;
            this.Tm_constancias.Name = "Tm_constancias";
            this.Tm_constancias.Size = new System.Drawing.Size(263, 28);
            this.Tm_constancias.Text = "Constancias";
            this.Tm_constancias.Click += new System.EventHandler(this.constanciasToolStripMenuItem_Click);
            // 
            // Tm_comprobacion
            // 
            this.Tm_comprobacion.BackColor = System.Drawing.Color.PowderBlue;
            this.Tm_comprobacion.Image = global::LaboratorioClinico.Properties.Resources.comprobado;
            this.Tm_comprobacion.Name = "Tm_comprobacion";
            this.Tm_comprobacion.Size = new System.Drawing.Size(263, 28);
            this.Tm_comprobacion.Text = "Comprobación de Citas";
            this.Tm_comprobacion.Click += new System.EventHandler(this.comprobaciónDeCitasToolStripMenuItem_Click);
            // 
            // Tm_Control
            // 
            this.Tm_Control.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPacienteToolStripMenuItem,
            this.nuevoEmpleadoToolStripMenuItem,
            this.membresiasToolStripMenuItem});
            this.Tm_Control.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tm_Control.Name = "Tm_Control";
            this.Tm_Control.Size = new System.Drawing.Size(79, 28);
            this.Tm_Control.Text = "Control";
            // 
            // nuevoPacienteToolStripMenuItem
            // 
            this.nuevoPacienteToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.nuevoPacienteToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoPacienteToolStripMenuItem.Image = global::LaboratorioClinico.Properties.Resources.anadir;
            this.nuevoPacienteToolStripMenuItem.Name = "nuevoPacienteToolStripMenuItem";
            this.nuevoPacienteToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.nuevoPacienteToolStripMenuItem.Text = "Nuevo Paciente";
            this.nuevoPacienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoPacienteToolStripMenuItem_Click);
            // 
            // nuevoEmpleadoToolStripMenuItem
            // 
            this.nuevoEmpleadoToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.nuevoEmpleadoToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoEmpleadoToolStripMenuItem.Image = global::LaboratorioClinico.Properties.Resources.examen;
            this.nuevoEmpleadoToolStripMenuItem.Name = "nuevoEmpleadoToolStripMenuItem";
            this.nuevoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.nuevoEmpleadoToolStripMenuItem.Text = "Nuevo Empleado";
            this.nuevoEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.nuevoEmpleadoToolStripMenuItem_Click);
            // 
            // membresiasToolStripMenuItem
            // 
            this.membresiasToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.membresiasToolStripMenuItem.Image = global::LaboratorioClinico.Properties.Resources.mem;
            this.membresiasToolStripMenuItem.Name = "membresiasToolStripMenuItem";
            this.membresiasToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.membresiasToolStripMenuItem.Text = "Membresias";
            this.membresiasToolStripMenuItem.Click += new System.EventHandler(this.membresiasToolStripMenuItem_Click_1);
            // 
            // Tm_Factura
            // 
            this.Tm_Factura.Name = "Tm_Factura";
            this.Tm_Factura.Size = new System.Drawing.Size(112, 28);
            this.Tm_Factura.Text = "Facturación";
            this.Tm_Factura.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(285, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "LABORATORIO CLINICO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox1.Image = global::LaboratorioClinico.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(755, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::LaboratorioClinico.Properties.Resources.salida__1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Pnl_menudespegable
            // 
            this.Pnl_menudespegable.BackColor = System.Drawing.Color.DarkCyan;
            this.Pnl_menudespegable.Controls.Add(this.lbl_tipo);
            this.Pnl_menudespegable.Controls.Add(this.pictureBox3);
            this.Pnl_menudespegable.Controls.Add(this.label2);
            this.Pnl_menudespegable.Controls.Add(this.lbl_usuario);
            this.Pnl_menudespegable.Controls.Add(this.pictureBox2);
            this.Pnl_menudespegable.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_menudespegable.Location = new System.Drawing.Point(638, 18);
            this.Pnl_menudespegable.Name = "Pnl_menudespegable";
            this.Pnl_menudespegable.Size = new System.Drawing.Size(153, 100);
            this.Pnl_menudespegable.TabIndex = 6;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(40, 36);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(57, 17);
            this.lbl_tipo.TabIndex = 2;
            this.lbl_tipo.Text = "Usuario";
            this.lbl_tipo.Click += new System.EventHandler(this.lbl_tipo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::LaboratorioClinico.Properties.Resources.usuario;
            this.pictureBox3.Location = new System.Drawing.Point(0, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cerrar sesion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(41, 14);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(57, 17);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(12, 357);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(56, 24);
            this.lbl_hora.TabIndex = 7;
            this.lbl_hora.Text = "label3";
            this.lbl_hora.Click += new System.EventHandler(this.lbl_hora_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(12, 380);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(43, 18);
            this.lbl_fecha.TabIndex = 8;
            this.lbl_fecha.Text = "label3";
            this.lbl_fecha.Click += new System.EventHandler(this.label3_Click);
            // 
            // tm_menu
            // 
            this.tm_menu.Interval = 10;
            this.tm_menu.Tick += new System.EventHandler(this.tm_menu_Tick);
            // 
            // tm_menu2
            // 
            this.tm_menu2.Interval = 10;
            this.tm_menu2.Tick += new System.EventHandler(this.tm_menu2_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 400);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Pnl_menudespegable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Pnl_menudespegable.ResumeLayout(false);
            this.Pnl_menudespegable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tm_admin;
        private System.Windows.Forms.ToolStripMenuItem Tm_Examen;
        private System.Windows.Forms.ToolStripMenuItem Tm_Factura;
        private System.Windows.Forms.ToolStripMenuItem segurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tm_cotizaciones;
        private System.Windows.Forms.ToolStripMenuItem Tm_resultados;
        private System.Windows.Forms.ToolStripMenuItem muestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tm_reportes;
        private System.Windows.Forms.ToolStripMenuItem leerCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tm_crearCodigo;
        private System.Windows.Forms.ToolStripMenuItem Tm_Erequerimientos;
        private System.Windows.Forms.ToolStripMenuItem Tm_informacion;
        private System.Windows.Forms.ToolStripMenuItem Tm_Control;
        private System.Windows.Forms.ToolStripMenuItem nuevoPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitácoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeContraseñaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Pnl_menudespegable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Timer tm_menu;
        private System.Windows.Forms.Timer tm_menu2;
        private System.Windows.Forms.ToolStripMenuItem nuevoEmpleadoToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem membresiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tm_citas;
        private System.Windows.Forms.ToolStripMenuItem Tm_constancias;
        private System.Windows.Forms.ToolStripMenuItem Tm_comprobacion;
    }
}