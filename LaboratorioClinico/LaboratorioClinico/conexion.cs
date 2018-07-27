using System.Data.Odbc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace LaboratorioClinico
{
    class conexion
    {
        /* public static MySqlConnection ObtenerConexion()
         {
             MySqlConnection conectar = new MySqlConnection("server=192.168.43.91;database=labclinico;Uid=grupo;pwd=2018;");
             conectar.Open();
             //MessageBox.Show("Conexion Exitosa");
             return conectar;
         }*/
        public static OdbcConnection ObtenerConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=BD_LabClinica");
            conectar.Open();
            return conectar;
        }  

    }
}
