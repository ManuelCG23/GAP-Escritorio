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
    public partial class Editar_Horario : Form
    {
        string nom;
        Principal p;

        public Editar_Horario(string nombre, Principal pri)
        {
            InitializeComponent();
            this.nom = nombre;
            this.p = pri;
        }
        MySqlConnection conexion = Conexion.conexion;

        private void Editar_Horario_Load(object sender, EventArgs e)
        {
            cBox_diaSemana.SelectedIndex = 0;
            lbl_titulo.Text = nom;
            cargarHorario();
        }

        public void cargarHorario()
        {
            conexion.Open();

            string query = "Select dia_semana, HE1, HS1, HE2, HS2 from contenido_horario where nombre_horario = '" + nom + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetString(0) == "Lunes") asociar(1, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                if (reader.GetString(0) == "Martes") asociar(2,reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                if (reader.GetString(0) == "Miércoles") asociar(3, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                if (reader.GetString(0) == "Jueves") asociar(4, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                if (reader.GetString(0) == "Viernes") asociar(5, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                if (reader.GetString(0) == "Sábado") asociar(6, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                if (reader.GetString(0) == "Domingo") asociar(7, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
            }

            reader.Close();
            conexion.Close();
        }

        public void actualizarTramoHorario(string dia, string HE1, string HS1, string HE2, string HS2)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE contenido_horario SET HE1 = '"+ HE1 + "', HS1 = '"+HS1+ "', HE2 = '" + HE2 + "', HS2 = '" + HS2 + "' where nombre_horario = '" + nom + "' && dia_semana = '"+dia+"'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();

                MessageBox.Show( dia + " actualizado", "Operación completada");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar el tramo del " + dia, "Ups");
            }
            finally
            {
                conexion.Close();
            }
        }

        public void actualizarNombreHorario(string nuevoNombre)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE horarios SET nombre = '" + nuevoNombre + "' where nombre = '" + nom + "'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();

                nom = nuevoNombre;
                MessageBox.Show("Nombre Actualizado", "Opetración completada");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al actualizar el nombre", "Ups");
            }
            finally
            {
                conexion.Close();
            }
        }



        public void asociar(int dia, string HE1, string HS1, string HE2, string HS2)
        {
            switch (dia)
            {
                case 1:     igualar(txt_HE1_L, txt_HS1_L, txt_HE2_L, txt_HS2_L, HE1, HS1, HE2, HS2);
                    break;
                case 2:     igualar(txt_HE1_M, txt_HS1_M, txt_HE2_M, txt_HS2_M, HE1, HS1, HE2, HS2);
                    break;
                case 3:     igualar(txt_HE1_X, txt_HS1_X, txt_HE2_X, txt_HS2_X, HE1, HS1, HE2, HS2);
                    break;
                case 4:     igualar(txt_HE1_J, txt_HS1_J, txt_HE2_J, txt_HS2_J, HE1, HS1, HE2, HS2);
                    break;
                case 5:     igualar(txt_HE1_V, txt_HS1_V, txt_HE2_V, txt_HS2_V, HE1, HS1, HE2, HS2);
                    break;
                case 6:     igualar(txt_HE1_S, txt_HS1_S, txt_HE2_S, txt_HS2_S, HE1, HS1, HE2, HS2);
                    break;
                case 7:     igualar(txt_HE1_D, txt_HS1_D, txt_HE2_D, txt_HS2_D, HE1, HS1, HE2, HS2);
                    break;
            }
        }

        public void igualar(Label tHE1, Label tHS1, Label tHE2, Label THS2, string HE1, string HS1, string HE2, string HS2)
        {
            tHE1.Text = HE1;
            tHS1.Text = HS1;
            tHE2.Text = HE2;
            THS2.Text = HS2;
        }

        private void cBox_diaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_diaSemana.SelectedIndex == 0)
            {
                enabledEdit(false);
                limpiar();
            }
            else
            {
                enabledEdit(true);
                asociar2(1);

                if (cBox_diaSemana.Text == "Lunes") asociar2(1);
                if (cBox_diaSemana.Text == "Martes") asociar2(2);
                if (cBox_diaSemana.Text == "Miércoles") asociar2(3);
                if (cBox_diaSemana.Text == "Jueves") asociar2(4);
                if (cBox_diaSemana.Text == "Viernes") asociar2(5);
                if (cBox_diaSemana.Text == "Sábado") asociar2(6);
                if (cBox_diaSemana.Text == "Domingo") asociar2(7);
            }
        }

        public void asociar2(int dia)
        {

            switch (dia)
            {
                case 1:
                    pasarEdit(txt_HE1_L, txt_HS1_L, txt_HE2_L, txt_HS2_L, txt_HE1, txt_HS1, txt_HE2, txt_HS2);
                    break;
                case 2:
                    pasarEdit(txt_HE1_M, txt_HS1_M, txt_HE2_M, txt_HS2_M, txt_HE1, txt_HS1, txt_HE2, txt_HS2);
                    break;
                case 3:
                    pasarEdit(txt_HE1_X, txt_HS1_X, txt_HE2_X, txt_HS2_X, txt_HE1, txt_HS1, txt_HE2, txt_HS2);
                    break;
                case 4:
                    pasarEdit(txt_HE1_J, txt_HS1_J, txt_HE2_J, txt_HS2_J, txt_HE1, txt_HS1, txt_HE2, txt_HS2);
                    break;
                case 5:
                    pasarEdit(txt_HE1_V, txt_HS1_V, txt_HE2_V, txt_HS2_V, txt_HE1, txt_HS1, txt_HE2, txt_HS2);
                    break;
                case 6:
                    pasarEdit(txt_HE1_S, txt_HS1_S, txt_HE2_S, txt_HS2_S, txt_HE1, txt_HS1, txt_HE2, txt_HS2);
                    break;
                case 7:
                    pasarEdit(txt_HE1_D, txt_HS1_D, txt_HE2_D, txt_HS2_D, txt_HE1, txt_HS1, txt_HE2, txt_HS2);
                    break;
            }
        }

        public void enabledEdit(Boolean opc)
        {
            bt_editar.Enabled = opc;
            txt_HE1.Enabled = opc;
            txt_HS1.Enabled = opc;
            txt_HE2.Enabled = opc;
            txt_HS2.Enabled = opc;
            bt_editarNombre.Enabled = !opc;
            txt_nombreHorario.Enabled = !opc;
        }

        public void pasarEdit(Label tHE1, Label tHS1, Label tHE2, Label THS2, TextBox HE1, TextBox HS1, TextBox HE2, TextBox HS2)
        {
            HE1.Text = tHE1.Text;
            HS1.Text = tHS1.Text;
            HE2.Text = tHE2.Text;
            HS2.Text = THS2.Text;
        }

        public void limpiar()
        {
            txt_HS1.Clear();
            txt_HE2.Clear();
            txt_HS2.Clear();
            txt_HE1.Clear();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            actualizarTramoHorario(cBox_diaSemana.Text, txt_HE1.Text, txt_HS1.Text, txt_HE2.Text, txt_HS2.Text);
            cargarHorario();
        }

        private void bt_editarNombre_Click(object sender, EventArgs e)
        {
            if (txt_nombreHorario.TextLength > 0)
            {
                if (!comprobarNombreHorario(txt_nombreHorario.Text))
                {
                    actualizarNombreHorario(txt_nombreHorario.Text);
                    lbl_titulo.Text = nom;
                }
            }
            else MessageBox.Show("Introduzca el nuevo nombre", "Error de inserción de datos");
        }


        private void txt_HE1_KeyPress_1(object sender, KeyPressEventArgs e) { p.horas(e, txt_HE1); }
        private void txt_HS1_KeyPress_1(object sender, KeyPressEventArgs e) { p.horas(e, txt_HS1); }
        private void txt_HE2_KeyPress_1(object sender, KeyPressEventArgs e) { p.horas(e, txt_HE2); }
        private void txt_HS2_KeyPress_1(object sender, KeyPressEventArgs e) { p.horas(e, txt_HS2); }


        public Boolean comprobarNombreHorario(string nuevoHorario)
        {
            Boolean opc = false;
            String result = "h";

            conexion.Open();

            string query = "Select nombre from horarios where nombre = '" + nuevoHorario + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                result = reader.GetString(0);
            }

            reader.Close();

            conexion.Close();

            if (result == nuevoHorario) opc = true;

            return opc;
        }
    }

}
