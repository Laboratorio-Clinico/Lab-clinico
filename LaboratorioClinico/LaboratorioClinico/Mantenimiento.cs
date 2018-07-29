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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
            prollenarSangre();
            prollenarEspecialidad();
            prollenarEmpresa();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            Tbc_paciente.Visible = false;
            Tbc_medicos.Visible = false;
            Tbc_examen.Visible = false;
            Tbc_empleado.Visible = false;
            Picb_fondo.Visible = true;
        }

        public void prollenarSangre() //LLENAR EL COMBOBOX DE TIPO DE SANGRE EN "PACIENTE", POR MEDIO DE UNA CONSULTA
        {
            try
            {
                Cmb_tipoSangre.Items.Clear();
                Cmb_tipoSangre.Text = "Seleccione el tipo de sangre";
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdTipoDeSangre,sGrupoSanguineo from tipoDeSangre", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);
                Cmb_tipoSangre.ValueMember = "iIdTipoDeSangre";
                Cmb_tipoSangre.DisplayMember = "sGrupoSanguineo";
                Cmb_tipoSangre.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }
        
        public void prollenarEspecialidad() //LLENAR EL COMBOBOX DE ESPECIALIDAD EN "MÉDICO", POR MEDIO DE UNA CONSULTA
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdEspecialidad,sEspecialidad from Especialidad", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                DataRow fila = tabla.NewRow();
                fila["sEspecialidad"] = "Seleccione la especialidad";
                tabla.Rows.InsertAt(fila, 0);

                Cmb_especialidadMedicoM.ValueMember = "iIdEspecialidad";
                Cmb_especialidadMedicoM.DisplayMember = "sEspecialidad";
                Cmb_especialidadMedicoM.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        public void prollenarEmpresa()  //LLENAR EL COMBOBOX DE EMPRESA EN "MÉDICO", POR MEDIO DE UNA CONSULTA
        {
            try
            {
                Cmb_empresaMedicoM.Items.Clear();
                Cmb_empresaMedicoM.Text = "Seleccione una empresa";
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdEmpresa,sEmpresa from Empresa", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);
                DataRow fila = tabla.NewRow();
                fila["sEmpresa"] = "Seleccione una Empresa";
                tabla.Rows.InsertAt(fila, 0);

                Cmb_empresaMedicoM.ValueMember = "iIdEmpresa";
                Cmb_empresaMedicoM.DisplayMember = "sEmpresa";
                Cmb_empresaMedicoM.DataSource = tabla;

                conexion.ObtenerConexion().Close();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }


        }

        private void Gpb_mantenimiento_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_tsangrep_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_eliminarm_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gpb_datosPersonales_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)  //Buscar paciente para poder eliminarlo.......................
        {
            try
            {
                Pnl_eliminarP.Visible = true;
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT pa.sNombre, te.iTelefono  , pa.sNit, sa.iIdTipoDeSangre, pa.sDireccion, co.sCorreo, pa.sAlergia, pa.sRefiere, pa.sGenero FROM paciente pa, telefono te, correo co, tipodesangre sa WHERE pa.nIdPaciente = te.nIdPaciente AND pa.nIdPaciente = co.nIdPaciente AND pa.iIdTipoDeSangre = sa.iIdTipoDeSangre AND pa.nIdPaciente='" + Convert.ToInt32(Txt_expedientep.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                //Llenar los campos con el paciente encontrado
                Txt_nombrep.Text = datos.Rows[0][0].ToString();
                Txt_telefonop.Text = datos.Rows[0][1].ToString();
                Txt_nitp.Text = datos.Rows[0][2].ToString();
                Cmb_tipoSangrep.Text = datos.Rows[0][3].ToString();
                Txt_direccionp.Text = datos.Rows[0][4].ToString();
                Txt_correoP.Text = datos.Rows[0][5].ToString(); ;
                Txt_alergiasp.Text = datos.Rows[0][6].ToString();
                Txt_refierep.Text = datos.Rows[0][7].ToString();
                Cmb_sexop.Text = datos.Rows[0][8].ToString();

                //Deshabilitar los campos, que sean solo de lectura
                Txt_nombrep.Enabled = false;
                Txt_telefonop.Enabled = false;
                Txt_nitp.Enabled = false;
                Cmb_tipoSangrep.Enabled = false;
                Txt_direccionp.Enabled = false;
                Txt_correoP.Enabled = false;
                Txt_alergiasp.Enabled = false;
                Txt_refierep.Enabled = false;
                Cmb_sexop.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)  //Buscar paciente para modificarlo................................
        {
            try
            {
                Pnl_modificarP.Visible = true;
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT pa.sNombre, te.iTelefono  , pa.sNit, sa.iIdTipoDeSangre, pa.sDireccion, co.sCorreo, pa.sAlergia, pa.sRefiere, pa.sGenero FROM paciente pa, telefono te, correo co, tipodesangre sa WHERE pa.nIdPaciente = te.nIdPaciente AND pa.nIdPaciente = co.nIdPaciente AND pa.iIdTipoDeSangre = sa.iIdTipoDeSangre AND pa.nIdPaciente='" + Convert.ToInt32(Txt_expe.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                //Llenar todos los campos con los datos del paciente encontrado................................
                Txt_nombre.Text = datos.Rows[0][0].ToString();
                Txt_telefono.Text = datos.Rows[0][1].ToString();
                Txt_nit.Text = datos.Rows[0][2].ToString();
                Cmb_tipoSangre.Text = datos.Rows[0][3].ToString();
                Txt_direccion.Text = datos.Rows[0][4].ToString();
                Txt_correo.Text = datos.Rows[0][5].ToString(); ;
                Txt_alergias.Text = datos.Rows[0][6].ToString();
                Txt_refiere.Text = datos.Rows[0][7].ToString();
                Cmb_sexo.Text = datos.Rows[0][8].ToString();

                Txt_expe.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_editarp_Click(object sender, EventArgs e) //EDITAR PACIENTE.........................................
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                //Realizar updates de cada dato del paciente por si se llegó a modificar alguno.
                cmd.CommandText = "update paciente set sNombre = '" + Txt_nombre.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update telefono set iTelefono = '" + Txt_telefono.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sNit = '" + Txt_nit.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set iIdTipoDeSangre = '" + Cmb_tipoSangre.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sDireccion = '" + Txt_direccion.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update correo set sCorreo = '" + Txt_correo.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sAlergia = '" + Txt_alergias.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sRefiere = '" + Txt_refiere.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sGenero = '" + Cmb_sexo.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Paciente Modificado Exitosamente.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                //Limpiar la información previamente cargada para volver a buscar otro paciente
                Txt_expe.Enabled = true;
                Txt_expe.Clear();

                Txt_nombre.Clear();
                Txt_telefono.Clear();
                Txt_nit.Clear();
                Cmb_tipoSangre.ResetText(); Cmb_tipoSangre.Items.Clear();
                Txt_direccion.Clear();
                Txt_correo.Clear();
                Txt_alergias.Clear();
                Txt_refiere.Clear();
                Cmb_sexo.ResetText();  Cmb_sexo.Items.Clear(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_eliminarp_Click(object sender, EventArgs e) //Eliminar paciente..................................
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                //Eliminar los datos del paciente de 4 tablas que guardan su información
                cmd.CommandText = "delete from paciente where nIdPaciente = '" + Convert.ToInt32(Txt_expedientep.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from telefono where nIdPaciente = '" + Convert.ToInt32(Txt_expedientep.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from correo where nIdPaciente = '" + Convert.ToInt32(Txt_expedientep.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from tipodesangre where iIdTipoDeSangre = '" + Convert.ToInt32(Txt_expedientep.Text) + "'";
                cmd.ExecuteNonQuery();
                

                MessageBox.Show("Paciente Eliminado Exitosamente", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Limpiar todos los textbox / combobox
                Txt_nombrep.Clear();
                Txt_telefonop.Clear();
                Txt_nitp.Clear();
                Cmb_tipoSangrep.ResetText(); Cmb_tipoSangrep.Items.Clear(); 
                Txt_direccionp.Clear();
                Txt_correoP.Clear();
                Txt_alergiasp.Clear();
                Txt_refierep.Clear();
                Cmb_sexop.ResetText();  Cmb_sexop.Items.Clear(); 

                //Volver a habilitar todos los textbox / combobox
                Txt_nombrep.Enabled = true;
                Txt_telefonop.Enabled = true;
                Txt_nitp.Enabled = true;
                Cmb_tipoSangrep.Enabled = true;
                Txt_direccionp.Enabled = true;
                Txt_correoP.Enabled = true;
                Txt_alergiasp.Enabled = true;
                Txt_refierep.Enabled = true;
                Cmb_sexop.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }



            
        }

        private void Cmb_tabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_tabla.SelectedItem.ToString() == "Paciente")
            {
                Tbc_paciente.Visible = true;
                Tbc_medicos.Visible = false;
                Tbc_examen.Visible = false;
                Tbc_empleado.Visible = false;
                Picb_fondo.Visible = false;

            }
            else if(Cmb_tabla.SelectedItem.ToString() == "Médico Asociado")
            {
                Tbc_paciente.Visible = false;
                Tbc_medicos.Visible = true;
                Tbc_examen.Visible = false;
                Tbc_empleado.Visible = false;
                Picb_fondo.Visible = false;

            }
            else if (Cmb_tabla.SelectedItem.ToString() == "Exámen")
            {
                Tbc_paciente.Visible = false;
                Tbc_medicos.Visible = false;
                Tbc_examen.Visible = true;
                Tbc_empleado.Visible = false;
                Picb_fondo.Visible = false;
            }
            else if (Cmb_tabla.SelectedItem.ToString() == "Empleado")
            {
                Tbc_paciente.Visible = false;
                Tbc_medicos.Visible = false;
                Tbc_examen.Visible = false;
                Tbc_empleado.Visible = true;
                Picb_fondo.Visible = false;
            }
        }
        private void Txt_direMedicoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_buscarm_Click(object sender, EventArgs e) //Buscar médico para modificar..........................................
        {
            try
            {
                Gpb_datos.Visible = true;
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT me.sNombre, me.sApellido, te.itelefono, me.sDireccion, co.sCorreo, es.sEspecialidad, em.sEmpresa, me.dFechaDeNacimiento FROM medicosasociados me, telefono te, correo co, especialidad es, empresa em  WHERE me.nNoColegiado = te.nIdPaciente AND me.nNoColegiado = co.nIdPaciente AND me.iIdEspecialidad = es.iIdEspecialidad AND me.iIdEmpresa = em.iIdEmpresa AND me.nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_nombreMedicoM.Text = datos.Rows[0][0].ToString();
                Txt_apellidoMedicoM.Text = datos.Rows[0][1].ToString();
                Txt_telefonoMedicoM.Text = datos.Rows[0][2].ToString();
                Txt_direMedicoM.Text = datos.Rows[0][3].ToString();
                Txt_correoMedicoM.Text = datos.Rows[0][4].ToString();
                Cmb_especialidadMedicoM.Text = datos.Rows[0][5].ToString();
                Cmb_empresaMedicoM.Text = datos.Rows[0][6].ToString();
                Dtp_nacimiento.Text = datos.Rows[0][7].ToString();

                Txt_colegiadoM.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Txt_apellidoMedicoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_editarm_Click(object sender, EventArgs e) //Modificar médico asociado...................................
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                cmd.CommandText = "update medicosasociados set sNombre = '" + Txt_nombreMedicoM.Text + "' where nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update medicosasociados set sApellido = '" + Txt_apellidoMedicoM.Text + "' where nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update telefono set iTelefono = '" + Txt_telefonoMedicoM.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update medicosasociados set sDireccion = '" + Txt_direMedicoM.Text + "' where nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update correo set sCorreo = '" + Txt_correoMedicoM.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update medicosasociados set iIdEspecialidad = '" + Cmb_especialidadMedicoM.Text + "' where nNoColegiado = '" + Convert.ToInt32(Cmb_especialidadMedicoM.SelectedValue) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update medicosasociados set iIdEmpresa = '" + Cmb_empresaMedicoM.Text + "' where nNoColegiado = '" + Convert.ToInt32(Cmb_empresaMedicoM.SelectedValue) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update medicosasociados set dFechaDeNacimiento = '" + Dtp_nacimiento.Value + "' where nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("NO VA A SERVIR");
                MessageBox.Show("Médico Modificado Exitosamente.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Txt_colegiadoM.Enabled = true;
                Txt_colegiadoM.Clear();

                Txt_nombreMedicoM.Clear();
                Txt_apellidoMedicoM.Clear();
                Txt_telefonoMedicoM.Clear();
                Txt_direMedicoM.Clear();
                Txt_correoMedicoM.Clear();
                Cmb_especialidadMedicoM.ResetText(); Cmb_especialidadMedicoM.Items.Clear();
                Cmb_empresaMedicoM.ResetText(); Cmb_empresaMedicoM.Items.Clear();
                Dtp_nacimiento.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Cmb_tipoSangre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_eliminarm_Click(object sender, EventArgs e) //Eliminar médico asociado.........................
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                //Eliminar los datos del medico de 3 tablas que guardan su información
                cmd.CommandText = "delete from medicosasociados where nIdPaciente = '" + Convert.ToInt32(Txt_colegiadoE.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from telefono where nIdPaciente = '" + Convert.ToInt32(Txt_colegiadoE.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from correo where nIdPaciente = '" + Convert.ToInt32(Txt_colegiadoE.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Médico Eliminado Exitosamente", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Limpiar todos los textbox / combobox
                Txt_nombreMedicoE.Clear();
                Txt_apellidoMedicoE.Clear();
                Txt_telMedicoE.Clear();
                Txt_direMedicoE.Clear();
                Cmb_especialidadMedicoE.ResetText(); Cmb_especialidadMedicoE.Items.Clear();
                Cmb_empresaMedicoE.ResetText(); Cmb_empresaMedicoE.Items.Clear();
                Dtp_nacimientoE.Refresh();
                //Dtp_nacimientoE.CustomFormat = " ";


                //Volver a habilitar todos los textbox / combobox
                Txt_nombreMedicoE.Enabled = true;
                Txt_apellidoMedicoE.Enabled = true;
                Txt_telMedicoE.Enabled = true;
                Txt_direMedicoE.Enabled = true;
                Cmb_especialidadMedicoE.Enabled = true;
                Cmb_empresaMedicoE.Enabled = true;
                Dtp_nacimientoE.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_buscarE_Click(object sender, EventArgs e) // Buscar médico para eliminarlo............................
        {
            try
            {
                Gpb_datosEliminar.Visible = true;
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT me.sNombre, me.sApellido, te.itelefono, me.sDireccion, es.sEspecialidad, em.sEmpresa, me.dFechaDeNacimiento FROM medicosasociados me, telefono te, especialidad es, empresa em WHERE me.nNoColegiado = te.nIdPaciente AND me.iIdEspecialidad = es.iIdEspecialidad AND me.iIdEmpresa = em.iIdEmpresa AND me.nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoE.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_nombreMedicoE.Text = datos.Rows[0][0].ToString();
                Txt_apellidoMedicoE.Text = datos.Rows[0][1].ToString();
                Txt_telMedicoE.Text = datos.Rows[0][2].ToString();
                Txt_direMedicoE.Text = datos.Rows[0][3].ToString();
                Cmb_especialidadMedicoE.Text = datos.Rows[0][4].ToString();
                Cmb_empresaMedicoE.Text = datos.Rows[0][5].ToString();
                Dtp_nacimientoE.Text = datos.Rows[0][6].ToString();

                Txt_colegiadoE.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
