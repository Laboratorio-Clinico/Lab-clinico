namespace LaboratorioClinico
{
    partial class Mantenimiento
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
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Lbl_tabla = new System.Windows.Forms.Label();
            this.Cmb_tabla = new System.Windows.Forms.ComboBox();
            this.Gpb_mantenimiento = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Txt_nombrep = new System.Windows.Forms.TextBox();
            this.Txt_telefonop = new System.Windows.Forms.TextBox();
            this.Txt_nitp = new System.Windows.Forms.TextBox();
            this.Txt_direccionp = new System.Windows.Forms.TextBox();
            this.Txt_refierep = new System.Windows.Forms.TextBox();
            this.Txt_expedientep = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Lbl_expedientep = new System.Windows.Forms.Label();
            this.Lbl_nombrep = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_telefonop = new System.Windows.Forms.Label();
            this.Lbl_nitp = new System.Windows.Forms.Label();
            this.Lbl_direccionp = new System.Windows.Forms.Label();
            this.Lbl_refierep = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_alergiasp = new System.Windows.Forms.TextBox();
            this.Lbl_alergiasp = new System.Windows.Forms.Label();
            this.Txt_tsangrep = new System.Windows.Forms.TextBox();
            this.Lbl_tipoSangrep = new System.Windows.Forms.Label();
            this.Txt_correoP = new System.Windows.Forms.TextBox();
            this.Lbl_correop = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Tbc_control = new System.Windows.Forms.TabControl();
            this.Gpb_mantenimiento.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Tbc_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.editar;
            this.Btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Editar.Location = new System.Drawing.Point(672, 34);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(53, 44);
            this.Btn_Editar.TabIndex = 4;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.goma_de_borrar;
            this.Btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_borrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_borrar.Location = new System.Drawing.Point(672, 34);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(53, 44);
            this.Btn_borrar.TabIndex = 4;
            this.Btn_borrar.UseVisualStyleBackColor = true;
            // 
            // Lbl_tabla
            // 
            this.Lbl_tabla.AutoSize = true;
            this.Lbl_tabla.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_tabla.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tabla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_tabla.Location = new System.Drawing.Point(299, 39);
            this.Lbl_tabla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_tabla.Name = "Lbl_tabla";
            this.Lbl_tabla.Size = new System.Drawing.Size(147, 22);
            this.Lbl_tabla.TabIndex = 1;
            this.Lbl_tabla.Text = "Seleccione tabla:";
            // 
            // Cmb_tabla
            // 
            this.Cmb_tabla.BackColor = System.Drawing.Color.LightBlue;
            this.Cmb_tabla.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_tabla.FormattingEnabled = true;
            this.Cmb_tabla.Location = new System.Drawing.Point(454, 35);
            this.Cmb_tabla.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_tabla.Name = "Cmb_tabla";
            this.Cmb_tabla.Size = new System.Drawing.Size(160, 26);
            this.Cmb_tabla.TabIndex = 0;
            // 
            // Gpb_mantenimiento
            // 
            this.Gpb_mantenimiento.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.Gpb_mantenimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gpb_mantenimiento.Controls.Add(this.Btn_Editar);
            this.Gpb_mantenimiento.Controls.Add(this.Lbl_tabla);
            this.Gpb_mantenimiento.Controls.Add(this.Cmb_tabla);
            this.Gpb_mantenimiento.Controls.Add(this.Tbc_control);
            this.Gpb_mantenimiento.Controls.Add(this.Btn_borrar);
            this.Gpb_mantenimiento.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_mantenimiento.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Gpb_mantenimiento.Location = new System.Drawing.Point(9, 12);
            this.Gpb_mantenimiento.Name = "Gpb_mantenimiento";
            this.Gpb_mantenimiento.Size = new System.Drawing.Size(745, 465);
            this.Gpb_mantenimiento.TabIndex = 3;
            this.Gpb_mantenimiento.TabStop = false;
            this.Gpb_mantenimiento.Text = "Mantenimiento";
            this.Gpb_mantenimiento.Enter += new System.EventHandler(this.Gpb_mantenimiento_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Txt_tsangrep);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.Lbl_correop);
            this.tabPage2.Controls.Add(this.Txt_correoP);
            this.tabPage2.Controls.Add(this.Txt_alergiasp);
            this.tabPage2.Controls.Add(this.Txt_expedientep);
            this.tabPage2.Controls.Add(this.Txt_refierep);
            this.tabPage2.Controls.Add(this.Txt_direccionp);
            this.tabPage2.Controls.Add(this.Txt_nitp);
            this.tabPage2.Controls.Add(this.Txt_telefonop);
            this.tabPage2.Controls.Add(this.Txt_nombrep);
            this.tabPage2.Controls.Add(this.Lbl_tipoSangrep);
            this.tabPage2.Controls.Add(this.Lbl_alergiasp);
            this.tabPage2.Controls.Add(this.Btn_buscar);
            this.tabPage2.Controls.Add(this.Lbl_refierep);
            this.tabPage2.Controls.Add(this.Lbl_direccionp);
            this.tabPage2.Controls.Add(this.Lbl_nitp);
            this.tabPage2.Controls.Add(this.Lbl_telefonop);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Lbl_nombrep);
            this.tabPage2.Controls.Add(this.Lbl_expedientep);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(700, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Txt_nombrep
            // 
            this.Txt_nombrep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nombrep.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombrep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_nombrep.Location = new System.Drawing.Point(139, 84);
            this.Txt_nombrep.Name = "Txt_nombrep";
            this.Txt_nombrep.Size = new System.Drawing.Size(271, 25);
            this.Txt_nombrep.TabIndex = 50;
            // 
            // Txt_telefonop
            // 
            this.Txt_telefonop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_telefonop.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefonop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_telefonop.Location = new System.Drawing.Point(139, 127);
            this.Txt_telefonop.Name = "Txt_telefonop";
            this.Txt_telefonop.Size = new System.Drawing.Size(123, 25);
            this.Txt_telefonop.TabIndex = 51;
            // 
            // Txt_nitp
            // 
            this.Txt_nitp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_nitp.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nitp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_nitp.Location = new System.Drawing.Point(281, 127);
            this.Txt_nitp.Name = "Txt_nitp";
            this.Txt_nitp.Size = new System.Drawing.Size(129, 25);
            this.Txt_nitp.TabIndex = 52;
            // 
            // Txt_direccionp
            // 
            this.Txt_direccionp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_direccionp.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccionp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_direccionp.Location = new System.Drawing.Point(139, 191);
            this.Txt_direccionp.Name = "Txt_direccionp";
            this.Txt_direccionp.Size = new System.Drawing.Size(271, 25);
            this.Txt_direccionp.TabIndex = 53;
            // 
            // Txt_refierep
            // 
            this.Txt_refierep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_refierep.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_refierep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_refierep.Location = new System.Drawing.Point(429, 191);
            this.Txt_refierep.Name = "Txt_refierep";
            this.Txt_refierep.Size = new System.Drawing.Size(180, 25);
            this.Txt_refierep.TabIndex = 54;
            // 
            // Txt_expedientep
            // 
            this.Txt_expedientep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_expedientep.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_expedientep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_expedientep.Location = new System.Drawing.Point(123, 22);
            this.Txt_expedientep.Name = "Txt_expedientep";
            this.Txt_expedientep.Size = new System.Drawing.Size(82, 25);
            this.Txt_expedientep.TabIndex = 55;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.comboBox2.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(429, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(57, 25);
            this.comboBox2.TabIndex = 56;
            // 
            // Lbl_expedientep
            // 
            this.Lbl_expedientep.AutoSize = true;
            this.Lbl_expedientep.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_expedientep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_expedientep.Location = new System.Drawing.Point(38, 24);
            this.Lbl_expedientep.Name = "Lbl_expedientep";
            this.Lbl_expedientep.Size = new System.Drawing.Size(79, 18);
            this.Lbl_expedientep.TabIndex = 57;
            this.Lbl_expedientep.Text = "Expediente:";
            // 
            // Lbl_nombrep
            // 
            this.Lbl_nombrep.AutoSize = true;
            this.Lbl_nombrep.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombrep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_nombrep.Location = new System.Drawing.Point(136, 69);
            this.Lbl_nombrep.Name = "Lbl_nombrep";
            this.Lbl_nombrep.Size = new System.Drawing.Size(138, 18);
            this.Lbl_nombrep.TabIndex = 58;
            this.Lbl_nombrep.Text = "Nombre del paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(426, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "Sexo:";
            // 
            // Lbl_telefonop
            // 
            this.Lbl_telefonop.AutoSize = true;
            this.Lbl_telefonop.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_telefonop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_telefonop.Location = new System.Drawing.Point(139, 112);
            this.Lbl_telefonop.Name = "Lbl_telefonop";
            this.Lbl_telefonop.Size = new System.Drawing.Size(65, 18);
            this.Lbl_telefonop.TabIndex = 60;
            this.Lbl_telefonop.Text = "Teléfono:";
            // 
            // Lbl_nitp
            // 
            this.Lbl_nitp.AutoSize = true;
            this.Lbl_nitp.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nitp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_nitp.Location = new System.Drawing.Point(280, 112);
            this.Lbl_nitp.Name = "Lbl_nitp";
            this.Lbl_nitp.Size = new System.Drawing.Size(47, 18);
            this.Lbl_nitp.TabIndex = 61;
            this.Lbl_nitp.Text = "N.I.T:";
            // 
            // Lbl_direccionp
            // 
            this.Lbl_direccionp.AutoSize = true;
            this.Lbl_direccionp.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_direccionp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_direccionp.Location = new System.Drawing.Point(139, 159);
            this.Lbl_direccionp.Name = "Lbl_direccionp";
            this.Lbl_direccionp.Size = new System.Drawing.Size(71, 18);
            this.Lbl_direccionp.TabIndex = 62;
            this.Lbl_direccionp.Text = "Dirección:";
            // 
            // Lbl_refierep
            // 
            this.Lbl_refierep.AutoSize = true;
            this.Lbl_refierep.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_refierep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_refierep.Location = new System.Drawing.Point(426, 169);
            this.Lbl_refierep.Name = "Lbl_refierep";
            this.Lbl_refierep.Size = new System.Drawing.Size(95, 18);
            this.Lbl_refierep.TabIndex = 63;
            this.Lbl_refierep.Text = "Quién refiere:";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_buscar.BackgroundImage = global::LaboratorioClinico.Properties.Resources.file;
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_buscar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_buscar.Location = new System.Drawing.Point(220, 11);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(53, 44);
            this.Btn_buscar.TabIndex = 64;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            // 
            // Txt_alergiasp
            // 
            this.Txt_alergiasp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_alergiasp.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_alergiasp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_alergiasp.Location = new System.Drawing.Point(139, 292);
            this.Txt_alergiasp.Multiline = true;
            this.Txt_alergiasp.Name = "Txt_alergiasp";
            this.Txt_alergiasp.Size = new System.Drawing.Size(470, 51);
            this.Txt_alergiasp.TabIndex = 65;
            // 
            // Lbl_alergiasp
            // 
            this.Lbl_alergiasp.AutoSize = true;
            this.Lbl_alergiasp.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_alergiasp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_alergiasp.Location = new System.Drawing.Point(139, 271);
            this.Lbl_alergiasp.Name = "Lbl_alergiasp";
            this.Lbl_alergiasp.Size = new System.Drawing.Size(57, 18);
            this.Lbl_alergiasp.TabIndex = 66;
            this.Lbl_alergiasp.Text = "Alergías";
            // 
            // Txt_tsangrep
            // 
            this.Txt_tsangrep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_tsangrep.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_tsangrep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_tsangrep.Location = new System.Drawing.Point(429, 131);
            this.Txt_tsangrep.Name = "Txt_tsangrep";
            this.Txt_tsangrep.Size = new System.Drawing.Size(180, 25);
            this.Txt_tsangrep.TabIndex = 67;
            // 
            // Lbl_tipoSangrep
            // 
            this.Lbl_tipoSangrep.AutoSize = true;
            this.Lbl_tipoSangrep.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoSangrep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_tipoSangrep.Location = new System.Drawing.Point(426, 117);
            this.Lbl_tipoSangrep.Name = "Lbl_tipoSangrep";
            this.Lbl_tipoSangrep.Size = new System.Drawing.Size(79, 18);
            this.Lbl_tipoSangrep.TabIndex = 68;
            this.Lbl_tipoSangrep.Text = "Tipo Sangre";
            // 
            // Txt_correoP
            // 
            this.Txt_correoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(246)))));
            this.Txt_correoP.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_correoP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_correoP.Location = new System.Drawing.Point(139, 242);
            this.Txt_correoP.Name = "Txt_correoP";
            this.Txt_correoP.Size = new System.Drawing.Size(470, 25);
            this.Txt_correoP.TabIndex = 69;
            // 
            // Lbl_correop
            // 
            this.Lbl_correop.AutoSize = true;
            this.Lbl_correop.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_correop.Location = new System.Drawing.Point(139, 220);
            this.Lbl_correop.Name = "Lbl_correop";
            this.Lbl_correop.Size = new System.Drawing.Size(56, 18);
            this.Lbl_correop.TabIndex = 70;
            this.Lbl_correop.Text = "Correo:";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(700, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modificar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Tbc_control
            // 
            this.Tbc_control.Controls.Add(this.tabPage1);
            this.Tbc_control.Controls.Add(this.tabPage2);
            this.Tbc_control.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbc_control.Location = new System.Drawing.Point(17, 85);
            this.Tbc_control.Margin = new System.Windows.Forms.Padding(4);
            this.Tbc_control.Name = "Tbc_control";
            this.Tbc_control.SelectedIndex = 0;
            this.Tbc_control.Size = new System.Drawing.Size(708, 354);
            this.Tbc_control.TabIndex = 0;
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioClinico.Properties.Resources.FONDOO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 489);
            this.Controls.Add(this.Gpb_mantenimiento);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            this.Gpb_mantenimiento.ResumeLayout(false);
            this.Gpb_mantenimiento.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Tbc_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl_tabla;
        private System.Windows.Forms.ComboBox Cmb_tabla;
        private System.Windows.Forms.GroupBox Gpb_mantenimiento;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.TabControl Tbc_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Lbl_correop;
        private System.Windows.Forms.TextBox Txt_correoP;
        private System.Windows.Forms.TextBox Txt_tsangrep;
        private System.Windows.Forms.TextBox Txt_alergiasp;
        private System.Windows.Forms.TextBox Txt_expedientep;
        private System.Windows.Forms.TextBox Txt_refierep;
        private System.Windows.Forms.TextBox Txt_direccionp;
        private System.Windows.Forms.TextBox Txt_nitp;
        private System.Windows.Forms.TextBox Txt_telefonop;
        private System.Windows.Forms.TextBox Txt_nombrep;
        private System.Windows.Forms.Label Lbl_tipoSangrep;
        private System.Windows.Forms.Label Lbl_alergiasp;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_refierep;
        private System.Windows.Forms.Label Lbl_direccionp;
        private System.Windows.Forms.Label Lbl_nitp;
        private System.Windows.Forms.Label Lbl_telefonop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_nombrep;
        private System.Windows.Forms.Label Lbl_expedientep;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}