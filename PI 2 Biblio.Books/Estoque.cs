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

            string connectionString = Properties.Settings.Default.BiblioBooksConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT Book_Name, Book_Author, Book_Publisher FROM BooksTable WHERE Book_ID = @Id", conn);

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
                        txAutorEstoque.Text = reader["Book_Author"].ToString();
                        txTituloEstoque.Text = reader["Book_Name"].ToString();
                        txEditoraEstoque.Text = reader["Book_Publisher"].ToString();
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

            string connectionString = Properties.Settings.Default.BiblioBooksConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "DELETE FROM BooksTable WHERE Book_ID = @Id", conn);

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
            SqlConnection conn;
            SqlCommand comm;
            string connectionString;
            bool OperationStatus = true;

            connectionString = Properties.Settings.Default.BiblioBooksConnectionString;

            conn = new SqlConnection(connectionString);
            
            comm = new SqlCommand(
                "UPDATE BooksTable SET Book_Name = @Title, Book_Author = @Autor, Book_Publisher = @Publisher WHERE Book_ID = @Id",
                conn);

            comm.Parameters.Add("@Id", SqlDbType.Int);
            comm.Parameters["@Id"].Value = Convert.ToInt32(txIDEstoque.Text);

            comm.Parameters.Add("@Title", SqlDbType.NVarChar);
            comm.Parameters["@Title"].Value = txTituloEstoque.Text;

            comm.Parameters.Add("@Autor", SqlDbType.NVarChar);
            comm.Parameters["@Autor"].Value = txAutorEstoque.Text;

            comm.Parameters.Add("@Publisher", SqlDbType.NVarChar);
            comm.Parameters["@Publisher"].Value = txEditoraEstoque.Text;

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
            // TODO: This line of code loads data into the 'biblioBooksDataSet.BooksTable' table. You can move, or remove it, as needed.
            this.booksTableTableAdapter.Fill(this.biblioBooksDataSet.BooksTable);

        }

        private void UpdateTable()
        {
            this.booksTableTableAdapter.Fill(this.biblioBooksDataSet.BooksTable);
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
