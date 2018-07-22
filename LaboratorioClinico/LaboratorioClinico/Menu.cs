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
    public partial class Menu : Form
    {
        public Menu(string nombre)
        {
            InitializeComponent();
            lbl_usuario.Text = nombre;
            lbl_tipo.Text = "Admin";
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void segurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void crearCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCodigo nuevo = new CrearCodigo();
            nuevo.ShowDialog();
        }

        private void leerCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeerCodigo nuevo = new LeerCodigo();
            nuevo.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando sesión");
            this.Close();
        }

        private void lbl_tipo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Pnl_menudespegable.Visible == true)
            {
                Pnl_menudespegable.Visible = false;
            }
            else
            {
                Pnl_menudespegable.Visible = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
       
     
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Factura formulario = new Factura();
            formulario.ShowDialog();
            this.Show();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bitácora formulario = new Bitácora();
            formulario.ShowDialog();
            this.Show();
        }

        private void requerimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requerimientos formulario = new Requerimientos();
            formulario.ShowDialog();
            this.Show();
        }
    }
}
