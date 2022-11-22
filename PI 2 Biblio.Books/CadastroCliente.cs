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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCancelarCad_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Você realmente quer fechar o cadastro?",
               "",
               MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OperationStatus = true;

            string connectionString = Properties.Settings.Default.TestDBConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "INSERT INTO Clientes (nome, cpf, phone, address, city) VALUES (@Name, @CPF, @Phone, @Address, @City)", conn);

            comm.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Name"].Value = txNome.Text;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = txCPF.Text;

            comm.Parameters.Add("@Phone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Phone"].Value = txTelefone.Text;

            comm.Parameters.Add("@Address", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Address"].Value = txEndereco.Text;

            comm.Parameters.Add("@City", System.Data.SqlDbType.NVarChar);
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
                    txNome.Clear();
                    txCPF.Clear();
                    txEndereco.Clear();
                    txTelefone.Clear();
                    cbCidades.Text = "";
                    txNome.Focus();
                }
            }
        }
    }
}
