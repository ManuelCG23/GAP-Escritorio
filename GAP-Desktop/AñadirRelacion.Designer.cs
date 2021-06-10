
namespace PruebaC
{
    partial class AñadirRelacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_horario = new System.Windows.Forms.Label();
            this.cBox_trabajador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_prioridad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dT_ini = new System.Windows.Forms.DateTimePicker();
            this.dt_fin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horario:";
            // 
            // lbl_horario
            // 
            this.lbl_horario.AutoSize = true;
            this.lbl_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horario.Location = new System.Drawing.Point(178, 35);
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(236, 29);
            this.lbl_horario.TabIndex = 1;
            this.lbl_horario.Text = "Horario a modificar";
            // 
            // cBox_trabajador
            // 
            this.cBox_trabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_trabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_trabajador.FormattingEnabled = true;
            this.cBox_trabajador.Location = new System.Drawing.Point(127, 111);
            this.cBox_trabajador.Name = "cBox_trabajador";
            this.cBox_trabajador.Size = new System.Drawing.Size(188, 24);
            this.cBox_trabajador.TabIndex = 4;
            this.cBox_trabajador.SelectedValueChanged += new System.EventHandler(this.cBox_trabajador_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trabajador";
            // 
            // txt_prioridad
            // 
            this.txt_prioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prioridad.Location = new System.Drawing.Point(127, 182);
            this.txt_prioridad.Name = "txt_prioridad";
            this.txt_prioridad.Size = new System.Drawing.Size(188, 22);
            this.txt_prioridad.TabIndex = 6;
            this.txt_prioridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prioridad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prioridad";
            // 
            // dT_ini
            // 
            this.dT_ini.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dT_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dT_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dT_ini.Location = new System.Drawing.Point(527, 112);
            this.dT_ini.Name = "dT_ini";
            this.dT_ini.Size = new System.Drawing.Size(111, 24);
            this.dT_ini.TabIndex = 49;
            // 
            // dt_fin
            // 
            this.dt_fin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fin.Location = new System.Drawing.Point(527, 184);
            this.dt_fin.Name = "dt_fin";
            this.dt_fin.Size = new System.Drawing.Size(111, 24);
            this.dt_fin.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Fecha Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Fecha Inicial";
            // 
            // btn_insertar
            // 
            this.btn_insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertar.Location = new System.Drawing.Point(127, 249);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(151, 48);
            this.btn_insertar.TabIndex = 56;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(427, 249);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(151, 48);
            this.btn_cancelar.TabIndex = 57;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // AñadirRelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 322);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_insertar);
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
            this.Name = "AñadirRelacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAP-Crear Relación";
            this.Load += new System.EventHandler(this.AñadirRelacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_horario;
        private System.Windows.Forms.ComboBox cBox_trabajador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_prioridad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dT_ini;
        private System.Windows.Forms.DateTimePicker dt_fin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}