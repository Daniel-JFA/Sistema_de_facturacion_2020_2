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
                    string sentencia = $"EXEC [actualizar_cliente] '{TxtIdCliente.Text}','{TxtNombreCliente.Text}','{TxtDocumento.Text}','{TxtDireccion.Text}','{TxtTelefono.Text}','{TxtEmail.Text}','Daniel','{DateTime.Now.ToShortDateString()}'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    LlenarGrid();
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
    }
}
