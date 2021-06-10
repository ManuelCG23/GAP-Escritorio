
namespace PruebaC
{
    partial class EditarRelacion
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_fin = new System.Windows.Forms.DateTimePicker();
            this.dT_ini = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_prioridad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBox_trabajador = new System.Windows.Forms.ComboBox();
            this.lbl_horario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_trabajador = new System.Windows.Forms.Label();
            this.lbl_prioridad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(434, 247);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(151, 48);
            this.btn_cancelar.TabIndex = 69;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(134, 247);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(151, 48);
            this.btn_editar.TabIndex = 68;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Fecha Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 66;
            this.label6.Text = "Fecha Inicial";
            // 
            // dt_fin
            // 
            this.dt_fin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fin.Enabled = false;
            this.dt_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fin.Location = new System.Drawing.Point(534, 182);
            this.dt_fin.Name = "dt_fin";
            this.dt_fin.Size = new System.Drawing.Size(111, 24);
            this.dt_fin.TabIndex = 65;
            // 
            // dT_ini
            // 
            this.dT_ini.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dT_ini.Enabled = false;
            this.dT_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dT_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dT_ini.Location = new System.Drawing.Point(534, 110);
            this.dT_ini.Name = "dT_ini";
            this.dT_ini.Size = new System.Drawing.Size(111, 24);
            this.dT_ini.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 63;
            this.label4.Text = "Prioridad";
            // 
            // txt_prioridad
            // 
            this.txt_prioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prioridad.Location = new System.Drawing.Point(134, 180);
            this.txt_prioridad.Name = "txt_prioridad";
            this.txt_prioridad.Size = new System.Drawing.Size(188, 22);
            this.txt_prioridad.TabIndex = 62;
            this.txt_prioridad.Visible = false;
            this.txt_prioridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prioridad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Trabajador";
            // 
            // cBox_trabajador
            // 
            this.cBox_trabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_trabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_trabajador.FormattingEnabled = true;
            this.cBox_trabajador.Location = new System.Drawing.Point(134, 109);
            this.cBox_trabajador.Name = "cBox_trabajador";
            this.cBox_trabajador.Size = new System.Drawing.Size(188, 24);
            this.cBox_trabajador.TabIndex = 60;
            this.cBox_trabajador.Visible = false;
            this.cBox_trabajador.SelectedValueChanged += new System.EventHandler(this.cBox_trabajador_SelectedValueChanged);
            // 
            // lbl_horario
            // 
            this.lbl_horario.AutoSize = true;
            this.lbl_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horario.Location = new System.Drawing.Point(185, 33);
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(236, 29);
            this.lbl_horario.TabIndex = 59;
            this.lbl_horario.Text = "Horario a modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 42);
            this.label1.TabIndex = 58;
            this.label1.Text = "Horario:";
            // 
            // lbl_trabajador
            // 
            this.lbl_trabajador.AutoSize = true;
            this.lbl_trabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trabajador.Location = new System.Drawing.Point(172, 110);
            this.lbl_trabajador.Name = "lbl_trabajador";
            this.lbl_trabajador.Size = new System.Drawing.Size(79, 18);
            this.lbl_trabajador.TabIndex = 70;
            this.lbl_trabajador.Text = "Trabajador";
            // 
            // lbl_prioridad
            // 
            this.lbl_prioridad.AutoSize = true;
            this.lbl_prioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prioridad.Location = new System.Drawing.Point(172, 182);
            this.lbl_prioridad.Name = "lbl_prioridad";
            this.lbl_prioridad.Size = new System.Drawing.Size(67, 18);
            this.lbl_prioridad.TabIndex = 71;
            this.lbl_prioridad.Text = "Prioridad";
            // 
            // EditarRelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 321);
            this.Controls.Add(this.lbl_prioridad);
            this.Controls.Add(this.lbl_trabajador);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_fin);
            this.Controls.Add(this.dT_ini);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_prioridad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBox_trabajador);
            this.Controls.Add(this.lbl_horario);
            this.Controls.Add(this.label1);
            this.Name = "EditarRelacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAP-Editar Realcion";
            this.Load += new System.EventHandler(this.EditarRealcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_fin;
        private System.Windows.Forms.DateTimePicker dT_ini;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_prioridad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBox_trabajador;
        private System.Windows.Forms.Label lbl_horario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_trabajador;
        private System.Windows.Forms.Label lbl_prioridad;
    }
}