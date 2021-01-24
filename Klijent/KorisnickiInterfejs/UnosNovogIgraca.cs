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
    public partial class UnosNovogIgraca : Form
    {
        public UnosNovogIgraca()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (KontolerKorisnickogInterfejsa.KreirajNovogIgraca(txtSifra, gbIgrac, btnKreiraj))
            {
                KontolerKorisnickogInterfejsa.PopuniComboZaKategorijuIgraca(cmbKategorijaIgraca);

            }

        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            if (KontolerKorisnickogInterfejsa.ZapamtiNovogIgraca(txtIme,txtPrezime,txtGodina,txtVisina,txtTezina,txtKontakt,txtNapomena,cmbKategorijaIgraca,rbMuski,rbZenski))
            {
                this.Close();
            }
        }

        private void UnosNovogIgraca_Load(object sender, EventArgs e)
        {

        }
    }
}
