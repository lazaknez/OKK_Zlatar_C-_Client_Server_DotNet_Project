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
    public class TipStatistike:OpstiDomenskiObjekat
    {

        public override string ToString()
        {
            return nazivStat;
        }

        int statId;
        string nazivStat;

        public int StatId { get => statId; set => statId = value; }
        public string NazivStat { get => nazivStat; set => nazivStat = value; }

        //odo deo
        [Browsable(false)]
        public string nazivTabele => "TipStatistike";
        [Browsable(false)]
        public string primarniKljuc => "StatID";
        [Browsable(false)]
        public string uslovVezanZaPrimarniKljuc => "StatID=" + statId;
        [Browsable(false)]
        public string Uslov => "";
        [Browsable(false)]
        public string uslovZaOstalo => Uslov;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

        public override bool Equals(object obj)
        {
            var statistike = obj as TipStatistike;
            return statistike != null &&
                   statId == statistike.statId;
        }

        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            TipStatistike ts = new TipStatistike();

            ts.StatId = Convert.ToInt32(red["StatID"]);
            ts.NazivStat = red["NazivStat"].ToString();

            return ts;
        }
    }
}
