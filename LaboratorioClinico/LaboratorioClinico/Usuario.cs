using MySql.Data.MySqlClient;
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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_confirmarContraseña_Click(object sender, EventArgs e)
        {

        }

        public void proIngresarUsuario(int pPrivilegio)
        {

            MySqlCommand cm;
            cm = new MySqlCommand("Pro_ingresoUsuario", conexion.ObtenerConexion());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@iCodigoEmpleado", this.Txt_codigoDeEmpleado);
            cm.Parameters.AddWithValue("@sUsuario", this.Txt_usuario);
            cm.Parameters.AddWithValue("@sContrasena", this.Txt_password);
            cm.Parameters.AddWithValue("@iPrivilegios", pPrivilegio);

            int query = cm.ExecuteNonQuery();

            if (query == 1)
            {
            }
            else
            {
                MessageBox.Show("No se pudo ingresar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Txt_codigoDeEmpleado.ResetText();
            Txt_usuario.ResetText();
            Txt_password.ResetText();
            MessageBox.Show("Cliente ingresado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cmb_privelegio.ResetText();


        }



        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            int pPrivilegio = 0;
            if (String.Compare(Cmb_privelegio.SelectedItem.ToString(), "Administrador") == 0)
            {
                pPrivilegio = 1;

            }
            if (String.Compare(Cmb_privelegio.SelectedItem.ToString(), "Usuario") == 0)
            {
                pPrivilegio = 2;

            }

            proIngresarUsuario(pPrivilegio);

        }

        private void Gpb_nuevoUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
    }

