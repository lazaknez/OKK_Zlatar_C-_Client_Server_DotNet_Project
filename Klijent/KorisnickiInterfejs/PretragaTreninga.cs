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
    public partial class PretragaTreninga : Form
    {
        public PretragaTreninga()
        {
            InitializeComponent();
        }

        private void PretragaTreninga_Load(object sender, EventArgs e)
        {
            KontolerKorisnickogInterfejsa.PopuniComboVrstaTreninga(cmbVrsta);
            KontolerKorisnickogInterfejsa.PronadjiTreninge(cmbVrsta,dataGridView1);
        }

        private void cmbVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontolerKorisnickogInterfejsa.PronadjiTreninge(cmbVrsta,dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PretragaTreninga_Load(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontolerKorisnickogInterfejsa.PrikaziTrening(dataGridView1)) new IzmenaTreninga().ShowDialog();
            PretragaTreninga_Load(sender, e);
        }
    }
}
