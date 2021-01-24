using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Klijent
{
    public class KontolerKorisnickogInterfejsa
    {
        public static Igrac igrac;
        public static VrstaTreninga vrstaTreninga;
        public static Komunikacija komunikacija;
        public static Trener trener;
        public static Trening trening;
        public static TipStatistike tipStatistike;

        internal static void PopuniPoljaTrening(TextBox txtID, TextBox txtNapomena, TextBox txtTrajanjeTreninga, TextBox txtVrednost, DateTimePicker dtpDatum, ComboBox cmbVrstaTrening, DataGridView dataGridView1)
        {
            txtID.Text = trening.TreningID.ToString();
            txtNapomena.Text = trening.Napomena;
            txtTrajanjeTreninga.Text = trening.TrajanjeTreninga.ToString();
            dtpDatum.Value = trening.Datum;
            dataGridView1.DataSource = trening.ListaStatistikaIgraca;
            cmbVrstaTrening.SelectedItem = trening.VrstaTreninga;
        }

        public static StatistikaIgraca statistikaIgraca;

        internal static bool KreirajTrening(TextBox txtID, Button btnKreiraj, DataGridView dataGridView1)
        {
            trening = komunikacija.KreirajNoviTrening() as Trening;
            if (trening == null)
            {
                MessageBox.Show("Trening ne moze biti kreiran!");
                return false;
            }

            txtID.Text = trening.TreningID.ToString();
            dataGridView1.DataSource = trening.ListaStatistikaIgraca;
            btnKreiraj.Enabled = false;
            MessageBox.Show("Sistem je kreirao trening!");
            return true;

        }

        internal static bool PrikaziTrening(DataGridView dataGridView1)
        {
            try
            {
                trening = dataGridView1.CurrentRow.DataBoundItem as Trening;
                trening = komunikacija.UcitajTrening(trening) as Trening;

                if (trening == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita trening!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao trening");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali trening!");
                return false;
            }
        }

        internal static void PronadjiTreninge(ComboBox cmbVrsta, DataGridView dataGridView1)
        {
            VrstaTreninga v = cmbVrsta.SelectedItem as VrstaTreninga;
            trening = new Trening();
            if (v != null)
            {
                trening.Uslov = " VrstaTreningaID=" + v.VrstaTreningaID + "";
            }
            else
            {
                trening.Uslov = "Datum is not null";
            }

            List<Trening> lista = (List<Trening>)komunikacija.PretraziTreninge(trening);

            dataGridView1.DataSource = lista;
            if (lista == null)
            {
                MessageBox.Show("Sistem ne može da nađe treninge po zadatim vrednostima!");
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Ne postoje treninzi za odabrani kriterijum!");
            }
            else MessageBox.Show("Sistem je uspešno pronašao treninge!");
        }

        internal static void DodajStaistiku(ComboBox cmbIgrac, ComboBox cmbNazivStatistike, TextBox txtVrednost)
        {
            StatistikaIgraca si = new StatistikaIgraca();
            si.Rb = trening.ListaStatistikaIgraca.Count + 1;
            si.TreningID = trening.TreningID;

            si.Igrac = cmbIgrac.SelectedItem as Igrac;
            if (si.Igrac == null)
            {
                MessageBox.Show("Niste odabrali igraca!");
                return;
            }

            si.TipStatistike = cmbNazivStatistike.SelectedItem as TipStatistike;
            if (si.TipStatistike == null)
            {
                MessageBox.Show("Niste odabrali tip statistike!");
                return;
            }

            try
            {
                si.Vrednost = Convert.ToDouble(txtVrednost.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste ispravno uneli vrednost!");
                return;
            }

            if (trening.ListaStatistikaIgraca.Contains(si))
            {
                MessageBox.Show("Vec je unet tip statistike za odabranog igraca!");
                return;
            }


            trening.ListaStatistikaIgraca.Add(si);
        }

        internal static bool ZapamtiTrening(DateTimePicker dtpDatum, ComboBox cmbVrstaTrening, TextBox txtTrajanjeTreninga, TextBox txtNapomena)
        {
            
            trening.Datum = dtpDatum.Value;

            trening.VrstaTreninga = cmbVrstaTrening.SelectedItem as VrstaTreninga;
            if (trening.VrstaTreninga == null)
            {
                MessageBox.Show("Niste odabrali vrstu treninga!");
                return false;
            }

            trening.Napomena = txtNapomena.Text;
            if (string.IsNullOrEmpty(trening.Napomena))
            {
                MessageBox.Show("Napomena mora da sadrži nešto!");
                txtNapomena.Focus();
                return false;
            }

            try
            {
                trening.TrajanjeTreninga = Convert.ToInt32(txtTrajanjeTreninga.Text);
                if (trening.TrajanjeTreninga>180 || trening.TrajanjeTreninga<0)
                {
                    MessageBox.Show("Trening ne sme da bude duži od 3h(180 minuta)!");
                    txtTrajanjeTreninga.Focus();
                    return false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Trajanje nije ispravno uneto!");
                txtTrajanjeTreninga.Focus();
                return false;
            }


            object rez = komunikacija.ZapamtiTrening(trening);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti trening!");
                return false;
            }
            
            MessageBox.Show("Sistem je zapamtio trening!");
            return true;
        }

        internal static void ObrisiStatistiku(DataGridView dataGridView1)
        {
            try
            {
                StatistikaIgraca si = dataGridView1.CurrentRow.DataBoundItem as StatistikaIgraca;
                trening.ListaStatistikaIgraca.Remove(si);

                int i = 1;
                foreach (StatistikaIgraca s in trening.ListaStatistikaIgraca)
                {
                    s.Rb = i;
                    i++;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali statistiku za brisanje!");
            }
        }

        internal static void PopuniComboTipStat(ComboBox cmbNazivStatistike)
        {
            cmbNazivStatistike.Items.Clear();
            foreach (var x in (List<TipStatistike>)komunikacija.VratiTipStatistike())
            {
                cmbNazivStatistike.Items.Add(x);
            }

            cmbNazivStatistike.Text = "Odaberite tip statistike!";
        }

        internal static void PopuniComboVrstaTreninga(ComboBox cmbVrstaTrening)
        {
            cmbVrstaTrening.Items.Clear();
            foreach (var x in (List<VrstaTreninga>)komunikacija.VratiListuVrstaTreninga())
            {
                cmbVrstaTrening.Items.Add(x);
            }

            cmbVrstaTrening.Text = "Odaberite vrstu treninga!";
        }

        internal static void PopuniComboIgrac(ComboBox cmbIgrac)
        {
            cmbIgrac.Items.Clear();
            foreach (var x in (List<Igrac>)komunikacija.VratiListuIgraca())
            {
                cmbIgrac.Items.Add(x);
            }

            cmbIgrac.Text = "Odaberite igraca!";
        }

        public static KategorijaIgraca kategorijaIgraca;
        //public static Igrac igracc;

        internal static void PopuniPoljaZaIgraca(TextBox txtIme, TextBox txtPrezime, TextBox txtGodina, TextBox txtVisina, TextBox txtTezina, TextBox txtKontakt, TextBox txtNapomena, ComboBox cmbKategorijaIgraca, RadioButton rbMuski, RadioButton rbŽenski)
        {
            PopuniComboZaKategorijuIgraca(cmbKategorijaIgraca);

            txtIme.Text = igrac.Ime.ToString();
            txtPrezime.Text = igrac.Prezime.ToString();
            txtGodina.Text = igrac.GodinaRodjenja.ToString();
            
            txtVisina.Text = igrac.Visina.ToString();
            txtTezina.Text = igrac.Tezina.ToString();
            txtKontakt.Text = igrac.Kontakt.ToString();
            txtNapomena.Text = igrac.Napomena.ToString();
            cmbKategorijaIgraca.Text = igrac.KategorijaIgraca.ToString();


            if (igrac.Pol == "Muški")
            {
                rbMuski.Checked = true;
            }
            else
            {
                rbŽenski.Checked = true;
            }

        }

        internal static bool ObrisiIgraca()
        {
            object o = komunikacija.ObrisiIgraca(igrac);

            if (o==null)
            {
                MessageBox.Show("Sistem ne može da obriše igrača!");
                return false;
            }
            else
            {
                MessageBox.Show("Igrač je obrisan!");
                return true;
            }

        }

        internal static void PretraziIgraca(TextBox txtNazivIgraca, DataGridView dataGridView1)
        {
            igrac = new Igrac();
            //da sadrzi neki deo imena
            igrac.Uslov = " Ime like '%"+txtNazivIgraca.Text+ "%' or Prezime like '%" + txtNazivIgraca.Text + "%'";

            List<Igrac> lista = (List<Igrac>)komunikacija.PretraziIgraca(igrac);


            if (lista==null)
            {
                MessageBox.Show("Sistem ne može da pronadje igrača/e!");
                return;
            }

            dataGridView1.DataSource = lista;

            if (lista.Count==0)
            {
                MessageBox.Show("Sistem ne može da nađe igrača/e po zadatom kriterijumu!");
            }

            MessageBox.Show("Pretraga igrača je bila uspešna!");


        }

        internal static bool UcitajIgraca(DataGridView dataGridView1)
        {
            try
            {
                igrac = dataGridView1.CurrentRow.DataBoundItem as Igrac;
                igrac = (Igrac)komunikacija.UcitajIgraca(igrac);

                if (igrac == null)
                {
                    MessageBox.Show("Sistem ne može da učita podatke o igraču!");
                    return false;
                }
                else {
                    MessageBox.Show("Sistem je učitao podatke o igraču!");
                    return true;
                }
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali igrača!!!");
                return false;
            }
        }

        internal static bool KreirajNovogIgraca(TextBox txtSifra, GroupBox gbIgrac, Button btnKreiraj)
        {
            igrac = (Igrac)komunikacija.KreirajNovogIgraca();

            if (igrac == null)
            {
                MessageBox.Show("Sistem ne moze da kreira novog igraca!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao novog igraca!");
                txtSifra.Text = igrac.IgracId.ToString();
                btnKreiraj.Enabled = false;
                gbIgrac.Enabled = true;
                return true;
            }
        }

        internal static void PopuniComboZaKategorijuIgraca(ComboBox cmbKategorijaIgraca)
        {
            cmbKategorijaIgraca.Items.Clear();
            List<KategorijaIgraca> lista = (List<KategorijaIgraca>)komunikacija.VratiListuKategorijaIgraca();

            foreach (KategorijaIgraca ki in lista)
            {
                cmbKategorijaIgraca.Items.Add(ki);
            }

            cmbKategorijaIgraca.Text = "Izaberite kategoriju!";

        }

        internal static bool ZapamtiNovogIgraca(TextBox txtIme, TextBox txtPrezime, TextBox txtGodina, TextBox txtVisina, TextBox txtTezina, TextBox txtKontakt, TextBox txtNapomena, ComboBox cmbKategorijaIgraca, RadioButton rbMuski, RadioButton rbZenski)
        {
           
        
            igrac.Ime = txtIme.Text;
            if (string.IsNullOrEmpty(igrac.Ime))
            {
                MessageBox.Show("Niste uneli dobro ime!");
                return false;
            }
            igrac.Prezime = txtPrezime.Text;
            if (string.IsNullOrEmpty(igrac.Prezime))
            {
                MessageBox.Show("Niste uneli dobro prezime!");
                return false;
            }
            try
            {
                igrac.GodinaRodjenja = Convert.ToInt32(txtGodina.Text);

                if (igrac.GodinaRodjenja<1970 || igrac.GodinaRodjenja>2020 || (DateTime.Now.Year - igrac.GodinaRodjenja)<12)
                {
                    MessageBox.Show("Nije moguće da takav igrač igra košarku!");
                    return false;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Niste dobro uneli godinu rodjenja!");
                return false;
            }

            if (rbMuski.Checked)
            {
                igrac.Pol = "Muški";
            }
            if (rbZenski.Checked)
            {
                igrac.Pol = "Ženski";
            }
            if (rbMuski.Checked && rbZenski.Checked)
            {
                MessageBox.Show("Ne možete odabrati oba pola!");
                return false;
            }
            if (!rbMuski.Checked && !rbZenski.Checked)
            {
                MessageBox.Show("Morate odabrati pol!");
                return false;
            }
            
            try
            {
                igrac.Visina = Convert.ToDouble(txtVisina.Text);
                if (igrac.Visina<150 || igrac.Visina>250)
                {
                    MessageBox.Show("Nije dobra visina! Mogući raspon visine od 150-250 cm.");
                    return false;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Niste dobro uneli visinu!");
                return false;
            }
            try { 

            igrac.Tezina = Convert.ToDouble(txtTezina.Text);

                if (igrac.Tezina<50 || igrac.Tezina>150)
                {
                    MessageBox.Show("Nije dobro uneta tezina!Mogući raspon težine igrača iznosi od 50 do 150 kg!");
                    return false;
                }
            }   
            catch (Exception)
            {

                MessageBox.Show("Niste dobro uneli tezinu!");
                return false;
            }

            Regex reg = new Regex(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$");

            Match match = reg.Match(txtKontakt.Text);


            if (match.Success)
            {
                igrac.Kontakt = txtKontakt.Text;
            }
            else
            {
                MessageBox.Show("Nije dobar format unosa! Mora biti kao na sledećem primeru: +(033) - 123-45-78");
                return false;
            }
            //igrac.Kontakt = txtKontakt.Text;
            if (string.IsNullOrEmpty(igrac.Kontakt))
            {
                MessageBox.Show("Niste uneli dobro kontakt!");
                return false;
            }
            igrac.Napomena = txtNapomena.Text;
            if (string.IsNullOrEmpty(igrac.Napomena))
            {
                MessageBox.Show("Niste uneli dobro napomenu!");
                return false;
            }
            //trebaju ti sve validacije

            try
            {
                igrac.KategorijaIgraca = cmbKategorijaIgraca.SelectedItem as KategorijaIgraca;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali kategoriju igrača!");
                return false;
            }


            Object rezultat = komunikacija.ZapamtiIgraca(igrac);

            

            if (rezultat == null)
            {
                MessageBox.Show("Sistem ne može da zapamti igrača!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio novog igrača!");
                return true;
            }

        }

        internal static string PrikaziUlogovanogTrenera()
        {
            return "Ulogovani trener: "+trener.ToString();
        }

        internal static void Kraj()
        {
            komunikacija.kraj();
            komunikacija = null;
        }

        public static bool PoveziSeNaServer()
        {
            if (komunikacija == null)
            {
                komunikacija = new Komunikacija();
            }
            return komunikacija.poveziSeNaServer();
           

        }

        internal static bool Login(TextBox txtUsername, TextBox txtPassword)
        {
            trener = new Trener();

            trener.Username = txtUsername.Text;
            trener.Password = txtPassword.Text;

            trener = (Trener)komunikacija.NadjiTrenera(trener);

            if (trener == null)
            {
                //alternativa scenario
                MessageBox.Show("Sistem ne može da nađe trenera na osnovu unetih vrednosti.");
                return false;
            }
            else
            {
                //osnovni scenario
                MessageBox.Show("Trener je uspešno prijavljen");
                return true;

            }

        }
    }
}
