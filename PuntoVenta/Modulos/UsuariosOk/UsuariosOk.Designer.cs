
namespace PuntoVenta.Modulos
{
    partial class UsuariosOk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosOk));
            this.PanelBusqueda = new System.Windows.Forms.Panel();
            this.BtnAgregarUsuario = new System.Windows.Forms.Button();
            this.BtnBuscarUsuario = new System.Windows.Forms.Button();
            this.TxtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.DataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelAgregarUsuario = new System.Windows.Forms.Panel();
            this.Label_idUsuario = new System.Windows.Forms.Label();
            this.BtnGuardarEditado = new System.Windows.Forms.Button();
            this.PanelUsuarioImagen = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtRol = new System.Windows.Forms.ComboBox();
            this.LabelRol = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.LabelCorreo = new System.Windows.Forms.Label();
            this.LabelContraseña = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelNombres = new System.Windows.Forms.Label();
            this.PanelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuarios)).BeginInit();
            this.PanelAgregarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBusqueda
            // 
            this.PanelBusqueda.BackColor = System.Drawing.Color.Silver;
            this.PanelBusqueda.Controls.Add(this.BtnAgregarUsuario);
            this.PanelBusqueda.Controls.Add(this.BtnBuscarUsuario);
            this.PanelBusqueda.Controls.Add(this.TxtBuscarUsuario);
            this.PanelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.PanelBusqueda.Name = "PanelBusqueda";
            this.PanelBusqueda.Size = new System.Drawing.Size(1043, 63);
            this.PanelBusqueda.TabIndex = 1;
            // 
            // BtnAgregarUsuario
            // 
            this.BtnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarUsuario.Location = new System.Drawing.Point(416, 21);
            this.BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            this.BtnAgregarUsuario.Size = new System.Drawing.Size(75, 24);
            this.BtnAgregarUsuario.TabIndex = 2;
            this.BtnAgregarUsuario.Text = "Agregar";
            this.BtnAgregarUsuario.UseVisualStyleBackColor = true;
            this.BtnAgregarUsuario.Click += new System.EventHandler(this.BtnAgregarUsuario_Click);
            // 
            // BtnBuscarUsuario
            // 
            this.BtnBuscarUsuario.BackColor = System.Drawing.Color.White;
            this.BtnBuscarUsuario.Location = new System.Drawing.Point(335, 21);
            this.BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            this.BtnBuscarUsuario.Size = new System.Drawing.Size(75, 24);
            this.BtnBuscarUsuario.TabIndex = 1;
            this.BtnBuscarUsuario.Text = "Buscar";
            this.BtnBuscarUsuario.UseVisualStyleBackColor = false;
            this.BtnBuscarUsuario.Click += new System.EventHandler(this.BuscarUsuario);
            // 
            // TxtBuscarUsuario
            // 
            this.TxtBuscarUsuario.Location = new System.Drawing.Point(12, 21);
            this.TxtBuscarUsuario.Name = "TxtBuscarUsuario";
            this.TxtBuscarUsuario.Size = new System.Drawing.Size(317, 23);
            this.TxtBuscarUsuario.TabIndex = 0;
            // 
            // DataGridUsuarios
            // 
            this.DataGridUsuarios.AllowUserToAddRows = false;
            this.DataGridUsuarios.BackgroundColor = System.Drawing.Color.Gray;
            this.DataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.DataGridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridUsuarios.Location = new System.Drawing.Point(0, 63);
            this.DataGridUsuarios.Name = "DataGridUsuarios";
            this.DataGridUsuarios.RowTemplate.Height = 25;
            this.DataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridUsuarios.Size = new System.Drawing.Size(1043, 398);
            this.DataGridUsuarios.TabIndex = 2;
            this.DataGridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EliminarUsuario);
            this.DataGridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarUsuario);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PanelAgregarUsuario
            // 
            this.PanelAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PanelAgregarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAgregarUsuario.Controls.Add(this.Label_idUsuario);
            this.PanelAgregarUsuario.Controls.Add(this.PanelUsuarioImagen);
            this.PanelAgregarUsuario.Controls.Add(this.BtnCancelar);
            this.PanelAgregarUsuario.Controls.Add(this.BtnGuardar);
            this.PanelAgregarUsuario.Controls.Add(this.TxtRol);
            this.PanelAgregarUsuario.Controls.Add(this.LabelRol);
            this.PanelAgregarUsuario.Controls.Add(this.TxtCorreo);
            this.PanelAgregarUsuario.Controls.Add(this.TxtContraseña);
            this.PanelAgregarUsuario.Controls.Add(this.TxtLogin);
            this.PanelAgregarUsuario.Controls.Add(this.TxtNombres);
            this.PanelAgregarUsuario.Controls.Add(this.LabelCorreo);
            this.PanelAgregarUsuario.Controls.Add(this.LabelContraseña);
            this.PanelAgregarUsuario.Controls.Add(this.LabelLogin);
            this.PanelAgregarUsuario.Controls.Add(this.LabelNombres);
            this.PanelAgregarUsuario.Controls.Add(this.BtnGuardarEditado);
            this.PanelAgregarUsuario.Location = new System.Drawing.Point(3, 63);
            this.PanelAgregarUsuario.Name = "PanelAgregarUsuario";
            this.PanelAgregarUsuario.Size = new System.Drawing.Size(760, 323);
            this.PanelAgregarUsuario.TabIndex = 3;
            this.PanelAgregarUsuario.Visible = false;
            // 
            // Label_idUsuario
            // 
            this.Label_idUsuario.AutoSize = true;
            this.Label_idUsuario.Location = new System.Drawing.Point(675, 23);
            this.Label_idUsuario.Name = "Label_idUsuario";
            this.Label_idUsuario.Size = new System.Drawing.Size(38, 15);
            this.Label_idUsuario.TabIndex = 609;
            this.Label_idUsuario.Text = "label1";
            this.Label_idUsuario.Visible = false;
            // 
            // BtnGuardarEditado
            // 
            this.BtnGuardarEditado.BackColor = System.Drawing.Color.Green;
            this.BtnGuardarEditado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarEditado.Location = new System.Drawing.Point(412, 223);
            this.BtnGuardarEditado.Name = "BtnGuardarEditado";
            this.BtnGuardarEditado.Size = new System.Drawing.Size(110, 51);
            this.BtnGuardarEditado.TabIndex = 608;
            this.BtnGuardarEditado.Text = "Guardar";
            this.BtnGuardarEditado.UseVisualStyleBackColor = false;
            this.BtnGuardarEditado.Click += new System.EventHandler(this.BtnGuardar2);
            // 
            // PanelUsuarioImagen
            // 
            this.PanelUsuarioImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUsuarioImagen.BackgroundImage")));
            this.PanelUsuarioImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelUsuarioImagen.Location = new System.Drawing.Point(492, 19);
            this.PanelUsuarioImagen.Name = "PanelUsuarioImagen";
            this.PanelUsuarioImagen.Size = new System.Drawing.Size(143, 106);
            this.PanelUsuarioImagen.TabIndex = 12;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(525, 223);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 51);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Green;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(412, 223);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(110, 51);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardarUsuario_Click);
            // 
            // TxtRol
            // 
            this.TxtRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtRol.FormattingEnabled = true;
            this.TxtRol.Items.AddRange(new object[] {
            "Vendedor",
            "Cajero",
            "Administrador"});
            this.TxtRol.Location = new System.Drawing.Point(172, 163);
            this.TxtRol.Name = "TxtRol";
            this.TxtRol.Size = new System.Drawing.Size(461, 23);
            this.TxtRol.TabIndex = 607;
            this.TxtRol.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRoles);
            // 
            // LabelRol
            // 
            this.LabelRol.AutoSize = true;
            this.LabelRol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelRol.Location = new System.Drawing.Point(128, 166);
            this.LabelRol.Name = "LabelRol";
            this.LabelRol.Size = new System.Drawing.Size(34, 20);
            this.LabelRol.TabIndex = 8;
            this.LabelRol.Text = "Rol:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(172, 127);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(274, 23);
            this.TxtCorreo.TabIndex = 7;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(172, 92);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(274, 23);
            this.TxtContraseña.TabIndex = 6;
            this.TxtContraseña.UseSystemPasswordChar = true;
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(172, 53);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(274, 23);
            this.TxtLogin.TabIndex = 5;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(172, 19);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(274, 23);
            this.TxtNombres.TabIndex = 4;
            // 
            // LabelCorreo
            // 
            this.LabelCorreo.AutoSize = true;
            this.LabelCorreo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCorreo.Location = new System.Drawing.Point(31, 126);
            this.LabelCorreo.Name = "LabelCorreo";
            this.LabelCorreo.Size = new System.Drawing.Size(135, 20);
            this.LabelCorreo.TabIndex = 3;
            this.LabelCorreo.Text = "Correo electrónico:";
            // 
            // LabelContraseña
            // 
            this.LabelContraseña.AutoSize = true;
            this.LabelContraseña.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelContraseña.Location = new System.Drawing.Point(80, 91);
            this.LabelContraseña.Name = "LabelContraseña";
            this.LabelContraseña.Size = new System.Drawing.Size(86, 20);
            this.LabelContraseña.TabIndex = 2;
            this.LabelContraseña.Text = "Contraseña:";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelLogin.Location = new System.Drawing.Point(118, 52);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(49, 20);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Login:";
            // 
            // LabelNombres
            // 
            this.LabelNombres.AutoSize = true;
            this.LabelNombres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNombres.Location = new System.Drawing.Point(15, 19);
            this.LabelNombres.Name = "LabelNombres";
            this.LabelNombres.Size = new System.Drawing.Size(151, 20);
            this.LabelNombres.TabIndex = 0;
            this.LabelNombres.Text = "Nombres y Apellidos:";
            // 
            // UsuariosOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1043, 461);
            this.Controls.Add(this.PanelAgregarUsuario);
            this.Controls.Add(this.DataGridUsuarios);
            this.Controls.Add(this.PanelBusqueda);
            this.Name = "UsuariosOk";
            this.Text = "Usuarios del Sistema";
            this.PanelBusqueda.ResumeLayout(false);
            this.PanelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuarios)).EndInit();
            this.PanelAgregarUsuario.ResumeLayout(false);
            this.PanelAgregarUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelBusqueda;
        private System.Windows.Forms.Button BtnBuscarUsuario;
        private System.Windows.Forms.TextBox TxtBuscarUsuario;
        private System.Windows.Forms.Button BtnAgregarUsuario;
        private System.Windows.Forms.DataGridView DataGridUsuarios;
        private System.Windows.Forms.Panel PanelAgregarUsuario;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelNombres;
        private System.Windows.Forms.Label LabelCorreo;
        private System.Windows.Forms.Label LabelContraseña;
        private System.Windows.Forms.ComboBox TxtRol;
        private System.Windows.Forms.Label LabelRol;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Panel PanelUsuarioImagen;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Button BtnGuardarEditado;
        private System.Windows.Forms.Label Label_idUsuario;
    }
}