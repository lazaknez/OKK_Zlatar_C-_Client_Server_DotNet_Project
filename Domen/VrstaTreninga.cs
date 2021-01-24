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
    public class VrstaTreninga:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return naziv;
        }
        int vrstaTreningaID;
        string naziv;
        string opisTreninga;

        public int VrstaTreningaID { get => vrstaTreningaID; set => vrstaTreningaID = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string OpisTreninga { get => opisTreninga; set => opisTreninga = value; }


        //odo deo
        [Browsable(false)]
        public string nazivTabele => "VrstaTreninga";
        [Browsable(false)]
        public string primarniKljuc => "VrstaTreningaID";
        [Browsable(false)]
        public string uslovVezanZaPrimarniKljuc => "VrstaTreningaID="+ vrstaTreningaID;
        [Browsable(false)]
        public string uslovZaOstalo => null;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

        public override bool Equals(object obj)
        {
            var treninga = obj as VrstaTreninga;
            return treninga != null &&
                   vrstaTreningaID == treninga.vrstaTreningaID;
        }

        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            VrstaTreninga vs = new VrstaTreninga();

            vs.vrstaTreningaID = Convert.ToInt32(red["VrstaTreningaID"]);
            vs.Naziv = red["Naziv"].ToString();
            vs.OpisTreninga = red["OpisTreninga"].ToString();

            return vs;
        }

    }
}
