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
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
            Pnl_menudespegable.Height = 10;
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
            this.Hide();
            Exámen open = new Exámen();
            open.ShowDialog();
            this.Show();
        }

        private void segurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            cotizar formaDeCotizar = new cotizar();
            formaDeCotizar.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (lbl_tipo.Text == "Usuario")
            {
                Tm_admin.Enabled = false;
                Tm_crearCodigo.Enabled = false;
            }else if (lbl_tipo.Text == "UsuarioL")
            {
                Tm_admin.Enabled = false;
                Tm_Control.Enabled = false;
                Tm_Erequerimientos.Enabled = false;
                Tm_Eresultados.Enabled = false;
                Tm_Enuevo.Enabled = false;
                
            }
        }

        private void crearCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearCodigo open = new CrearCodigo();
            open.ShowDialog();
            this.Show();
        }

        private void leerCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeerCodigo open = new LeerCodigo();
            open.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Quieres cerrar sesión?", "Cerrando sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
            
        }

        private void lbl_tipo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Pnl_menudespegable.Height==10)
            {
                tm_menu.Enabled = true;
            }
            else if(Pnl_menudespegable.Height == 90) 
            {
                tm_menu2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalido");
            }

      

        }

        private void label2_Click(object sender, EventArgs e)
        {
       
     
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bitácora open = new Bitácora();
            open.ShowDialog();
            this.Show();
        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Paciente open = new Paciente();
            open.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimiento open = new Mantenimiento();
            open.ShowDialog();
            this.Show();
        }

        private void tm_menu_Tick(object sender, EventArgs e)
        {
            if (Pnl_menudespegable.Height<90)  //Desocultar
            {
                Pnl_menudespegable.Height = Pnl_menudespegable.Height + 10;
            }
            else
            {
                
                tm_menu.Enabled = false;
                
            }
        }

        private void tm_menu2_Tick(object sender, EventArgs e)
        {
            if (Pnl_menudespegable.Height > 10)  //ocultar
            {
                Pnl_menudespegable.Height = Pnl_menudespegable.Height - 10;
            }
            else
            {
                
                tm_menu2.Enabled = false;
               
            }
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Factura open = new Factura();
            open.ShowDialog();
            this.Show();
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resultados open = new Resultados();
            open.ShowDialog();
            this.Show();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Médicos formaDeMedicos = new Médicos();
            formaDeMedicos.ShowDialog();
            this.Show();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario formaDeUsuarios = new Usuario();
            formaDeUsuarios.ShowDialog();
            this.Show();
        }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empleado  formaDeEmpleado = new Empleado();
            formaDeEmpleado.ShowDialog();
            this.Show();
        }

        private void lbl_hora_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void requerimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requerimientos formaDeEmpleado = new Requerimientos();
            formaDeEmpleado.ShowDialog();
            this.Show();
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConfigUser().ShowDialog();
            this.Show();
        }

        private void Tm_reportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Reportes().ShowDialog();
            this.Show();
        }
    }
}
