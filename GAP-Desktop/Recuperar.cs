using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaC
{
    public partial class Recuperar : Form
    {
        public string usuario;

        public Recuperar(string usu)
        {
            InitializeComponent();
            this.usuario = usu;
        }

        MySqlConnection conexion = Conexion.conexion;
        Cifrado c = new Cifrado();

        private void Recuperar_Load(object sender, EventArgs e)
        {
            txt_usuario.Text = usuario;
            txt_contraseña1.UseSystemPasswordChar = true;
            txt_contraseña2.UseSystemPasswordChar = true;

        }

        private void cBox_Mostrar2_CheckedChanged(object sender, EventArgs e)
        {
            string text1 = txt_contraseña1.Text;
            string text2 = txt_contraseña2.Text;
            if (!cBox_Mostrar2.Checked)
            {
                txt_contraseña1.UseSystemPasswordChar = true;
                txt_contraseña2.UseSystemPasswordChar = true;
            }
            else {
                txt_contraseña1.UseSystemPasswordChar = false;
                txt_contraseña2.UseSystemPasswordChar = false;
            }

            txt_contraseña1.Text = text1;
            txt_contraseña2.Text = text2;
        }

        public void cambiarContraseña(String contra)
        {
            conexion.Open();

            string query = "UPDATE accesos SET contraseña = '" + c.cifrar(contra) + "' where DNI = '" + usuario + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        private void bt_recuperar_Click(object sender, EventArgs e)
        {
            if(txt_contraseña1.Text == txt_contraseña2.Text)
            {
                cambiarContraseña(txt_contraseña1.Text);

                MessageBox.Show("Contraseña actualizada");
            }
        }
    }
}
