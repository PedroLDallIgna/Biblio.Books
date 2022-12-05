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
using System.Net.NetworkInformation;

namespace PI_2_Biblio.Books
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCliente = new CadastroCliente();
            cadCliente.Show();

            UpdateTable();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioBooksDataSet.ClientsTable' table. You can move, or remove it, as needed.
            this.clientsTableTableAdapter.Fill(this.biblioBooksDataSet.ClientsTable);
        }

        private void UpdateTable()
        {
            this.clientsTableTableAdapter.Fill(this.biblioBooksDataSet.ClientsTable);
        }

        private void ClearForm()
        {
            txID.Clear();
            txNome.Clear();
            txCPF.Clear();
            txEndereco.Clear();
            mtxTelefone.Clear();
            cbCidades.Text = "";
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.BiblioBooksConnectionString;
            
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT Client_Name, Client_Cpf, Client_Phone, Client_Address, Client_City FROM ClientsTabel WHERE Client_ID = @Id", 
                conn);

            comm.Parameters.Add("@ID", SqlDbType.Int);
            comm.Parameters["@Id"].Value = Convert.ToInt32(txID.Text);

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message,
                        "Erro ao tentar abrir o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        txNome.Text = reader["Client_Name"].ToString();
                        txCPF.Text = reader["Client_Cpf"].ToString();
                        txEndereco.Text = reader["Client_Address"].ToString();
                        mtxTelefone.Text = reader["Client_Phone"].ToString();
                        cbCidades.Text = reader["Client_City"].ToString();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message,
                        "Erro ao tentar executar o comando SQL.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }

        }

        private void btnExcluirClientes_Click(object sender, EventArgs e)
        {
            bool OperationStatus = true;
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.BiblioBooksConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "DELETE FROM ClientsTable WHERE Client_ID = @Id", conn );

            comm.Parameters.Add("@Id", SqlDbType.Int);
            comm.Parameters["@Id"].Value = Convert.ToInt32(txID.Text);


            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception er)
                {
                    OperationStatus = false;
                    MessageBox.Show(er.Message,
                        "Erro ao tentar abrir o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception er)
                {
                    OperationStatus = false;
                    MessageBox.Show(er.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();

                if (OperationStatus)
                {
                    MessageBox.Show("Registro Excluído!",
                        "DELETE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            UpdateTable();
            ClearForm();
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OperationStatus = true;

            string connectionString = Properties.Settings.Default.BiblioBooksConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "UPDATE ClientsTable SET Client_Name = @Nome, Client_Cpf = @Cpf, Client_Phone = @Phone, Client_Address = @Address, Client_City = @City WHERE Client_ID = @id",
                conn);

            comm.Parameters.Add("@id", SqlDbType.Int);
            comm.Parameters["@id"].Value = Convert.ToInt32(txID.Text);

            comm.Parameters.Add("@Nome", SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@Cpf", SqlDbType.NVarChar);
            comm.Parameters["@Cpf"].Value = txCPF.Text;

            comm.Parameters.Add("@Phone", SqlDbType.NVarChar);
            comm.Parameters["@Phone"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@Address", SqlDbType.NVarChar);
            comm.Parameters["@Address"].Value = txEndereco.Text;

            comm.Parameters.Add("@City", SqlDbType.NVarChar);
            comm.Parameters["@City"].Value = cbCidades.Text;

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception er)
                {
                    OperationStatus = false;
                    MessageBox.Show(er.Message,
                        "Erro ao tentar abrir o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception er)
                {
                    OperationStatus = false;
                    MessageBox.Show(er.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();

                if (OperationStatus)
                {
                    MessageBox.Show("Registro Alterado!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            UpdateTable();
            ClearForm();
        }
    }
}
