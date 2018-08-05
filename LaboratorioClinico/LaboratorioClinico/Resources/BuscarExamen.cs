using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace LaboratorioClinico.Resources
{
    class BuscarExamen
    {
        public static List<Examen> buscar(Int32 iIdExamenes)
        {
            List<Examen> lExamenes = new List<Examen>();


            OdbcCommand comando = new OdbcCommand(string.Format("Select *from examenes where iIdExamen='{0}'",iIdExamenes), conexion.ObtenerConexion());

            OdbcDataReader buscador = comando.ExecuteReader();
            while (buscador.Read())
            {
                Examen vExamen = new Examen();
                vExamen.iIdExamen = buscador.GetInt32(0);
                vExamen.sDescripcion = buscador.GetString(1);
                vExamen.fPrecio = buscador.GetDouble(2);
                lExamenes.Add(vExamen);
            }
            return lExamenes;
        }
    }
    }
