using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface OpstiDomenskiObjekat
    {
        string nazivTabele { get; }
        string primarniKljuc { get; }
        string uslovVezanZaPrimarniKljuc { get; }
        string uslovZaOstalo { get; }
        string izmena { get; }
        string unos { get; }

        OpstiDomenskiObjekat Procitaj(DataRow red);
       
    }
}
