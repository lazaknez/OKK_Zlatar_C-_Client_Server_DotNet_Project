using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.Sistemske_Operacije
{
    public class VratiListuVrstaTreninga : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSistemskuOperaciju(OpstiDomenskiObjekat odo)
        {
            return Broker.DajSesiju().VratiSve(odo).OfType<VrstaTreninga>().ToList<VrstaTreninga>();
        }
    }
}
