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

        private void Btn_verb_Click(object sender, EventArgs e)
        {
            
            conexion.ObtenerConexion();
            DataTable dtDatos = new DataTable();
            OdbcDataAdapter tablaData = new OdbcDataAdapter("select *from bitacora", conexion.ObtenerConexion());
            tablaData.Fill(dtDatos);
            Dgv_bitacora.DataSource = dtDatos;
            conexion.ObtenerConexion().Close();
            

        }
    }
}
