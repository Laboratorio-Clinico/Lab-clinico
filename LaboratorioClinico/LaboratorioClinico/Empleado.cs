﻿using MySql.Data.MySqlClient;
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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
            proLlenareCargo();
        }

        public void Pro_guardarDatos(int iCargo) {
            try {

                MySqlCommand cm;
                cm = new MySqlCommand("Pro_ingresoNuevoEmpleado", conexion.ObtenerConexion());
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@iIdEmpleado", this.Txt_DPIEmpleado.Text);
                cm.Parameters.AddWithValue("@sNombre", this.Txt_nombre.Text);
                cm.Parameters.AddWithValue("@sApellido", this.Txt_apellido.Text);
                cm.Parameters.AddWithValue("@nTelefono", this.Txt_telefono.Text);
                cm.Parameters.AddWithValue("@sDireccion", this.Txt_direccion.Text);
                cm.Parameters.AddWithValue("@sCorreo", this.Txt_correo.Text);
                cm.Parameters.AddWithValue("@iIdCargo", iCargo);
                cm.Parameters.AddWithValue("@fSueldo", this.Txt_sueldo.Text);
                cm.Parameters.AddWithValue("@dFechaDeNacimiento", this.Dtp_fechaNacimiento.Text);
                cm.Parameters.AddWithValue("@iIdUsuario", this.Txt_DPIEmpleado.Text);
                MessageBox.Show("Datos insertados correctamente");
            } catch(MySqlException error) { MessageBox.Show(error.Message); }

            finally {

            conexion.ObtenerConexion().Close(); }
            Txt_nombre.ResetText();
            Txt_apellido.ResetText();
            Txt_telefono.ResetText();
            Txt_correo.ResetText();
            Txt_direccion.ResetText();
            Txt_sueldo.ResetText();
            Cmb_cargo.ResetText();
            Dtp_fechaNacimiento.ResetText();
        }
        public void proLlenareCargo()
        {


            try
            {
                Cmb_cargo.Text = "Seleccione el cargo correspondiente";
                Cmb_cargo.Items.Clear();
                conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("Select iIdCargo,sDescripcion from Cargo", conexion.ObtenerConexion());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb_cargo.ValueMember = "iIdCargo";
                Cmb_cargo.DisplayMember = "sDescripcion";

                Cmb_cargo.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            int iCargo = Convert.ToInt32(Cmb_cargo.SelectedValue);
            Pro_guardarDatos(iCargo);

        }
    }
}
