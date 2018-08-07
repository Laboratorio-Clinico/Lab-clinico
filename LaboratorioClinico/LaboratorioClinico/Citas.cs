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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }

        private void Citas_Load(object sender, EventArgs e)
        {

        }

        private void Dgv_examen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gpb_detalleCita_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CrearCodigo(Convert.ToInt32(Cmb_examenes.SelectedItem.ToString()), Convert.ToInt32(Txt_dpi.Text)).ShowDialog();
            this.Show();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
