using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.Sistemske_Operacije.TreningSO
{
    [Serializable]
    public class ZapamtiTrening : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSistemskuOperaciju(OpstiDomenskiObjekat odo)
        {
            Trening t = odo as Trening;

            Broker.DajSesiju().IzmeniUslovPrimarni(t);

            StatistikaIgraca si = new StatistikaIgraca();
            si.Uslov = " TreningID = " + t.TreningID;

            Broker.DajSesiju().ObrisiZaUslovOstalo(si);

            foreach (StatistikaIgraca statistikaIgraca in t.ListaStatistikaIgraca)
            {
                Broker.DajSesiju().Sacuvaj(statistikaIgraca);
            }


            return t;
        }
    }
}
