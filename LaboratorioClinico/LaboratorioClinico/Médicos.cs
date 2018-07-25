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
    public partial class Médicos : Form
    {
        public Médicos()
        {
            InitializeComponent();
        }

        private void Médicos_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            MySqlCommand cm;
            cm = new MySqlCommand("Pro_ingresoNuevoMedico", conexion.ObtenerConexion());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@sNombre", this.Txt_nombre);
            cm.Parameters.AddWithValue("@sApellido", this.Txt_apellido);
            cm.Parameters.AddWithValue("@deTelefono", this.Txt_telefono);
            cm.Parameters.AddWithValue("@sDireccion", this.Txt_direccion);
            cm.Parameters.AddWithValue("@sEspecialidad", this.Txt_especialidad);
            cm.Parameters.AddWithValue("@iColegiado", this.Txt_colegiado);
            cm.Parameters.AddWithValue("@sEmpresa", this.Cmb_empresa);
            cm.Parameters.AddWithValue("@dFechaDeNacimiento", this.Dtp_fechaNacimiento);

            int query = cm.ExecuteNonQuery();

            if (query == 1)
            {
                MessageBox.Show("Cliente ingresado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo ingresar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Txt_nombre.ResetText();
            Txt_apellido.ResetText();
            Txt_telefono.ResetText();
            Txt_direccion.ResetText();
            Txt_especialidad.ResetText();
            Txt_colegiado.ResetText();
            Cmb_empresa.ResetText();
            Dtp_fechaNacimiento.ResetText();


        }
    }
}
