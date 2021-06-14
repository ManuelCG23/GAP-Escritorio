
namespace PruebaC
{
    partial class Recuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperar));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña1 = new System.Windows.Forms.TextBox();
            this.txt_contraseña2 = new System.Windows.Forms.TextBox();
            this.cBox_Mostrar2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_recuperar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(185, 133);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(170, 24);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.Text = "78945612K";
            // 
            // txt_contraseña1
            // 
            this.txt_contraseña1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña1.Location = new System.Drawing.Point(185, 183);
            this.txt_contraseña1.Name = "txt_contraseña1";
            this.txt_contraseña1.Size = new System.Drawing.Size(170, 24);
            this.txt_contraseña1.TabIndex = 1;
            // 
            // txt_contraseña2
            // 
            this.txt_contraseña2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña2.Location = new System.Drawing.Point(185, 233);
            this.txt_contraseña2.Name = "txt_contraseña2";
            this.txt_contraseña2.Size = new System.Drawing.Size(170, 24);
            this.txt_contraseña2.TabIndex = 2;
            // 
            // cBox_Mostrar2
            // 
            this.cBox_Mostrar2.AutoSize = true;
            this.cBox_Mostrar2.BackColor = System.Drawing.Color.Transparent;
            this.cBox_Mostrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Mostrar2.Location = new System.Drawing.Point(185, 273);
            this.cBox_Mostrar2.Name = "cBox_Mostrar2";
            this.cBox_Mostrar2.Size = new System.Drawing.Size(141, 17);
            this.cBox_Mostrar2.TabIndex = 16;
            this.cBox_Mostrar2.Text = "Mostrar contraseñas";
            this.cBox_Mostrar2.UseVisualStyleBackColor = false;
            this.cBox_Mostrar2.CheckedChanged += new System.EventHandler(this.cBox_Mostrar2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Recuperar Contraseña";
            // 
            // bt_recuperar
            // 
            this.bt_recuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(46)))), ((int)(((byte)(71)))));
            this.bt_recuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_recuperar.ForeColor = System.Drawing.Color.White;
            this.bt_recuperar.Location = new System.Drawing.Point(194, 308);
            this.bt_recuperar.Name = "bt_recuperar";
            this.bt_recuperar.Size = new System.Drawing.Size(132, 53);
            this.bt_recuperar.TabIndex = 19;
            this.bt_recuperar.Text = "Recuperar";
            this.bt_recuperar.UseVisualStyleBackColor = false;
            this.bt_recuperar.Click += new System.EventHandler(this.bt_recuperar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nueva Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Repetir Contraseña";
            // 
            // Recuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(132)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(479, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_recuperar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_Mostrar2);
            this.Controls.Add(this.txt_contraseña2);
            this.Controls.Add(this.txt_contraseña1);
            this.Controls.Add(this.txt_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recuperar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAP-Recuperar Contraseña";
            this.Load += new System.EventHandler(this.Recuperar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña1;
        private System.Windows.Forms.TextBox txt_contraseña2;
        private System.Windows.Forms.CheckBox cBox_Mostrar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_recuperar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}