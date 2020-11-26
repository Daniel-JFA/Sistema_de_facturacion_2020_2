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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtBuscarCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnSalirClientes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtIdEmpleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgEmpleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgEmpleado
            // 
            this.DgEmpleado.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgEmpleado.Location = new System.Drawing.Point(75, 413);
            this.DgEmpleado.Name = "DgEmpleado";
            this.DgEmpleado.Size = new System.Drawing.Size(445, 116);
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
            this.BtnNuevo.Location = new System.Drawing.Point(680, 166);
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
            this.ACTUALIZAR.Location = new System.Drawing.Point(680, 221);
            this.ACTUALIZAR.MouseState = MaterialSkin.MouseState.HOVER;
            this.ACTUALIZAR.Name = "ACTUALIZAR";
            this.ACTUALIZAR.Primary = true;
            this.ACTUALIZAR.Size = new System.Drawing.Size(103, 36);
            this.ACTUALIZAR.TabIndex = 15;
            this.ACTUALIZAR.Text = "ACTUALIZAR";
            this.ACTUALIZAR.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(680, 274);
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
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(57, 140);
            this.TxtNombreEmpleado.MaxLength = 32767;
            this.TxtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.PasswordChar = '\0';
            this.TxtNombreEmpleado.SelectedText = "";
            this.TxtNombreEmpleado.SelectionLength = 0;
            this.TxtNombreEmpleado.SelectionStart = 0;
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(207, 23);
            this.TxtNombreEmpleado.TabIndex = 17;
            this.TxtNombreEmpleado.TabStop = false;
            this.TxtNombreEmpleado.UseSystemPasswordChar = false;
            this.TxtNombreEmpleado.Click += new System.EventHandler(this.TxtNombreCliente_Click);
            // 
            // TxtDocumentoEmpleado
            // 
            this.TxtDocumentoEmpleado.Depth = 0;
            this.TxtDocumentoEmpleado.Hint = "Documento";
            this.TxtDocumentoEmpleado.Location = new System.Drawing.Point(57, 179);
            this.TxtDocumentoEmpleado.MaxLength = 32767;
            this.TxtDocumentoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDocumentoEmpleado.Name = "TxtDocumentoEmpleado";
            this.TxtDocumentoEmpleado.PasswordChar = '\0';
            this.TxtDocumentoEmpleado.SelectedText = "";
            this.TxtDocumentoEmpleado.SelectionLength = 0;
            this.TxtDocumentoEmpleado.SelectionStart = 0;
            this.TxtDocumentoEmpleado.Size = new System.Drawing.Size(207, 23);
            this.TxtDocumentoEmpleado.TabIndex = 18;
            this.TxtDocumentoEmpleado.TabStop = false;
            this.TxtDocumentoEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtDireccionEmpleado
            // 
            this.TxtDireccionEmpleado.Depth = 0;
            this.TxtDireccionEmpleado.Hint = "Direccion";
            this.TxtDireccionEmpleado.Location = new System.Drawing.Point(57, 218);
            this.TxtDireccionEmpleado.MaxLength = 32767;
            this.TxtDireccionEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDireccionEmpleado.Name = "TxtDireccionEmpleado";
            this.TxtDireccionEmpleado.PasswordChar = '\0';
            this.TxtDireccionEmpleado.SelectedText = "";
            this.TxtDireccionEmpleado.SelectionLength = 0;
            this.TxtDireccionEmpleado.SelectionStart = 0;
            this.TxtDireccionEmpleado.Size = new System.Drawing.Size(207, 23);
            this.TxtDireccionEmpleado.TabIndex = 19;
            this.TxtDireccionEmpleado.TabStop = false;
            this.TxtDireccionEmpleado.UseSystemPasswordChar = false;
            this.TxtDireccionEmpleado.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // TxtTelefonoEmpleado
            // 
            this.TxtTelefonoEmpleado.Depth = 0;
            this.TxtTelefonoEmpleado.Hint = "Telefono";
            this.TxtTelefonoEmpleado.Location = new System.Drawing.Point(57, 254);
            this.TxtTelefonoEmpleado.MaxLength = 32767;
            this.TxtTelefonoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTelefonoEmpleado.Name = "TxtTelefonoEmpleado";
            this.TxtTelefonoEmpleado.PasswordChar = '\0';
            this.TxtTelefonoEmpleado.SelectedText = "";
            this.TxtTelefonoEmpleado.SelectionLength = 0;
            this.TxtTelefonoEmpleado.SelectionStart = 0;
            this.TxtTelefonoEmpleado.Size = new System.Drawing.Size(207, 23);
            this.TxtTelefonoEmpleado.TabIndex = 20;
            this.TxtTelefonoEmpleado.TabStop = false;
            this.TxtTelefonoEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtEmailEmpleado
            // 
            this.TxtEmailEmpleado.Depth = 0;
            this.TxtEmailEmpleado.Hint = "Email";
            this.TxtEmailEmpleado.Location = new System.Drawing.Point(57, 294);
            this.TxtEmailEmpleado.MaxLength = 32767;
            this.TxtEmailEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEmailEmpleado.Name = "TxtEmailEmpleado";
            this.TxtEmailEmpleado.PasswordChar = '\0';
            this.TxtEmailEmpleado.SelectedText = "";
            this.TxtEmailEmpleado.SelectionLength = 0;
            this.TxtEmailEmpleado.SelectionStart = 0;
            this.TxtEmailEmpleado.Size = new System.Drawing.Size(207, 23);
            this.TxtEmailEmpleado.TabIndex = 21;
            this.TxtEmailEmpleado.TabStop = false;
            this.TxtEmailEmpleado.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(57, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 193);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtIdEmpleado);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Location = new System.Drawing.Point(23, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 253);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS BASICOS";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(275, 29);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(228, 19);
            this.LblTitulo.TabIndex = 32;
            this.LblTitulo.Text = "ADMINISTRACION  EMPLEADOS";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(394, 270);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "materialLabel2";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(305, 140);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "materialLabel1";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(282, 90);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(108, 19);
            this.materialLabel3.TabIndex = 28;
            this.materialLabel3.Text = "materialLabel3";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(305, 218);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(108, 19);
            this.materialLabel4.TabIndex = 29;
            this.materialLabel4.Text = "materialLabel4";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(432, 218);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(432, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(432, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Icon = null;
            this.BtnBuscar.Location = new System.Drawing.Point(484, 64);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(74, 36);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscarCliente
            // 
            this.TxtBuscarCliente.Depth = 0;
            this.TxtBuscarCliente.Hint = "Buscar Cliente";
            this.TxtBuscarCliente.Location = new System.Drawing.Point(63, 378);
            this.TxtBuscarCliente.MaxLength = 32767;
            this.TxtBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarCliente.Name = "TxtBuscarCliente";
            this.TxtBuscarCliente.PasswordChar = '\0';
            this.TxtBuscarCliente.SelectedText = "";
            this.TxtBuscarCliente.SelectionLength = 0;
            this.TxtBuscarCliente.SelectionStart = 0;
            this.TxtBuscarCliente.Size = new System.Drawing.Size(311, 23);
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
            this.BtnSalirClientes.Location = new System.Drawing.Point(680, 458);
            this.BtnSalirClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalirClientes.Name = "BtnSalirClientes";
            this.BtnSalirClientes.Primary = true;
            this.BtnSalirClientes.Size = new System.Drawing.Size(58, 36);
            this.BtnSalirClientes.TabIndex = 33;
            this.BtnSalirClientes.Text = "SALIR";
            this.BtnSalirClientes.UseVisualStyleBackColor = true;
            this.BtnSalirClientes.Click += new System.EventHandler(this.BtnSalirClientes_Click);
            // 
            // TxtIdEmpleado
            // 
            this.TxtIdEmpleado.Location = new System.Drawing.Point(6, 19);
            this.TxtIdEmpleado.Name = "TxtIdEmpleado";
            this.TxtIdEmpleado.Size = new System.Drawing.Size(20, 20);
            this.TxtIdEmpleado.TabIndex = 29;
            this.TxtIdEmpleado.Text = "null\r\n";
            this.TxtIdEmpleado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.BtnSalirClientes);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgEmpleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalirClientes;
        private System.Windows.Forms.TextBox TxtIdEmpleado;
    }
}