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
        public Menu(string nombre, string tipo)
        {
            InitializeComponent();
            lbl_usuario.Text = nombre;
            lbl_tipo.Text = tipo;
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
    }
}
