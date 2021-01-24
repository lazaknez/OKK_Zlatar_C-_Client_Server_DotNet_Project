using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Sistemske_Operacije
{
    public abstract class OpstaSistemskaOperacija
    {
        public Object IzvrsiSistemskuOperaciju(OpstiDomenskiObjekat odo)
        {
            Object rezultat = null;
            try
            {
                Broker.DajSesiju().OtvoriKonekciju();
                Broker.DajSesiju().ZapocniTransakciju();
                rezultat = IzvrsiKonkretnuSistemskuOperaciju(odo);

                Broker.DajSesiju().PotvrdiTransakciju();

               
            }
            catch (Exception)
            {
                Broker.DajSesiju().PonistiTransakciju();
               
            }
            finally
            {
                Broker.DajSesiju().ZatvoriKonekciju();
            }
            return rezultat;
        }

        public abstract Object IzvrsiKonkretnuSistemskuOperaciju(OpstiDomenskiObjekat odo);

    }
}
