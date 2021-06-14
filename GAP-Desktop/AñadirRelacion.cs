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
    public partial class AñadirRelacion : Form
    {
        public string horario;
        Principal p;

        public AñadirRelacion(string hor, Principal pri)
        {
            InitializeComponent();
            this.horario = hor;
            this.p = pri;
        }

        MySqlConnection conexion = Conexion.conexion;

        private void AñadirRelacion_Load(object sender, EventArgs e)
        {
            cargarTrabajadores();
            cBox_trabajador.SelectedIndex = 0;
            lbl_horario.Text = horario;
        }

        public void mensaje()
        {

        }

        public Boolean insertarRelacion( string DNI, string prioridad, DateTime fecha_ini, DateTime fecha_fin)
        {
            Boolean opc = true;
            try
            {
                conexion.Open();

                string query = "INSERT INTO relacion (dni_empleado, nombre_horario, fecha_ini, fecha_fin, prioridad) VALUES ('" + DNI + "', '"+horario+ "', '" + fecha_ini.Year + "/" + fecha_ini.Month + "/" + fecha_ini.Day + "', '" + fecha_fin.Year + "/" + fecha_fin.Month + "/" + fecha_fin.Day + "', '"+prioridad+"')";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Relación creada", "Operación exitosa");

                p.aviso = 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al crear la relación", "Ups");
                opc = false;
            }
            finally
            {
                conexion.Close();
            }

            return opc;
        }

        public void cargarTrabajadores()
        {
            cBox_trabajador.Items.Add("-Parámetros de Búsqueda-");

            conexion.Open();            

            string query = "Select DNI from empleados";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())       
            {
               
               cBox_trabajador.Items.Add(reader.GetString(0));
                
            }

            reader.Close();

            conexion.Close();
        }

        public Boolean comprobarEmpleado(string DNI)
        {

            Boolean opc = false;
            string result = "";
            conexion.Open();

            string query = "Select dni_empleado from relacion where nombre_horario = '" + horario+"' && dni_empleado = '"+DNI+"'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                result = reader.GetString(0); 
            }

            reader.Close();

            conexion.Close();

            if (result == DNI) opc = true;

            return opc;

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cBox_trabajador_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cBox_trabajador.SelectedIndex > 0)
            {
                if (comprobarEmpleado(cBox_trabajador.Text))
                {
                    MessageBox.Show("Este trabajador ya tiene asociado este horario","!Cuidado¡");
                    cBox_trabajador.SelectedIndex = 0;
                }
            }
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            if (comprobaciones())
            {
                insertarRelacion(cBox_trabajador.Text, txt_prioridad.Text, dT_ini.Value, dt_fin.Value);
                this.Dispose();
            }
        }

        public Boolean comprobaciones()
        {
            Boolean opc = true;

            if (cBox_trabajador.SelectedIndex < 1)
            {
                MessageBox.Show("Se debe de escoger el DNI de un trabajador para realizar la relación", "Error de inserción de datos");
                return false;
            }

            if (txt_prioridad.TextLength > 0)
            {
                if(comprobarPrioridad(txt_prioridad.Text, cBox_trabajador.Text))
                {
                    MessageBox.Show("Ya existe esta prioridad asociada a un horario de este trabajador", "Error de inserción de datos");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Se debe dar una prioridad para realizar la relación", "Error de inserción de datos");
                return false;
            }

            if(!compararFechas(dT_ini.Value, dt_fin.Value))
            {
                MessageBox.Show("La fecha inicial no puede ser mayo a la final", "Error de inserción de datos");
                return false;
            }

            return opc;
        }

        public Boolean comprobarPrioridad( string prioridad, string DNI)
        {
            Boolean opc = false;
            string result = "";
            conexion.Open();

            string query = "Select prioridad from relacion where prioridad = '" + prioridad + "' && dni_empleado = '" + DNI + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                result = reader.GetInt32(0).ToString();
            }

            reader.Close();

            conexion.Close();

            if (result == prioridad) opc = true;

            return opc;
        }

        public Boolean compararFechas(DateTime ini, DateTime fin)
        {
            Boolean opc = true;

            if (ini.Year > fin.Year) return false;
            else
            {
                if (ini.Year == fin.Year)
                {
                    if (ini.Month > fin.Month) return false;
                    else
                    {
                        if (ini.Month == fin.Month)
                        {
                            if (ini.Day > fin.Day) return false;
                        }
                    }
                }
                    
            }

            return opc;
        }

        private void txt_prioridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_prioridad.Text.Length == 2)
            {
                p.txtBloq(e);
            }
            else p.txtSoloNum(e);
        }
    }
}
