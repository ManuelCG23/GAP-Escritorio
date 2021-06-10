using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaC
{
    public partial class MensajeRecuperación : Form
    {

        public string usuario;

        public MensajeRecuperación(string usu)
        {
            InitializeComponent();
            this.usuario = usu;
        }

        MySqlConnection conexion = Conexion.conexion;
        Cifrado c = new Cifrado();
        public int contador = 0;

        private void MensajeRecuperación_Load(object sender, EventArgs e)
        {
            txt_usuario.Text = usuario;
        }

        public string generadorContraseña()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudPassword = 10;
            string passwordAleatoria = "!";
            for (int i = 0; i < longitudPassword; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                passwordAleatoria += letra.ToString();
            }

            return passwordAleatoria;
        }

        public void cambiarContraseña(String contra)
        {
            conexion.Open();

            string query = "UPDATE accesos SET contraseña = '" + c.cifrar(contra) + "' where DNI = '" + usuario + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public string[] obtenerCorreoOrigen()
        {
            string[] correo = new string[2];

            conexion.Open();

            string query = "Select correo, contraseña from recuperacion";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                correo[0] = reader.GetString(0);
                correo[1] = reader.GetString(1);
            }

            reader.Close();

            conexion.Close();

            return correo;
        }

        public string obtenerCorreoDestino()
        {
            string correo = "";

            conexion.Open();

            string query = "Select correo from empleados where DNI = '"+txt_usuario.Text+"'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                correo = reader.GetString(0);
            }

            reader.Close();

            conexion.Close();

            return correo;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                lbl_titulo.Text = "¿Esta seguro de obtener una nueva contraseña?";
                lbl_anot.Text = "Una vez realizada tendrá que usar la nueva contraseña";
                bt_accion.Text = "Si";
                bt_cancelar.Text = "No";
                txt_usuario.Enabled = false;

                contador++;
            }
            else
            {
                string[] credenciales = obtenerCorreoOrigen();

                string emailOrigen = credenciales[0], contra = c.descifrar(credenciales[1]);
                string emailDestino = obtenerCorreoDestino();
                string nuevaContra = generadorContraseña();

                // MessageBox.Show("Email origen-->" + emailOrigen + " - Contraseña --> " + contra + " - Email Destino --> " + emailDestino + " - nuevaContra --> " + nuevaContra);



                if (emailDestino.Length == 0)
                {
                    MessageBox.Show("El usuario no tiene asociado un correo. Pongase en contacto con otro administrador o con el soporte técnico");
                    this.Dispose();
                }
                else
                {
                    MailMessage mg = new MailMessage(emailOrigen, emailDestino, "Recuperación de contraseña", "Correo generado de forma automática para facilitar la nueva contraseña(" + nuevaContra + "). Una vez que inicie sesión, podrá cambiarla a su gusto");

                    mg.IsBodyHtml = true;

                    SmtpClient cliente = new SmtpClient("smtp.gmail.com");
                    cliente.EnableSsl = true;
                    cliente.UseDefaultCredentials = false;
                    cliente.Port = 587;
                    cliente.Credentials = new System.Net.NetworkCredential(emailOrigen, contra);

                    try
                    {
                        cliente.Send(mg);
                        cambiarContraseña(nuevaContra);
                        MessageBox.Show("Se ha enviado el correo");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Se ha producido un error al enviar el mensaje. Prueba mas tarde");
                        this.Close();
                    }
                }
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
