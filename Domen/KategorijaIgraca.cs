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
    public class KategorijaIgraca:OpstiDomenskiObjekat
    {

        public override string ToString()
        {
            return nazivKategorije;
        }
        

        int kategorijaId;
        string nazivKategorije;
        string opisKategorije;

        public int KategorijaId { get => kategorijaId; set => kategorijaId = value; }
        public string NazivKategorije { get => nazivKategorije; set => nazivKategorije = value; }
        public string OpisKategorije { get => opisKategorije; set => opisKategorije = value; }


        //odo deo
        [Browsable(false)]
        public string nazivTabele => "KategorijaIgraca";
        [Browsable(false)]
        public string primarniKljuc => "KategorijaID";
        [Browsable(false)]
        public string uslovVezanZaPrimarniKljuc => "KategorijaID=" + kategorijaId;
        [Browsable(false)]
        public string Uslov => "";
        [Browsable(false)]
        public string uslovZaOstalo => Uslov;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            KategorijaIgraca ks = new KategorijaIgraca();

            ks.KategorijaId = Convert.ToInt32(red["KategorijaID"]);
            ks.NazivKategorije = red["NazivKategorije"].ToString();
            ks.OpisKategorije = red["OpisKategorije"].ToString();

            return ks;
        }

    }
}
