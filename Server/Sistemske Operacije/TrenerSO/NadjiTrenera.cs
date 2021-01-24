using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.Sistemske_Operacije.TrenerSO
{

    //ovo je kao Login samo je ovakav naziv jer sam stavio u dokumentaciji NadjiTrenera pa da znam

    [Serializable]
    public class NadjiTrenera : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSistemskuOperaciju(OpstiDomenskiObjekat odo)
        {
            return Broker.DajSesiju().VratiZaUslovOstalo(odo) as Trener;

        }
    }
}
