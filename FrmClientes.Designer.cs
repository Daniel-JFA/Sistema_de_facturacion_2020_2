namespace Sistema_de_facturacion_2020_2
{
    partial class FrmClientes
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtBuscarCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ACTUALIZAR = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalirClientes = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(276, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(229, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ADMINISTRACION DE CLIENTES";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 116);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Depth = 0;
            this.TxtTelefono.Hint = "Telefono";
            this.TxtTelefono.Location = new System.Drawing.Point(60, 168);
            this.TxtTelefono.MaxLength = 32767;
            this.TxtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PasswordChar = '\0';
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.SelectionLength = 0;
            this.TxtTelefono.SelectionStart = 0;
            this.TxtTelefono.Size = new System.Drawing.Size(207, 23);
            this.TxtTelefono.TabIndex = 3;
            this.TxtTelefono.TabStop = false;
            this.TxtTelefono.UseSystemPasswordChar = false;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Depth = 0;
            this.TxtDireccion.Hint = "Direccion";
            this.TxtDireccion.Location = new System.Drawing.Point(60, 139);
            this.TxtDireccion.MaxLength = 32767;
            this.TxtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.SelectionLength = 0;
            this.TxtDireccion.SelectionStart = 0;
            this.TxtDireccion.Size = new System.Drawing.Size(207, 23);
            this.TxtDireccion.TabIndex = 4;
            this.TxtDireccion.TabStop = false;
            this.TxtDireccion.UseSystemPasswordChar = false;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Depth = 0;
            this.TxtDocumento.Hint = "Documento";
            this.TxtDocumento.Location = new System.Drawing.Point(60, 110);
            this.TxtDocumento.MaxLength = 32767;
            this.TxtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.PasswordChar = '\0';
            this.TxtDocumento.SelectedText = "";
            this.TxtDocumento.SelectionLength = 0;
            this.TxtDocumento.SelectionStart = 0;
            this.TxtDocumento.Size = new System.Drawing.Size(207, 23);
            this.TxtDocumento.TabIndex = 5;
            this.TxtDocumento.TabStop = false;
            this.TxtDocumento.UseSystemPasswordChar = false;
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Depth = 0;
            this.TxtNombreCliente.Hint = "Nombre Cliente";
            this.TxtNombreCliente.Location = new System.Drawing.Point(60, 81);
            this.TxtNombreCliente.MaxLength = 32767;
            this.TxtNombreCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.PasswordChar = '\0';
            this.TxtNombreCliente.SelectedText = "";
            this.TxtNombreCliente.SelectionLength = 0;
            this.TxtNombreCliente.SelectionStart = 0;
            this.TxtNombreCliente.Size = new System.Drawing.Size(207, 23);
            this.TxtNombreCliente.TabIndex = 6;
            this.TxtNombreCliente.TabStop = false;
            this.TxtNombreCliente.UseSystemPasswordChar = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Depth = 0;
            this.TxtEmail.Hint = "Email";
            this.TxtEmail.Location = new System.Drawing.Point(60, 197);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.Size = new System.Drawing.Size(207, 23);
            this.TxtEmail.TabIndex = 7;
            this.TxtEmail.TabStop = false;
            this.TxtEmail.UseSystemPasswordChar = false;
            // 
            // TxtBuscarCliente
            // 
            this.TxtBuscarCliente.Depth = 0;
            this.TxtBuscarCliente.Hint = "Buscar Cliente";
            this.TxtBuscarCliente.Location = new System.Drawing.Point(60, 267);
            this.TxtBuscarCliente.MaxLength = 32767;
            this.TxtBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarCliente.Name = "TxtBuscarCliente";
            this.TxtBuscarCliente.PasswordChar = '\0';
            this.TxtBuscarCliente.SelectedText = "";
            this.TxtBuscarCliente.SelectionLength = 0;
            this.TxtBuscarCliente.SelectionStart = 0;
            this.TxtBuscarCliente.Size = new System.Drawing.Size(311, 23);
            this.TxtBuscarCliente.TabIndex = 8;
            this.TxtBuscarCliente.TabStop = false;
            this.TxtBuscarCliente.UseSystemPasswordChar = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(554, 168);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(136, 23);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // ACTUALIZAR
            // 
            this.ACTUALIZAR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ACTUALIZAR.Depth = 0;
            this.ACTUALIZAR.Icon = null;
            this.ACTUALIZAR.Location = new System.Drawing.Point(554, 123);
            this.ACTUALIZAR.MouseState = MaterialSkin.MouseState.HOVER;
            this.ACTUALIZAR.Name = "ACTUALIZAR";
            this.ACTUALIZAR.Primary = true;
            this.ACTUALIZAR.Size = new System.Drawing.Size(136, 23);
            this.ACTUALIZAR.TabIndex = 10;
            this.ACTUALIZAR.Text = "ACTUALIZAR";
            this.ACTUALIZAR.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Icon = null;
            this.BtnNuevo.Location = new System.Drawing.Point(554, 81);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(136, 23);
            this.BtnNuevo.TabIndex = 11;
            this.BtnNuevo.Text = "NUEVO";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Icon = null;
            this.BtnBuscar.Location = new System.Drawing.Point(377, 267);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(128, 23);
            this.BtnBuscar.TabIndex = 12;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnSalirClientes
            // 
            this.BtnSalirClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSalirClientes.Depth = 0;
            this.BtnSalirClientes.Icon = null;
            this.BtnSalirClientes.Location = new System.Drawing.Point(554, 399);
            this.BtnSalirClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalirClientes.Name = "BtnSalirClientes";
            this.BtnSalirClientes.Primary = true;
            this.BtnSalirClientes.Size = new System.Drawing.Size(142, 23);
            this.BtnSalirClientes.TabIndex = 13;
            this.BtnSalirClientes.Text = "SALIR";
            this.BtnSalirClientes.UseVisualStyleBackColor = true;
            this.BtnSalirClientes.Click += new System.EventHandler(this.BtnSalirClientes_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalirClientes);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.ACTUALIZAR);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtBuscarCliente);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton ACTUALIZAR;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalirClientes;
    }
}