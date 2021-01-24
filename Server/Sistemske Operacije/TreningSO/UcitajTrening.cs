using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.Sistemske_Operacije.TreningSO
{
    public class UcitajTrening:OpstaSistemskaOperacija
    {
        

        public override object IzvrsiKonkretnuSistemskuOperaciju(OpstiDomenskiObjekat odo)
        {
            Trening t = odo as Trening;

            t.VrstaTreninga = Broker.DajSesiju().VratiZaUslovPrimarni(t.VrstaTreninga) as VrstaTreninga;
           
            StatistikaIgraca si = new StatistikaIgraca();
            si.Uslov = " TreningID = " + t.TreningID;

            List<StatistikaIgraca> lista = Broker.DajSesiju().VratiSveZaUslovOpsti(si).OfType<StatistikaIgraca>().ToList<StatistikaIgraca>();

            foreach (StatistikaIgraca statistika in lista)
            {
                statistika.Igrac = Broker.DajSesiju().VratiZaUslovPrimarni(statistika.Igrac) as Igrac; 
                statistika.TipStatistike = Broker.DajSesiju().VratiZaUslovPrimarni(statistika.TipStatistike) as TipStatistike;
                t.ListaStatistikaIgraca.Add(statistika);
            }


            return t;
        }
    }
}
