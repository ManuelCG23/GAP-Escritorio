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
    public partial class Editar : Form
    {
        Principal p;
        public String DNI, empresa;

        public Editar(string id, Principal x, string emp)
        {
            InitializeComponent();
            this.p = x;
            this.DNI = id;
            this.empresa = emp;
        }

        MySqlConnection conexion = Conexion.conexion;
        Cifrado c = new Cifrado();
        public int cantTelefono, edad;


        public void cargarDatos()
        {
            obtnerEmpleado();
            obtenerCredenciales(); 
            obtenerTelefonosEmpresa();
        }

        public void obtnerEmpleado()
        {
            conexion.Open();            

            string query = "Select DNI, nombre, apellidos, sexo, nacionalidad, fecha_nac, direccion, correo from empleados where empresa = '" + empresa + "' && DNI = '" + DNI + "'";
    
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())       
            {
                asignar(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5).ToShortDateString(), reader.GetString(6), reader.GetString(7));
            }

            reader.Close();
            conexion.Close();

        }

        public void obtenerCredenciales()
        {
            conexion.Open();

            string query = "Select contraseña, tipo from accesos where DNI = '" + DNI + "'";

            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                lbl_contra.Text = reader.GetString(0);
                txt_contra.Text = reader.GetString(0);
                lbl_tipo.Text = reader.GetString(1);

                

            }

            if (lbl_tipo.Text == "Escritorio") cbox_crendecialTipo.SelectedIndex = 2;
            else cbox_crendecialTipo.SelectedIndex = 1;


            conexion.Close();
        }

        public void obtenerCantidadTelefonoEmpleados()
        {
            conexion.Open();

            string query = "Select Count(numTelefono) from contacto_empleados where id_empleado = '" + DNI + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cantTelefono = reader.GetInt32(0);
            }

            reader.Close();

            conexion.Close();
        }

        public void obtenerTelefonosEmpresa()
        {

            obtenerCantidadTelefonoEmpleados();

            conexion.Open();

            string query = "Select numTelefono from contacto_empleados where id_empleado = '" + DNI + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            int i = 0;

            while (reader.Read())
            {

                if (i == 0)
                {
                    lbl_num1.Text = reader.GetString(0);
                    txt_num1.Text = reader.GetString(0);
                }
                else
                {
                    lbl_num2.Text = reader.GetString(0);
                    txt_num2.Text = reader.GetString(0);
                }

                i++;
            }

            reader.Close();

            conexion.Close();
        }

        public void obtenerTipos()
        {
            cbox_crendecialTipo.Items.Clear();
            cbox_crendecialTipo.Items.Add("Seleccione Tipo");
            conexion.Open();

            string query = "Select estado from permisos";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cbox_crendecialTipo.Items.Add(reader.GetString(0));
            }

            reader.Close();

            conexion.Close();

            cbox_crendecialTipo.SelectedIndex = 0;
        }

        public void asignar(string dni, string nom, string ape, string sexo, string nac, string fecha, string dir, string correo)
        {
            lbl_DniC.Text = dni;
            txt_Dni.Text = dni.Substring(0, dni.Length - 1);

            lbl_Nombre.Text = nom;
            txt_Nombre.Text = nom;
            
            lbl_Apellidos.Text = ape;
            txt_apellidos.Text = ape;
            
            lbl_sexo.Text = sexo;
            if (sexo == "Hombre") rb_hombre.Checked=true;
            if (sexo == "Mujer") rb_mujer.Checked=true;
            if (sexo == "Otro") rb_otro.Checked=true;
            
            lbl_Nacionalidad.Text = nac;
            txt_nacionalidad.Text = nac;
            
            dT_nacimiento.Text = fecha;

            lbl_direccion.Text = dir;
            txt_direccion.Text = dir;
            
            lbl_correo.Text = correo;
            txt_email.Text = correo;
        }


        public static char calcularLetra(int n)
        {
            string cadena = "TRWAGMYFPDXBNJZSQVHLCKE";
            return (char)cadena[n % 23];
        }

        private void txt_Dni_TextChanged(object sender, EventArgs e)
        {
            if (txt_Dni.TextLength > 0)
            {
                int numero = Convert.ToInt32(txt_Dni.Text);
                txt_Letra.Text = Convert.ToString(calcularLetra(numero));

            }
            else txt_Letra.Clear();
        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Dni.Text.Length == 8)
            {
                p.txtBloq(e);
            }
            else p.txtSoloNum(e);
        }

        private void txt_num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_num1.Text.Length == 9)
            {
                p.txtBloq(e);
            }
            else p.txtSoloNum(e);
        }

        private void txt_num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_num2.Text.Length == 12)
            {
                p.txtBloq(e);
            }
            else p.txtSoloNum(e);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (btn_editar.Text == "Editar") {
                visible(false, true);
                visibleTLF(1);
                btn_editar.Text = "Guardar";
                bt_cerrar.Text = "Cancelar";
            }
            else
            {
                string nuevoDNI = txt_Dni.Text + txt_Letra.Text;

                if (!comprobarTrabajador(nuevoDNI) && txt_Dni.Text.Length == 8)
                {
                    if (p.comprobaciones(txt_Nombre, txt_apellidos, txt_nacionalidad, rb_hombre, rb_mujer, rb_otro, edad, txt_direccion, txt_email, txt_num1, txt_num2, cbox_crendecialTipo, txt_contra))
                    {
                        actualizarTodo(nuevoDNI);

                        MessageBox.Show("Actualizado los datos correctamente", "Operacion realizada");
                        DNI = nuevoDNI;
                        cargarDatos();
                        btn_editar.Text = "Editar";
                        bt_cerrar.Text = "Cerrar";
                        visible(true, false);
                        visibleTLF(0);
                        p.aviso = 1;
                    }

                }
                else MessageBox.Show("Inserte un DNI válido", "Error");
            }
        }

        public void actualizarTodo(string nuevoDNI)
        {
            try
            {
                updateTrabajador(nuevoDNI, txt_Nombre.Text, txt_apellidos.Text, p.devolverSexo(rb_hombre, rb_mujer, rb_otro), txt_nacionalidad.Text, dT_nacimiento.Value, txt_direccion.Text, txt_email.Text);
                UpdateTelefonosTrabajador(txt_num1.Text, lbl_num1.Text);
                if(cantTelefono>1) UpdateTelefonosTrabajador(txt_num2.Text, lbl_num2.Text);
                UpdateCredenciales(txt_contra.Text, cbox_crendecialTipo.Text, lbl_contra.Text);
            }
            catch(Exception e)
            {
                MessageBox.Show("Se ha producido un error en la actualización, intentelo de nuevo", "Ups");
            }
        
        }

        public void visible(Boolean labels, Boolean text)
        {
            lbl_DniC.Visible = labels;
            txt_Dni.Visible = text;
            txt_Letra.Visible = text;

            lbl_Nombre.Visible = labels;
            txt_Nombre.Visible = text;

            lbl_Apellidos.Visible = labels;
            txt_apellidos.Visible = text;

            lbl_sexo.Visible = labels;
            rb_hombre.Visible = text;
            rb_mujer.Visible = text;
            rb_otro.Visible = text;

            lbl_Nacionalidad.Visible = labels;
            txt_nacionalidad.Visible = text;

            dT_nacimiento.Enabled = text;

            lbl_direccion.Visible = labels;
            txt_direccion.Visible = text;

            lbl_correo.Visible = labels;
            txt_email.Visible = text;

            lbl_tipo.Visible = labels;
            cbox_crendecialTipo.Visible = text;

            cBox_pass.Visible = text;
            txt_contra.Enabled = text;
        }

        public void visibleTLF(int s)
        {
            if (s == 0)
            {
                lbl_num1.Visible = true;

                if (cantTelefono > 1)
                {
                    lbl_num2.Visible = true;
                    lbl_titu_num2.Visible = true;
                }
                else
                {
                    lbl_num2.Visible = false;
                    lbl_titu_num2.Visible = false;
                }

                txt_num1.Visible = false;
                txt_num2.Visible = false;
            }
            else
            {
                txt_num1.Visible = true;
                lbl_num1.Visible = false;

                if (cantTelefono > 1)
                {
                    txt_num2.Visible = true;
                    lbl_titu_num2.Visible = true;
                }
                else
                {
                    txt_num2.Visible = false;
                    lbl_titu_num2.Visible = false;
                }

                lbl_num2.Visible = false;
            }
        }

        public void updateTrabajador(string dni, string nom, string ape, string sexo, string nac, DateTime fecha, string dir, string correo)
        {
            conexion.Open();
            string query = "UPDATE empleados SET DNI = '" + dni + "', nombre= '" + nom + "', apellidos= '" + ape + "', sexo= '" + sexo + "', nacionalidad= '" + nac + "', fecha_nac= '" + fecha.Year + "/" + fecha.Month + "/" + fecha.Day + "',  direccion='" + dir + "', correo= '" + correo + "' where DNI = '"+DNI+"'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public void UpdateTelefonosTrabajador(string numero, string numAnterior)
        {
            conexion.Open();
            string query = "UPDATE contacto_empleados SET numTelefono = '" + numero + "' where id_empleado = '" + DNI + "' && numTelefono='" + numAnterior + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdateCredenciales(string contra, string t, string ncontra)
        {
            if (contra == ncontra) contra = c.descifrar(contra);
            conexion.Open();
            string query = "UPDATE accesos SET contraseña = '" + c.cifrar(contra) + "', tipo = '"+t+"' where DNI = '" + DNI + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public Boolean comprobarTrabajador(string nuevoDNI)
        {
            Boolean opc = false;
            String result = "h";

            conexion.Open();

            string query = "Select DNI from empleados where DNI = '" + DNI + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                result = reader.GetString(0);
            }

            reader.Close();

            conexion.Close();

            if (result == nuevoDNI && DNI != nuevoDNI) opc = true;

            return opc;
        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            if(bt_cerrar.Text=="Cerrar") this.Dispose();
            else
            {
                cargarDatos();
                btn_editar.Text = "Editar";
                bt_cerrar.Text = "Cerrar";
                visible(true, false);
                visibleTLF(0);
            }
        }

        private void cBox_pass_CheckedChanged(object sender, EventArgs e)
        {
            string text = txt_contra.Text;
            if (!cBox_pass.Checked) txt_contra.UseSystemPasswordChar = true;
            else txt_contra.UseSystemPasswordChar = false;
            txt_contra.Text = text;
        }

        private void dT_nacimiento_ValueChanged(object sender, EventArgs e)
        {
            edad = p.sacarEdad(dT_nacimiento.Value);

            if (edad < 0) lbl_edad.Text = "0";
            else lbl_edad.Text = edad.ToString();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            txt_contra.UseSystemPasswordChar = true;
            obtenerTipos();
            cargarDatos();
            visibleTLF(0);
            this.Text += txt_Nombre.Text + " " + txt_apellidos.Text;
        }
    }
}
