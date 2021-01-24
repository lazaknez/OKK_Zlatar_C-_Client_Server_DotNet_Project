using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

using Server.Sistemske_Operacije.StatistikaIgracaSO;
using Server.Sistemske_Operacije.IgracSO;
using Server.Sistemske_Operacije.TrenerSO;
using Server.Sistemske_Operacije.TreningSO;
using Server.Sistemske_Operacije;

namespace Server
{
    public class NitKlijenta
    {
        private NetworkStream tok;
        
        BinaryFormatter formater;

        public NitKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradi;
            new Thread(ts).Start();

        }
        void obradi()
        {
            try
            {
                int operacija = 0;
                while (operacija!=(int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {
                        //za statistiku igraca!!!
                        case Operacije.ZapamtiStatistikuIgraca:                          
                            EvidentiranjeStatistikeIgraca esi = new EvidentiranjeStatistikeIgraca();
                            transfer.Rezultat = esi.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                            //svih 15. ostalih odradjenih
                        case Operacije.NadjiTrenera:
                            NadjiTrenera nt = new NadjiTrenera();
                            transfer.Rezultat = nt.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.KreirajNovogIgraca:
                            KreirajNovogIgraca kni = new KreirajNovogIgraca();
                            transfer.Rezultat = kni.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.ZapamtiIgraca:
                            ZapamtiIgraca zi = new ZapamtiIgraca();
                            transfer.Rezultat =zi.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.PretraziIgraca:
                           PretraziIgraca pi = new PretraziIgraca();
                            transfer.Rezultat = pi.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.UcitajIgraca:
                            UcitajIgraca ui = new UcitajIgraca();
                            transfer.Rezultat = ui.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.ObrisiIgraca:
                            ObrisiIgraca oi = new ObrisiIgraca();
                            transfer.Rezultat = oi.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.KreirajNoviTrening:
                            KreirajNoviTrening knt = new KreirajNoviTrening();
                            transfer.Rezultat = knt.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.ZapamtiTrening:
                            ZapamtiTrening zt = new ZapamtiTrening();
                            transfer.Rezultat = zt.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.PretraziTreninge:
                            PretraziTreninge pt = new PretraziTreninge();
                            transfer.Rezultat = pt.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.UcitajTreninge:
                            UcitajTrening ut = new UcitajTrening();
                            transfer.Rezultat = ut.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.VratiListuTreninga:
                            VratiListuTreninga vlt = new VratiListuTreninga();
                            transfer.Rezultat = vlt.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.VratiListuKategorijaIgraca:
                            VratiListuKategorijaIgraca vlki = new VratiListuKategorijaIgraca();
                            transfer.Rezultat = vlki.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.VratiListuIgraca:
                            VratiListuIgraca vli = new VratiListuIgraca();
                            transfer.Rezultat = vli.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.VratiListuVrstaTreninga:
                            VratiListuVrstaTreninga vlvt = new VratiListuVrstaTreninga();
                            transfer.Rezultat = vlvt.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.VratiTipStatistike:
                            VratiTipStatistike vts = new VratiTipStatistike();
                            transfer.Rezultat = vts.IzvrsiSistemskuOperaciju(transfer.TransferObjekat as OpstiDomenskiObjekat);

                            formater.Serialize(tok, transfer);

                            break;
                        case Operacije.Kraj:operacija = 1;
                            Server.listaTokova.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Server.listaTokova.Remove(tok);

            }
        }
    }
}
