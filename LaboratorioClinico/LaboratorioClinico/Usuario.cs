using System.Data.Odbc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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


        }

        public static string EncripContra(string password)
        {
            SHA1 sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            byte[] input = (new UnicodeEncoding()).GetBytes(password); byte[] hash = sha1.ComputeHash(input);
            return Convert.ToBase64String(hash);

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            int pPrivilegio = 0;
            if (String.Compare(Cmb_privelegio.SelectedItem.ToString(), "Administrador") == 0)
            {
                pPrivilegio = 1;

            }
            if (String.Compare(Cmb_privelegio.SelectedItem.ToString(), "UsuarioL") == 0)
            {
                pPrivilegio = 2;

            }
            if (String.Compare(Cmb_privelegio.SelectedItem.ToString(), "Usuario") == 0)
            {
                pPrivilegio =3;

            }

            try { 
            OdbcCommand cm;
            cm = new OdbcCommand("{CALL ingresaUsuario(?,?,?,?)}", conexion.ObtenerConexion());
                cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@iIdPrivilegio", pPrivilegio);
            cm.Parameters.AddWithValue("@nDPI", Txt_codigoDeEmpleado.Text);
            cm.Parameters.AddWithValue("@sUsuario", Txt_usuario.Text);
            cm.Parameters.AddWithValue("@sContrasena", EncripContra(Txt_password.Text));


            int query = cm.ExecuteNonQuery();

            if (query == 1)
            {
                MessageBox.Show("Usuario ingresado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo ingresar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Txt_codigoDeEmpleado.ResetText();
            Txt_usuario.ResetText();
            Txt_password.ResetText();
            Cmb_privelegio.ResetText();
        }catch (Exception ex){

                MessageBox.Show("No se pudo ingresar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

}

        private void Gpb_nuevoUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string dpiE = Txt_codigoDeEmpleado.Text;

            try { 
            OdbcDataAdapter sda = new OdbcDataAdapter("select count(*) from empleado where nIdEmpleado='" + Convert.ToInt64(dpiE) + "'", conexion.ObtenerConexion());
            DataTable datos = new DataTable();
            sda.Fill(datos);

            if (datos.Rows[0][0].ToString() == "1")
            {
                Pnl_usuario.Visible = true;
            }
            else
            {
                MessageBox.Show("DPI no encontrado y/o no se encuentra registrado en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_codigoDeEmpleado.ResetText();


            }

        }catch (Exception ex){

                MessageBox.Show("Intente de nuevo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
}

        private void Txt_codigoDeEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

