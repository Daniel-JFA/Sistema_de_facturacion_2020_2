using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_facturacion_2020_2
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if(TxtNombreCliente.Text == string.Empty)
            {
                MensajeError.SetError(TxtNombreCliente, "Debe ingresar el nombre del empleado");
                TxtNombreCliente.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(TxtNombreCliente, ""); }

            return errorCampos;
        }

        public Boolean Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {

                    AccesoDatos Acceso = new AccesoDatos();
                    string sentencia = "";
                    if (TxtIdCliente.Text == "null")
                    {
                       sentencia = $"INSERT INTO TblClientes (strNombre,NumDocumento,StrDireccion,StrTelefono,StrEmail,DtmFechaModifica,StrUsuarioModifico) VALUES ('{TxtNombreCliente.Text}','{TxtDocumento.Text}','{TxtDireccion.Text}','{TxtTelefono.Text}','{TxtEmail.Text}','{DateTime.Now.ToShortDateString()}','daniel')";
                    }
                    else 
                    { 
                     sentencia  = $"EXEC [actualizar_Cliente] '{TxtNombreCliente.Text}','{TxtDocumento.Text}','{TxtDireccion.Text}','{TxtTelefono.Text}','{TxtEmail.Text}','{DateTime.Now.ToShortDateString()}','prueba'";
                    }
                    LlenarGrid();
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo insercion: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }

        private void LlenarGrid()
        {

            DataTable dt = new DataTable();
            AccesoDatos Acceso = new AccesoDatos();
            dt = Acceso.CargaTabla("[TblClientes]", "");
            DgCliente.DataSource = dt;
        }

        public void Nuevo()
        {
            TxtIdCliente.Text = "null";
            TxtNombreCliente.Text = "";
            TxtDocumento.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";
            TxtEmail.Text = "";

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ACTUALIZAR_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void DgCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int PosActual = 0;
            TxtIdCliente.Text = DgCliente[0, PosActual].Value.ToString();
            TxtNombreCliente.Text = DgCliente[1, PosActual].Value.ToString();
            TxtDocumento.Text = DgCliente[2, PosActual].Value.ToString();
            TxtDireccion.Text = DgCliente[3, PosActual].Value.ToString();
            TxtTelefono.Text = DgCliente[4, PosActual].Value.ToString();
            TxtEmail.Text = DgCliente[5, PosActual].Value.ToString();

        }
    }
}
