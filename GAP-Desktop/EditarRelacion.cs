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
    public partial class EditarRelacion : Form
    {
        Principal p;
        public string DNI, horario;

        public EditarRelacion(Principal pri, string id, string hor)
        {
            InitializeComponent();
            this.DNI = id;
            this.horario = hor;
            this.p = pri;
        }

        MySqlConnection conexion = Conexion.conexion;

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditarRealcion_Load(object sender, EventArgs e)
        {
            lbl_horario.Text = horario;
            lbl_trabajador.Text = DNI;
            cargarTrabajadores();
            cargarDatos();
        }

        public void cargarTrabajadores()
        {
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

        public void cargarDatos()
        {
            conexion.Open();

            string query = "Select fecha_ini, fecha_fin, prioridad from relacion where dni_empleado = '"+DNI+"' && nombre_horario = '"+horario+"'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                dT_ini.Text = reader.GetDateTime(0).ToShortDateString();
                dt_fin.Text = reader.GetDateTime(1).ToShortDateString();
                lbl_prioridad.Text = reader.GetInt32(2).ToString();
            }

            reader.Close();

            conexion.Close();
        }

       

        public void cambio(int opc)
        {
            if (opc == 0)
            {
                btn_editar.Text = "Guardar";
                txt_prioridad.Visible = true;
                cBox_trabajador.Visible = true;
                dT_ini.Enabled = true;
                dt_fin.Enabled = true;

                cBox_trabajador.SelectedIndex = cBox_trabajador.FindStringExact(lbl_trabajador.Text);
                txt_prioridad.Text = lbl_prioridad.Text;

                lbl_prioridad.Visible = false;
                lbl_trabajador.Visible = false;
            }
            else
            {
                btn_editar.Text = "Editar";
                txt_prioridad.Visible = false;
                cBox_trabajador.Visible = false;
                dT_ini.Enabled = false;
                dt_fin.Enabled = false;

                lbl_prioridad.Visible = true;
                lbl_trabajador.Visible = true;

            } 
        }

        private void txt_prioridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_prioridad.Text.Length == 2)
            {
                p.txtBloq(e);
            }
            else p.txtSoloNum(e);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (btn_editar.Text == "Editar")
            {
                cambio(0);
            }
            else
            {
                if (comprobaciones())
                {
                    updateRelacion(cBox_trabajador.Text, txt_prioridad.Text, dT_ini.Value, dt_fin.Value);
                    cargarDatos();
                    cambio(1);

                }

            }
        }

        public void updateRelacion(string trabajador, string prioridad, DateTime fecha_ini, DateTime fecha_fin)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE relacion SET dni_empleado = '" + trabajador + "', prioridad = '"+prioridad+ "', fecha_ini = '" + fecha_ini.Year + "/" + fecha_ini.Month + "/" + fecha_ini.Day + "', fecha_fin ='" + fecha_fin.Year + "/" + fecha_fin.Month + "/" + fecha_fin.Day + "' where dni_empleado = '" + DNI + "' && nombre_horario = '"+horario+"'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();

                DNI = trabajador;
                MessageBox.Show("Relación Actualizado", "Operación completada");
                p.aviso = 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar el nombre", "Ups");
            }
            finally
            {
                conexion.Close();
            }
        }


        public Boolean comprobaciones()
        {
            Boolean opc = true;

            if (cBox_trabajador.SelectedIndex < 0)
            {
                MessageBox.Show("Se debe de escoger el DNI de un trabajador para realizar la relación", "Error de inserción de datos");
                return false;
            }

            if (txt_prioridad.TextLength > 0)
            {
                if (txt_prioridad.Text != lbl_prioridad.Text)
                {
                    if (comprobarPrioridad(txt_prioridad.Text, cBox_trabajador.Text))
                    {
                        MessageBox.Show("Ya existe esta prioridad asociada a un horario de este trabajador", "Error de inserción de datos");
                        return false;
                    }

                }
            }
            else
            {
                MessageBox.Show("Se debe dar una prioridad para realizar la relación", "Error de inserción de datos");
                return false;
            }

            if (!compararFechas(dT_ini.Value, dt_fin.Value))
            {
                MessageBox.Show("La fecha inicial no puede ser mayo a la final", "Error de inserción de datos");
                return false;
            }

            return opc;
        }

        public Boolean comprobarPrioridad(string prioridad, string DNI)
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

        public Boolean comprobarEmpleado(string DNI)
        {

            Boolean opc = false;
            string result = "";
            conexion.Open();

            string query = "Select dni_empleado from relacion where nombre_horario = '" + horario + "' && dni_empleado = '" + DNI + "'";
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

        private void cBox_trabajador_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cBox_trabajador.SelectedIndex > 0)
            {
                if (cBox_trabajador.Text != lbl_trabajador.Text){
                    if (comprobarEmpleado(cBox_trabajador.Text))
                    {
                        MessageBox.Show("Este trabajador ya tiene asociado este horario", "!Cuidado¡");
                        cBox_trabajador.SelectedIndex = cBox_trabajador.FindStringExact(lbl_trabajador.Text);
                    }
                }
            }
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

    }
}
