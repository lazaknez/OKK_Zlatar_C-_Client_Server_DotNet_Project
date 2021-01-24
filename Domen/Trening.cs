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
    public class Trening:OpstiDomenskiObjekat
    {
        int treningID;
        DateTime datum;
        int trajanjeTreninga;
        string napomena;
        VrstaTreninga vrstaTreninga;


        [Browsable(false)]
        public int TreningID { get => treningID; set => treningID = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int TrajanjeTreninga { get => trajanjeTreninga; set => trajanjeTreninga = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        [Browsable(false)]
        public VrstaTreninga VrstaTreninga { get => vrstaTreninga; set => vrstaTreninga = value; }

        
        BindingList<StatistikaIgraca> listaStatistikaIgraca = new BindingList<StatistikaIgraca>();

        public Trening()
        {
            ListaStatistikaIgraca = new BindingList<StatistikaIgraca>();
        }

        //odo deo
        [Browsable(false)]
        public string nazivTabele => "Trening";
        [Browsable(false)]
        public string primarniKljuc => "TreningID";
        [Browsable(false)]
        public string uslovVezanZaPrimarniKljuc => "TreningID=" + treningID;       
        [Browsable(false)]
        public string Uslov = "Datum is null";
        [Browsable(false)]
        public string uslovZaOstalo => Uslov;
        [Browsable(false)]
        public string izmena => " Datum='"+datum.ToString("yyyy-MM-dd")+"', TrajanjeTreninga="+trajanjeTreninga+", Napomena='"+Napomena+"', VrstaTreningaID="+vrstaTreninga.VrstaTreningaID+"";
        [Browsable(false)]
        public string unos => " (TreningID) values ("+treningID+")";

        public BindingList<StatistikaIgraca> ListaStatistikaIgraca { get => listaStatistikaIgraca; set => listaStatistikaIgraca = value; }

        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            Trening t = new Trening();

            t.TreningID= Convert.ToInt32(red["TreningID"]);
            t.Datum = Convert.ToDateTime(red["Datum"]);
            t.TrajanjeTreninga = Convert.ToInt32(red["TrajanjeTreninga"]);
            t.Napomena = red["Napomena"].ToString();
            t.VrstaTreninga = new VrstaTreninga();
            t.VrstaTreninga.VrstaTreningaID = Convert.ToInt32(red["VrstaTreningaID"]);


            return t;
        }


    }
}
