using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaC
{
    public partial class Principal : Form
    {
        public string usuario;
        Login l;

        public Principal(string usu, Login lo)
        {
            InitializeComponent();
            this.usuario = usu;
            this.l = lo;
        }

        MySqlConnection conexion = Conexion.conexion;
        Cifrado c = new Cifrado();
        public string empresas, enlace;
        public int cantidadTLF;

        
        public void txtSoloTexto(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
             if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsWhiteSpace(e.KeyChar)) 
                    e.Handled = false;
                else
                   e.Handled = true; //el resto de teclas pulsadas se desactivan
            }
        }

        public void txtSoloNum(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        public void txtBloq(KeyPressEventArgs e)
        {
            
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }


        public string obtenerEmpresa()
        {
            string empresa="";

            conexion.Open();

            string query = "Select empresa from empleados where DNI = '"+usuario+"'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                empresa = reader.GetString(0);
            }

            reader.Close();

            conexion.Close();

            return empresa;
        }

        public void cambioNombre(string em)
        {
            this.Text = "GAP-" + em;
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            empresas = obtenerEmpresa();
            cambioNombre(empresas);
            //obtenerDatosEmpresa();
            txt_passCredential.UseSystemPasswordChar = true;
            cargarPlantilla();
            cargarSelector();

        }

        private void bt_tab_trabajadores_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void bt_tab_Horarios_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
            CargarTablaHorario();
            cargarTramosHorarios();
            cargarRelacionHorarios();
        }

        private void bt_tab_Gestion_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
            //this.tabControl2.SelectedIndex = 0;
            obtenerTipos();
        }

        private void bt_tab_Nosotros_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 3;
            obtenerTelefonosEmpresa();
            obtenerDatosEmpresa();
            cambio(1);
            activar(1);

        }

        //-------------------------NOSOTROS Métodos -------------------------------

        public string t1, t2, t3;

        public void obtenerDatosEmpresa()
        {
            conexion.Open();

            string query = "Select direccion, fecha_fundacion, estructuraJuridica, sector, pais, correo, pagina from empresas where nombre = '" + empresas + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                asignar(reader.GetString(0), reader.GetDateTime(1).ToShortDateString(), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
            }

            reader.Close();

            conexion.Close();
        }


        public void obtenerCantidadTelefonoEmpresa()
        {
            conexion.Open();

            string query = "Select Count(numTelefono) from contacto_empresas where id_Empresa = '" + empresas + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cantidadTLF = reader.GetInt32(0);
            }

            reader.Close();

            conexion.Close();
        }

        public void obtenerTelefonosEmpresa()
        {

            obtenerCantidadTelefonoEmpresa();

            conexion.Open();

            string query = "Select numTelefono from contacto_empresas where id_Empresa = '" + empresas + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            int i = 0;

            while (reader.Read())
            {
               
                if(i==0)
                {
                    lbl_tlf1.Text = reader.GetString(0);
                    mtxt_tlf1.Text = reader.GetString(0);
                }
                else { 
                    if(i==1)
                    {
                        lbl_tlf2.Text = reader.GetString(0);
                        mtxt_tlf2.Text = reader.GetString(0);
                    }

                    else
                    {
                        lbl_tlf3.Text = reader.GetString(0);
                        mtxt_tlf3.Text = reader.GetString(0);
                    }
                }
                    
                i++;
            }

            reader.Close();

            conexion.Close();

            
        }

        public void updateEmpresa(string nombre, string dir, DateTime fecha, string jur, string sec, string pais, string correo, string pag)
        {
            conexion.Open();
            string query = "UPDATE empresas SET nombre = '" + nombre + "', direccion= '" + dir + "', fecha_fundacion= '" + fecha.Year + "/"+fecha.Month+"/"+fecha.Day+"',  estructuraJuridica='" + jur + "', sector= '" + sec + "', pais= '" + pais + "', correo= '" + correo + "', pagina= '" + pag + "' where nombre = '" + empresas + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public void UpdateTelefonosEmpresa(string numero, string numAnterior)
        {
            conexion.Open();
            string query = "UPDATE contacto_empresas SET numTelefono = '" + numero + "' where id_Empresa = '" + empresas + "' && numTelefono='"+numAnterior+"'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void insertarTelefonos(string numero)
        {
            conexion.Open();

            string query = "INSERT INTO contacto_empresas (id_Empresa, numTelefono) VALUES ('" + empresas + "','" + numero + "')";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("Teléfono insertada correctamente", "Operación exitosa");
        }

        public void eliminarTelefonoEmpresa(string numero)
        {
            conexion.Open();
            string query = "DELETE FROM contacto_empresas where numTelefono = '" + numero+"' && id_Empresa = '"+ empresas + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("Teléfono eliminado correctamente", "Operación exitosa");

        }


        public void asignar(string dir, string fecha, string jur, string sec, string pais, string correo, string pag)
        {
            lbl_nomEmpresa.Text = empresas;
            txt_nom.Text = empresas;

            dTime_fundacion.Text = fecha;

            lbl_direccion.Text = dir;
            txt_dir.Text = dir;

            lbl_juridica.Text = jur;
            txt_juridica.Text = jur;

            lbl_sector.Text = sec;
            txt_sector.Text = sec;

            lbl_pais.Text = pais;
            txt_pais.Text = pais;

            lbl_correo.Text = correo;
            txt_correo.Text = correo;

            lbl_pagina.Text = pag;
            txt_pag.Text = pag;

            enlace = pag;
        }

        private void bt_accion_Click(object sender, EventArgs e)
        {
            if(bt_accion.Text == "Editar")
            {
                cambio(0);
            }
            else
            {
                actualizarTelefonosEmpresas();
                updateEmpresa(txt_nom.Text, txt_dir.Text, dTime_fundacion.Value, txt_juridica.Text, txt_sector.Text, txt_pais.Text, txt_correo.Text, txt_pag.Text);
                cambio(1);
                empresas = txt_nom.Text;
                cambioNombre(empresas);
                MessageBox.Show("Información guardada correctamente", "Operación exitosa");
            }
            obtenerTelefonosEmpresa();
            obtenerDatosEmpresa();
        }

        public void actualizarTelefonosEmpresas()
        {
            UpdateTelefonosEmpresa(mtxt_tlf1.Text, lbl_tlf1.Text);
            UpdateTelefonosEmpresa(mtxt_tlf2.Text, lbl_tlf2.Text);
            UpdateTelefonosEmpresa(mtxt_tlf3.Text, lbl_tlf3.Text);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            cambio(1);
            activar(1); 
        }

        public void cambio( int i)
        {
            if (i == 0)
            {
                visibilidad(lbl_nomEmpresa, txt_nom, 0);
                visibilidad(lbl_direccion, txt_dir, 0);
                visibilidad(lbl_juridica, txt_juridica, 0);
                visibilidad(lbl_sector, txt_sector, 0);
                visibilidad(lbl_pais, txt_pais, 0);
                visibilidad(lbl_correo, txt_correo, 0);
                visibilidad(lbl_pagina, txt_pag, 0);

                if (cantidadTLF >= 1) visibilidad2(lbl_tlf1, mtxt_tlf1, pBox_trash1, 0);
                if (cantidadTLF >= 2) visibilidad2(lbl_tlf2, mtxt_tlf2, pBox_trash2, 0);
                if (cantidadTLF == 3) visibilidad2(lbl_tlf3, mtxt_tlf3, pBox_trash3, 0);

                if (cantidadTLF < 3) bt_addTlf.Visible = true;
                else bt_addTlf.Visible = false;

                bt_accion.Text = "Guardar";

                dTime_fundacion.Enabled = true;
                dTime_fundacion.Font = new System.Drawing.Font(dTime_fundacion.Font, FontStyle.Regular);
            }
            else
            {
                visibilidad(lbl_nomEmpresa, txt_nom, 1);
                visibilidad(lbl_direccion, txt_dir, 1);
                visibilidad(lbl_juridica, txt_juridica, 1);
                visibilidad(lbl_sector, txt_sector, 1);
                visibilidad(lbl_pais, txt_pais, 1);
                visibilidad(lbl_correo, txt_correo, 1);
                visibilidad(lbl_pagina, txt_pag, 1);

                if (cantidadTLF >= 1) visibilidad2(lbl_tlf1, mtxt_tlf1, pBox_trash1, 1);
                if (cantidadTLF >= 2) visibilidad2(lbl_tlf2, mtxt_tlf2, pBox_trash2, 1);
                if (cantidadTLF == 3) visibilidad2(lbl_tlf3, mtxt_tlf3, pBox_trash3, 1);

                bt_addTlf.Visible = false;

                bt_accion.Text = "Editar";

                dTime_fundacion.Enabled = false;
                dTime_fundacion.Font = new System.Drawing.Font(dTime_fundacion.Font, FontStyle.Bold);
            }
            
        }

        public void visibilidad(Label l, TextBox t, int i)
        {
            if (i == 0)
            {
                l.Visible = false;
                t.Visible = true;
            }
            else{
                l.Visible = true;
                t.Visible = false;
            }
            
        }

        public void visibilidad2(Label l, MaskedTextBox t, PictureBox p, int i)
        {
            if (i == 0)
            {
                l.Visible = false;
                t.Visible = true;
                p.Visible = true;

            }
            else
            {
                if(i==1)
                {
                    l.Visible = true;
                    t.Visible = false;
                    p.Visible = false;
                }
                else
                {
                    t.Visible = false;
                    p.Visible = false;
                }
            }
        }


        private void bt_addTlf_Click(object sender, EventArgs e)
        {
            if (bt_addTlf.Text == "Añadir Número") activar(0);
            else activar(1);
        }

        public void activar(int opc )
        {
            if (opc == 0)
            {
                gBox_tfl.Visible = true;
                bt_addTlf.Text = "Cancelar";
                bt_accion.Enabled = false;
            }
            else
            {
                gBox_tfl.Visible = false;
                bt_addTlf.Text = "Añadir Número";
                bt_accion.Enabled = true;
                txt_addTlf.Clear();
            }
        }

        private void pBox_trash1_Click(object sender, EventArgs e)
        {
            eliminarTE(lbl_tlf1);
            mtxt_tlf1.Clear();
            visibilidad2(lbl_tlf1, mtxt_tlf1, pBox_trash1, 2);
        }

        private void pBox_trash2_Click(object sender, EventArgs e)
        {
            eliminarTE(lbl_tlf2);
            mtxt_tlf2.Clear();
            visibilidad2(lbl_tlf2, mtxt_tlf2, pBox_trash2, 2);
        }

        private void pBox_trash3_Click(object sender, EventArgs e)
        {
            eliminarTE(lbl_tlf3);
            mtxt_tlf3.Clear();
            visibilidad2(lbl_tlf3, mtxt_tlf3, pBox_trash3, 2);
        }

        public void eliminarTE(Label l)
        {
            eliminarTelefonoEmpresa(l.Text);
            obtenerTelefonosEmpresa();
            obtenerDatosEmpresa();
            cambio(0);
        }

        private void txt_addTlf_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtSoloNum(e);
        }

        private void bt_guardarTlf_Click(object sender, EventArgs e)
        {
            if(txt_addTlf.TextLength > 10)
            {
                insertarTelefonos(txt_addTlf.Text);
                activar(1);
                obtenerTelefonosEmpresa();
                obtenerDatosEmpresa();
                cambio(0);

            }
            else
            {
                MessageBox.Show("Rellene correctamente el número", "Error de formulario");
            }
        }

       

        private void lbl_pagina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                lbl_pagina.LinkVisited = true;
                System.Diagnostics.Process.Start(enlace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible abrir el enlace en estos momentos");
            }
        }

       

        //-----------------------------Gestión-------------------------

        private void bt_tab_FormularioEmpleado_Click(object sender, EventArgs e)
        {
            this.tabControl2.SelectedIndex = 0;
            obtenerTipos();
        }


        private void bt_tab_horario_Click(object sender, EventArgs e)
        {
            this.tabControl2.SelectedIndex = 1;
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoloTexto(e);
        }

        private void txt_apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoloTexto(e);
        }
        private void mtxt_num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtxt_num1.Text.Length == 9)
            {
                txtBloq(e);
            }
            else txtSoloNum(e);
        }

        private void mtxt_num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtxt_num2.Text.Length == 12)
            {
                txtBloq(e);
            }
            else txtSoloNum(e);

        }

        private void mtxt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtxt_Dni.Text.Length == 8)
            {
                txtBloq(e);
            }
            else txtSoloNum(e);
        }



        private void dT_nacimiento_ValueChanged(object sender, EventArgs e)
        {
            sacarEdad(dT_nacimiento.Value);

            if (edad < 0) lbl_edad.Text = "0";
            else lbl_edad.Text = edad.ToString();
            
               
        }


        public Boolean comprobarTrabajador(String dni)
        {
            Boolean opc = false;
            String result = "h";

            conexion.Open();

            string query = "Select DNI from empleados where DNI = '" + dni + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                result = reader.GetString(0);
            }

            reader.Close();

            conexion.Close();

            if (result == dni) opc = true;

            return opc;
        }


        public void insertarTrabajador(string dni, string nombre, string apellidos, string nacionalidad, string sexo, DateTime fecha, string direccion, string correo, string num1, string num2, string pass, string tipo)
        {
            conexion.Open();

            string query = "INSERT INTO empleados (DNI, nombre, apellidos,nacionalidad, sexo, fecha_nac, direccion, correo, empresa) VALUES ('" + dni + "','" + nombre + "','" + apellidos + "','" + nacionalidad + "','" + sexo + "','" + fecha.Year + "/" + fecha.Month + "/" + fecha.Day + "','" + direccion + "','" + correo + "', '"+ empresas + "')";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            string query2 = "INSERT INTO contacto_empleados (id_empleado, numTelefono) VALUES ('"+dni+"', '"+num1+"')";
            comando = new MySqlCommand(query2, conexion);
            comando.ExecuteNonQuery();


            if (num2.Length > 0)
            {
                string query3 = "INSERT INTO contacto_empleados (id_empleado, numTelefono) VALUES ('" + dni + "', '" + num2 + "')";
                comando = new MySqlCommand(query3, conexion);
                comando.ExecuteNonQuery();
            }

            string query4 = "INSERT INTO accesos (DNI, contraseña, tipo) VALUES ('" + dni + "', '" + c.cifrar(pass) + "', + '"+tipo+"')";
            comando = new MySqlCommand(query4, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("Trabajador insertada correctamente", "Operación exitosa");
        }

        public void obtenerTipos()
        {
            cBox_tipoCredential.Items.Clear();
            cBox_tipoCredential.Items.Add("Seleccione Tipo");
            conexion.Open();

            string query = "Select estado from permisos";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cBox_tipoCredential.Items.Add(reader.GetString(0));
            }
            
            reader.Close();

            conexion.Close();

            cBox_tipoCredential.SelectedIndex = 0;
        }


        public static char calcularLetra(int n)
        {
            string cadena = "TRWAGMYFPDXBNJZSQVHLCKE";
            return (char)cadena[n % 23];
        }

        private void mtxt_Dni_TextChanged_1(object sender, EventArgs e)
        {
            if (mtxt_Dni.TextLength > 0)
            {
                int numero = Convert.ToInt32(mtxt_Dni.Text);
                txt_Letra.Text = Convert.ToString(calcularLetra(numero));

            }
            else txt_Letra.Clear();

        }

        public static int edad;

        public int sacarEdad(DateTime birthday)
        {
            edad = DateTime.Now.Year - birthday.Year;

            if (birthday.Month > DateTime.Now.Month)
            {
                --edad;
            }

            return edad;

        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            string DNI = mtxt_Dni.Text + txt_Letra.Text;

            if (DNI.Length == 9)
            {
                if (!comprobarTrabajador(DNI))
                {
                    if (comprobaciones( txt_Nombre, txt_apellidos, txt_nacionalidad, rb_hombre, rb_mujer, rb_otro,edad, txt_direccion, txt_email, mtxt_num1, mtxt_num2, cBox_tipoCredential, txt_passCredential))
                    {
                        insertarTrabajador(DNI, txt_Nombre.Text, txt_apellidos.Text, txt_nacionalidad.Text, devolverSexo(rb_hombre, rb_mujer, rb_otro), dT_nacimiento.Value, txt_direccion.Text, txt_email.Text, mtxt_num1.Text, mtxt_num2.Text, txt_passCredential.Text, cBox_tipoCredential.Text);
                        limpiar();
                        cargarPlantilla();
                    }
                }
                else MessageBox.Show("La empresa ya cuenta con un trabajador con el mismo DNI", "Error");

            }
            else MessageBox.Show("Introduzca un DNI válido", "Error");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cBox_passCredential_CheckedChanged(object sender, EventArgs e)
        {
            string text = txt_passCredential.Text;
            if (!cBox_passCredential.Checked) txt_passCredential.UseSystemPasswordChar = true;
            else txt_passCredential.UseSystemPasswordChar = false;
            txt_passCredential.Text = text;
        }

        public string devolverSexo(RadioButton r_Hombre, RadioButton r_Mujer, RadioButton r_Otros)
        {
            if (r_Hombre.Checked) return rb_hombre.Text;
            else
            {
                if (r_Mujer.Checked) return rb_mujer.Text;

                else if (r_Otros.Checked) return rb_otro.Text;

            }

            return " ";
        }

        public Boolean comprobaciones(TextBox tNombre, TextBox tApellido, TextBox tNac, RadioButton rHombre, RadioButton rMujer, RadioButton rOtro,
            int edad, TextBox tDireccion,TextBox tCorreo, TextBox tNum1, TextBox tNum2, ComboBox cTipo, TextBox tContra)
        {
            Boolean opc = true;

            if (tNombre.TextLength == 0) {
                MessageBox.Show("Nombre no introducido", "Error");
                return false;
            }

            if (tApellido.TextLength == 0 || !tApellido.Text.Trim().Contains(" "))
            {
                if (tApellido.TextLength == 0) MessageBox.Show("Apellido no introducido", "Error");
                else
                    if (!tApellido.Text.Trim().Contains(" "))  MessageBox.Show("Introduzca ambos apellidos", "Error");

                return false;
            }

            if (tNac.TextLength == 0) { 
                MessageBox.Show("Nacionalidad no introducida", "Error");
                return false;
            }

            if(!rHombre.Checked && !rMujer.Checked && !rOtro.Checked)
            {
                MessageBox.Show("Seleccione una orientación sexual", "Error");
                return false;
            }

            if (edad < 16)
            {
               if(edad < 0) MessageBox.Show("Inserte un fecha válida", "Error");
               else MessageBox.Show("El trabajador no puede ser menor de 16 años", "Error");
               
               return false;
            }

            if (tDireccion.TextLength == 0)
            {
                MessageBox.Show("Seleccione una dirección", "Error");
                return false;
            }

            if (tCorreo.TextLength == 0)
            {
                MessageBox.Show("Introduzca un correo electrónico", "Error");
                return  false;
            }

            if (tNum1.Text.Length==0)
            {
                MessageBox.Show("Introduzca el número obligatorio", "Error");
                return false;
            }

            if (tNum1.Text == tNum2.Text)
            {
                MessageBox.Show("El número opcional es igual que el obligatorio", "Error");
                return false;
            }

            if(cTipo.SelectedIndex < 1)
            {
                MessageBox.Show("Seleccione un tipo", "Error");
                return false;
            }

            if (tContra.Text.Length == 0 || tContra.Text.Length < 10)
            {
                if (tContra.Text.Length == 0)
                {
                    MessageBox.Show("Introduzca una contraseña", "Error");
                    return false;
                }
                else
                {
                    MessageBox.Show("La contraseña tiene que tener un mínimo de 10 caracteres", "Error");
                    return false;
                }
            }

            return opc;
        }

        public void limpiar()
        {
            mtxt_Dni.Clear();
            txt_Letra.Clear();
            txt_Nombre.Clear();
            txt_apellidos.Clear();
            txt_nacionalidad.Clear();
            txt_direccion.Clear();
            txt_email.Clear();
            mtxt_num1.Clear();
            mtxt_num2.Clear();
            dT_nacimiento.Value = DateTime.Now;
            txt_passCredential.Clear();
            cBox_tipoCredential.SelectedIndex = 0;
        }

        //---------------------------Tab Plantilla-------------------------------

        public void cargarPlantilla()
        {
            tabla_trabajadores.Rows.Clear();      //limpiamos la tabla

            conexion.Open();            //iniciamos la consulta 

            string query = "Select DNI, nombre, apellidos, sexo, nacionalidad, fecha_nac, direccion, correo from empleados where empresa = '"+ empresas + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())       //metemos en la tabla los datos
            {
                tabla_trabajadores.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5).ToShortDateString(), reader.GetString(6), reader.GetString(7));
            }

            reader.Close();

            conexion.Close();
        }


        public void cargarTabla_buscador(String columna)
        {
            conexion.Open();            //iniciamos la consulta para meter todos los clientes que tenga este usuario

            string query = "Select DNI, nombre, apellidos, sexo, nacionalidad, fecha_nac, direccion, correo from empleados where empresa = '" + empresas + "' && " + columna + " LIKE'" + txt_buscador.Text + "%'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            tabla_trabajadores.Rows.Clear();          //limpiamos todo el contenido antes de introducir

            while (reader.Read())
            {
                tabla_trabajadores.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5).ToShortDateString(), reader.GetString(6), reader.GetString(7));
            }

            reader.Close();

            conexion.Close();
        }

        public void cargarSelector()
        {
            int numColum = tabla_trabajadores.Columns.Count;
            cBox_buscador.Items.Add("-Parámetros de Búsqueda-");

            for(int i=0; i<numColum; i++)
            {
                cBox_buscador.Items.Add(tabla_trabajadores.Columns[i].HeaderText.ToString());
            }

            cBox_buscador.SelectedIndex = 0;
        }

        private void pic_bt_add_Click(object sender, EventArgs e)
        {
           this.tabControl1.SelectedIndex = 2;
           this.tabControl2.SelectedIndex = 0;
            obtenerTipos();
        }
        public int aviso=0;

        private void pic_bt_editar_Click(object sender, EventArgs e)
        {
            llamarFormularioOperaciones(1);

        }

        private void pic_bt_borrar_Click(object sender, EventArgs e)
        {
            llamarFormularioOperaciones(0);
        }

        public void llamarFormularioOperaciones(int tipo)
        {
            int aux = Convert.ToInt32(tabla_trabajadores.CurrentRow.Index);
            if (aux < 0) {
                if(tipo==0) MessageBox.Show("Para borrar ha de seleccionarse un trabajador", "¡Cuidado!");
                else MessageBox.Show("Para editar ha de seleccionarse un trabajador", "¡Cuidado!");  
            }
            else
            {
                String id = tabla_trabajadores.Rows[aux].Cells[0].Value.ToString();
                if (tipo == 0)
                {
                    Borrar b = new Borrar(0, id, this);
                    b.ShowDialog();
                }
                else
                {
                    Editar e = new Editar(id, this, empresas);
                    e.ShowDialog();
                }
               
                if (aviso == 1)
                {
                    cargarPlantilla();
                    cBox_buscador.SelectedIndex = 0;
                    aviso = 0;
                }
            }
        }

   
        private void cBox_buscador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_buscador.SelectedIndex != 0) txt_buscador.Enabled = true;
            else
            {
                txt_buscador.Enabled = false;
                txt_buscador.Clear();
            }
        }

       
    

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            int numColum = tabla_trabajadores.Columns.Count;

            if (txt_buscador.TextLength > 0)
            {
                for (int i = 0; i < numColum; i++)
                {
                    if (cBox_buscador.Text == tabla_trabajadores.Columns[i].HeaderText.ToString())
                        cargarTabla_buscador(tabla_trabajadores.Columns[i].Name.ToString());
                }
            }
            else cargarPlantilla();
        }




        //--------------------------------Horario Gestion----------------------------------------


        public Boolean insertarNombreHorario(string nombre)
        {
            Boolean opc = true;
            try
            {
                conexion.Open();

                string query = "INSERT INTO horarios (nombre) VALUES ('" + nombre + "')";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Horario creado", "Operación exitosa");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al crear Horario", "Ups");
                opc = false;
            }
            finally
            {
                conexion.Close();
            }

            return opc;

        }

        public Boolean insertarContenidoHorario(string he1, string hs1, string he2, string hs2, string día, string nombreHorario)
        {
            Boolean opc = true;
            try
            {
                conexion.Open();

                string query = "INSERT INTO contenido_horario (nombre_horario, dia_semana, HE1, HS1, HE2, HS2 ) VALUES ('" + nombreHorario + "','" + día + "','" + he1 + "','" + hs1 + "','" + he2 + "','" + hs2 + "')";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                opc = false;
            }
            finally
            {
                conexion.Close();
            }

            return opc;

        }

        public Boolean comprobarNombreHorario(string nuevoNombre)
        {
            Boolean opc = false;
            String result = "h";

            conexion.Open();

            string query = "Select nombre from horarios where nombre = '" + nuevoNombre + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                result = reader.GetString(0);
            }

            reader.Close();

            conexion.Close();

            if (result == nuevoNombre) opc = true;

            return opc;
        }


        public void horas(KeyPressEventArgs e, TextBox t)
        {
            if (t.TextLength == 5) txtBloq(e);
            else
            {
                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)|| e.KeyChar == ':' )
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }


        private void txt_HE1_KeyPress(object sender, KeyPressEventArgs e){horas(e, txt_HE1);}
        private void txt_HS1_KeyPress(object sender, KeyPressEventArgs e){horas(e, txt_HS1);}
        private void txt_HE2_KeyPress(object sender, KeyPressEventArgs e){horas(e, txt_HE2);}
        private void txt_HS2_KeyPress(object sender, KeyPressEventArgs e){horas(e, txt_HS2);}
        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (txt_nHorario.Enabled == true)
            {
                if (txt_nHorario.TextLength>0)
                {
                    if (!comprobarNombreHorario(txt_nHorario.Text))
                    {
                        if (insertarNombreHorario(txt_nHorario.Text)) habilitarHorario(true);
                        bt_accionHorario.Text = "Finalizar";
                    }
                    else MessageBox.Show("Ya existe un horario con ese nombre", "Error de inserción de datos");
                }
            }
            else
            {
                if(comprobarTramosHorarios(txt_HE1.Text, txt_HS1.Text, txt_HE2.Text, txt_HS2.Text, chBox_L, chBox_M, chBox_X, chBox_J, chBox_V, chBox_S, chBox_D))
                {
                    tramitarDias(0);
                    limpiarHorario(1);
                }
                
            }
        }

        public void tramitarDias(int opc)
        {
            enviarDía(chBox_L,opc); enviarDía(chBox_M,opc); enviarDía(chBox_X,opc); enviarDía(chBox_J,opc);
            enviarDía(chBox_V,opc); enviarDía(chBox_S,opc); enviarDía(chBox_D,opc);

        

          if(opc==0)MessageBox.Show(" Datos insertados en el horario", "Operación exitosa");

            
        }

        private void bt_accionHorario_Click(object sender, EventArgs e)
        {
            if (bt_accionHorario.Text == "Limpiar")
            {
                if (txt_nHorario.Enabled == true) limpiarHorario(0);
                else limpiarHorario(1);
            }
            else
            {
                tramitarDias(1);
                limpiarHorario(0);
                limpiarHorario(1);
                habilitarHorario(false);
                bt_accionHorario.Text = "Limpiar";
            }
        }


        public void limpiarHorario(int opc)
        {
            if (opc == 0) txt_nHorario.Clear();
            else
            {
                txt_HE1.Clear();
                txt_HE2.Clear();
                txt_HS1.Clear();
                txt_HS2.Clear();
                chBox_L.Checked = false;
                chBox_M.Checked = false;
                chBox_X.Checked = false;
                chBox_J.Checked = false;
                chBox_V.Checked = false;
                chBox_S.Checked = false;
                chBox_D.Checked = false;
            }
        }

       

        public void habilitarHorario(Boolean opc)
        {
            txt_nHorario.Enabled = !opc;
            txt_HE1.Enabled = opc;
            txt_HE2.Enabled = opc;
            txt_HS1.Enabled = opc;
            txt_HS2.Enabled = opc;
            chBox_L.Enabled = opc;
            chBox_M.Enabled = opc;
            chBox_X.Enabled = opc;
            chBox_J.Enabled = opc;
            chBox_V.Enabled = opc;
            chBox_S.Enabled = opc;
            chBox_D.Enabled = opc;
        }

       
        public void enviarDía(CheckBox dia, int o)
        {
            Boolean opc;

            if (o == 0 && dia.Checked == true) {
                opc = insertarContenidoHorario(txt_HE1.Text, txt_HS1.Text, txt_HE2.Text, txt_HS2.Text, dia.Text, txt_nHorario.Text);
                if (opc) dia.Enabled = false;
                
                else MessageBox.Show("Error al insertar el "+dia.Text+" en el horario", "Operación exitosa");
            }

            if (o == 1 && dia.Enabled == true)
            {
                insertarContenidoHorario(txt_HE1.Text, txt_HS1.Text, txt_HE2.Text, txt_HS2.Text, dia.Text, txt_nHorario.Text);
            }
        }

        public Boolean comprobarTramosHorarios(string HE1, string HS1, string HE2, string HS2, CheckBox L, CheckBox M, CheckBox X, CheckBox J, CheckBox V, CheckBox S, CheckBox D)
        {
            Boolean opc=true;

            if(!L.Checked && !M.Checked && !X.Checked && !J.Checked && !V.Checked && !S.Checked && !D.Checked)
            {
                MessageBox.Show("Para guardar un tramo horario ha de elegír mínimo un día de la semana", "Error de inserción de datos");
                return false;
            }


            if(HE1.Length==0 && HS1.Length==0)
            {
                MessageBox.Show("Debe de introducir obligatoriamente el primer tramo horario", "Error de inserción de datos");
                return false;
            }
            else
            {
                if(HE1.Length == 0 && HS1.Length > 0 || HE1.Length > 0 && HS1.Length == 0)
                {
                    MessageBox.Show("No puede introducir un tramo horario sin rellenar ambas referencias (comienzo y final)", "Error de inserción de datos");
                    return false;
                }
            }

            if (HE2.Length == 0 && HS2.Length > 0 || HE2.Length > 0 && HS2.Length == 0)
            {
                MessageBox.Show("No puede introducir un tramo horario sin rellenar ambas referencias (comienzo y final)", "Error de inserción de datos");
                return false;
            }


            return opc;
        }

      


        //------------------------Horario-----------------------

        public void CargarTablaHorario()
        {
            conexion.Open();            

            string query = "Select nombre from horarios";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            tabla_Horario.Rows.Clear();         

            while (reader.Read())
            {
                tabla_Horario.Rows.Add(reader.GetString(0));
            }

            reader.Close();

            conexion.Close();
        }

       

        public void cargarTramosHorarios()
        {
            int aux = Convert.ToInt32(tabla_Horario.CurrentRow.Index);
            if (aux >= 0)
            {
                String horario = tabla_Horario.Rows[aux].Cells[0].Value.ToString();
                conexion.Open();

                string query = "Select dia_semana, HE1, HS1, HE2, HS2 from contenido_horario where nombre_horario = '"+horario+"'";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                tabla_tramosHorarios.Rows.Clear();

                while (reader.Read())
                {
                    if (reader.GetString(1).Length > 0)
                    {
                        tabla_tramosHorarios.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    }
                }

                reader.Close();

                conexion.Close();
            }
        }

        private void tabla_Horario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarTramosHorarios();
            cargarRelacionHorarios();
        }

        private void pic_bt_addHorario_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
            this.tabControl2.SelectedIndex = 1;
        }

        private void tabla_Horario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        private void pic_bt_eliminarHorario_Click(object sender, EventArgs e)
        {
            int aux = Convert.ToInt32(tabla_Horario.CurrentRow.Index);

            if (aux >= 0)
            {
                String horario = tabla_Horario.Rows[aux].Cells[0].Value.ToString();

                Borrar b = new Borrar(1, horario, this);
                b.ShowDialog();

                if (aviso == 1) cargarTablasOrganizacion();


            }
            else MessageBox.Show("No hay ningún horario que poder borrar", "Ups");
        }

     

        private void pic_bt_editarHorario_Click(object sender, EventArgs e)
        {
            int aux = Convert.ToInt32(tabla_Horario.CurrentRow.Index);

            if (aux >= 0)
            {
                String horario = tabla_Horario.Rows[aux].Cells[0].Value.ToString();

                Editar_Horario eH = new Editar_Horario(horario, this);
                eH.ShowDialog();

                if (aviso == 1)  cargarTablasOrganizacion();
                
            }
            else MessageBox.Show("No hay ningún horario que poder editar", "Ups");
        }

        public void cargarTablasOrganizacion()
        {
            CargarTablaHorario();
            cargarTramosHorarios();
            cargarRelacionHorarios();
            aviso = 0;
        }

     

        //-----------------------------Relación-------------------------

        public void cargarRelacionHorarios()
        {
            int aux = Convert.ToInt32(tabla_Horario.CurrentRow.Index);

            if (aux >= 0)
            {
                String horario = tabla_Horario.Rows[aux].Cells[0].Value.ToString();
                conexion.Open();

                string query = "Select dni_empleado, fecha_ini, fecha_fin, prioridad from relacion where nombre_horario = '" + horario + "'";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                tabla_relacionHorario.Rows.Clear();

                while (reader.Read())
                {
                    tabla_relacionHorario.Rows.Add(reader.GetString(0), reader.GetDateTime(1).ToShortDateString(), reader.GetDateTime(2).ToShortDateString(), reader.GetInt32(3));
                    
                }

                reader.Close();

                conexion.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Close();
        }

        private void pic_bt_borrarRelacion_Click(object sender, EventArgs e)
        {
            int aux = Convert.ToInt32(tabla_Horario.CurrentRow.Index), aux2 = Convert.ToInt32(tabla_relacionHorario.CurrentRow.Index);

            if (aux >= 0)
            {
                String horario = tabla_Horario.Rows[aux].Cells[0].Value.ToString(), relacion = tabla_relacionHorario.Rows[aux2].Cells[0].Value.ToString();

                Borrar b = new Borrar(2, horario, this, relacion);
                b.ShowDialog();

                if (aviso == 1)  cargarTablasOrganizacion();
            }
            else MessageBox.Show("No hay ningún horario que poder borrar relación", "Ups");
        }

        private void pic_bt_addRelacion_Click(object sender, EventArgs e)
        {
            int aux = Convert.ToInt32(tabla_Horario.CurrentRow.Index);

            if (aux >= 0)
            {
                String horario = tabla_Horario.Rows[aux].Cells[0].Value.ToString();
                AñadirRelacion Rel = new AñadirRelacion(horario, this);
                Rel.ShowDialog();

                if (aviso == 1) cargarTablasOrganizacion();
            }
            else MessageBox.Show("No hay ningún horario al que poder relacionar con un trabajador", "Ups");
        }

        private void pic_bt_editarRelación_Click(object sender, EventArgs e)
        {
            int aux = Convert.ToInt32(tabla_Horario.CurrentRow.Index), aux2 = Convert.ToInt32(tabla_relacionHorario.CurrentRow.Index);

            if (aux >= 0)
            {
                String horario = tabla_Horario.Rows[aux].Cells[0].Value.ToString(), relacion = tabla_relacionHorario.Rows[aux2].Cells[0].Value.ToString();

                EditarRelacion er = new EditarRelacion(this, relacion, horario);
                er.ShowDialog();

                if (aviso == 1) cargarTablasOrganizacion();
            }
            else MessageBox.Show("No hay ningún horario al que poder reditar su relación", "Ups");
        }
    }
}
