using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PuntoVenta.Modulos
{
    public partial class UsuariosOk : Form
    {
        public UsuariosOk()
        {
            InitializeComponent();
            MostrarUsuarios();
        }

        private void ComboBoxRoles(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            TxtNombres.Clear();
            TxtLogin.Clear();
            TxtCorreo.Clear();
            BtnGuardar.Visible = true;
        }

        private void MostrarUsuarios()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("dbo.sp_usuario_mostrar", con);




                da.Fill(dt);
                DataGridUsuarios.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            PanelBusqueda.Hide();
            DataGridUsuarios.Hide();
            PanelAgregarUsuario.Show();
        }

        public bool ValidarCorreo(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");

        }

        private void BtnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if(!ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com, " + " por favor, seleccione un correo válido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {



                if (TxtNombres.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("dbo.sp_usuario_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombres", TxtNombres.Text);
                        cmd.Parameters.AddWithValue("@Login", TxtLogin.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text);

                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        cmd.Parameters.AddWithValue("@Rol", TxtRol.Text);
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();

                        cmd.Parameters.AddWithValue("@Estado", "ACTIVO");

                        cmd.ExecuteNonQuery();
                        con.Close();
                        PanelAgregarUsuario.Hide();
                        PanelBusqueda.Show();
                        DataGridUsuarios.Show();
                        MostrarUsuarios();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelBusqueda.Show();
            PanelAgregarUsuario.Hide();
            DataGridUsuarios.Show();
            MostrarUsuarios();
            limpiar();
        }

        private void BuscarUsuario()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("dbo.sp_usuario_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBuscarUsuario.Text);
                da.Fill(dt);
                DataGridUsuarios.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BuscarUsuario(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void EliminarUsuario(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == this.DataGridUsuarios.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox
                .Show("¿Está seguro de eliminar este usuario del sistema?", "Eliminando registro...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in DataGridUsuarios.SelectedRows)
                        {

                            int onekey = Convert.ToInt32(row.Cells["idUsuario"].Value);
                            string usuario = Convert.ToString(row.Cells["Login"].Value);

                            try
                            {

                                try
                                {

                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("dbo.sp_usuario_eliminar", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@idUsuario", onekey);
                                    cmd.Parameters.AddWithValue("@login", usuario);
                                    cmd.ExecuteNonQuery();

                                    con.Close();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }

                        }
                        MostrarUsuarios();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void EditarUsuario(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.DataGridUsuarios.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarEditado.Visible = true;
                ObtenerDatosUsuario();
            }
        }

        private void ObtenerDatosUsuario()
        {
            try
            {
                Label_idUsuario.Text = DataGridUsuarios.SelectedCells[2].Value.ToString();
                TxtNombres.Text = DataGridUsuarios.SelectedCells[3].Value.ToString();
                TxtLogin.Text = DataGridUsuarios.SelectedCells[4].Value.ToString();
                TxtCorreo.Text = DataGridUsuarios.SelectedCells[5].Value.ToString();
                TxtRol.Text = DataGridUsuarios.SelectedCells[6].Value.ToString();

                PanelBusqueda.Hide();
                DataGridUsuarios.Hide();
                PanelAgregarUsuario.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGuardar2(object sender, EventArgs e)
        {
            if (!ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com, " + " por favor, seleccione un correo válido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {
                if (TxtNombres.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("dbo.sp_usuario_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idUsuario", Label_idUsuario.Text);
                        cmd.Parameters.AddWithValue("@nombres", TxtNombres.Text);
                        cmd.Parameters.AddWithValue("@Login", TxtLogin.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text);

                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        cmd.Parameters.AddWithValue("@Rol", TxtRol.Text);
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();

                        cmd.ExecuteNonQuery();
                        con.Close();
                        PanelAgregarUsuario.Hide();
                        PanelBusqueda.Show();
                        DataGridUsuarios.Show();
                        MostrarUsuarios();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
            }
        }
    }
}