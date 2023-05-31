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
    public partial class frmTablas : Form
    {
        public string cadenaConexion;
        public frmTablas()
        {
            InitializeComponent();
        }
        
        

        private void frmTablas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            ClassConexion objConexion = new ClassConexion();
            objConexion.ListarTablasBD(cmbTablas, dgvTablas, lblNombreDB);

            lblNombreDB.Visible = true;
            cmbTablas.Visible = true;
            label1.Visible = true;
            dgvTablas.Visible = true;

            
            
            


        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConexion objConexion = new ClassConexion();
            objConexion.MostrarTablasDB(cmbTablas, cadenaConexion, dgvTablas);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }
    }
}
