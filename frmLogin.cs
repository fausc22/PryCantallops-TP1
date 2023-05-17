using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCantallops_TP1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtUsuario.Text != null)
            {
                txtPassword.Enabled = true;
            }
        }

        private void btnInciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtPassword.Text == "123" || txtUsuario.Text == "guest" && txtPassword.Text == "321")
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("El usuario y/o la contraseña son incorrectos. Intente nuevamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = "";
                txtPassword.Text = "";
                btnInciar.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtPassword.Text != null)
            {
                btnInciar.Enabled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && txtPassword.Text.Contains(","))
            {
                e.Handled = true;
            }
        }
    }
}
