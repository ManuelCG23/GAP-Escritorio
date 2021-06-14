
namespace PruebaC
{
    partial class Borrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrar));
            this.lbl_uno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_accion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_dos = new System.Windows.Forms.Label();
            this.lbl_tres = new System.Windows.Forms.Label();
            this.lbl_tres_dos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_uno
            // 
            this.lbl_uno.AutoSize = true;
            this.lbl_uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uno.Location = new System.Drawing.Point(127, 38);
            this.lbl_uno.Name = "lbl_uno";
            this.lbl_uno.Size = new System.Drawing.Size(352, 16);
            this.lbl_uno.TabIndex = 1;
            this.lbl_uno.Text = "Esta a punto de dar de baja al empleado con NIF ";
            this.lbl_uno.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(489, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "¿Esta seguro de realizar esta operación?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // bt_accion
            // 
            this.bt_accion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(46)))), ((int)(((byte)(71)))));
            this.bt_accion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_accion.ForeColor = System.Drawing.Color.White;
            this.bt_accion.Location = new System.Drawing.Point(161, 156);
            this.bt_accion.Name = "bt_accion";
            this.bt_accion.Size = new System.Drawing.Size(129, 59);
            this.bt_accion.TabIndex = 32;
            this.bt_accion.Text = "Borrar";
            this.bt_accion.UseVisualStyleBackColor = false;
            this.bt_accion.Click += new System.EventHandler(this.bt_accion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(46)))), ((int)(((byte)(71)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(390, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 59);
            this.button1.TabIndex = 33;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_dos
            // 
            this.lbl_dos.AutoSize = true;
            this.lbl_dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dos.Location = new System.Drawing.Point(158, 38);
            this.lbl_dos.Name = "lbl_dos";
            this.lbl_dos.Size = new System.Drawing.Size(249, 16);
            this.lbl_dos.TabIndex = 34;
            this.lbl_dos.Text = "Esta a punto de eliminar el horario ";
            this.lbl_dos.Visible = false;
            // 
            // lbl_tres
            // 
            this.lbl_tres.AutoSize = true;
            this.lbl_tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tres.Location = new System.Drawing.Point(158, 38);
            this.lbl_tres.Name = "lbl_tres";
            this.lbl_tres.Size = new System.Drawing.Size(256, 16);
            this.lbl_tres.TabIndex = 35;
            this.lbl_tres.Text = "Esta a punto de quitar al trabajador ";
            this.lbl_tres.Visible = false;
            // 
            // lbl_tres_dos
            // 
            this.lbl_tres_dos.AutoSize = true;
            this.lbl_tres_dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tres_dos.Location = new System.Drawing.Point(212, 54);
            this.lbl_tres_dos.Name = "lbl_tres_dos";
            this.lbl_tres_dos.Size = new System.Drawing.Size(78, 16);
            this.lbl_tres_dos.TabIndex = 36;
            this.lbl_tres_dos.Text = "el horario ";
            this.lbl_tres_dos.Visible = false;
            // 
            // Borrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(132)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(699, 246);
            this.Controls.Add(this.lbl_tres_dos);
            this.Controls.Add(this.lbl_tres);
            this.Controls.Add(this.lbl_dos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_accion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_uno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Borrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAP-Borrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_uno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_accion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_dos;
        private System.Windows.Forms.Label lbl_tres;
        private System.Windows.Forms.Label lbl_tres_dos;
    }
}