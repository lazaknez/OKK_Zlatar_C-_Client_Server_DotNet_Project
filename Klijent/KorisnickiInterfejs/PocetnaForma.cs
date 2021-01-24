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
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            this.Text = KontolerKorisnickogInterfejsa.PrikaziUlogovanogTrenera();
        }

        private void PocetnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontolerKorisnickogInterfejsa.Kraj();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosNovogIgraca().ShowDialog();
            this.Show();
        }

        private void pretraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaIgraca().ShowDialog();
            this.Show();
        }

        private void igracToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmEvidentiranjeStatistikeIgraca().ShowDialog();
            this.Show();
        }

        private void pretraziToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaTreninga().ShowDialog();
            this.Show();
        }
    }
}
