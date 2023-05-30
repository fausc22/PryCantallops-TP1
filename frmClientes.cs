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

                HashSet<string> Paises = new HashSet<string>();
                HashSet<string> Ciudades = new HashSet<string>();

                while (rdr.Read())
                {
                    dgvClientes.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10]);

                    string Pais = rdr[8].ToString();
                    string ciudad = rdr[5].ToString();
                    Paises.Add(Pais);
                    Ciudades.Add(ciudad);

                    

                }

                cmbCiudad.Items.AddRange(Ciudades.ToArray());
                cmbPais.Items.AddRange(Paises.ToArray());

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
               
                string PaisFiltrado = cmbPais.SelectedItem.ToString();
                while (rdr.Read())
                {
                    if (PaisFiltrado == rdr[8].ToString())
                    {
                        DataTable datosFiltrados = new DataTable();

                        datosFiltrados.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10]);
                        
                        
                    }
                    






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

                cmbCiudad.Items.Clear();
                HashSet<string> NoRepetidos = new HashSet<string>();    
                while (rdr.Read())
                {
                    if (rdr[8].ToString() == cmbPais.Text)
                    {
                        string ciudad = rdr[5].ToString();
                        NoRepetidos.Add(ciudad);
                    }
                }
                cmbCiudad.Items.AddRange(NoRepetidos.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
