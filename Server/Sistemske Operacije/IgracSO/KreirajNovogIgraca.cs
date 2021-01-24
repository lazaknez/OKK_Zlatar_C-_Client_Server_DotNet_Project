using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Sistemske_Operacije.IgracSO
{
    
    public class KreirajNovogIgraca:OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSistemskuOperaciju(OpstiDomenskiObjekat odo)
        {
            Igrac i = new Igrac();
            i.IgracId = Broker.DajSesiju().VratiSifru(i);
            Broker.DajSesiju().Sacuvaj(i);
            return i;
        }
    }
}
