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
            if (TxtPassword.Text == "usuario" && TxtUsuario.Text == "usuario")
            {
                FrmPrincipal mainMenu = new FrmPrincipal();
                mainMenu.Show();
                this.Hide();
                
            }
        }
    }
}
