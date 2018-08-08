using System.Data.Odbc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioClinico
{
    public partial class Bitácora : Form
    {
        public Bitácora()
        {
            InitializeComponent();
        }

       //@Sindy Batz
        private void Btn_verb_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select nIdBitacora as ID, sUsuario as Usuario, dfechaEntrada as Entrada, dfechaSalida as Salida, sComputadora as IP from bitacora", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                //Column1. = "iIdExamen";
                Dgv_bitacora.DataSource = tabla;
                conexion.ObtenerConexion().Close();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }

        }

        private void Dgv_bitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
