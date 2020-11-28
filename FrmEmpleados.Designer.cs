namespace Sistema_de_facturacion_2020_2
{
    partial class FrmEmpleados
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
            this.DgEmpleado = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ACTUALIZAR = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDocumentoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDireccionEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtTelefonoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtEmailEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtIdEmpleado = new System.Windows.Forms.TextBox();
            this.TxtIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.LblDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.TxtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.TxtRolEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.TxtRetiro = new MaterialSkin.Controls.MaterialLabel();
            this.DtmRetiro = new System.Windows.Forms.DateTimePicker();
            this.DtmIngreso = new System.Windows.Forms.DateTimePicker();
            this.CboRol = new System.Windows.Forms.ComboBox();
            this.TxtBuscarCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnSalirClientes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MensajeErrorEmpleado = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgEmpleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeErrorEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // DgEmpleado
            // 
            this.DgEmpleado.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgEmpleado.Location = new System.Drawing.Point(100, 508);
            this.DgEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgEmpleado.Name = "DgEmpleado";
            this.DgEmpleado.Size = new System.Drawing.Size(593, 143);
            this.DgEmpleado.TabIndex = 2;
            this.DgEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DgEmpleado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgEmpleado_CellMouseClick);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSize = true;
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Icon = null;
            this.BtnNuevo.Location = new System.Drawing.Point(907, 204);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(66, 36);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.Text = "NUEVO";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // ACTUALIZAR
            // 
            this.ACTUALIZAR.AutoSize = true;
            this.ACTUALIZAR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ACTUALIZAR.Depth = 0;
            this.ACTUALIZAR.Icon = null;
            this.ACTUALIZAR.Location = new System.Drawing.Point(907, 272);
            this.ACTUALIZAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ACTUALIZAR.MouseState = MaterialSkin.MouseState.HOVER;
            this.ACTUALIZAR.Name = "ACTUALIZAR";
            this.ACTUALIZAR.Primary = true;
            this.ACTUALIZAR.Size = new System.Drawing.Size(103, 36);
            this.ACTUALIZAR.TabIndex = 15;
            this.ACTUALIZAR.Text = "ACTUALIZAR";
            this.ACTUALIZAR.UseVisualStyleBackColor = true;
            this.ACTUALIZAR.Click += new System.EventHandler(this.ACTUALIZAR_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(907, 337);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(83, 36);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.Depth = 0;
            this.TxtNombreEmpleado.Hint = "Nombre Empleado";
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(76, 172);
            this.TxtNombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombreEmpleado.MaxLength = 32767;
            this.TxtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.PasswordChar = '\0';
            this.TxtNombreEmpleado.SelectedText = "";
            this.TxtNombreEmpleado.SelectionLength = 0;
            this.TxtNombreEmpleado.SelectionStart = 0;
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(276, 23);
            this.TxtNombreEmpleado.TabIndex = 17;
            this.TxtNombreEmpleado.TabStop = false;
            this.TxtNombreEmpleado.UseSystemPasswordChar = false;
            this.TxtNombreEmpleado.Click += new System.EventHandler(this.TxtNombreCliente_Click);
            // 
            // TxtDocumentoEmpleado
            // 
            this.TxtDocumentoEmpleado.Depth = 0;
            this.TxtDocumentoEmpleado.Hint = "Documento";
            this.TxtDocumentoEmpleado.Location = new System.Drawing.Point(76, 220);
            this.TxtDocumentoEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDocumentoEmpleado.MaxLength = 32767;
            this.TxtDocumentoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDocumentoEmpleado.Name = "TxtDocumentoEmpleado";
            this.TxtDocumentoEmpleado.PasswordChar = '\0';
            this.TxtDocumentoEmpleado.SelectedText = "";
            this.TxtDocumentoEmpleado.SelectionLength = 0;
            this.TxtDocumentoEmpleado.SelectionStart = 0;
            this.TxtDocumentoEmpleado.Size = new System.Drawing.Size(276, 23);
            this.TxtDocumentoEmpleado.TabIndex = 18;
            this.TxtDocumentoEmpleado.TabStop = false;
            this.TxtDocumentoEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtDireccionEmpleado
            // 
            this.TxtDireccionEmpleado.Depth = 0;
            this.TxtDireccionEmpleado.Hint = "Direccion";
            this.TxtDireccionEmpleado.Location = new System.Drawing.Point(76, 268);
            this.TxtDireccionEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDireccionEmpleado.MaxLength = 32767;
            this.TxtDireccionEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDireccionEmpleado.Name = "TxtDireccionEmpleado";
            this.TxtDireccionEmpleado.PasswordChar = '\0';
            this.TxtDireccionEmpleado.SelectedText = "";
            this.TxtDireccionEmpleado.SelectionLength = 0;
            this.TxtDireccionEmpleado.SelectionStart = 0;
            this.TxtDireccionEmpleado.Size = new System.Drawing.Size(276, 23);
            this.TxtDireccionEmpleado.TabIndex = 19;
            this.TxtDireccionEmpleado.TabStop = false;
            this.TxtDireccionEmpleado.UseSystemPasswordChar = false;
            this.TxtDireccionEmpleado.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // TxtTelefonoEmpleado
            // 
            this.TxtTelefonoEmpleado.Depth = 0;
            this.TxtTelefonoEmpleado.Hint = "Telefono";
            this.TxtTelefonoEmpleado.Location = new System.Drawing.Point(76, 313);
            this.TxtTelefonoEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTelefonoEmpleado.MaxLength = 32767;
            this.TxtTelefonoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTelefonoEmpleado.Name = "TxtTelefonoEmpleado";
            this.TxtTelefonoEmpleado.PasswordChar = '\0';
            this.TxtTelefonoEmpleado.SelectedText = "";
            this.TxtTelefonoEmpleado.SelectionLength = 0;
            this.TxtTelefonoEmpleado.SelectionStart = 0;
            this.TxtTelefonoEmpleado.Size = new System.Drawing.Size(276, 23);
            this.TxtTelefonoEmpleado.TabIndex = 20;
            this.TxtTelefonoEmpleado.TabStop = false;
            this.TxtTelefonoEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtEmailEmpleado
            // 
            this.TxtEmailEmpleado.Depth = 0;
            this.TxtEmailEmpleado.Hint = "Email";
            this.TxtEmailEmpleado.Location = new System.Drawing.Point(76, 362);
            this.TxtEmailEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmailEmpleado.MaxLength = 32767;
            this.TxtEmailEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEmailEmpleado.Name = "TxtEmailEmpleado";
            this.TxtEmailEmpleado.PasswordChar = '\0';
            this.TxtEmailEmpleado.SelectedText = "";
            this.TxtEmailEmpleado.SelectionLength = 0;
            this.TxtEmailEmpleado.SelectionStart = 0;
            this.TxtEmailEmpleado.Size = new System.Drawing.Size(276, 23);
            this.TxtEmailEmpleado.TabIndex = 21;
            this.TxtEmailEmpleado.TabStop = false;
            this.TxtEmailEmpleado.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(76, 433);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(773, 238);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Icon = null;
            this.BtnBuscar.Location = new System.Drawing.Point(645, 79);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(74, 36);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtIdEmpleado);
            this.groupBox2.Controls.Add(this.TxtIngreso);
            this.groupBox2.Controls.Add(this.DtmIngreso);
            this.groupBox2.Controls.Add(this.DtmRetiro);
            this.groupBox2.Location = new System.Drawing.Point(31, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(819, 311);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS BASICOS";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TxtIdEmpleado
            // 
            this.TxtIdEmpleado.Location = new System.Drawing.Point(8, 23);
            this.TxtIdEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIdEmpleado.Name = "TxtIdEmpleado";
            this.TxtIdEmpleado.Size = new System.Drawing.Size(25, 22);
            this.TxtIdEmpleado.TabIndex = 29;
            this.TxtIdEmpleado.Text = "null\r\n";
            this.TxtIdEmpleado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.AutoSize = true;
            this.TxtIngreso.Depth = 0;
            this.TxtIngreso.Font = new System.Drawing.Font("Roboto", 11F);
            this.TxtIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtIngreso.Location = new System.Drawing.Point(376, 111);
            this.TxtIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.Size = new System.Drawing.Size(59, 19);
            this.TxtIngreso.TabIndex = 28;
            this.TxtIngreso.Text = "Ingreso";
            this.TxtIngreso.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(367, 36);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(228, 19);
            this.LblTitulo.TabIndex = 32;
            this.LblTitulo.Text = "ADMINISTRACION  EMPLEADOS";
            // 
            // LblDatosAdicionales
            // 
            this.LblDatosAdicionales.AutoSize = true;
            this.LblDatosAdicionales.Depth = 0;
            this.LblDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDatosAdicionales.Location = new System.Drawing.Point(525, 332);
            this.LblDatosAdicionales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDatosAdicionales.Name = "LblDatosAdicionales";
            this.LblDatosAdicionales.Size = new System.Drawing.Size(108, 19);
            this.LblDatosAdicionales.TabIndex = 27;
            this.LblDatosAdicionales.Text = "materialLabel2";
            this.LblDatosAdicionales.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // TxtDatosAdicionales
            // 
            this.TxtDatosAdicionales.Location = new System.Drawing.Point(512, 362);
            this.TxtDatosAdicionales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDatosAdicionales.Name = "TxtDatosAdicionales";
            this.TxtDatosAdicionales.Size = new System.Drawing.Size(265, 22);
            this.TxtDatosAdicionales.TabIndex = 25;
            this.TxtDatosAdicionales.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtRolEmpleado
            // 
            this.TxtRolEmpleado.AutoSize = true;
            this.TxtRolEmpleado.Depth = 0;
            this.TxtRolEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.TxtRolEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtRolEmpleado.Location = new System.Drawing.Point(407, 172);
            this.TxtRolEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRolEmpleado.Name = "TxtRolEmpleado";
            this.TxtRolEmpleado.Size = new System.Drawing.Size(98, 19);
            this.TxtRolEmpleado.TabIndex = 26;
            this.TxtRolEmpleado.Text = "RolEmpleado";
            this.TxtRolEmpleado.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // TxtRetiro
            // 
            this.TxtRetiro.AutoSize = true;
            this.TxtRetiro.Depth = 0;
            this.TxtRetiro.Font = new System.Drawing.Font("Roboto", 11F);
            this.TxtRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtRetiro.Location = new System.Drawing.Point(407, 268);
            this.TxtRetiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRetiro.Name = "TxtRetiro";
            this.TxtRetiro.Size = new System.Drawing.Size(49, 19);
            this.TxtRetiro.TabIndex = 29;
            this.TxtRetiro.Text = "Retiro";
            this.TxtRetiro.Click += new System.EventHandler(this.DtmRetiro_Click);
            // 
            // DtmRetiro
            // 
            this.DtmRetiro.Location = new System.Drawing.Point(464, 151);
            this.DtmRetiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtmRetiro.Name = "DtmRetiro";
            this.DtmRetiro.Size = new System.Drawing.Size(265, 22);
            this.DtmRetiro.TabIndex = 23;
            // 
            // DtmIngreso
            // 
            this.DtmIngreso.Location = new System.Drawing.Point(463, 111);
            this.DtmIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtmIngreso.Name = "DtmIngreso";
            this.DtmIngreso.Size = new System.Drawing.Size(265, 22);
            this.DtmIngreso.TabIndex = 22;
            this.DtmIngreso.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CboRol
            // 
            this.CboRol.FormattingEnabled = true;
            this.CboRol.Location = new System.Drawing.Point(576, 172);
            this.CboRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboRol.Name = "CboRol";
            this.CboRol.Size = new System.Drawing.Size(160, 24);
            this.CboRol.TabIndex = 24;
            // 
            // TxtBuscarCliente
            // 
            this.TxtBuscarCliente.Depth = 0;
            this.TxtBuscarCliente.Hint = "Buscar Cliente";
            this.TxtBuscarCliente.Location = new System.Drawing.Point(84, 465);
            this.TxtBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBuscarCliente.MaxLength = 32767;
            this.TxtBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarCliente.Name = "TxtBuscarCliente";
            this.TxtBuscarCliente.PasswordChar = '\0';
            this.TxtBuscarCliente.SelectedText = "";
            this.TxtBuscarCliente.SelectionLength = 0;
            this.TxtBuscarCliente.SelectionStart = 0;
            this.TxtBuscarCliente.Size = new System.Drawing.Size(415, 23);
            this.TxtBuscarCliente.TabIndex = 9;
            this.TxtBuscarCliente.TabStop = false;
            this.TxtBuscarCliente.UseSystemPasswordChar = false;
            this.TxtBuscarCliente.Click += new System.EventHandler(this.TxtBuscarCliente_Click);
            // 
            // BtnSalirClientes
            // 
            this.BtnSalirClientes.AutoSize = true;
            this.BtnSalirClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSalirClientes.Depth = 0;
            this.BtnSalirClientes.Icon = null;
            this.BtnSalirClientes.Location = new System.Drawing.Point(907, 564);
            this.BtnSalirClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSalirClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalirClientes.Name = "BtnSalirClientes";
            this.BtnSalirClientes.Primary = true;
            this.BtnSalirClientes.Size = new System.Drawing.Size(58, 36);
            this.BtnSalirClientes.TabIndex = 33;
            this.BtnSalirClientes.Text = "SALIR";
            this.BtnSalirClientes.UseVisualStyleBackColor = true;
            this.BtnSalirClientes.Click += new System.EventHandler(this.BtnSalirClientes_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MensajeErrorEmpleado
            // 
            this.MensajeErrorEmpleado.ContainerControl = this;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 686);
            this.Controls.Add(this.BtnSalirClientes);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtRetiro);
            this.Controls.Add(this.LblDatosAdicionales);
            this.Controls.Add(this.TxtRolEmpleado);
            this.Controls.Add(this.TxtDatosAdicionales);
            this.Controls.Add(this.CboRol);
            this.Controls.Add(this.TxtEmailEmpleado);
            this.Controls.Add(this.TxtTelefonoEmpleado);
            this.Controls.Add(this.TxtDireccionEmpleado);
            this.Controls.Add(this.TxtDocumentoEmpleado);
            this.Controls.Add(this.TxtNombreEmpleado);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.ACTUALIZAR);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.TxtBuscarCliente);
            this.Controls.Add(this.DgEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgEmpleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeErrorEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton ACTUALIZAR;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDocumentoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDireccionEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTelefonoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtEmailEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private MaterialSkin.Controls.MaterialLabel LblDatosAdicionales;
        private System.Windows.Forms.TextBox TxtDatosAdicionales;
        private MaterialSkin.Controls.MaterialLabel TxtRolEmpleado;
        private MaterialSkin.Controls.MaterialLabel TxtRetiro;
        private System.Windows.Forms.DateTimePicker DtmRetiro;
        private System.Windows.Forms.DateTimePicker DtmIngreso;
        private System.Windows.Forms.ComboBox CboRol;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalirClientes;
        private System.Windows.Forms.TextBox TxtIdEmpleado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider MensajeErrorEmpleado;
        private MaterialSkin.Controls.MaterialLabel TxtIngreso;
    }
}