
namespace PruebaC
{
    partial class Editar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cBox_pass = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.cbox_crendecialTipo = new System.Windows.Forms.ComboBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_Letra = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.lbl_titu_num2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dT_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.rb_mujer = new System.Windows.Forms.RadioButton();
            this.rb_otro = new System.Windows.Forms.RadioButton();
            this.rb_hombre = new System.Windows.Forms.RadioButton();
            this.txt_nacionalidad = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_DniC = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Nacionalidad = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.lbl_contra = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_tipo);
            this.groupBox1.Controls.Add(this.cBox_pass);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txt_contra);
            this.groupBox1.Controls.Add(this.cbox_crendecialTipo);
            this.groupBox1.Controls.Add(this.lbl_contra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(554, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 224);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales de acceso";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(223, 82);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(36, 16);
            this.lbl_tipo.TabIndex = 102;
            this.lbl_tipo.Text = "Tipo";
            // 
            // cBox_pass
            // 
            this.cBox_pass.AutoSize = true;
            this.cBox_pass.BackColor = System.Drawing.Color.Transparent;
            this.cBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_pass.Location = new System.Drawing.Point(219, 177);
            this.cBox_pass.Name = "cBox_pass";
            this.cBox_pass.Size = new System.Drawing.Size(117, 17);
            this.cBox_pass.TabIndex = 63;
            this.cBox_pass.Text = "Mostrar contraseña";
            this.cBox_pass.UseVisualStyleBackColor = false;
            this.cBox_pass.Visible = false;
            this.cBox_pass.CheckedChanged += new System.EventHandler(this.cBox_pass_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(86, 79);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 16);
            this.label24.TabIndex = 16;
            this.label24.Text = "Tipo";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(85, 141);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 16);
            this.label23.TabIndex = 15;
            this.label23.Text = "Contraseña";
            // 
            // txt_contra
            // 
            this.txt_contra.Enabled = false;
            this.txt_contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contra.Location = new System.Drawing.Point(219, 138);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(171, 22);
            this.txt_contra.TabIndex = 14;
            // 
            // cbox_crendecialTipo
            // 
            this.cbox_crendecialTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_crendecialTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_crendecialTipo.FormattingEnabled = true;
            this.cbox_crendecialTipo.Location = new System.Drawing.Point(219, 79);
            this.cbox_crendecialTipo.Name = "cbox_crendecialTipo";
            this.cbox_crendecialTipo.Size = new System.Drawing.Size(171, 24);
            this.cbox_crendecialTipo.TabIndex = 104;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dni.Location = new System.Drawing.Point(189, 100);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(178, 24);
            this.txt_Dni.TabIndex = 91;
            this.txt_Dni.Visible = false;
            this.txt_Dni.TextChanged += new System.EventHandler(this.txt_Dni_TextChanged);
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dni_KeyPress);
            // 
            // txt_num2
            // 
            this.txt_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num2.Location = new System.Drawing.Point(254, 450);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(178, 24);
            this.txt_num2.TabIndex = 90;
            this.txt_num2.Visible = false;
            this.txt_num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num2_KeyPress);
            // 
            // txt_num1
            // 
            this.txt_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num1.Location = new System.Drawing.Point(255, 390);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(178, 24);
            this.txt_num1.TabIndex = 89;
            this.txt_num1.Visible = false;
            this.txt_num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num1_KeyPress);
            // 
            // txt_Letra
            // 
            this.txt_Letra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Letra.Location = new System.Drawing.Point(402, 101);
            this.txt_Letra.Name = "txt_Letra";
            this.txt_Letra.Size = new System.Drawing.Size(27, 24);
            this.txt_Letra.TabIndex = 88;
            this.txt_Letra.Visible = false;
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(615, 496);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(151, 48);
            this.btn_editar.TabIndex = 86;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // lbl_titu_num2
            // 
            this.lbl_titu_num2.AutoSize = true;
            this.lbl_titu_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titu_num2.Location = new System.Drawing.Point(27, 450);
            this.lbl_titu_num2.Name = "lbl_titu_num2";
            this.lbl_titu_num2.Size = new System.Drawing.Size(162, 18);
            this.lbl_titu_num2.TabIndex = 84;
            this.lbl_titu_num2.Text = "Teléfono secundario";
            this.lbl_titu_num2.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(27, 390);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(157, 18);
            this.label19.TabIndex = 83;
            this.label19.Text = "Número de teléfono";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad.Location = new System.Drawing.Point(961, 106);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(16, 18);
            this.lbl_edad.TabIndex = 82;
            this.lbl_edad.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(884, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 18);
            this.label21.TabIndex = 81;
            this.label21.Text = "Edad";
            // 
            // dT_nacimiento
            // 
            this.dT_nacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dT_nacimiento.Enabled = false;
            this.dT_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dT_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dT_nacimiento.Location = new System.Drawing.Point(719, 104);
            this.dT_nacimiento.Name = "dT_nacimiento";
            this.dT_nacimiento.Size = new System.Drawing.Size(111, 24);
            this.dT_nacimiento.TabIndex = 80;
            this.dT_nacimiento.ValueChanged += new System.EventHandler(this.dT_nacimiento_ValueChanged);
            // 
            // rb_mujer
            // 
            this.rb_mujer.AutoSize = true;
            this.rb_mujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_mujer.ForeColor = System.Drawing.Color.Black;
            this.rb_mujer.Location = new System.Drawing.Point(285, 321);
            this.rb_mujer.Name = "rb_mujer";
            this.rb_mujer.Size = new System.Drawing.Size(63, 22);
            this.rb_mujer.TabIndex = 79;
            this.rb_mujer.TabStop = true;
            this.rb_mujer.Text = "Mujer";
            this.rb_mujer.UseVisualStyleBackColor = true;
            this.rb_mujer.Visible = false;
            // 
            // rb_otro
            // 
            this.rb_otro.AutoSize = true;
            this.rb_otro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_otro.ForeColor = System.Drawing.Color.Black;
            this.rb_otro.Location = new System.Drawing.Point(376, 321);
            this.rb_otro.Name = "rb_otro";
            this.rb_otro.Size = new System.Drawing.Size(56, 22);
            this.rb_otro.TabIndex = 78;
            this.rb_otro.TabStop = true;
            this.rb_otro.Text = "Otro";
            this.rb_otro.UseVisualStyleBackColor = true;
            this.rb_otro.Visible = false;
            // 
            // rb_hombre
            // 
            this.rb_hombre.AutoSize = true;
            this.rb_hombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_hombre.ForeColor = System.Drawing.Color.Black;
            this.rb_hombre.Location = new System.Drawing.Point(189, 321);
            this.rb_hombre.Name = "rb_hombre";
            this.rb_hombre.Size = new System.Drawing.Size(80, 22);
            this.rb_hombre.TabIndex = 77;
            this.rb_hombre.TabStop = true;
            this.rb_hombre.Text = "Hombre";
            this.rb_hombre.UseVisualStyleBackColor = true;
            this.rb_hombre.Visible = false;
            // 
            // txt_nacionalidad
            // 
            this.txt_nacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nacionalidad.Location = new System.Drawing.Point(189, 269);
            this.txt_nacionalidad.Name = "txt_nacionalidad";
            this.txt_nacionalidad.Size = new System.Drawing.Size(242, 24);
            this.txt_nacionalidad.TabIndex = 76;
            this.txt_nacionalidad.Visible = false;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(718, 211);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(281, 24);
            this.txt_email.TabIndex = 75;
            this.txt_email.Visible = false;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(718, 155);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(281, 24);
            this.txt_direccion.TabIndex = 74;
            this.txt_direccion.Visible = false;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.Location = new System.Drawing.Point(189, 211);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(242, 24);
            this.txt_apellidos.TabIndex = 73;
            this.txt_apellidos.Visible = false;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(189, 155);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(242, 24);
            this.txt_Nombre.TabIndex = 72;
            this.txt_Nombre.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(513, 214);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 18);
            this.label18.TabIndex = 71;
            this.label18.Text = "Correo electrónico";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(72, 214);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 18);
            this.label17.TabIndex = 70;
            this.label17.Text = "Apellidos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(57, 272);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 18);
            this.label16.TabIndex = 69;
            this.label16.Text = "Nacionalidad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(498, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 18);
            this.label15.TabIndex = 68;
            this.label15.Text = "Fecha de Nacimiento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(535, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 67;
            this.label14.Text = "Dirección";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(77, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 18);
            this.label13.TabIndex = 66;
            this.label13.Text = "Sexo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(72, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 65;
            this.label12.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(87, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 18);
            this.label11.TabIndex = 64;
            this.label11.Text = "DNI";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(26, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(138, 55);
            this.lbl_titulo.TabIndex = 63;
            this.lbl_titulo.Text = "Perfil";
            // 
            // lbl_DniC
            // 
            this.lbl_DniC.AutoSize = true;
            this.lbl_DniC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DniC.Location = new System.Drawing.Point(221, 102);
            this.lbl_DniC.Name = "lbl_DniC";
            this.lbl_DniC.Size = new System.Drawing.Size(106, 18);
            this.lbl_DniC.TabIndex = 93;
            this.lbl_DniC.Text = "DNI_Completo";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(221, 158);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(62, 18);
            this.lbl_Nombre.TabIndex = 94;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.Location = new System.Drawing.Point(221, 215);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(67, 18);
            this.lbl_Apellidos.TabIndex = 95;
            this.lbl_Apellidos.Text = "Apellidos";
            // 
            // lbl_Nacionalidad
            // 
            this.lbl_Nacionalidad.AutoSize = true;
            this.lbl_Nacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nacionalidad.Location = new System.Drawing.Point(221, 272);
            this.lbl_Nacionalidad.Name = "lbl_Nacionalidad";
            this.lbl_Nacionalidad.Size = new System.Drawing.Size(93, 18);
            this.lbl_Nacionalidad.TabIndex = 96;
            this.lbl_Nacionalidad.Text = "Nacionalidad";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(722, 158);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(71, 18);
            this.lbl_direccion.TabIndex = 100;
            this.lbl_direccion.Text = "Dirección";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num2.Location = new System.Drawing.Point(259, 453);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(48, 18);
            this.lbl_num2.TabIndex = 99;
            this.lbl_num2.Text = "Num2";
            this.lbl_num2.Visible = false;
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num1.Location = new System.Drawing.Point(258, 393);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(48, 18);
            this.lbl_num1.TabIndex = 98;
            this.lbl_num1.Text = "Num1";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.Location = new System.Drawing.Point(221, 321);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(42, 18);
            this.lbl_sexo.TabIndex = 97;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(720, 214);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(55, 18);
            this.lbl_correo.TabIndex = 101;
            this.lbl_correo.Text = "Correo";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cerrar.Location = new System.Drawing.Point(827, 496);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(151, 48);
            this.bt_cerrar.TabIndex = 102;
            this.bt_cerrar.Text = "Cerrar";
            this.bt_cerrar.UseVisualStyleBackColor = true;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // lbl_contra
            // 
            this.lbl_contra.AutoSize = true;
            this.lbl_contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contra.Location = new System.Drawing.Point(223, 140);
            this.lbl_contra.Name = "lbl_contra";
            this.lbl_contra.Size = new System.Drawing.Size(77, 16);
            this.lbl_contra.TabIndex = 103;
            this.lbl_contra.Text = "Contraseña";
            this.lbl_contra.Visible = false;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 566);
            this.Controls.Add(this.bt_cerrar);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_Nacionalidad);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_DniC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.txt_Letra);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lbl_titu_num2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dT_nacimiento);
            this.Controls.Add(this.rb_mujer);
            this.Controls.Add(this.rb_otro);
            this.Controls.Add(this.rb_hombre);
            this.Controls.Add(this.txt_nacionalidad);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAP-";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBox_pass;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_Letra;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label lbl_titu_num2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dT_nacimiento;
        private System.Windows.Forms.RadioButton rb_mujer;
        private System.Windows.Forms.RadioButton rb_otro;
        private System.Windows.Forms.RadioButton rb_hombre;
        private System.Windows.Forms.TextBox txt_nacionalidad;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_DniC;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Nacionalidad;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_correo;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox cbox_crendecialTipo;
        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.Label lbl_contra;
    }
}