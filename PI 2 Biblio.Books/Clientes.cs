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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCliente = new CadastroCliente();
            cadCliente.Show();

            UpdateTable();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDBDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.testDBDataSet.Clientes);
        }

        private void UpdateTable()
        {
            this.clientesTableAdapter.Fill(this.testDBDataSet.Clientes);
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

            string connectionString = Properties.Settings.Default.TestDBConnectionString;
            
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT nome, cpf, phone, address, city FROM Clientes WHERE id = @Id", conn);

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
                        txNome.Text = reader["nome"].ToString();
                        txCPF.Text = reader["cpf"].ToString();
                        txEndereco.Text = reader["address"].ToString();
                        mtxTelefone.Text = reader["phone"].ToString();
                        cbCidades.Text = reader["city"].ToString();
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

            string connectionString = Properties.Settings.Default.TestDBConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "DELETE FROM Clientes WHERE id = @Id", conn );
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OperationStatus = true;

            string connectionString = Properties.Settings.Default.TestDBConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "UPDATE Clientes SET nome=@Nome, cpf=@Cpf, phone=@Phone, address=@Address, city=@City WHERE id=@ID", conn);

            comm.Parameters.Add("@Id", SqlDbType.Int);
            comm.Parameters["@Id"].Value = Convert.ToInt32(txID.Text);

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
