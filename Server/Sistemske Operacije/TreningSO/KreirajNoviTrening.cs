using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.Sistemske_Operacije.TreningSO
{
    [Serializable]
    public class KreirajNoviTrening : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSistemskuOperaciju(OpstiDomenskiObjekat odo)
        {
            Trening t = new Trening();
            t.TreningID = Broker.DajSesiju().VratiSifru(t);
            Broker.DajSesiju().Sacuvaj(t);
            return t;
        }
    }
}
