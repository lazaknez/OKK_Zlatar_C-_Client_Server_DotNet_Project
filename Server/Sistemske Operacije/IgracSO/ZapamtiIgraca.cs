using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.Sistemske_Operacije.IgracSO
{
    [Serializable]
    public class ZapamtiIgraca : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSistemskuOperaciju(OpstiDomenskiObjekat odo)
        {

            Igrac i = odo as Igrac;

            Broker.DajSesiju().IzmeniUslovPrimarni(i);

            //za slab objekat!

            StatistikaIgraca si = new StatistikaIgraca();
            si.Uslov = " IgracID="+i.IgracId;

            Broker.DajSesiju().ObrisiZaUslovOstalo(si);

            foreach (StatistikaIgraca statistikaIgraca in i.ListaStatistikaIgraca)
            {
                Broker.DajSesiju().Sacuvaj(i);
            }

            return i;

        }
    }
}
