
namespace PuntoVenta.Modulos.Productos
{
    partial class Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datalistadoProductos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelRegistro = new System.Windows.Forms.Panel();
            this.TxtCodigoProd = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtCategoria = new System.Windows.Forms.ComboBox();
            this.TxtUMedida = new System.Windows.Forms.ComboBox();
            this.LblUMedida = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.PanelUsuarioImagen = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtExistencia = new System.Windows.Forms.TextBox();
            this.TxtPorcUtilidad = new System.Windows.Forms.TextBox();
            this.TxtPrecioMayorista = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblExistencia = new System.Windows.Forms.Label();
            this.LblPorcUtilidad = new System.Windows.Forms.Label();
            this.LblPrecioMayorista = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCosto = new System.Windows.Forms.Label();
            this.LblDescripción = new System.Windows.Forms.Label();
            this.LblImpuesto = new System.Windows.Forms.Label();
            this.TxtImpuesto = new System.Windows.Forms.ComboBox();
            this.PanelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoProductos)).BeginInit();
            this.PanelRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEncabezado
            // 
            this.PanelEncabezado.BackColor = System.Drawing.SystemColors.Control;
            this.PanelEncabezado.Controls.Add(this.datalistado);
            this.PanelEncabezado.Controls.Add(this.BtnNuevo);
            this.PanelEncabezado.Controls.Add(this.TxtBusqueda);
            this.PanelEncabezado.Controls.Add(this.menuStrip1);
            this.PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.PanelEncabezado.Name = "PanelEncabezado";
            this.PanelEncabezado.Size = new System.Drawing.Size(1041, 49);
            this.PanelEncabezado.TabIndex = 1;
            // 
            // datalistado
            // 
            this.datalistado.AllowUserToAddRows = false;
            this.datalistado.AllowUserToResizeRows = false;
            this.datalistado.BackgroundColor = System.Drawing.Color.White;
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Location = new System.Drawing.Point(586, 24);
            this.datalistado.Name = "datalistado";
            this.datalistado.RowTemplate.Height = 25;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(49, 13);
            this.datalistado.TabIndex = 9;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(420, 5);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(116, 37);
            this.BtnNuevo.TabIndex = 8;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.CrearProducto);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBusqueda.Location = new System.Drawing.Point(39, 12);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.PlaceholderText = "Texto a buscar...";
            this.TxtBusqueda.Size = new System.Drawing.Size(307, 25);
            this.TxtBusqueda.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(338, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(43, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.BuscarProducto);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 21);
            // 
            // datalistadoProductos
            // 
            this.datalistadoProductos.AllowUserToAddRows = false;
            this.datalistadoProductos.AllowUserToResizeRows = false;
            this.datalistadoProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datalistadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.datalistadoProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistadoProductos.Location = new System.Drawing.Point(0, 49);
            this.datalistadoProductos.Name = "datalistadoProductos";
            this.datalistadoProductos.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistadoProductos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datalistadoProductos.RowTemplate.Height = 25;
            this.datalistadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoProductos.Size = new System.Drawing.Size(1041, 401);
            this.datalistadoProductos.TabIndex = 5;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // PanelRegistro
            // 
            this.PanelRegistro.Controls.Add(this.TxtImpuesto);
            this.PanelRegistro.Controls.Add(this.LblImpuesto);
            this.PanelRegistro.Controls.Add(this.TxtCodigoProd);
            this.PanelRegistro.Controls.Add(this.TxtCodigo);
            this.PanelRegistro.Controls.Add(this.TxtCategoria);
            this.PanelRegistro.Controls.Add(this.TxtUMedida);
            this.PanelRegistro.Controls.Add(this.LblUMedida);
            this.PanelRegistro.Controls.Add(this.LblCategoria);
            this.PanelRegistro.Controls.Add(this.PanelUsuarioImagen);
            this.PanelRegistro.Controls.Add(this.BtnCancelar);
            this.PanelRegistro.Controls.Add(this.BtnGuardarCambios);
            this.PanelRegistro.Controls.Add(this.BtnGuardar);
            this.PanelRegistro.Controls.Add(this.TxtExistencia);
            this.PanelRegistro.Controls.Add(this.TxtPorcUtilidad);
            this.PanelRegistro.Controls.Add(this.TxtPrecioMayorista);
            this.PanelRegistro.Controls.Add(this.TxtPrecio);
            this.PanelRegistro.Controls.Add(this.TxtCosto);
            this.PanelRegistro.Controls.Add(this.TxtDescripcion);
            this.PanelRegistro.Controls.Add(this.LblExistencia);
            this.PanelRegistro.Controls.Add(this.LblPorcUtilidad);
            this.PanelRegistro.Controls.Add(this.LblPrecioMayorista);
            this.PanelRegistro.Controls.Add(this.LblPrecio);
            this.PanelRegistro.Controls.Add(this.LblCosto);
            this.PanelRegistro.Controls.Add(this.LblDescripción);
            this.PanelRegistro.Location = new System.Drawing.Point(0, 49);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.Size = new System.Drawing.Size(1041, 401);
            this.PanelRegistro.TabIndex = 6;
            this.PanelRegistro.Visible = false;
            // 
            // TxtCodigoProd
            // 
            this.TxtCodigoProd.Location = new System.Drawing.Point(132, 6);
            this.TxtCodigoProd.Name = "TxtCodigoProd";
            this.TxtCodigoProd.Size = new System.Drawing.Size(562, 23);
            this.TxtCodigoProd.TabIndex = 612;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCodigo.Location = new System.Drawing.Point(19, 7);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 18);
            this.TxtCodigo.TabIndex = 611;
            this.TxtCodigo.Text = "Código:";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.FormattingEnabled = true;
            this.TxtCategoria.Location = new System.Drawing.Point(132, 250);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(562, 23);
            this.TxtCategoria.TabIndex = 610;
            // 
            // TxtUMedida
            // 
            this.TxtUMedida.FormattingEnabled = true;
            this.TxtUMedida.Location = new System.Drawing.Point(132, 279);
            this.TxtUMedida.Name = "TxtUMedida";
            this.TxtUMedida.Size = new System.Drawing.Size(562, 23);
            this.TxtUMedida.TabIndex = 609;
            // 
            // LblUMedida
            // 
            this.LblUMedida.AutoSize = true;
            this.LblUMedida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUMedida.Location = new System.Drawing.Point(14, 279);
            this.LblUMedida.Name = "LblUMedida";
            this.LblUMedida.Size = new System.Drawing.Size(106, 19);
            this.LblUMedida.TabIndex = 17;
            this.LblUMedida.Text = "Unidad Medida:";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCategoria.Location = new System.Drawing.Point(14, 251);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(71, 19);
            this.LblCategoria.TabIndex = 16;
            this.LblCategoria.Text = "Categoria:";
            // 
            // PanelUsuarioImagen
            // 
            this.PanelUsuarioImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUsuarioImagen.BackgroundImage")));
            this.PanelUsuarioImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelUsuarioImagen.Location = new System.Drawing.Point(741, 91);
            this.PanelUsuarioImagen.Name = "PanelUsuarioImagen";
            this.PanelUsuarioImagen.Size = new System.Drawing.Size(143, 106);
            this.PanelUsuarioImagen.TabIndex = 15;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(542, 323);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(116, 37);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarCambios.Location = new System.Drawing.Point(420, 323);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(116, 37);
            this.BtnGuardarCambios.TabIndex = 14;
            this.BtnGuardarCambios.Text = "Guardar";
            this.BtnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(420, 323);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 37);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.GuardarProducto);
            // 
            // TxtExistencia
            // 
            this.TxtExistencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtExistencia.Location = new System.Drawing.Point(132, 219);
            this.TxtExistencia.Name = "TxtExistencia";
            this.TxtExistencia.Size = new System.Drawing.Size(562, 25);
            this.TxtExistencia.TabIndex = 12;
            // 
            // TxtPorcUtilidad
            // 
            this.TxtPorcUtilidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPorcUtilidad.Location = new System.Drawing.Point(132, 159);
            this.TxtPorcUtilidad.Name = "TxtPorcUtilidad";
            this.TxtPorcUtilidad.Size = new System.Drawing.Size(562, 25);
            this.TxtPorcUtilidad.TabIndex = 11;
            // 
            // TxtPrecioMayorista
            // 
            this.TxtPrecioMayorista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrecioMayorista.Location = new System.Drawing.Point(132, 128);
            this.TxtPrecioMayorista.Name = "TxtPrecioMayorista";
            this.TxtPrecioMayorista.Size = new System.Drawing.Size(562, 25);
            this.TxtPrecioMayorista.TabIndex = 10;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrecio.Location = new System.Drawing.Point(132, 97);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(562, 25);
            this.TxtPrecio.TabIndex = 9;
            // 
            // TxtCosto
            // 
            this.TxtCosto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCosto.Location = new System.Drawing.Point(132, 66);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(562, 25);
            this.TxtCosto.TabIndex = 8;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDescripcion.Location = new System.Drawing.Point(132, 35);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(562, 25);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // LblExistencia
            // 
            this.LblExistencia.AutoSize = true;
            this.LblExistencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblExistencia.Location = new System.Drawing.Point(14, 222);
            this.LblExistencia.Name = "LblExistencia";
            this.LblExistencia.Size = new System.Drawing.Size(70, 19);
            this.LblExistencia.TabIndex = 5;
            this.LblExistencia.Text = "Existencia:";
            // 
            // LblPorcUtilidad
            // 
            this.LblPorcUtilidad.AutoSize = true;
            this.LblPorcUtilidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPorcUtilidad.Location = new System.Drawing.Point(13, 162);
            this.LblPorcUtilidad.Name = "LblPorcUtilidad";
            this.LblPorcUtilidad.Size = new System.Drawing.Size(89, 19);
            this.LblPorcUtilidad.TabIndex = 4;
            this.LblPorcUtilidad.Text = "Porc Utilidad:";
            // 
            // LblPrecioMayorista
            // 
            this.LblPrecioMayorista.AutoSize = true;
            this.LblPrecioMayorista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrecioMayorista.Location = new System.Drawing.Point(13, 131);
            this.LblPrecioMayorista.Name = "LblPrecioMayorista";
            this.LblPrecioMayorista.Size = new System.Drawing.Size(114, 19);
            this.LblPrecioMayorista.TabIndex = 3;
            this.LblPrecioMayorista.Text = "Precio Mayorista:";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrecio.Location = new System.Drawing.Point(13, 100);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(49, 19);
            this.LblPrecio.TabIndex = 2;
            this.LblPrecio.Text = "Precio:";
            // 
            // LblCosto
            // 
            this.LblCosto.AutoSize = true;
            this.LblCosto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCosto.Location = new System.Drawing.Point(13, 69);
            this.LblCosto.Name = "LblCosto";
            this.LblCosto.Size = new System.Drawing.Size(48, 19);
            this.LblCosto.TabIndex = 1;
            this.LblCosto.Text = "Costo:";
            // 
            // LblDescripción
            // 
            this.LblDescripción.AutoSize = true;
            this.LblDescripción.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescripción.Location = new System.Drawing.Point(14, 38);
            this.LblDescripción.Name = "LblDescripción";
            this.LblDescripción.Size = new System.Drawing.Size(82, 19);
            this.LblDescripción.TabIndex = 0;
            this.LblDescripción.Text = "Descripción:";
            // 
            // LblImpuesto
            // 
            this.LblImpuesto.AutoSize = true;
            this.LblImpuesto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblImpuesto.Location = new System.Drawing.Point(14, 192);
            this.LblImpuesto.Name = "LblImpuesto";
            this.LblImpuesto.Size = new System.Drawing.Size(70, 19);
            this.LblImpuesto.TabIndex = 615;
            this.LblImpuesto.Text = "Impuesto:";
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "5",
            "10"});
            this.TxtImpuesto.FormattingEnabled = true;
            this.TxtImpuesto.Location = new System.Drawing.Point(132, 191);
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.Size = new System.Drawing.Size(562, 23);
            this.TxtImpuesto.TabIndex = 616;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.PanelRegistro);
            this.Controls.Add(this.datalistadoProductos);
            this.Controls.Add(this.PanelEncabezado);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.PanelEncabezado.ResumeLayout(false);
            this.PanelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoProductos)).EndInit();
            this.PanelRegistro.ResumeLayout(false);
            this.PanelRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelEncabezado;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView datalistadoProductos;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Panel PanelRegistro;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtExistencia;
        private System.Windows.Forms.TextBox TxtPorcUtilidad;
        private System.Windows.Forms.TextBox TxtPrecioMayorista;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblExistencia;
        private System.Windows.Forms.Label LblPorcUtilidad;
        private System.Windows.Forms.Label LblPrecioMayorista;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCosto;
        private System.Windows.Forms.Label LblDescripción;
        private System.Windows.Forms.Label LblUMedida;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox TxtCategoria;
        private System.Windows.Forms.ComboBox TxtUMedida;
        private System.Windows.Forms.Panel PanelUsuarioImagen;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.TextBox TxtCodigoProd;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblImpuesto;
        private System.Windows.Forms.ComboBox TxtImpuesto;
    }
}