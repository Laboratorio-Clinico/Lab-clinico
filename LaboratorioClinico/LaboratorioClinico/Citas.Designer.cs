namespace LaboratorioClinico
{
    partial class Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Gpb_datosm = new System.Windows.Forms.GroupBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_dpi = new System.Windows.Forms.TextBox();
            this.Lbl_dpi = new System.Windows.Forms.Label();
            this.Pnl_datosp = new System.Windows.Forms.Panel();
            this.Txt_direp = new System.Windows.Forms.TextBox();
            this.Txt_nombrep = new System.Windows.Forms.TextBox();
            this.Txt_nitp = new System.Windows.Forms.TextBox();
            this.Lbl_direp = new System.Windows.Forms.Label();
            this.Lbl_nombrep = new System.Windows.Forms.Label();
            this.Lbl_nitp = new System.Windows.Forms.Label();
            this.Gpb_detalleCita = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgv_examen = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Cmb_examenes = new System.Windows.Forms.ComboBox();
            this.Lbl_agregar = new System.Windows.Forms.Label();
            this.Lbl_info = new System.Windows.Forms.Label();
            this.Lbl_examen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Gpb_cita = new System.Windows.Forms.GroupBox();
            this.Cmb_estado = new System.Windows.Forms.ComboBox();
            this.Txt_estado = new System.Windows.Forms.Label();
            this.Txt_numero = new System.Windows.Forms.Label();
            this.Lbl_numeroCita = new System.Windows.Forms.Label();
            this.Gpb_fechayhora = new System.Windows.Forms.GroupBox();
            this.Txt_hora = new System.Windows.Forms.TextBox();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Gpb_datosm.SuspendLayout();
            this.Pnl_datosp.SuspendLayout();
            this.Gpb_detalleCita.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_examen)).BeginInit();
            this.Gpb_cita.SuspendLayout();
            this.Gpb_fechayhora.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_titulo.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Lbl_titulo.Location = new System.Drawing.Point(303, 22);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(203, 33);
            this.Lbl_titulo.TabIndex = 17;
            this.Lbl_titulo.Text = "Programar Cita";
            // 
            // Gpb_datosm
            // 
            this.Gpb_datosm.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_datosm.Controls.Add(this.Btn_buscar);
            this.Gpb_datosm.Controls.Add(this.Txt_dpi);
            this.Gpb_datosm.Controls.Add(this.Lbl_dpi);
            this.Gpb_datosm.Controls.Add(this.Pnl_datosp);
            this.Gpb_datosm.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gpb_datosm.Location = new System.Drawing.Point(23, 58);
            this.Gpb_datosm.Name = "Gpb_datosm";
            this.Gpb_datosm.Size = new System.Drawing.Size(732, 173);
            this.Gpb_datosm.TabIndex = 120;
            this.Gpb_datosm.TabStop = false;
            this.Gpb_datosm.Text = "Datos paciente";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_buscar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.icons8_encuentra_hombre_usuario_48;
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_buscar.Location = new System.Drawing.Point(270, 20);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(53, 44);
            this.Btn_buscar.TabIndex = 106;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_dpi
            // 
            this.Txt_dpi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_dpi.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_dpi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Txt_dpi.Location = new System.Drawing.Point(81, 35);
            this.Txt_dpi.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_dpi.Name = "Txt_dpi";
            this.Txt_dpi.Size = new System.Drawing.Size(185, 26);
            this.Txt_dpi.TabIndex = 103;
            // 
            // Lbl_dpi
            // 
            this.Lbl_dpi.AutoSize = true;
            this.Lbl_dpi.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_dpi.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dpi.ForeColor = System.Drawing.Color.White;
            this.Lbl_dpi.Location = new System.Drawing.Point(36, 35);
            this.Lbl_dpi.Name = "Lbl_dpi";
            this.Lbl_dpi.Size = new System.Drawing.Size(38, 22);
            this.Lbl_dpi.TabIndex = 2;
            this.Lbl_dpi.Text = "DPI";
            // 
            // Pnl_datosp
            // 
            this.Pnl_datosp.Controls.Add(this.Txt_direp);
            this.Pnl_datosp.Controls.Add(this.Txt_nombrep);
            this.Pnl_datosp.Controls.Add(this.Txt_nitp);
            this.Pnl_datosp.Controls.Add(this.Lbl_direp);
            this.Pnl_datosp.Controls.Add(this.Lbl_nombrep);
            this.Pnl_datosp.Controls.Add(this.Lbl_nitp);
            this.Pnl_datosp.Enabled = false;
            this.Pnl_datosp.Location = new System.Drawing.Point(138, 43);
            this.Pnl_datosp.Name = "Pnl_datosp";
            this.Pnl_datosp.Size = new System.Drawing.Size(427, 130);
            this.Pnl_datosp.TabIndex = 111;
            // 
            // Txt_direp
            // 
            this.Txt_direp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_direp.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Txt_direp.Location = new System.Drawing.Point(32, 89);
            this.Txt_direp.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_direp.Name = "Txt_direp";
            this.Txt_direp.Size = new System.Drawing.Size(377, 26);
            this.Txt_direp.TabIndex = 108;
            // 
            // Txt_nombrep
            // 
            this.Txt_nombrep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nombrep.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombrep.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Txt_nombrep.Location = new System.Drawing.Point(30, 43);
            this.Txt_nombrep.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombrep.Name = "Txt_nombrep";
            this.Txt_nombrep.Size = new System.Drawing.Size(250, 26);
            this.Txt_nombrep.TabIndex = 104;
            // 
            // Txt_nitp
            // 
            this.Txt_nitp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nitp.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nitp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Txt_nitp.Location = new System.Drawing.Point(288, 43);
            this.Txt_nitp.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nitp.Name = "Txt_nitp";
            this.Txt_nitp.Size = new System.Drawing.Size(121, 26);
            this.Txt_nitp.TabIndex = 110;
            // 
            // Lbl_direp
            // 
            this.Lbl_direp.AutoSize = true;
            this.Lbl_direp.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_direp.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_direp.ForeColor = System.Drawing.Color.White;
            this.Lbl_direp.Location = new System.Drawing.Point(9, 71);
            this.Lbl_direp.Name = "Lbl_direp";
            this.Lbl_direp.Size = new System.Drawing.Size(78, 22);
            this.Lbl_direp.TabIndex = 107;
            this.Lbl_direp.Text = "Dirección";
            // 
            // Lbl_nombrep
            // 
            this.Lbl_nombrep.AutoSize = true;
            this.Lbl_nombrep.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nombrep.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombrep.ForeColor = System.Drawing.Color.White;
            this.Lbl_nombrep.Location = new System.Drawing.Point(9, 23);
            this.Lbl_nombrep.Name = "Lbl_nombrep";
            this.Lbl_nombrep.Size = new System.Drawing.Size(70, 22);
            this.Lbl_nombrep.TabIndex = 1;
            this.Lbl_nombrep.Text = "Nombre";
            // 
            // Lbl_nitp
            // 
            this.Lbl_nitp.AutoSize = true;
            this.Lbl_nitp.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nitp.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nitp.ForeColor = System.Drawing.Color.White;
            this.Lbl_nitp.Location = new System.Drawing.Point(275, 23);
            this.Lbl_nitp.Name = "Lbl_nitp";
            this.Lbl_nitp.Size = new System.Drawing.Size(33, 22);
            this.Lbl_nitp.TabIndex = 109;
            this.Lbl_nitp.Text = "Nit";
            // 
            // Gpb_detalleCita
            // 
            this.Gpb_detalleCita.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_detalleCita.Controls.Add(this.groupBox1);
            this.Gpb_detalleCita.Controls.Add(this.Gpb_cita);
            this.Gpb_detalleCita.Controls.Add(this.Gpb_fechayhora);
            this.Gpb_detalleCita.Controls.Add(this.Btn_guardar);
            this.Gpb_detalleCita.Controls.Add(this.Lbl_guardar);
            this.Gpb_detalleCita.Enabled = false;
            this.Gpb_detalleCita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Gpb_detalleCita.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_detalleCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gpb_detalleCita.Location = new System.Drawing.Point(23, 237);
            this.Gpb_detalleCita.Name = "Gpb_detalleCita";
            this.Gpb_detalleCita.Size = new System.Drawing.Size(732, 375);
            this.Gpb_detalleCita.TabIndex = 121;
            this.Gpb_detalleCita.TabStop = false;
            this.Gpb_detalleCita.Text = "Detalle";
            this.Gpb_detalleCita.Enter += new System.EventHandler(this.Gpb_detalleCita_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgv_examen);
            this.groupBox1.Controls.Add(this.Btn_agregar);
            this.groupBox1.Controls.Add(this.Cmb_examenes);
            this.groupBox1.Controls.Add(this.Lbl_agregar);
            this.groupBox1.Controls.Add(this.Lbl_info);
            this.groupBox1.Controls.Add(this.Lbl_examen);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(29, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 225);
            this.groupBox1.TabIndex = 140;
            this.groupBox1.TabStop = false;
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
            this.Dgv_examen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_examen.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_examen.EnableHeadersVisualStyles = false;
            this.Dgv_examen.Location = new System.Drawing.Point(154, 97);
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
            this.Dgv_examen.Size = new System.Drawing.Size(386, 104);
            this.Dgv_examen.TabIndex = 126;
            this.Dgv_examen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_examen_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Examen";
            this.Column2.Name = "Column2";
            this.Column2.Width = 97;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.Width = 85;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.anadir;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_agregar.Location = new System.Drawing.Point(280, 36);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(53, 44);
            this.Btn_agregar.TabIndex = 127;
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Cmb_examenes
            // 
            this.Cmb_examenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Cmb_examenes.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_examenes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Cmb_examenes.FormattingEnabled = true;
            this.Cmb_examenes.Items.AddRange(new object[] {
            "No Confirmado",
            "Confirmado"});
            this.Cmb_examenes.Location = new System.Drawing.Point(96, 48);
            this.Cmb_examenes.Name = "Cmb_examenes";
            this.Cmb_examenes.Size = new System.Drawing.Size(168, 25);
            this.Cmb_examenes.TabIndex = 129;
            this.Cmb_examenes.Text = "Seleccione una opción";
            // 
            // Lbl_agregar
            // 
            this.Lbl_agregar.AutoSize = true;
            this.Lbl_agregar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_agregar.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_agregar.ForeColor = System.Drawing.Color.PowderBlue;
            this.Lbl_agregar.Location = new System.Drawing.Point(279, 21);
            this.Lbl_agregar.Name = "Lbl_agregar";
            this.Lbl_agregar.Size = new System.Drawing.Size(52, 15);
            this.Lbl_agregar.TabIndex = 137;
            this.Lbl_agregar.Text = "Agregar";
            // 
            // Lbl_info
            // 
            this.Lbl_info.AutoSize = true;
            this.Lbl_info.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_info.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_info.ForeColor = System.Drawing.Color.White;
            this.Lbl_info.Location = new System.Drawing.Point(16, 193);
            this.Lbl_info.Name = "Lbl_info";
            this.Lbl_info.Size = new System.Drawing.Size(93, 18);
            this.Lbl_info.TabIndex = 134;
            this.Lbl_info.Text = "Info Exámenes";
            // 
            // Lbl_examen
            // 
            this.Lbl_examen.AutoSize = true;
            this.Lbl_examen.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_examen.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_examen.ForeColor = System.Drawing.Color.White;
            this.Lbl_examen.Location = new System.Drawing.Point(26, 47);
            this.Lbl_examen.Name = "Lbl_examen";
            this.Lbl_examen.Size = new System.Drawing.Size(67, 22);
            this.Lbl_examen.TabIndex = 130;
            this.Lbl_examen.Text = "Examen";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LaboratorioClinico.Properties.Resources.info;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(42, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 133;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gpb_cita
            // 
            this.Gpb_cita.Controls.Add(this.Cmb_estado);
            this.Gpb_cita.Controls.Add(this.Txt_estado);
            this.Gpb_cita.Controls.Add(this.Txt_numero);
            this.Gpb_cita.Controls.Add(this.Lbl_numeroCita);
            this.Gpb_cita.Location = new System.Drawing.Point(455, 21);
            this.Gpb_cita.Name = "Gpb_cita";
            this.Gpb_cita.Size = new System.Drawing.Size(254, 100);
            this.Gpb_cita.TabIndex = 139;
            this.Gpb_cita.TabStop = false;
            // 
            // Cmb_estado
            // 
            this.Cmb_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Cmb_estado.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_estado.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Cmb_estado.FormattingEnabled = true;
            this.Cmb_estado.Items.AddRange(new object[] {
            "No Confirmado",
            "Confirmado"});
            this.Cmb_estado.Location = new System.Drawing.Point(120, 55);
            this.Cmb_estado.Name = "Cmb_estado";
            this.Cmb_estado.Size = new System.Drawing.Size(113, 25);
            this.Cmb_estado.TabIndex = 125;
            // 
            // Txt_estado
            // 
            this.Txt_estado.AutoSize = true;
            this.Txt_estado.BackColor = System.Drawing.Color.Transparent;
            this.Txt_estado.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.ForeColor = System.Drawing.Color.White;
            this.Txt_estado.Location = new System.Drawing.Point(57, 54);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(57, 22);
            this.Txt_estado.TabIndex = 124;
            this.Txt_estado.Text = "Estado";
            // 
            // Txt_numero
            // 
            this.Txt_numero.AutoSize = true;
            this.Txt_numero.BackColor = System.Drawing.Color.Transparent;
            this.Txt_numero.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numero.ForeColor = System.Drawing.Color.White;
            this.Txt_numero.Location = new System.Drawing.Point(10, 21);
            this.Txt_numero.Name = "Txt_numero";
            this.Txt_numero.Size = new System.Drawing.Size(135, 22);
            this.Txt_numero.TabIndex = 111;
            this.Txt_numero.Text = "Número de cita";
            // 
            // Lbl_numeroCita
            // 
            this.Lbl_numeroCita.AutoSize = true;
            this.Lbl_numeroCita.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_numeroCita.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_numeroCita.ForeColor = System.Drawing.Color.Red;
            this.Lbl_numeroCita.Location = new System.Drawing.Point(160, 21);
            this.Lbl_numeroCita.Name = "Lbl_numeroCita";
            this.Lbl_numeroCita.Size = new System.Drawing.Size(23, 22);
            this.Lbl_numeroCita.TabIndex = 112;
            this.Lbl_numeroCita.Text = "#";
            // 
            // Gpb_fechayhora
            // 
            this.Gpb_fechayhora.Controls.Add(this.Txt_hora);
            this.Gpb_fechayhora.Controls.Add(this.Dtp_fecha);
            this.Gpb_fechayhora.Controls.Add(this.Lbl_fecha);
            this.Gpb_fechayhora.Controls.Add(this.Lbl_hora);
            this.Gpb_fechayhora.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_fechayhora.Location = new System.Drawing.Point(29, 21);
            this.Gpb_fechayhora.Name = "Gpb_fechayhora";
            this.Gpb_fechayhora.Size = new System.Drawing.Size(411, 100);
            this.Gpb_fechayhora.TabIndex = 138;
            this.Gpb_fechayhora.TabStop = false;
            // 
            // Txt_hora
            // 
            this.Txt_hora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_hora.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_hora.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Txt_hora.Location = new System.Drawing.Point(263, 58);
            this.Txt_hora.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_hora.Name = "Txt_hora";
            this.Txt_hora.Size = new System.Drawing.Size(58, 26);
            this.Txt_hora.TabIndex = 111;
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Dtp_fecha.CustomFormat = "yyyy-MM-dd";
            this.Dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fecha.Location = new System.Drawing.Point(263, 21);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(114, 26);
            this.Dtp_fecha.TabIndex = 123;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_fecha.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.Lbl_fecha.Location = new System.Drawing.Point(38, 21);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(225, 22);
            this.Lbl_fecha.TabIndex = 111;
            this.Lbl_fecha.Text = "Fecha programada para la cita: ";
            // 
            // Lbl_hora
            // 
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_hora.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hora.ForeColor = System.Drawing.Color.White;
            this.Lbl_hora.Location = new System.Drawing.Point(38, 59);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.Size = new System.Drawing.Size(222, 22);
            this.Lbl_hora.TabIndex = 122;
            this.Lbl_hora.Text = "Hora programada para la cita: ";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.guardar;
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guardar.Location = new System.Drawing.Point(635, 216);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 44);
            this.Btn_guardar.TabIndex = 135;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Lbl_guardar
            // 
            this.Lbl_guardar.AutoSize = true;
            this.Lbl_guardar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_guardar.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_guardar.ForeColor = System.Drawing.Color.PowderBlue;
            this.Lbl_guardar.Location = new System.Drawing.Point(636, 259);
            this.Lbl_guardar.Name = "Lbl_guardar";
            this.Lbl_guardar.Size = new System.Drawing.Size(52, 15);
            this.Lbl_guardar.TabIndex = 136;
            this.Lbl_guardar.Text = "Guardar";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(754, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 122;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 624);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Gpb_detalleCita);
            this.Controls.Add(this.Gpb_datosm);
            this.Controls.Add(this.Lbl_titulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Citas_Load);
            this.Gpb_datosm.ResumeLayout(false);
            this.Gpb_datosm.PerformLayout();
            this.Pnl_datosp.ResumeLayout(false);
            this.Pnl_datosp.PerformLayout();
            this.Gpb_detalleCita.ResumeLayout(false);
            this.Gpb_detalleCita.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_examen)).EndInit();
            this.Gpb_cita.ResumeLayout(false);
            this.Gpb_cita.PerformLayout();
            this.Gpb_fechayhora.ResumeLayout(false);
            this.Gpb_fechayhora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.GroupBox Gpb_datosm;
        private System.Windows.Forms.Label Lbl_dpi;
        private System.Windows.Forms.Label Lbl_nombrep;
        private System.Windows.Forms.TextBox Txt_nombrep;
        private System.Windows.Forms.TextBox Txt_dpi;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_nitp;
        private System.Windows.Forms.Label Lbl_nitp;
        private System.Windows.Forms.TextBox Txt_direp;
        private System.Windows.Forms.Label Lbl_direp;
        private System.Windows.Forms.GroupBox Gpb_detalleCita;
        private System.Windows.Forms.TextBox Txt_hora;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Txt_estado;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.ComboBox Cmb_estado;
        private System.Windows.Forms.Label Lbl_numeroCita;
        private System.Windows.Forms.Label Txt_numero;
        private System.Windows.Forms.DataGridView Dgv_examen;
        private System.Windows.Forms.Label Lbl_examen;
        private System.Windows.Forms.ComboBox Cmb_examenes;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Label Lbl_info;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_agregar;
        private System.Windows.Forms.Label Lbl_guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Gpb_cita;
        private System.Windows.Forms.GroupBox Gpb_fechayhora;
        private System.Windows.Forms.Panel Pnl_datosp;
        private System.Windows.Forms.Button button2;
    }
}