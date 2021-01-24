﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.Sistemske_Operacije.IgracSO
{
    public class ObrisiIgraca : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSistemskuOperaciju(OpstiDomenskiObjekat odo)
        {
            return Broker.DajSesiju().ObrisiZaPrimarniUslov(odo);
        }
    }
}
