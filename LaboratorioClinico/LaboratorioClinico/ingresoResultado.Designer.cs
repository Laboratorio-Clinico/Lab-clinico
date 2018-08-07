namespace LaboratorioClinico
{
    partial class ingresoResultado
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
            this.Lbl_ingreseResultados = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_correo = new System.Windows.Forms.ComboBox();
            this.Btn_BuscarExamen = new System.Windows.Forms.Button();
            this.Txt_Correor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_resultadox = new System.Windows.Forms.TextBox();
            this.Lbl_resultado = new System.Windows.Forms.Label();
            this.Txt_codEx = new System.Windows.Forms.TextBox();
            this.Lbl_codigor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_nombrex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_examenRealizado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_fechar = new System.Windows.Forms.DateTimePicker();
            this.Gpb_datosf = new System.Windows.Forms.GroupBox();
            this.Btn_busc = new System.Windows.Forms.Button();
            this.Txt_direccionr = new System.Windows.Forms.TextBox();
            this.Lbl_fechaf = new System.Windows.Forms.Label();
            this.Txt_dpir = new System.Windows.Forms.TextBox();
            this.Lbl_direccionf = new System.Windows.Forms.Label();
            this.Txt_nombrer = new System.Windows.Forms.TextBox();
            this.Lbl_nitf = new System.Windows.Forms.Label();
            this.Lbl_nombref = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_guardarResultado = new System.Windows.Forms.Button();
            this.Lbl_ingresarr = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.Gpb_datosf.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_ingreseResultados
            // 
            this.Lbl_ingreseResultados.AutoSize = true;
            this.Lbl_ingreseResultados.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ingreseResultados.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ingreseResultados.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Lbl_ingreseResultados.Location = new System.Drawing.Point(49, 29);
            this.Lbl_ingreseResultados.Name = "Lbl_ingreseResultados";
            this.Lbl_ingreseResultados.Size = new System.Drawing.Size(284, 31);
            this.Lbl_ingreseResultados.TabIndex = 128;
            this.Lbl_ingreseResultados.Text = "INGRESE RESULTADOS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cmb_correo);
            this.groupBox1.Controls.Add(this.Btn_BuscarExamen);
            this.groupBox1.Controls.Add(this.Txt_Correor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_resultadox);
            this.groupBox1.Controls.Add(this.Lbl_resultado);
            this.groupBox1.Controls.Add(this.Txt_codEx);
            this.groupBox1.Controls.Add(this.Lbl_codigor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_nombrex);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Lbl_examenRealizado);
            this.groupBox1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(15, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 243);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evaluación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(427, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "@";
            // 
            // Cmb_correo
            // 
            this.Cmb_correo.FormattingEnabled = true;
            this.Cmb_correo.Items.AddRange(new object[] {
            "gmail",
            "yahoo",
            "hotmail",
            "outlook"});
            this.Cmb_correo.Location = new System.Drawing.Point(453, 94);
            this.Cmb_correo.Name = "Cmb_correo";
            this.Cmb_correo.Size = new System.Drawing.Size(134, 30);
            this.Cmb_correo.TabIndex = 112;
            this.Cmb_correo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Btn_BuscarExamen
            // 
            this.Btn_BuscarExamen.BackColor = System.Drawing.Color.White;
            this.Btn_BuscarExamen.BackgroundImage = global::LaboratorioClinico.Properties.Resources.codigobarra;
            this.Btn_BuscarExamen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_BuscarExamen.Location = new System.Drawing.Point(546, 26);
            this.Btn_BuscarExamen.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BuscarExamen.Name = "Btn_BuscarExamen";
            this.Btn_BuscarExamen.Size = new System.Drawing.Size(41, 38);
            this.Btn_BuscarExamen.TabIndex = 111;
            this.Btn_BuscarExamen.UseVisualStyleBackColor = false;
            this.Btn_BuscarExamen.Click += new System.EventHandler(this.Btn_BuscarExamen_Click);
            // 
            // Txt_Correor
            // 
            this.Txt_Correor.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Correor.Location = new System.Drawing.Point(164, 98);
            this.Txt_Correor.Multiline = true;
            this.Txt_Correor.Name = "Txt_Correor";
            this.Txt_Correor.Size = new System.Drawing.Size(257, 25);
            this.Txt_Correor.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 109;
            this.label2.Text = "Correo";
            // 
            // Txt_resultadox
            // 
            this.Txt_resultadox.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_resultadox.Location = new System.Drawing.Point(164, 129);
            this.Txt_resultadox.Multiline = true;
            this.Txt_resultadox.Name = "Txt_resultadox";
            this.Txt_resultadox.Size = new System.Drawing.Size(423, 96);
            this.Txt_resultadox.TabIndex = 104;
            // 
            // Lbl_resultado
            // 
            this.Lbl_resultado.AutoSize = true;
            this.Lbl_resultado.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_resultado.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_resultado.ForeColor = System.Drawing.Color.White;
            this.Lbl_resultado.Location = new System.Drawing.Point(20, 131);
            this.Lbl_resultado.Name = "Lbl_resultado";
            this.Lbl_resultado.Size = new System.Drawing.Size(66, 18);
            this.Lbl_resultado.TabIndex = 103;
            this.Lbl_resultado.Text = "Resultado";
            // 
            // Txt_codEx
            // 
            this.Txt_codEx.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codEx.Location = new System.Drawing.Point(164, 44);
            this.Txt_codEx.Multiline = true;
            this.Txt_codEx.Name = "Txt_codEx";
            this.Txt_codEx.Size = new System.Drawing.Size(375, 20);
            this.Txt_codEx.TabIndex = 101;
            // 
            // Lbl_codigor
            // 
            this.Lbl_codigor.AutoSize = true;
            this.Lbl_codigor.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_codigor.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigor.ForeColor = System.Drawing.Color.White;
            this.Lbl_codigor.Location = new System.Drawing.Point(20, 46);
            this.Lbl_codigor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codigor.Name = "Lbl_codigor";
            this.Lbl_codigor.Size = new System.Drawing.Size(100, 18);
            this.Lbl_codigor.TabIndex = 100;
            this.Lbl_codigor.Text = "Código exámen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(298, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 7;
            // 
            // Txt_nombrex
            // 
            this.Txt_nombrex.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombrex.Location = new System.Drawing.Point(164, 71);
            this.Txt_nombrex.Multiline = true;
            this.Txt_nombrex.Name = "Txt_nombrex";
            this.Txt_nombrex.Size = new System.Drawing.Size(423, 20);
            this.Txt_nombrex.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 6;
            // 
            // Lbl_examenRealizado
            // 
            this.Lbl_examenRealizado.AutoSize = true;
            this.Lbl_examenRealizado.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_examenRealizado.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_examenRealizado.ForeColor = System.Drawing.Color.White;
            this.Lbl_examenRealizado.Location = new System.Drawing.Point(20, 73);
            this.Lbl_examenRealizado.Name = "Lbl_examenRealizado";
            this.Lbl_examenRealizado.Size = new System.Drawing.Size(112, 18);
            this.Lbl_examenRealizado.TabIndex = 5;
            this.Lbl_examenRealizado.Text = "Examen realizado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 102;
            this.label1.Text = "Emisión exámen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dtp_fechar
            // 
            this.Dtp_fechar.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Dtp_fechar.CustomFormat = "dd-MM-yy";
            this.Dtp_fechar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechar.Location = new System.Drawing.Point(167, 19);
            this.Dtp_fechar.Name = "Dtp_fechar";
            this.Dtp_fechar.Size = new System.Drawing.Size(144, 20);
            this.Dtp_fechar.TabIndex = 22;
            this.Dtp_fechar.ValueChanged += new System.EventHandler(this.Dtp_fechar_ValueChanged);
            // 
            // Gpb_datosf
            // 
            this.Gpb_datosf.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_datosf.Controls.Add(this.Btn_busc);
            this.Gpb_datosf.Controls.Add(this.Txt_direccionr);
            this.Gpb_datosf.Controls.Add(this.Lbl_fechaf);
            this.Gpb_datosf.Controls.Add(this.Txt_dpir);
            this.Gpb_datosf.Controls.Add(this.Lbl_direccionf);
            this.Gpb_datosf.Controls.Add(this.Txt_nombrer);
            this.Gpb_datosf.Controls.Add(this.Lbl_nitf);
            this.Gpb_datosf.Controls.Add(this.Lbl_nombref);
            this.Gpb_datosf.Controls.Add(this.textBox2);
            this.Gpb_datosf.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosf.ForeColor = System.Drawing.SystemColors.Info;
            this.Gpb_datosf.Location = new System.Drawing.Point(15, 62);
            this.Gpb_datosf.Name = "Gpb_datosf";
            this.Gpb_datosf.Size = new System.Drawing.Size(736, 95);
            this.Gpb_datosf.TabIndex = 127;
            this.Gpb_datosf.TabStop = false;
            this.Gpb_datosf.Text = "Datos Paciente";
            // 
            // Btn_busc
            // 
            this.Btn_busc.BackColor = System.Drawing.Color.White;
            this.Btn_busc.BackgroundImage = global::LaboratorioClinico.Properties.Resources.lupa;
            this.Btn_busc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_busc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_busc.Location = new System.Drawing.Point(250, 51);
            this.Btn_busc.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_busc.Name = "Btn_busc";
            this.Btn_busc.Size = new System.Drawing.Size(41, 38);
            this.Btn_busc.TabIndex = 51;
            this.Btn_busc.UseVisualStyleBackColor = false;
            this.Btn_busc.Click += new System.EventHandler(this.Btn_busc_Click);
            // 
            // Txt_direccionr
            // 
            this.Txt_direccionr.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccionr.Location = new System.Drawing.Point(382, 62);
            this.Txt_direccionr.Multiline = true;
            this.Txt_direccionr.Name = "Txt_direccionr";
            this.Txt_direccionr.Size = new System.Drawing.Size(338, 20);
            this.Txt_direccionr.TabIndex = 11;
            // 
            // Lbl_fechaf
            // 
            this.Lbl_fechaf.AutoSize = true;
            this.Lbl_fechaf.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_fechaf.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechaf.ForeColor = System.Drawing.Color.White;
            this.Lbl_fechaf.Location = new System.Drawing.Point(539, 24);
            this.Lbl_fechaf.Name = "Lbl_fechaf";
            this.Lbl_fechaf.Size = new System.Drawing.Size(0, 18);
            this.Lbl_fechaf.TabIndex = 10;
            // 
            // Txt_dpir
            // 
            this.Txt_dpir.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_dpir.Location = new System.Drawing.Point(124, 62);
            this.Txt_dpir.Multiline = true;
            this.Txt_dpir.Name = "Txt_dpir";
            this.Txt_dpir.Size = new System.Drawing.Size(124, 20);
            this.Txt_dpir.TabIndex = 9;
            // 
            // Lbl_direccionf
            // 
            this.Lbl_direccionf.AutoSize = true;
            this.Lbl_direccionf.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_direccionf.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_direccionf.ForeColor = System.Drawing.Color.White;
            this.Lbl_direccionf.Location = new System.Drawing.Point(298, 62);
            this.Lbl_direccionf.Name = "Lbl_direccionf";
            this.Lbl_direccionf.Size = new System.Drawing.Size(66, 18);
            this.Lbl_direccionf.TabIndex = 7;
            this.Lbl_direccionf.Text = "Dirección";
            // 
            // Txt_nombrer
            // 
            this.Txt_nombrer.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombrer.Location = new System.Drawing.Point(124, 24);
            this.Txt_nombrer.Multiline = true;
            this.Txt_nombrer.Name = "Txt_nombrer";
            this.Txt_nombrer.Size = new System.Drawing.Size(336, 20);
            this.Txt_nombrer.TabIndex = 4;
            // 
            // Lbl_nitf
            // 
            this.Lbl_nitf.AutoSize = true;
            this.Lbl_nitf.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nitf.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nitf.ForeColor = System.Drawing.Color.White;
            this.Lbl_nitf.Location = new System.Drawing.Point(29, 64);
            this.Lbl_nitf.Name = "Lbl_nitf";
            this.Lbl_nitf.Size = new System.Drawing.Size(31, 18);
            this.Lbl_nitf.TabIndex = 6;
            this.Lbl_nitf.Text = "DPI";
            // 
            // Lbl_nombref
            // 
            this.Lbl_nombref.AutoSize = true;
            this.Lbl_nombref.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nombref.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombref.ForeColor = System.Drawing.Color.White;
            this.Lbl_nombref.Location = new System.Drawing.Point(29, 24);
            this.Lbl_nombref.Name = "Lbl_nombref";
            this.Lbl_nombref.Size = new System.Drawing.Size(58, 18);
            this.Lbl_nombref.TabIndex = 5;
            this.Lbl_nombref.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 0;
            // 
            // Btn_guardarResultado
            // 
            this.Btn_guardarResultado.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar;
            this.Btn_guardarResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guardarResultado.Location = new System.Drawing.Point(36, 43);
            this.Btn_guardarResultado.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardarResultado.Name = "Btn_guardarResultado";
            this.Btn_guardarResultado.Size = new System.Drawing.Size(53, 44);
            this.Btn_guardarResultado.TabIndex = 136;
            this.Btn_guardarResultado.UseVisualStyleBackColor = true;
            this.Btn_guardarResultado.Click += new System.EventHandler(this.Btn_guardarResultado_Click);
            // 
            // Lbl_ingresarr
            // 
            this.Lbl_ingresarr.AutoSize = true;
            this.Lbl_ingresarr.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ingresarr.ForeColor = System.Drawing.Color.White;
            this.Lbl_ingresarr.Location = new System.Drawing.Point(42, 92);
            this.Lbl_ingresarr.Name = "Lbl_ingresarr";
            this.Lbl_ingresarr.Size = new System.Drawing.Size(43, 15);
            this.Lbl_ingresarr.TabIndex = 137;
            this.Lbl_ingresarr.Text = "Ingresar";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Btn_guardarResultado);
            this.groupBox2.Controls.Add(this.Lbl_ingresarr);
            this.groupBox2.Location = new System.Drawing.Point(631, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 237);
            this.groupBox2.TabIndex = 138;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Dtp_fechar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(742, 54);
            this.groupBox3.TabIndex = 139;
            this.groupBox3.TabStop = false;
            // 
            // ingresoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Lbl_ingreseResultados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gpb_datosf);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ingresoResultado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gpb_datosf.ResumeLayout(false);
            this.Gpb_datosf.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_ingreseResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_resultadox;
        private System.Windows.Forms.Label Lbl_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_fechar;
        private System.Windows.Forms.TextBox Txt_codEx;
        private System.Windows.Forms.Label Lbl_codigor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_nombrex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_examenRealizado;
        private System.Windows.Forms.GroupBox Gpb_datosf;
        private System.Windows.Forms.Button Btn_busc;
        private System.Windows.Forms.TextBox Txt_direccionr;
        private System.Windows.Forms.Label Lbl_fechaf;
        private System.Windows.Forms.TextBox Txt_dpir;
        private System.Windows.Forms.Label Lbl_direccionf;
        private System.Windows.Forms.TextBox Txt_nombrer;
        private System.Windows.Forms.Label Lbl_nitf;
        private System.Windows.Forms.Label Lbl_nombref;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Txt_Correor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_BuscarExamen;
        private System.Windows.Forms.Button Btn_guardarResultado;
        private System.Windows.Forms.Label Lbl_ingresarr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmb_correo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}