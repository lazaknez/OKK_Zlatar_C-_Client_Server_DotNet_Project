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
    public partial class FrmEvidentiranjeStatistikeIgraca : Form
    {
        public FrmEvidentiranjeStatistikeIgraca()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (KontolerKorisnickogInterfejsa.KreirajTrening(txtID, btnKreiraj, dataGridView1))
            {
                KontolerKorisnickogInterfejsa.PopuniComboIgrac(cmbIgrac);
                KontolerKorisnickogInterfejsa.PopuniComboTipStat(cmbNazivStatistike);
                KontolerKorisnickogInterfejsa.PopuniComboVrstaTreninga(cmbVrstaTrening);
            }
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
          if(  KontolerKorisnickogInterfejsa.ZapamtiTrening(dtpDatum, cmbVrstaTrening,txtTrajanjeTreninga,txtNapomena) )this.Close();
        }

        private void FrmEvidentiranjeStatistikeIgraca_Load(object sender, EventArgs e)
        {

        }
    }
}
