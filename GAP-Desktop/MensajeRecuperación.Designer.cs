
namespace PruebaC
{
    partial class MensajeRecuperación
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_anot = new System.Windows.Forms.Label();
            this.bt_accion = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(79, 34);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(407, 18);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "¿Desea recibir una nueva contraseña de transicción?";
            // 
            // lbl_anot
            // 
            this.lbl_anot.AutoSize = true;
            this.lbl_anot.Location = new System.Drawing.Point(133, 62);
            this.lbl_anot.Name = "lbl_anot";
            this.lbl_anot.Size = new System.Drawing.Size(281, 13);
            this.lbl_anot.TabIndex = 1;
            this.lbl_anot.Text = "Una vez se acceda con ella podrá cambiar por una propia";
            // 
            // bt_accion
            // 
            this.bt_accion.Location = new System.Drawing.Point(136, 147);
            this.bt_accion.Name = "bt_accion";
            this.bt_accion.Size = new System.Drawing.Size(105, 23);
            this.bt_accion.TabIndex = 2;
            this.bt_accion.Text = "Enviar";
            this.bt_accion.UseVisualStyleBackColor = true;
            this.bt_accion.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(309, 147);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(105, 23);
            this.bt_cancelar.TabIndex = 4;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_usuario.Location = new System.Drawing.Point(208, 94);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(169, 20);
            this.txt_usuario.TabIndex = 5;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario";
            // 
            // MensajeRecuperación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 194);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_accion);
            this.Controls.Add(this.lbl_anot);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MensajeRecuperación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperación";
            this.Load += new System.EventHandler(this.MensajeRecuperación_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_anot;
        private System.Windows.Forms.Button bt_accion;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label3;
    }
}