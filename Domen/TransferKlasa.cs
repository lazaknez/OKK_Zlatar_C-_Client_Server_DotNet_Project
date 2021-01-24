using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije { Kraj = 1,
        NadjiTrenera = 2,
        KreirajNovogIgraca = 3,
        ZapamtiIgraca = 4,
        PretraziIgraca = 5,
        UcitajIgraca = 6,
        ObrisiIgraca = 7,
        KreirajNoviTrening = 8,
        ZapamtiTrening = 9,
        PretraziTreninge = 10,
        UcitajTreninge = 11,
        VratiListuTreninga = 12,
        VratiListuKategorijaIgraca = 13,
        VratiListuIgraca = 14,
        VratiListuVrstaTreninga = 15,
        VratiTipStatistike = 16,
        ZapamtiStatistikuIgraca = 17
    }

    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;
    }
}
