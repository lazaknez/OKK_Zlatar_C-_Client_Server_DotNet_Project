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
    public class Trener:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return ime + " "+prezime;
        }


        int trenerID;
        string ime;
        string prezime;
        string username;
        string password;

        public int TrenerID { get => trenerID; set => trenerID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }


        //ODO
        [Browsable(false)]
        public string nazivTabele => "Trener";
        [Browsable(false)]
        public string primarniKljuc => "TrenerID";
        [Browsable(false)]
        public string uslovVezanZaPrimarniKljuc => "TrenerID="+trenerID;
        [Browsable(false)]
        public string uslovZaOstalo => " Username = '"+username+"' and Password = '"+password+"' ";
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;


        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            Trener t = new Trener();

            t.TrenerID = Convert.ToInt32(red["TrenerID"]);
            t.Ime = red["Ime"].ToString();
            t.Prezime = red["Prezime"].ToString();
            t.Username = red["Username"].ToString();
            t.Password = red["Password"].ToString();

            return t;
        }
    }
}
