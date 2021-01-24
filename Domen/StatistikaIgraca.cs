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
    public class StatistikaIgraca:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return igrac.Ime+" "+igrac.Prezime+" "+tipStatistike.NazivStat;
        }


        int treningID;
        int rb;
        Igrac igrac;     
        TipStatistike tipStatistike;
        double vrednost;

        [Browsable(false)]
        public Igrac Igrac { get => igrac; set => igrac = value; }
        [Browsable(false)]
        public int TreningID { get => treningID; set => treningID = value; }
        [Browsable(false)]
        public TipStatistike TipStatistike { get => tipStatistike; set => tipStatistike = value; }
        
        [Browsable(false)]
        public int Rb { get => rb; set => rb = value; }
        [DisplayName("Ime i prezime:")]
        public string ImeiPrezime
        { get => igrac.Ime + " "+igrac.Prezime; }
        [DisplayName("Naziv statistike:")]
        public string NazivStatistike
        { get => tipStatistike.NazivStat; }
        public double Vrednost { get => vrednost; set => vrednost = value; }


        [Browsable(false)]
        public string nazivTabele => "StatistikaIgraca";
        [Browsable(false)]
        public string primarniKljuc => "";
        [Browsable(false)]
        public string uslovVezanZaPrimarniKljuc => "";
        [Browsable(false)]
        public string Uslov;
        [Browsable(false)]
        public string uslovZaOstalo => Uslov;
        [Browsable(false)]
        public string izmena => "";
        [Browsable(false)]
        public string unos => " values("+treningID+","+rb+","+ igrac.IgracId + ","+tipStatistike.StatId+","+vrednost+")";

        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            StatistikaIgraca si = new StatistikaIgraca();

            si.igrac = new Igrac();
            si.igrac.IgracId = Convert.ToInt32(red["IgracID"]);

            si.rb= Convert.ToInt32(red["Rb"]);
            
            si.TreningID = Convert.ToInt32(red["TreningID"]);

            si.tipStatistike = new TipStatistike();
            si.tipStatistike.StatId = Convert.ToInt32(red["StatID"]);

            si.vrednost = Convert.ToDouble(red["Vrednost"]);

            return si;

        }

        public override bool Equals(object obj)
        {
            var igraca = obj as StatistikaIgraca;
            return igraca != null &&
                   EqualityComparer<Igrac>.Default.Equals(igrac, igraca.igrac) &&
                   EqualityComparer<TipStatistike>.Default.Equals(tipStatistike, igraca.tipStatistike);
        }
    }
}
