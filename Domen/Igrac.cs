using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Igrac:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return Ime+" "+Prezime;
        }

        int igracId;
        string ime;
        string prezime;
        int godinaRodjenja;
        string pol;
        double visina;
        double tezina;
        string kontakt;
        string napomena;
        KategorijaIgraca kategorijaIgraca;
        BindingList<StatistikaIgraca> listaStatistikaIgraca;

        [Browsable(false)]
        public int IgracId { get => igracId; set => igracId = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        [DisplayName("Godina rodjenja")]
        public int GodinaRodjenja { get => godinaRodjenja; set => godinaRodjenja = value; }
        public string Pol { get => pol; set => pol = value; }
        public double Visina { get => visina; set => visina = value; }
        [DisplayName("Težina")]
        public double Tezina { get => tezina; set => tezina = value; }
        public string Kontakt { get => kontakt; set => kontakt = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        [Browsable(false)]
        public KategorijaIgraca KategorijaIgraca { get => kategorijaIgraca; set => kategorijaIgraca = value; }


        public Igrac()
        {
            listaStatistikaIgraca = new BindingList<StatistikaIgraca>();
        }


        
        //odo deo
        [Browsable(false)]
        public string nazivTabele => "Igrac";
        [Browsable(false)]
        public string primarniKljuc => "IgracID";
        [Browsable(false)]
        public string uslovVezanZaPrimarniKljuc => "IgracID="+igracId;
        [Browsable(false)]
        public string Uslov = " Ime is null or Prezime is null"; 
        [Browsable(false)]
        public string uslovZaOstalo => Uslov;
        [Browsable(false)]
        public string izmena => " Ime = '"+Ime+ "', Prezime = '" + Prezime + "', GodinaRodjenja = "+GodinaRodjenja+ ", Pol = '" + Pol + "', Visina = "+Visina+ ", Tezina = " + Tezina + ", Kontakt = '" + Kontakt + "', Napomena = '" + Napomena + "', KategorijaID = "+KategorijaIgraca.KategorijaId+"";
        [Browsable(false)]
        public string unos =>" (IgracID) values ("+igracId+")";

        public BindingList<StatistikaIgraca> ListaStatistikaIgraca { get => listaStatistikaIgraca; set => listaStatistikaIgraca = value; }

        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            Igrac i = new Igrac();

            i.IgracId = Convert.ToInt32(red["IgracID"]);
            i.Ime = red["Ime"].ToString();
            i.Prezime = red["Prezime"].ToString();
            i.GodinaRodjenja = Convert.ToInt32(red["GodinaRodjenja"]);
            i.Pol = red["Pol"].ToString();
            i.Visina = Convert.ToDouble(red["Visina"]);
            i.Tezina = Convert.ToDouble(red["Tezina"]);
            i.Kontakt = red["Kontakt"].ToString();
            i.Napomena = red["Napomena"].ToString();
            //!!!
            i.KategorijaIgraca = new KategorijaIgraca();
            i.KategorijaIgraca.KategorijaId = Convert.ToInt32(red["KategorijaID"]);
           

            return i;
        }

        public override bool Equals(object obj)
        {
            var igrac = obj as Igrac;
            return igrac != null &&
                   igracId == igrac.igracId;
        }
    }
}
