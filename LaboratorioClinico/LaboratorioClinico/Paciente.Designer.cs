namespace LaboratorioClinico
{
    partial class Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paciente));
            this.Btn_guardarp = new System.Windows.Forms.Button();
            this.Gpb_guardarp = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Gpb_datosp = new System.Windows.Forms.GroupBox();
            this.Cmb_sangrep = new System.Windows.Forms.ComboBox();
            this.Lbl_correop = new System.Windows.Forms.Label();
            this.Txt_correoP = new System.Windows.Forms.TextBox();
            this.Lbl_tipoSangrep = new System.Windows.Forms.Label();
            this.Lbl_alergiasp = new System.Windows.Forms.Label();
            this.Txt_alergiasp = new System.Windows.Forms.TextBox();
            this.Btn_expedientep = new System.Windows.Forms.Button();
            this.Lbl_refierep = new System.Windows.Forms.Label();
            this.Lbl_direccionp = new System.Windows.Forms.Label();
            this.Lbl_nitp = new System.Windows.Forms.Label();
            this.Lbl_telefonop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_nombrep = new System.Windows.Forms.Label();
            this.Lbl_expedientep = new System.Windows.Forms.Label();
            this.Cmb_sexop = new System.Windows.Forms.ComboBox();
            this.Txt_expedientep = new System.Windows.Forms.TextBox();
            this.Txt_refierep = new System.Windows.Forms.TextBox();
            this.Txt_direccionp = new System.Windows.Forms.TextBox();
            this.Txt_nitp = new System.Windows.Forms.TextBox();
            this.Txt_telefonop = new System.Windows.Forms.TextBox();
            this.Txt_nombrep = new System.Windows.Forms.TextBox();
            this.Gpb_fechanp = new System.Windows.Forms.GroupBox();
            this.Dtp_fechap = new System.Windows.Forms.DateTimePicker();
            this.Dtp_fecha2p = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fechaep = new System.Windows.Forms.Label();
            this.Gpb_fechap = new System.Windows.Forms.GroupBox();
            this.Er_validar = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Gpb_guardarp.SuspendLayout();
            this.Gpb_datosp.SuspendLayout();
            this.Gpb_fechanp.SuspendLayout();
            this.Gpb_fechap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Er_validar)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_guardarp
            // 
            this.Btn_guardarp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_guardarp.BackgroundImage")));
            this.Btn_guardarp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guardarp.Location = new System.Drawing.Point(21, 14);
            this.Btn_guardarp.Name = "Btn_guardarp";
            this.Btn_guardarp.Size = new System.Drawing.Size(53, 44);
            this.Btn_guardarp.TabIndex = 1;
            this.Btn_guardarp.UseVisualStyleBackColor = true;
            this.Btn_guardarp.Click += new System.EventHandler(this.Btn_guardarp_Click);
            // 
            // Gpb_guardarp
            // 
            this.Gpb_guardarp.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_guardarp.Controls.Add(this.label10);
            this.Gpb_guardarp.Controls.Add(this.Btn_guardarp);
            this.Gpb_guardarp.Location = new System.Drawing.Point(627, 371);
            this.Gpb_guardarp.Name = "Gpb_guardarp";
            this.Gpb_guardarp.Size = new System.Drawing.Size(95, 82);
            this.Gpb_guardarp.TabIndex = 2;
            this.Gpb_guardarp.TabStop = false;
            this.Gpb_guardarp.Enter += new System.EventHandler(this.Gpb_guardarp_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "Guardar";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Gpb_datosp
            // 
            this.Gpb_datosp.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_datosp.Controls.Add(this.Cmb_sangrep);
            this.Gpb_datosp.Controls.Add(this.Lbl_correop);
            this.Gpb_datosp.Controls.Add(this.Txt_correoP);
            this.Gpb_datosp.Controls.Add(this.Lbl_tipoSangrep);
            this.Gpb_datosp.Controls.Add(this.Lbl_alergiasp);
            this.Gpb_datosp.Controls.Add(this.Txt_alergiasp);
            this.Gpb_datosp.Controls.Add(this.Btn_expedientep);
            this.Gpb_datosp.Controls.Add(this.Lbl_refierep);
            this.Gpb_datosp.Controls.Add(this.Lbl_direccionp);
            this.Gpb_datosp.Controls.Add(this.Lbl_nitp);
            this.Gpb_datosp.Controls.Add(this.Lbl_telefonop);
            this.Gpb_datosp.Controls.Add(this.label3);
            this.Gpb_datosp.Controls.Add(this.Lbl_nombrep);
            this.Gpb_datosp.Controls.Add(this.Lbl_expedientep);
            this.Gpb_datosp.Controls.Add(this.Cmb_sexop);
            this.Gpb_datosp.Controls.Add(this.Txt_expedientep);
            this.Gpb_datosp.Controls.Add(this.Txt_refierep);
            this.Gpb_datosp.Controls.Add(this.Txt_direccionp);
            this.Gpb_datosp.Controls.Add(this.Txt_nitp);
            this.Gpb_datosp.Controls.Add(this.Txt_telefonop);
            this.Gpb_datosp.Controls.Add(this.Txt_nombrep);
            this.Gpb_datosp.Controls.Add(this.Gpb_fechanp);
            this.Gpb_datosp.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosp.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_datosp.Location = new System.Drawing.Point(31, 23);
            this.Gpb_datosp.Name = "Gpb_datosp";
            this.Gpb_datosp.Size = new System.Drawing.Size(691, 337);
            this.Gpb_datosp.TabIndex = 2;
            this.Gpb_datosp.TabStop = false;
            this.Gpb_datosp.Text = "Datos Paciente";
            this.Gpb_datosp.Enter += new System.EventHandler(this.Gpb_datosp_Enter);
            // 
            // Cmb_sangrep
            // 
            this.Cmb_sangrep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Cmb_sangrep.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_sangrep.FormattingEnabled = true;
            this.Cmb_sangrep.Location = new System.Drawing.Point(410, 117);
            this.Cmb_sangrep.Name = "Cmb_sangrep";
            this.Cmb_sangrep.Size = new System.Drawing.Size(180, 25);
            this.Cmb_sangrep.TabIndex = 50;
            this.Cmb_sangrep.SelectedIndexChanged += new System.EventHandler(this.Cmb_sangrep_SelectedIndexChanged);
            // 
            // Lbl_correop
            // 
            this.Lbl_correop.AutoSize = true;
            this.Lbl_correop.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correop.ForeColor = System.Drawing.Color.White;
            this.Lbl_correop.Location = new System.Drawing.Point(120, 199);
            this.Lbl_correop.Name = "Lbl_correop";
            this.Lbl_correop.Size = new System.Drawing.Size(56, 18);
            this.Lbl_correop.TabIndex = 48;
            this.Lbl_correop.Text = "Correo:";
            // 
            // Txt_correoP
            // 
            this.Txt_correoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_correoP.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_correoP.Location = new System.Drawing.Point(120, 221);
            this.Txt_correoP.Name = "Txt_correoP";
            this.Txt_correoP.Size = new System.Drawing.Size(470, 25);
            this.Txt_correoP.TabIndex = 47;
            // 
            // Lbl_tipoSangrep
            // 
            this.Lbl_tipoSangrep.AutoSize = true;
            this.Lbl_tipoSangrep.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoSangrep.ForeColor = System.Drawing.Color.White;
            this.Lbl_tipoSangrep.Location = new System.Drawing.Point(407, 96);
            this.Lbl_tipoSangrep.Name = "Lbl_tipoSangrep";
            this.Lbl_tipoSangrep.Size = new System.Drawing.Size(79, 18);
            this.Lbl_tipoSangrep.TabIndex = 46;
            this.Lbl_tipoSangrep.Text = "Tipo Sangre";
            // 
            // Lbl_alergiasp
            // 
            this.Lbl_alergiasp.AutoSize = true;
            this.Lbl_alergiasp.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_alergiasp.ForeColor = System.Drawing.Color.White;
            this.Lbl_alergiasp.Location = new System.Drawing.Point(120, 250);
            this.Lbl_alergiasp.Name = "Lbl_alergiasp";
            this.Lbl_alergiasp.Size = new System.Drawing.Size(57, 18);
            this.Lbl_alergiasp.TabIndex = 44;
            this.Lbl_alergiasp.Text = "Alergias";
            // 
            // Txt_alergiasp
            // 
            this.Txt_alergiasp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_alergiasp.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_alergiasp.Location = new System.Drawing.Point(120, 271);
            this.Txt_alergiasp.Multiline = true;
            this.Txt_alergiasp.Name = "Txt_alergiasp";
            this.Txt_alergiasp.Size = new System.Drawing.Size(470, 51);
            this.Txt_alergiasp.TabIndex = 43;
            this.Txt_alergiasp.TextChanged += new System.EventHandler(this.Txt_alergiasp_TextChanged);
            // 
            // Btn_expedientep
            // 
            this.Btn_expedientep.BackColor = System.Drawing.Color.Transparent;
            this.Btn_expedientep.BackgroundImage = global::LaboratorioClinico.Properties.Resources.historial_medico;
            this.Btn_expedientep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_expedientep.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_expedientep.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_expedientep.Location = new System.Drawing.Point(18, 108);
            this.Btn_expedientep.Name = "Btn_expedientep";
            this.Btn_expedientep.Size = new System.Drawing.Size(82, 77);
            this.Btn_expedientep.TabIndex = 42;
            this.Btn_expedientep.UseVisualStyleBackColor = false;
            // 
            // Lbl_refierep
            // 
            this.Lbl_refierep.AutoSize = true;
            this.Lbl_refierep.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_refierep.ForeColor = System.Drawing.Color.White;
            this.Lbl_refierep.Location = new System.Drawing.Point(407, 148);
            this.Lbl_refierep.Name = "Lbl_refierep";
            this.Lbl_refierep.Size = new System.Drawing.Size(95, 18);
            this.Lbl_refierep.TabIndex = 40;
            this.Lbl_refierep.Text = "Quién refiere:";
            // 
            // Lbl_direccionp
            // 
            this.Lbl_direccionp.AutoSize = true;
            this.Lbl_direccionp.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_direccionp.ForeColor = System.Drawing.Color.White;
            this.Lbl_direccionp.Location = new System.Drawing.Point(120, 148);
            this.Lbl_direccionp.Name = "Lbl_direccionp";
            this.Lbl_direccionp.Size = new System.Drawing.Size(71, 18);
            this.Lbl_direccionp.TabIndex = 37;
            this.Lbl_direccionp.Text = "Dirección:";
            // 
            // Lbl_nitp
            // 
            this.Lbl_nitp.AutoSize = true;
            this.Lbl_nitp.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nitp.ForeColor = System.Drawing.Color.White;
            this.Lbl_nitp.Location = new System.Drawing.Point(259, 96);
            this.Lbl_nitp.Name = "Lbl_nitp";
            this.Lbl_nitp.Size = new System.Drawing.Size(47, 18);
            this.Lbl_nitp.TabIndex = 36;
            this.Lbl_nitp.Text = "N.I.T:";
            // 
            // Lbl_telefonop
            // 
            this.Lbl_telefonop.AutoSize = true;
            this.Lbl_telefonop.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_telefonop.ForeColor = System.Drawing.Color.White;
            this.Lbl_telefonop.Location = new System.Drawing.Point(120, 96);
            this.Lbl_telefonop.Name = "Lbl_telefonop";
            this.Lbl_telefonop.Size = new System.Drawing.Size(65, 18);
            this.Lbl_telefonop.TabIndex = 35;
            this.Lbl_telefonop.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(407, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Sexo:";
            // 
            // Lbl_nombrep
            // 
            this.Lbl_nombrep.AutoSize = true;
            this.Lbl_nombrep.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombrep.ForeColor = System.Drawing.Color.White;
            this.Lbl_nombrep.Location = new System.Drawing.Point(117, 48);
            this.Lbl_nombrep.Name = "Lbl_nombrep";
            this.Lbl_nombrep.Size = new System.Drawing.Size(138, 18);
            this.Lbl_nombrep.TabIndex = 33;
            this.Lbl_nombrep.Text = "Nombre del paciente:";
            // 
            // Lbl_expedientep
            // 
            this.Lbl_expedientep.AutoSize = true;
            this.Lbl_expedientep.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_expedientep.ForeColor = System.Drawing.Color.White;
            this.Lbl_expedientep.Location = new System.Drawing.Point(15, 53);
            this.Lbl_expedientep.Name = "Lbl_expedientep";
            this.Lbl_expedientep.Size = new System.Drawing.Size(36, 18);
            this.Lbl_expedientep.TabIndex = 32;
            this.Lbl_expedientep.Text = "DPI:";
            // 
            // Cmb_sexop
            // 
            this.Cmb_sexop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Cmb_sexop.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_sexop.FormattingEnabled = true;
            this.Cmb_sexop.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Cmb_sexop.Location = new System.Drawing.Point(410, 68);
            this.Cmb_sexop.Name = "Cmb_sexop";
            this.Cmb_sexop.Size = new System.Drawing.Size(57, 25);
            this.Cmb_sexop.TabIndex = 31;
            // 
            // Txt_expedientep
            // 
            this.Txt_expedientep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_expedientep.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_expedientep.Location = new System.Drawing.Point(18, 74);
            this.Txt_expedientep.MaxLength = 13;
            this.Txt_expedientep.Name = "Txt_expedientep";
            this.Txt_expedientep.Size = new System.Drawing.Size(82, 25);
            this.Txt_expedientep.TabIndex = 30;
            // 
            // Txt_refierep
            // 
            this.Txt_refierep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_refierep.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_refierep.Location = new System.Drawing.Point(410, 170);
            this.Txt_refierep.Name = "Txt_refierep";
            this.Txt_refierep.Size = new System.Drawing.Size(180, 25);
            this.Txt_refierep.TabIndex = 28;
            // 
            // Txt_direccionp
            // 
            this.Txt_direccionp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_direccionp.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccionp.Location = new System.Drawing.Point(120, 170);
            this.Txt_direccionp.Name = "Txt_direccionp";
            this.Txt_direccionp.Size = new System.Drawing.Size(271, 25);
            this.Txt_direccionp.TabIndex = 27;
            // 
            // Txt_nitp
            // 
            this.Txt_nitp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nitp.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nitp.Location = new System.Drawing.Point(262, 118);
            this.Txt_nitp.Name = "Txt_nitp";
            this.Txt_nitp.Size = new System.Drawing.Size(129, 25);
            this.Txt_nitp.TabIndex = 26;
            // 
            // Txt_telefonop
            // 
            this.Txt_telefonop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_telefonop.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefonop.Location = new System.Drawing.Point(120, 118);
            this.Txt_telefonop.Name = "Txt_telefonop";
            this.Txt_telefonop.Size = new System.Drawing.Size(123, 25);
            this.Txt_telefonop.TabIndex = 25;
            // 
            // Txt_nombrep
            // 
            this.Txt_nombrep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nombrep.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombrep.Location = new System.Drawing.Point(120, 68);
            this.Txt_nombrep.Name = "Txt_nombrep";
            this.Txt_nombrep.Size = new System.Drawing.Size(271, 25);
            this.Txt_nombrep.TabIndex = 24;
            // 
            // Gpb_fechanp
            // 
            this.Gpb_fechanp.Controls.Add(this.Dtp_fechap);
            this.Gpb_fechanp.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_fechanp.ForeColor = System.Drawing.Color.White;
            this.Gpb_fechanp.Location = new System.Drawing.Point(500, 28);
            this.Gpb_fechanp.Name = "Gpb_fechanp";
            this.Gpb_fechanp.Size = new System.Drawing.Size(168, 66);
            this.Gpb_fechanp.TabIndex = 23;
            this.Gpb_fechanp.TabStop = false;
            this.Gpb_fechanp.Text = "Fecha de Nacimiento";
            // 
            // Dtp_fechap
            // 
            this.Dtp_fechap.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Dtp_fechap.CustomFormat = "yyyy-MM-dd";
            this.Dtp_fechap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechap.Location = new System.Drawing.Point(26, 25);
            this.Dtp_fechap.Name = "Dtp_fechap";
            this.Dtp_fechap.Size = new System.Drawing.Size(104, 26);
            this.Dtp_fechap.TabIndex = 21;
            this.Dtp_fechap.ValueChanged += new System.EventHandler(this.Dtp_fechap_ValueChanged);
            // 
            // Dtp_fecha2p
            // 
            this.Dtp_fecha2p.CustomFormat = "yyyy-MM-dd";
            this.Dtp_fecha2p.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha2p.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fecha2p.Location = new System.Drawing.Point(36, 45);
            this.Dtp_fecha2p.Name = "Dtp_fecha2p";
            this.Dtp_fecha2p.Size = new System.Drawing.Size(247, 26);
            this.Dtp_fecha2p.TabIndex = 41;
            // 
            // Lbl_fechaep
            // 
            this.Lbl_fechaep.AutoSize = true;
            this.Lbl_fechaep.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechaep.ForeColor = System.Drawing.Color.White;
            this.Lbl_fechaep.Location = new System.Drawing.Point(33, 20);
            this.Lbl_fechaep.Name = "Lbl_fechaep";
            this.Lbl_fechaep.Size = new System.Drawing.Size(165, 18);
            this.Lbl_fechaep.TabIndex = 38;
            this.Lbl_fechaep.Text = "Fecha emisión expediente:";
            // 
            // Gpb_fechap
            // 
            this.Gpb_fechap.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_fechap.Controls.Add(this.Dtp_fecha2p);
            this.Gpb_fechap.Controls.Add(this.Lbl_fechaep);
            this.Gpb_fechap.Location = new System.Drawing.Point(31, 371);
            this.Gpb_fechap.Name = "Gpb_fechap";
            this.Gpb_fechap.Size = new System.Drawing.Size(590, 82);
            this.Gpb_fechap.TabIndex = 3;
            this.Gpb_fechap.TabStop = false;
            this.Gpb_fechap.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Er_validar
            // 
            this.Er_validar.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(722, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gpb_fechap);
            this.Controls.Add(this.Gpb_datosp);
            this.Controls.Add(this.Gpb_guardarp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Paciente_Load);
            this.Gpb_guardarp.ResumeLayout(false);
            this.Gpb_guardarp.PerformLayout();
            this.Gpb_datosp.ResumeLayout(false);
            this.Gpb_datosp.PerformLayout();
            this.Gpb_fechanp.ResumeLayout(false);
            this.Gpb_fechap.ResumeLayout(false);
            this.Gpb_fechap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Er_validar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_guardarp;
        private System.Windows.Forms.GroupBox Gpb_guardarp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox Gpb_datosp;
        private System.Windows.Forms.Label Lbl_tipoSangrep;
        private System.Windows.Forms.Label Lbl_alergiasp;
        private System.Windows.Forms.TextBox Txt_alergiasp;
        private System.Windows.Forms.Button Btn_expedientep;
        private System.Windows.Forms.Label Lbl_refierep;
        private System.Windows.Forms.Label Lbl_direccionp;
        private System.Windows.Forms.Label Lbl_nitp;
        private System.Windows.Forms.Label Lbl_telefonop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_nombrep;
        private System.Windows.Forms.Label Lbl_expedientep;
        private System.Windows.Forms.ComboBox Cmb_sexop;
        private System.Windows.Forms.TextBox Txt_expedientep;
        private System.Windows.Forms.TextBox Txt_refierep;
        private System.Windows.Forms.TextBox Txt_direccionp;
        private System.Windows.Forms.TextBox Txt_nitp;
        private System.Windows.Forms.TextBox Txt_telefonop;
        private System.Windows.Forms.TextBox Txt_nombrep;
        private System.Windows.Forms.GroupBox Gpb_fechanp;
        private System.Windows.Forms.DateTimePicker Dtp_fechap;
        private System.Windows.Forms.DateTimePicker Dtp_fecha2p;
        private System.Windows.Forms.Label Lbl_fechaep;
        private System.Windows.Forms.GroupBox Gpb_fechap;
        private System.Windows.Forms.Label Lbl_correop;
        private System.Windows.Forms.TextBox Txt_correoP;
        private System.Windows.Forms.ErrorProvider Er_validar;
        private System.Windows.Forms.ComboBox Cmb_sangrep;
        private System.Windows.Forms.Button button1;
    }
}