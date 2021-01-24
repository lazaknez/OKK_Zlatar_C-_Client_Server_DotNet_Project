using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Data;
using System.Data.SqlClient;


namespace Server
{
    public class Broker
    {
        public static Broker instanca;
        //SqlCommand komanda;
        SqlConnection konekcija;
        SqlTransaction transakcija;


        public static Broker DajSesiju()
        {
            if (instanca == null)
                instanca = new Broker();
            return instanca;
        }

        public void OtvoriKonekciju()
        {
            try
            {
                konekcija = new SqlConnection(@"Data Source=(localdb)\MSSQLLocaldb;Initial Catalog=MojProjekatBazaZlatar;Integrated Security=True");
                konekcija.Open();
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Neuspesna konekcija!");
            }
        }
        public void ZatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Nije moguce zatvoriti konekciju!");
            }
        }

        public void ZapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Neuspesna transakcija!");
            }


        }

        public void PonistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Nije moguce ponistiti transakciju!");
            }
        }
        public void PotvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Nije moguce potvrditi transakciju!");
            }
        }




        public List<OpstiDomenskiObjekat> VratiSve(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from "+odo.nazivTabele;

            SqlDataReader citac = null;

            SqlCommand komanda = new SqlCommand(upit,konekcija,transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);

                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow row in tabela.Rows)
                {
                    OpstiDomenskiObjekat pomocna = odo.Procitaj(row);
                    lista.Add(pomocna);
                }
                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac!=null)
                {
                    citac.Close();
                }
            }

        }
        //2.
        public List<OpstiDomenskiObjekat> VratiSveZaUslovOpsti(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from "+odo.nazivTabele+" where "+odo.uslovZaOstalo;
            SqlDataReader citac = null;

            SqlCommand komanda = new SqlCommand(upit,konekcija,transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);

                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow row in tabela.Rows)
                {
                    OpstiDomenskiObjekat pomocna = odo.Procitaj(row);
                    lista.Add(pomocna);
                }
                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }
        //3.
        public OpstiDomenskiObjekat VratiZaUslovPrimarni(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.nazivTabele + " where " + odo.uslovVezanZaPrimarniKljuc;
            SqlDataReader citac = null;

            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);

                DataRow red;

                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else {
                    red = tabela.Rows[0];
                }
                return odo.Procitaj(red);
            }
            catch (Exception)
            {

                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }


        }
        //4.

        public OpstiDomenskiObjekat VratiZaUslovOstalo(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.nazivTabele + " where " + odo.uslovZaOstalo;
            SqlDataReader citac = null;

            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);

                DataRow red;

                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.Procitaj(red);
            }
            catch (Exception)
            {

                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        //5.
        public int IzmeniUslovPrimarni(OpstiDomenskiObjekat odo)
        {

            string upit = "Update "+odo.nazivTabele+" set "+odo.izmena+" where "+odo.uslovVezanZaPrimarniKljuc;

            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greska u radu sa bazom!"); ;
            }

        }
        //6.
        public int IzmeniUslovOstalo(OpstiDomenskiObjekat odo)
        {
            string upit = "Update " + odo.nazivTabele + " set " + odo.izmena + " where " + odo.uslovZaOstalo;

            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greska u radu sa bazom!");
            }

        }
        //7.
        public int Sacuvaj(OpstiDomenskiObjekat odo)
        {
            string upit = "Insert into " + odo.nazivTabele + " " + odo.unos;
            SqlCommand komanda = new SqlCommand(upit,konekcija,transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greska u radu sa bazom!");
            }
        }
        //8.
        public int ObrisiZaPrimarniUslov(OpstiDomenskiObjekat odo)
        {
            string upit = "Delete from " + odo.nazivTabele + " where " + odo.uslovVezanZaPrimarniKljuc;

            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greska u radu sa bazom!");
            }
        }
        //9.
        public int ObrisiZaUslovOstalo(OpstiDomenskiObjekat odo)
        {
            string upit = "Delete from " + odo.nazivTabele + " where " + odo.uslovZaOstalo;

            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greska u radu sa bazom!");
            }
        }
        //10.
        public int VratiSifru(OpstiDomenskiObjekat odo)
        {
            string upit = "Select max(" + odo.primarniKljuc+ ") from " + odo.nazivTabele;

            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                object o = komanda.ExecuteScalar();
                if (o == DBNull.Value) return 1;
                else
                    return Convert.ToInt32(o) + 1;            
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
