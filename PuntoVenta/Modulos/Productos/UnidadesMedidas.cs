using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.Productos
{
    public partial class UnidadesMedidas : Form
    {
        int idUMedida;
        public UnidadesMedidas()
        {
            InitializeComponent();
        }

        public DataTable cargarComboUnidadesMedidas()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("sp_umedida_cargar", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }

        private void UnidadesMedidas_Load(object sender, EventArgs e)
        {
            mostrarUnidadesMedidas();
        }

        private void mostrarUnidadesMedidas()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_umedida_mostrar", con);
                da.Fill(dt);
                datalistadoMedidas.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ocultar_columnas()
        {
            datalistadoMedidas.Columns[2].Visible = false;
        }

        private void BuscarUnidadMedida(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_umedida_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBusqueda.Text);
                da.Fill(dt);
                datalistadoMedidas.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarUnidadMedida(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoMedidas.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Está seguro de eliminar esta unidad de medida del sistema?", "Eliminando registro...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in datalistadoMedidas.SelectedRows)
                        {
                            int onekey = Convert.ToInt32(row.Cells["idUMedida"].Value);

                            try
                            {
                                try
                                {
                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("sp_umedida_eliminar", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@idUMedida", onekey);
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
                        mostrarUnidadesMedidas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void EditarUnidadMedida(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoMedidas.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                ObtenerDatosUnidadesMedidas();
            }
        }

        private void EditarUnidadMedida2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            ObtenerDatosUnidadesMedidas();
        }

        private void ObtenerDatosUnidadesMedidas()
        {
            try
            {
                idUMedida = Convert.ToInt32(datalistadoMedidas.SelectedCells[2].Value.ToString());
                TxtAbrev.Text = datalistadoMedidas.SelectedCells[3].Value.ToString();
                TxtDescripcion.Text = datalistadoMedidas.SelectedCells[4].Value.ToString();

                TxtBusqueda.Visible = false;
                menuStrip1.Visible = false;
                BtnNuevo.Visible = false;
                PanelRegistro.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CrearUnidadMedida(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            BtnNuevo.Visible = false;
            PanelRegistro.Visible = true;
            BtnGuardarCambios.Visible = false;
            limpiar();
        }

        private void limpiar()
        {
            TxtAbrev.Clear();
            TxtDescripcion.Clear();
            BtnGuardar.Visible = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            TxtBusqueda.Visible = true;
            menuStrip1.Visible = true;
            BtnNuevo.Visible = true;
        }

        private void GuardarUnidadMedida(object sender, EventArgs e)
        {
            try
            {
                if (TxtAbrev.Text != "")
                {

                    if (TxtDescripcion.Text == "")
                    {
                        TxtDescripcion.Text = "Unidad de Medida " + TxtAbrev.Text;
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_umedida_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Abreviacion", TxtAbrev.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarUnidadesMedidas();
                        PanelRegistro.Visible = false;
                        TxtBusqueda.Visible = true;
                        menuStrip1.Visible = true;
                        BtnNuevo.Visible = true;
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtAbrev.Text != "")
                {

                    if (TxtDescripcion.Text == "")
                    {
                        TxtDescripcion.Text = "Unidad de Medida " + TxtAbrev.Text;
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_umedida_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idUMedida", idUMedida);
                        cmd.Parameters.AddWithValue("@Abreviacion", TxtAbrev.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarUnidadesMedidas();
                        PanelRegistro.Visible = false;
                        TxtBusqueda.Visible = true;
                        menuStrip1.Visible = true;
                        BtnNuevo.Visible = true;
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}