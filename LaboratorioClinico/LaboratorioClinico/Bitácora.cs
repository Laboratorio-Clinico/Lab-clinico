//using MySql.Data.MySqlClient;
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

        private void Btn_verb_Click(object sender, EventArgs e)
        {
            /*
            conexion.ObtenerConexion();
            DataTable dtDatos = new DataTable();
            MySqlDataAdapter tablaData = new MySqlDataAdapter("select *from bitacoraLC", conexion.ObtenerConexion());
            tablaData.Fill(dtDatos);
            Dgv_bitacora.DataSource = dtDatos;
            conexion.ObtenerConexion().Close();
            */

        }
    }
}
