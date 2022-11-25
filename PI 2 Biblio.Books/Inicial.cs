using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace PI_2_Biblio.Books
{
    public partial class Inicial : Form
    {
        
        Thread nt;

        public Inicial()
        {
            
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            var result = Hasher.SHA1(txSenhaLogin.Text);

            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.BiblioBooksConnectionString + ";Password=Senha123456!";

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT UsersTable.User_Password FROM UsersTable WHERE User_Name = @Username", conn
                );

            comm.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Username"].Value = txUsuarioLogin.Text;

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message,
                        "Erro ao tentar abrir o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        if (result == reader["User_Password"].ToString())
                        {
                            this.Close();

                            nt = new Thread(frmFashboard);
                            nt.SetApartmentState(ApartmentState.STA);
                            nt.Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos",
                            "Login",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message,
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
        private void frmFashboard()
        {
            Application.Run(new dashboard());
        }

        private void btnSairLogin_Click(object sender, EventArgs e)
        {
           DialogResult retorno = MessageBox.Show("Você realmente quer fechar o programa?",
               "",
               MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
            Carregamento carregamento = new Carregamento();
            carregamento.Close();
        }
    }
}
