using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace Sistema_de_facturacion_2020_2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsuario_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {

        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            string res = "";

            if (TxtUsuario.Text != "" && TxtPassword.Text != "")
            {
                AccesoDatos Acceso = new AccesoDatos();
                res = Acceso.ValidarUsuario(TxtUsuario.Text, TxtPassword.Text);

                if (res != "")
                {
                    MessageBox.Show("Venvenuti aqui: "+TxtUsuario.Text + TxtPassword.Text);
                    FrmPrincipal mainMenu = new FrmPrincipal();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("no tiene autorizacion: " + res+TxtUsuario.Text+TxtPassword.Text);
                    TxtPassword.Text = "";
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                }
            }
        }
    }
}
