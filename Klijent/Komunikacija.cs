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

namespace Klijent
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 12222);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void kraj()
        {
            
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok,transfer);
        }

        public Object NadjiTrenera(Trener t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.NadjiTrenera;
            transfer.TransferObjekat = t;
            formater.Serialize(tok,transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        //vracam sve Objekte pa posle kastujem sta mi i kako treba
        public Object KreirajNovogIgraca()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajNovogIgraca;
            transfer.TransferObjekat = new Igrac();
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object ZapamtiIgraca(Igrac i)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiIgraca;
            transfer.TransferObjekat = i;
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object PretraziIgraca(Igrac i)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziIgraca;
            transfer.TransferObjekat = i;
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object UcitajIgraca(Igrac t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajIgraca;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object ObrisiIgraca(Igrac t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiIgraca;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        //za trening sve!!!
        public Object KreirajNoviTrening()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajNoviTrening;
            transfer.TransferObjekat = new Trening();
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object ZapamtiTrening(Trening t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiTrening;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object PretraziTreninge(Trening t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziTreninge;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object UcitajTrening(Trening t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajTreninge;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object VratiListuTreninga()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiListuTreninga;
            transfer.TransferObjekat = new Trening();
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object VratiListuKategorijaIgraca()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiListuKategorijaIgraca;
            transfer.TransferObjekat = new KategorijaIgraca();
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object VratiListuIgraca()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiListuIgraca;
            transfer.TransferObjekat = new Igrac();
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object VratiListuVrstaTreninga()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiListuVrstaTreninga;
            transfer.TransferObjekat = new VrstaTreninga();
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object VratiTipStatistike()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiTipStatistike;
            transfer.TransferObjekat = new TipStatistike();
            formater.Serialize(tok, transfer);


            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

    }
}
