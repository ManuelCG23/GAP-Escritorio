using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = Conexion.conexion;

        public int contador = 0;
        Cifrado c = new Cifrado();
        public string tipoUsuario, ip, usuario;

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = true;
            ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(ip => ip.AddressFamily.ToString().ToUpper().Equals("INTERNETWORK")).FirstOrDefault().ToString();

            /*this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/
        }

        public void insertarOperacion()
        {
            conexion.Open();

            string query = "INSERT INTO operacion (IP, usuario) VALUES ('" + ip + "','" + txt_usuario.Text + "')";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public int comprobarUsuario(String u)
        {
            int opc = 0;

            conexion.Open();

            string query = "Select DNI, contraseña, Tipo from accesos";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetString(0) == txt_usuario.Text)
                {
                    if (c.descifrar(reader.GetString(1)) == txt_contraseña.Text) opc = 1;
                    else opc = 2;

                    if(opc==1) tipoUsuario = reader.GetString(2);
                }
            }

            reader.Close();

            conexion.Close();

            return opc;
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text != "" && txt_contraseña.Text != "")
            {
                int opction = comprobarUsuario(txt_usuario.Text);

                if (opction == 0 || opction == 2)
                {
                    if (opction == 0) { 
                        MessageBox.Show("Usuario no registrado", "Error de credenciales");
                        label2.Visible = false;
                        label2.Enabled = false;
                    } 
                    else
                    {
                        if (opction == 2)
                        {
                            MessageBox.Show("Contraseña incorrecta", "Error de credenciales");

                            if (contador >= 2)
                            {
                                label2.Visible = true;
                                label2.Enabled = true;
                            }
                            contador++;
                        }
                    }

                     usuario = txt_usuario.Text;
                }
                else
                {
                    label2.Visible = false;
                    label2.Enabled = false;
                    contador = 0;
                    usuario = txt_usuario.Text;

                    if (txt_contraseña.Text.Substring(0, 1) == "!")
                    {
                        Recuperar rc = new Recuperar(usuario);
                        rc.ShowDialog();
                    }


                   // insertarOperacion();          //PENDIENTE 
                    //MessageBox.Show(usuario);
                    Principal p = new Principal(usuario, this);
                    p.Show();
                    this.Hide();

                }
            }
            else
            {
                if(txt_usuario.Text == "" && txt_contraseña.Text == "") MessageBox.Show("No se ha rellenado el usuario ni la contraseña", "Error");
                else
                {
                    if (txt_usuario.Text == "") MessageBox.Show("No se ha rellenado el usuario", "Error");
                    if (txt_contraseña.Text == "") MessageBox.Show("No se ha rellenado la contraseña", "Error");
                }
                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string text = txt_contraseña.Text;
            if (!checkBox2.Checked) txt_contraseña.UseSystemPasswordChar = true;
            else txt_contraseña.UseSystemPasswordChar = false;
            txt_contraseña.Text = text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MensajeRecuperación mR = new MensajeRecuperación(usuario);
            mR.ShowDialog();
        }
    }
}
