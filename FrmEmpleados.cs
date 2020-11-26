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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void LlenarGrid()
        {

            DataTable dt = new DataTable();
            AccesoDatos Acceso = new AccesoDatos();
            dt = Acceso.CargaTabla("[TblEmpleado]", "");
            DgEmpleado.DataSource = dt;
        }

        public void Nuevo()
        {
            TxtIdEmpleado.Text = "null";
            TxtNombreEmpleado.Text = "";
            TxtDocumentoEmpleado.Text = "";
            TxtDireccionEmpleado.Text = "";
            TxtTelefonoEmpleado.Text = "";
            TxtEmailEmpleado.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombreCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgEmpleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int PosActual = 0;
            TxtIdEmpleado.Text = DgEmpleado[0, PosActual].Value.ToString();
            TxtNombreEmpleado.Text = DgEmpleado[1, PosActual].Value.ToString();
            TxtDocumentoEmpleado.Text = DgEmpleado[2, PosActual].Value.ToString();
            TxtDireccionEmpleado.Text = DgEmpleado[3, PosActual].Value.ToString();
            TxtTelefonoEmpleado.Text = DgEmpleado[4, PosActual].Value.ToString();
            TxtEmailEmpleado.Text = DgEmpleado[5, PosActual].Value.ToString();

        }

        private void TxtIdEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
