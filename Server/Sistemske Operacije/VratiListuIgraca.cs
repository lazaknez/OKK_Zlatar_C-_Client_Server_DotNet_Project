using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.Sistemske_Operacije
{
    public class VratiListuIgraca : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSistemskuOperaciju(OpstiDomenskiObjekat odo)
        {
            Igrac i = new Igrac();
            i.Uslov = " Ime is null";

            Broker.DajSesiju().ObrisiZaUslovOstalo(i);

            return Broker.DajSesiju().VratiSve(odo).OfType<Igrac>().ToList();
        }
    }
}
