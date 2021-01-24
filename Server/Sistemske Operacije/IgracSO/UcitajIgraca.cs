using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.Sistemske_Operacije.IgracSO
{
    public class UcitajIgraca : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSistemskuOperaciju(OpstiDomenskiObjekat odo)
        {
            Igrac i = odo as Igrac;

            //za spoljni kljuc!!!
            i.KategorijaIgraca = Broker.DajSesiju().VratiZaUslovPrimarni(i.KategorijaIgraca) as KategorijaIgraca;


            return i;
        }
    }
}
