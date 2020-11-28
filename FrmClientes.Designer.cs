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
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.DgCliente = new System.Windows.Forms.DataGridView();
            this.TxtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtBuscarCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizarClientes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalirClientes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(368, 42);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(229, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ADMINISTRACION DE CLIENTES";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // DgCliente
            // 
            this.DgCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCliente.Location = new System.Drawing.Point(80, 377);
            this.DgCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgCliente.Name = "DgCliente";
            this.DgCliente.Size = new System.Drawing.Size(593, 143);
            this.DgCliente.TabIndex = 1;
            this.DgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DgCliente.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgCliente_CellMouseClick);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Depth = 0;
            this.TxtTelefono.Hint = "Telefono";
            this.TxtTelefono.Location = new System.Drawing.Point(80, 207);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTelefono.MaxLength = 32767;
            this.TxtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PasswordChar = '\0';
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.SelectionLength = 0;
            this.TxtTelefono.SelectionStart = 0;
            this.TxtTelefono.Size = new System.Drawing.Size(276, 23);
            this.TxtTelefono.TabIndex = 3;
            this.TxtTelefono.TabStop = false;
            this.TxtTelefono.UseSystemPasswordChar = false;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Depth = 0;
            this.TxtDireccion.Hint = "Direccion";
            this.TxtDireccion.Location = new System.Drawing.Point(80, 171);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDireccion.MaxLength = 32767;
            this.TxtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.SelectionLength = 0;
            this.TxtDireccion.SelectionStart = 0;
            this.TxtDireccion.Size = new System.Drawing.Size(276, 23);
            this.TxtDireccion.TabIndex = 4;
            this.TxtDireccion.TabStop = false;
            this.TxtDireccion.UseSystemPasswordChar = false;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Depth = 0;
            this.TxtDocumento.Hint = "Documento";
            this.TxtDocumento.Location = new System.Drawing.Point(80, 135);
            this.TxtDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDocumento.MaxLength = 32767;
            this.TxtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.PasswordChar = '\0';
            this.TxtDocumento.SelectedText = "";
            this.TxtDocumento.SelectionLength = 0;
            this.TxtDocumento.SelectionStart = 0;
            this.TxtDocumento.Size = new System.Drawing.Size(276, 23);
            this.TxtDocumento.TabIndex = 5;
            this.TxtDocumento.TabStop = false;
            this.TxtDocumento.UseSystemPasswordChar = false;
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Depth = 0;
            this.TxtNombreCliente.Hint = "Nombre Cliente";
            this.TxtNombreCliente.Location = new System.Drawing.Point(80, 100);
            this.TxtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombreCliente.MaxLength = 32767;
            this.TxtNombreCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.PasswordChar = '\0';
            this.TxtNombreCliente.SelectedText = "";
            this.TxtNombreCliente.SelectionLength = 0;
            this.TxtNombreCliente.SelectionStart = 0;
            this.TxtNombreCliente.Size = new System.Drawing.Size(276, 23);
            this.TxtNombreCliente.TabIndex = 6;
            this.TxtNombreCliente.TabStop = false;
            this.TxtNombreCliente.UseSystemPasswordChar = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Depth = 0;
            this.TxtEmail.Hint = "Email";
            this.TxtEmail.Location = new System.Drawing.Point(80, 242);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.Size = new System.Drawing.Size(276, 23);
            this.TxtEmail.TabIndex = 7;
            this.TxtEmail.TabStop = false;
            this.TxtEmail.UseSystemPasswordChar = false;
            // 
            // TxtBuscarCliente
            // 
            this.TxtBuscarCliente.Depth = 0;
            this.TxtBuscarCliente.Hint = "Buscar Cliente";
            this.TxtBuscarCliente.Location = new System.Drawing.Point(80, 329);
            this.TxtBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBuscarCliente.MaxLength = 32767;
            this.TxtBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarCliente.Name = "TxtBuscarCliente";
            this.TxtBuscarCliente.PasswordChar = '\0';
            this.TxtBuscarCliente.SelectedText = "";
            this.TxtBuscarCliente.SelectionLength = 0;
            this.TxtBuscarCliente.SelectionStart = 0;
            this.TxtBuscarCliente.Size = new System.Drawing.Size(415, 23);
            this.TxtBuscarCliente.TabIndex = 8;
            this.TxtBuscarCliente.TabStop = false;
            this.TxtBuscarCliente.UseSystemPasswordChar = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(739, 207);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(83, 36);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizarClientes
            // 
            this.BtnActualizarClientes.AutoSize = true;
            this.BtnActualizarClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizarClientes.Depth = 0;
            this.BtnActualizarClientes.Icon = null;
            this.BtnActualizarClientes.Location = new System.Drawing.Point(739, 151);
            this.BtnActualizarClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnActualizarClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizarClientes.Name = "BtnActualizarClientes";
            this.BtnActualizarClientes.Primary = true;
            this.BtnActualizarClientes.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizarClientes.TabIndex = 10;
            this.BtnActualizarClientes.Text = "ACTUALIZAR";
            this.BtnActualizarClientes.UseVisualStyleBackColor = true;
            this.BtnActualizarClientes.Click += new System.EventHandler(this.ACTUALIZAR_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSize = true;
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Icon = null;
            this.BtnNuevo.Location = new System.Drawing.Point(739, 100);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(66, 36);
            this.BtnNuevo.TabIndex = 11;
            this.BtnNuevo.Text = "NUEVO";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Icon = null;
            this.BtnBuscar.Location = new System.Drawing.Point(503, 329);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(74, 36);
            this.BtnBuscar.TabIndex = 12;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnSalirClientes
            // 
            this.BtnSalirClientes.AutoSize = true;
            this.BtnSalirClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSalirClientes.Depth = 0;
            this.BtnSalirClientes.Icon = null;
            this.BtnSalirClientes.Location = new System.Drawing.Point(739, 491);
            this.BtnSalirClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSalirClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalirClientes.Name = "BtnSalirClientes";
            this.BtnSalirClientes.Primary = true;
            this.BtnSalirClientes.Size = new System.Drawing.Size(58, 36);
            this.BtnSalirClientes.TabIndex = 13;
            this.BtnSalirClientes.Text = "SALIR";
            this.BtnSalirClientes.UseVisualStyleBackColor = true;
            this.BtnSalirClientes.Click += new System.EventHandler(this.BtnSalirClientes_Click);
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(80, 43);
            this.TxtIdCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(27, 22);
            this.TxtIdCliente.TabIndex = 14;
            this.TxtIdCliente.Text = "null";
            this.TxtIdCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.BtnSalirClientes);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnActualizarClientes);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtBuscarCliente);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.DgCliente);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView DgCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizarClientes;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalirClientes;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}