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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            AddLivro addlivro = new AddLivro();
            addlivro.Show();
        }

        private void btnConsultarEstoque_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.TestDBConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT title, autor, editora FROM Livros WHERE id = @Id", conn);

            comm.Parameters.Add("@Id", SqlDbType.Int);
            comm.Parameters["@Id"].Value = Convert.ToInt32(txIDEstoque.Text);

            try
            {
                try
                {
                    conn.Open();
                } 
                catch (Exception er)
                {
                    MessageBox.Show(er.Message,
                        "Erro ao abrir o banco de dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        txAutorEstoque.Text = reader["autor"].ToString();
                        txTituloEstoque.Text = reader["title"].ToString();
                        txEditoraEstoque.Text = reader["editora"].ToString();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message,
                        "Erro ao executar comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }

            UpdateTable();
        }

        private void btnExcluirEstoque_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OperationStatus = true;

            string connectionString = Properties.Settings.Default.TestDBConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "DELETE FROM Livros WHERE id = @Id", conn);

            comm.Parameters.Add("@Id", SqlDbType.Int);
            comm.Parameters["@Id"].Value = Convert.ToInt32(txIDEstoque.Text);

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

                if (OperationStatus)
                {
                    MessageBox.Show("Registro excluído com sucesso", "DELETE",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            UpdateTable();
            ClearForm();
        }

        private void btnAlterarEstoque_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.TestDBConnectionString);
            SqlCommand comm = new SqlCommand("UPDATE Livros SET title = @Title, autor = @Autor, editora = @Editora WHERE id = @Id", conn);
            bool OperationStatus = true;

            comm.Parameters.Add("@Id", SqlDbType.Int);
            comm.Parameters["@Id"].Value = Convert.ToInt32(txIDEstoque.Text);

            comm.Parameters.Add("@Title", SqlDbType.NVarChar);
            comm.Parameters["@Title"].Value = txTituloEstoque.Text;

            comm.Parameters.Add("@Autor", SqlDbType.NVarChar);
            comm.Parameters["@Autor"].Value = txAutorEstoque.Text;

            comm.Parameters.Add("@Editora", SqlDbType.NVarChar);
            comm.Parameters["@Editora"].Value = txEditoraEstoque.Text;

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception er)
                {
                    OperationStatus = false;
                    MessageBox.Show(er.Message, "Erro ao tentar abrir o banco de dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception er)
                {
                    OperationStatus = false;
                    MessageBox.Show(er.Message, "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();

                if (OperationStatus)
                {
                    MessageBox.Show(
                        "Registro alterado com sucesso", "UPDATE",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            UpdateTable();
            ClearForm();

        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.testDBDataSet.Livros);

        }

        private void UpdateTable()
        {
            this.livrosTableAdapter.Fill(this.testDBDataSet.Livros);
        }

        private void ClearForm()
        {
            txIDEstoque.Clear();
            txAutorEstoque.Clear();
            txEditoraEstoque.Clear();
            txTituloEstoque.Clear();
        }
    }
}
