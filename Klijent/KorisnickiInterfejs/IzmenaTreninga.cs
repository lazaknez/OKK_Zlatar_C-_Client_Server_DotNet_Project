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
    public partial class IzmenaTreninga : Form
    {
        public IzmenaTreninga()
        {
            InitializeComponent();
        }

        private void IzmenaTreninga_Load(object sender, EventArgs e)
        {
            KontolerKorisnickogInterfejsa.PopuniComboIgrac(cmbIgrac);
            KontolerKorisnickogInterfejsa.PopuniComboTipStat(cmbNazivStatistike);
            KontolerKorisnickogInterfejsa.PopuniComboVrstaTreninga(cmbVrstaTrening);
            KontolerKorisnickogInterfejsa.PopuniPoljaTrening(txtID, txtNapomena, txtTrajanjeTreninga, txtVrednost, dtpDatum, cmbVrstaTrening, dataGridView1);
        }

        private void btnDodajIgraca_Click(object sender, EventArgs e)
        {
            KontolerKorisnickogInterfejsa.DodajStaistiku(cmbIgrac, cmbNazivStatistike, txtVrednost);
        }

        private void btnObrisiIgraca_Click(object sender, EventArgs e)
        {
            KontolerKorisnickogInterfejsa.ObrisiStatistiku(dataGridView1);
        }

        private void btnSacuvajTrening_Click(object sender, EventArgs e)
        {
            if (KontolerKorisnickogInterfejsa.ZapamtiTrening(dtpDatum, cmbVrstaTrening, txtTrajanjeTreninga, txtNapomena)) this.Close();
        }
    }
}
