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
    public partial class PretragaIgraca : Form
    {
        public PretragaIgraca()
        {
            InitializeComponent();
        }

        private void PretragaIgraca_Load(object sender, EventArgs e)
        {
            KontolerKorisnickogInterfejsa.PretraziIgraca(txtNazivIgraca,dataGridView1);
        }

        private void txtNazivIgraca_KeyDown(object sender, KeyEventArgs e)
        {
            //kad lupim enter da mi ucita odmah,mozes svuda da stavis
            if (e.KeyCode==Keys.Enter)
            {
                KontolerKorisnickogInterfejsa.PretraziIgraca(txtNazivIgraca, dataGridView1);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontolerKorisnickogInterfejsa.UcitajIgraca(dataGridView1))
            {
                this.Hide();
                new DetaljiOIgracu().ShowDialog();
                this.Show();

                //kao da osvezimo
                KontolerKorisnickogInterfejsa.PretraziIgraca(txtNazivIgraca, dataGridView1);
            }
        }
    }
}
