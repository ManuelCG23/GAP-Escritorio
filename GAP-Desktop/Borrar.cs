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
    public partial class Borrar : Form
    {
        public int operacion;
        public string identificador, relacion;

        Principal p;

        public Borrar(int op, string id, Principal pri, string r = "")
        {
            InitializeComponent();
            this.operacion = op;
            this.identificador = id;
            this.p = pri;
            this.relacion = r;

            if (op == 0)
            {
                lbl_uno.Text += id;
                lbl_uno.Visible = true;
            }
            else
            {
                if (op == 1)
                {
                    lbl_dos.Text += id;
                    lbl_dos.Visible = true;

                }
                else
                {
                    lbl_tres.Text +=  r;
                    lbl_tres_dos.Text += id;
                    lbl_tres.Visible = true;
                    lbl_tres_dos.Visible = true;
                }
            }       
        }

        MySqlConnection conexion = Conexion.conexion;

        private void bt_accion_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string query = "";
                if (operacion == 0) query = "DELETE FROM empleados where DNI = '" + identificador + "'";
                else
                {
                    if (operacion == 1) query = "DELETE FROM horarios where nombre = '" + identificador + "'";
                    else query = "DELETE FROM relacion where nombre_horario = '" + identificador + "' && dni_empleado = '"+relacion+"'";
                }

                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();

                if (operacion == 0) MessageBox.Show("Trabajador dado de baja exitosamente", "Operación exitosa");
                else 
                {
                    if (operacion == 1) MessageBox.Show("Horario eliminado", "Operación exitosa");
                    else MessageBox.Show("Relación eliminada", "Operación exitosa");
                }
                

                p.aviso = 1;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido un error", "Ups");
            }
            finally{
                conexion.Close();
               
            }

            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
