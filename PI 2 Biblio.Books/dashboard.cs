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

namespace PI_2_Biblio.Books
{
    public partial class dashboard : Form
    {

        Thread nt;

        public dashboard()
        {
            InitializeComponent();
        }

        private void exitDashboard_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Você realmente quer fechar o programa?",
               "",
               MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnComercial_Click(object sender, EventArgs e)
        {
            this.Close();

            nt = new Thread(frmComercial);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void frmComercial()
        {
            Application.Run(new comercial());
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            AddLivro addlivro = new AddLivro();
            addlivro.Show();
        }
    }
}
