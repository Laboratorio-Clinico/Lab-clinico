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
            conexionn.conectar();
            DataTable dtDatos = new DataTable();
            MySqlDataAdapter tablaData = new MySqlDataAdapter("select *from bitacora", conexionn.conectar());
            tablaData.Fill(dtDatos);
            Dgv_bitacora.DataSource = dtDatos;
            conexionn.conectar().Close();
            */

        }
    }
}
