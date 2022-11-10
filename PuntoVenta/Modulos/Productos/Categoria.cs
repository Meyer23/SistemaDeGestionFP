using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System;

namespace PuntoVenta.Modulos.Productos
{
    public partial class Categoria : Form
    {
        int idCategoria;
        public Categoria()
        {
            InitializeComponent();
        }

        public DataTable cargarComboCategorias()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("sp_categoria_cargar", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            mostrarCategorias();
        }

        private void mostrarCategorias()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_categoria_mostrar", con);
                da.Fill(dt);
                datalistadoCategorias.DataSource = dt;
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
            datalistadoCategorias.Columns[2].Visible = false;
        }

        private void BuscarCategoria(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_categoria_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBusqueda.Text);
                da.Fill(dt);
                datalistadoCategorias.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarCategoria(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoCategorias.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Está seguro de eliminar esta categoría del sistema?", "Eliminando registro...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in datalistadoCategorias.SelectedRows)
                        {
                            int onekey = Convert.ToInt32(row.Cells["idCategoria"].Value);

                            try
                            {
                                try
                                {
                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("sp_categoria_eliminar", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@idCategoria", onekey);
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
                        mostrarCategorias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void EditarCategoria(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoCategorias.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                ObtenerDatosCategorias();
            }
        }

        private void EditarCategoria2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            ObtenerDatosCategorias();
        }

        private void ObtenerDatosCategorias()
        {
            try
            {
                idCategoria = Convert.ToInt32(datalistadoCategorias.SelectedCells[2].Value.ToString());
                TxtNombre.Text = datalistadoCategorias.SelectedCells[3].Value.ToString();
                TxtDescripcion.Text = datalistadoCategorias.SelectedCells[4].Value.ToString();

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

        private void CrearCategoria(object sender, EventArgs e)
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
            TxtNombre.Clear();
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

        private void GuardarCategoria(object sender, EventArgs e)
        {
            try
            {
                if (TxtNombre.Text != "")
                {

                    if (TxtDescripcion.Text == "")
                    {
                        TxtDescripcion.Text = "Categoria " + TxtNombre.Text;
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_categoria_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarCategorias();
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
                if (TxtNombre.Text != "")
                {
                    if (TxtDescripcion.Text == "")
                    {
                        TxtDescripcion.Text = "Categoria " + TxtNombre.Text;
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_categoria_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarCategorias();
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