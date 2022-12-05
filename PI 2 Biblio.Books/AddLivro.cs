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
    public partial class AddLivro : Form
    {
        public AddLivro()
        {
            InitializeComponent();
        }

        private void btnCancelarCadLivro_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Você realmente quer fechar o cadastro?",
               "",
               MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OperationStatus = true;

            string connectionString = Properties.Settings.Default.BiblioBooksConnectionString + ";Password=Senha123456!";

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "INSERT INTO BooksTable (Book_Name, Book_Author, Book_Publisher) VALUES (@Name, @Author, @Publisher)", conn);

            comm.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Name"].Value = txTituloEstoque.Text;

            comm.Parameters.Add("@Author", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Author"].Value = txAutorEstoque.Text;

            comm.Parameters.Add("@Publisher", System.Data.SqlDbType.NVarChar);
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
                        "Erro ao tentar executar o comando SQL.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();
                if (OperationStatus == true)
                {
                    MessageBox.Show("Cliente Cadastrado com sucesso!",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txAutorEstoque.Text = "";
                    txTituloEstoque.Text = "";
                    txEditoraEstoque.Text = "";
                }
            }
        }
    }
}
