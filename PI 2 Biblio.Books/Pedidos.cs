using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_2_Biblio.Books
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void btnCadastrarPedidos_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OperationStatus = true;

            string connectionString = Properties.Settings.Default.TestDBConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("INSERT INTO Pedidos (id_livro, nome_cliente, titulo_livro, cpf_cliente) VALUES (@Id_Livro, @Nome_Cliente, @Titulo_Livro, @Cpf_Cliente)", conn);

            comm.Parameters.Add("@Id_Livro", SqlDbType.Int);
            comm.Parameters["@Id_Livro"].Value = Convert.ToInt32(txIDPedido.Text);

            comm.Parameters.Add("@Nome_Cliente", SqlDbType.NVarChar);
            comm.Parameters["@Nome_Cliente"].Value = txNomeCPedidos.Text;

            comm.Parameters.Add("@Cpf_Cliente", SqlDbType.NVarChar);
            comm.Parameters["@Cpf_Cliente"].Value = txCPF.Text;

            comm.Parameters.Add("@Titulo_Livro", SqlDbType.NVarChar);
            comm.Parameters["@Titulo_Livro"].Value = txNomeLivro.Text;

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
                        "Erro ao tentar abrir o banco de dados",
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

                if (OperationStatus) { 
                    MessageBox.Show("Pedido criado com sucesso",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            UpdateTable();
            ClearForm();

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDBDataSet.Pedidos' table. You can move, or remove it, as needed.
            this.pedidosTableAdapter.Fill(this.testDBDataSet.Pedidos);

        }

        private void UpdateTable()
        {
            this.pedidosTableAdapter.Fill(this.testDBDataSet.Pedidos);
        }

        private void ClearForm()
        {
            txCPF.Clear();
            txIDPedido.Clear();
            txNomeCPedidos.Clear();
            txNomeLivro.Clear();
        }
    }
}
