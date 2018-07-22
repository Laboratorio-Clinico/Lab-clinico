using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LaboratorioClinico
{
    class conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;database=login;Uid=root;pwd=2018;");
            conectar.Open();
            // MessageBox.Show("Conexion Exitosa");
            return conectar;
        }
    }
}
