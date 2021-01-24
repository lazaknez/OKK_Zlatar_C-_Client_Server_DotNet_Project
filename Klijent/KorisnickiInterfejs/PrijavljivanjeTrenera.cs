using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.KorisnickiInterfejs
{
    public partial class PrijavljivanjeTrenera : Form
    {
        
        public PrijavljivanjeTrenera()
        {
            InitializeComponent();
        }

        private void FormaKlijent_Load(object sender, EventArgs e)
        {


        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (KontolerKorisnickogInterfejsa.PoveziSeNaServer())
            {
                this.Text = "Povezan!";

                if (KontolerKorisnickogInterfejsa.Login(txtUsername,txtPassword))
                {
                    this.Hide();
                    new PocetnaForma().Show();
                    this.Show();
                }

            }
            else {

                MessageBox.Show("Neuspesno logovanje na sistem!");

            }
        }
    }
}
