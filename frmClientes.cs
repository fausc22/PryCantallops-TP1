using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PryCantallops_TP1
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        
        OleDbConnection cnn;
        OleDbCommand cmd;
        OleDbDataReader rdr;

        private void btnClientes_Click(object sender, EventArgs e)
        {
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb;";
            try
            {
                cnn = new OleDbConnection(conexion);
                cnn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = "Clientes";
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dgvClientes.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10]);
                    //for (int i = 0; i < cmbPais.Items.Count; i++)
                    //{
                    //    cmbPais.Items.Add(rdr[8]);
                    //}

                    cmbPais.Items.Add(rdr[5]);
                    comboBox1.Items.Add(rdr[8]);

                }

                MessageBox.Show("Datos obtenidos!", "", MessageBoxButtons.OK);
                dgvClientes.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb;";
            try
            {
                cnn = new OleDbConnection(conexion);
                cnn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = "Clientes";
                rdr = cmd.ExecuteReader();
               
                while (rdr.Read())
                {
                    
                    

                }

                MessageBox.Show("Datos obtenidos!", "", MessageBoxButtons.OK);
                dgvClientes.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb;";
            try
            {
                cnn = new OleDbConnection(conexion);
                cnn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = "Clientes";
                rdr = cmd.ExecuteReader();

                cmbPais.Items.Clear();
                while (rdr.Read())
                {
                    if (rdr[8].ToString() == comboBox1.Text)
                    {
                        cmbPais.Items.Add(rdr[5]);
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }
        }
    }
}
