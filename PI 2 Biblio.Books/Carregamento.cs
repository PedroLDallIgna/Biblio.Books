using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_2_Biblio.Books
{
    public partial class Carregamento : Form
    {
        public Carregamento()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 679)
            {
                timer.Stop();
                Inicial inicial = new Inicial();
                inicial.Show();
                this.Hide();
            }
        }
    }
}
