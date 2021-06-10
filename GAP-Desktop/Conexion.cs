using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaC
{
    class Conexion
    {
        //public static MySqlConnection conexion = new MySqlConnection("datasource= 2905900; Database=manuelcamacho; Uid=manuelcamacho; Pwd=8pUl7i2$;");
        public static MySqlConnection conexion = new MySqlConnection("datasource=127.0.0.1;port=3307;Database=proyecto_gap; Uid=root;");
    }
}
