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

            string connectionString = Properties.Settings.Default.BiblioBooksConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "INSERT INTO OrdersTable (Order_BookID, Order_ClientName, Order_BookName, Order_ClientCpf) VALUES (@BookID, @ClientName, @BookName, @ClientCpf)", 
                conn);

            comm.Parameters.Add("@BookID", SqlDbType.Int);
            comm.Parameters["@BookID"].Value = Convert.ToInt32(txIDPedido.Text);

            comm.Parameters.Add("@ClientName", SqlDbType.NVarChar);
            comm.Parameters["@ClientName"].Value = txNomeCPedidos.Text;

            comm.Parameters.Add("@ClientCpf", SqlDbType.NVarChar);
            comm.Parameters["@ClientCpf"].Value = txCPF.Text;

            comm.Parameters.Add("@BookName", SqlDbType.NVarChar);
            comm.Parameters["@BookName"].Value = txNomeLivro.Text;

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
            dgvPedidos.Columns.Add("Order_ID", "Order_ID");
            dgvPedidos.Columns.Add("Order_ClientName", "Order_ClientName");
            dgvPedidos.Columns.Add("Order_BookID", "Order_BookID");
            dgvPedidos.Columns.Add("Order_BookName", "Order_BookName");
            dgvPedidos.Columns.Add("Order_ClientCpf", "Order_ClientCpf");

            listAllOrders();
        }

        private void UpdateTable()
        {
            this.ordersTableTableAdapter.Fill(this.biblioBooksDataSet.OrdersTable);
        }

        private void ClearForm()
        {
            txCPF.Clear();
            txIDPedido.Clear();
            txNomeCPedidos.Clear();
            txNomeLivro.Clear();
        }

        private void btnConsultarPedidos_Click(object sender, EventArgs e)
        {
            string filter = "Order_BookID";
            string value = "";
            if (rdBook.Checked)
            {
                filter = "Order_BookID";
                value = txIDPedido.Text;
            } 
            else if (rdCpf.Checked)
            {
                filter = "Order_ClientCpf";
                value = txCPF.Text;
            }

            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.BiblioBooksConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT * FROM OrdersTable WHERE " + filter + " = @Value",
                conn);

            comm.Parameters.Add("@Value", SqlDbType.NVarChar);
            comm.Parameters["@Value"].Value = value;

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message,
                        "Erro ao tentar abrir o banco de dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    reader = comm.ExecuteReader();
                    int row = 0;

                    dgvPedidos.Rows.Clear();

                    while (reader.Read())
                    {
                        dgvPedidos.Rows.Add();

                        dgvPedidos.Rows[row].Cells[0].Value = Convert.ToInt32(reader["Order_ID"]);
                        dgvPedidos.Rows[row].Cells[1].Value = reader["Order_ClientName"].ToString();
                        dgvPedidos.Rows[row].Cells[2].Value = reader["Order_BookID"].ToString();
                        dgvPedidos.Rows[row].Cells[3].Value = reader["Order_BookName"].ToString();
                        dgvPedidos.Rows[row].Cells[4].Value = reader["Order_ClientCpf"].ToString();

                        row++;
                    }
                }
                catch (Exception er)
                {
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
            }
        }

        private void listAllOrders()
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.BiblioBooksConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT * FROM OrdersTable",
                conn);

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message,
                        "Erro ao tentar abrir o banco de dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    reader = comm.ExecuteReader();
                    int row = 0;

                    dgvPedidos.Rows.Clear();

                    while (reader.Read())
                    {
                        dgvPedidos.Rows.Add();

                        dgvPedidos.Rows[row].Cells[0].Value = Convert.ToInt32(reader["Order_ID"]);
                        dgvPedidos.Rows[row].Cells[1].Value = reader["Order_ClientName"].ToString();
                        dgvPedidos.Rows[row].Cells[2].Value = reader["Order_BookID"].ToString();
                        dgvPedidos.Rows[row].Cells[3].Value = reader["Order_BookName"].ToString();
                        dgvPedidos.Rows[row].Cells[4].Value = reader["Order_ClientCpf"].ToString();
                        row++;
                    }
                }
                catch (Exception er)
                {
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPedidos.Rows.Clear();

            listAllOrders();
        }
    }
}
