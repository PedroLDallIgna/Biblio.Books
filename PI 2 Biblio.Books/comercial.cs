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
    public partial class comercial : Form
    {

        Thread nt;
        public comercial()
        {
            InitializeComponent();
        }

        private void btnSairComercial_MouseHover(object sender, EventArgs e)
        {
            btnSairComercial.BackColor = Color.Red;
        }

        private void btnSairComercial_MouseLeave(object sender, EventArgs e)
        {
            btnSairComercial.BackColor = Color.Brown;
        }

        private void btnSairComercial_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Você realmente quer fechar o programa?",
               "",
               MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

            this.Close();

            nt = new Thread(frmFashboard);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void frmFashboard()
        {
            Application.Run(new dashboard());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;

            pnCentral.Controls.Clear();
            pnCentral.Controls.Add(clientes);
            clientes.BringToFront();
            clientes.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.TopLevel = false;
            pedidos.Dock = DockStyle.Fill;

            pnCentral.Controls.Clear();
            pnCentral.Controls.Add(pedidos);
            pedidos.BringToFront();
            pedidos.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.TopLevel = false;
            estoque.Dock = DockStyle.Fill;

            pnCentral.Controls.Clear();
            pnCentral.Controls.Add(estoque);
            estoque.BringToFront();
            estoque.Show();
        }
    }
}
