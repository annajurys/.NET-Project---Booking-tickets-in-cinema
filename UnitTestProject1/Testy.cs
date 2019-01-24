using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt;
using GUI;

namespace UnitTestProject1
{
    [TestClass]
    public class Testy
    {
        [TestMethod]
        public void DodawanieFilmuTest()
        {
            Film f = new Film();
            ListaFilmow lf = new ListaFilmow();
            lf.DodajFilm(f);
            Assert.IsNotNull(lf);
        }
        [TestMethod]
        public void TytulFilmuTest()
        {
            Film f = new Film("Aaa", "Bbb", 50);
            Assert.AreEqual(f.tytul, "Aaa");
        }
        [TestMethod]
        public void DodawanieBiletuTest()
        {
            
            Sala s = new Sala();
            Film f = new Film();
            Seans se = new Seans(f, DateTime.Now, s);
            Zamowienie z = new Zamowienie(se);
            z.DodajBilet(new BiletNormalny(), 5);
            Assert.IsNotNull(z.lista_biletow);
        }

        [TestMethod]
        [ExpectedException(typeof(Ujemny_czas_trwania_filmu_exception))]
        public void Ujemny_czas_trwania_filmu_exception_Test()
        {
            Film f = new Film("Aaa", "Bbb", -50);
        }
        [TestMethod]
        [ExpectedException(typeof(Zla_ilosc_miejsc_exception))]
        public void Zla_ilosc_miejsc_exception_Test()
        {
            Sala s = new Sala(200);
        }
        [TestMethod]
        [ExpectedException(typeof(Miejsce_juz_zajete_exception))]
        public void Miejsce_juz_zajete_exception_Test()
        {
            Sala sala = new Sala(10);
            Film film = new Film();
            BiletNormalny b = new BiletNormalny();
            BiletNormalny b1 = new BiletNormalny();
            Seans s = new Seans(film, DateTime.Now, sala);
            Zamowienie z = new Zamowienie(s);
            z.DodajBilet(b, 5);
            z.DodajBilet(b1, 5);
        }
        [TestMethod]
        public void RezyserFilmuTest()
        {
            Film f = new Film("Aaa", "Bbb", 50);
            Assert.AreEqual(f.rezyser, "Bbb");
        }
        [TestMethod]
        public void FilmWZamowieniuTest()
        {
            Sala sala = new Sala();
            Film film = new Film();
            Seans s = new Seans(film, DateTime.Now, sala);
            Zamowienie z = new Zamowienie(s);
            Assert.AreEqual(s.film, film);
        }
        [TestMethod]
        public void OdczytXMLTestFilmy()
        {
           
            Film film = new Film("Aaa", "Bbb", 50);
    
            
            ListaFilmow lf = new ListaFilmow();
            
            lf.DodajFilm(film);
            
            lf.ZapiszXML("filmy.xml");
            ListaFilmow ln = new ListaFilmow();
            ln = ln.OdczytajXML("filmy.xml") as ListaFilmow;
            Assert.AreEqual(lf.lista_filmow[0].tytul,ln.lista_filmow[0].tytul);
        }
        [TestMethod]
        public void OdczytXMLTestSeanse()
        {
            Sala sala = new Sala(10);
            Film film = new Film("Aaa", "Bbb", 50);
            Seans seans = new Seans(film, DateTime.Now, sala); 
            ListaSeansow ls = new ListaSeansow(); 
            ls.DodajSeans(seans);
            ls.ZapiszXML("seans.xml");
            ListaSeansow ls1 = new ListaSeansow();
            ls1 = ls1.OdczytajXML("seans.xml")as ListaSeansow;
            Assert.AreEqual(ls.lista_seansow[0].data_i_godzina_rozpoczecia, ls1.lista_seansow[0].data_i_godzina_rozpoczecia);
        }
        [TestMethod]
        public void DodawanieSeansuTest()
        {
            Sala s = new Sala();
            Film f = new Film();
            Seans se = new Seans(f, DateTime.Now, s);
            Zamowienie z = new Zamowienie(se);
            ListaSeansow lista = new ListaSeansow();
            lista.DodajSeans(se);
            Assert.IsNotNull(lista);
        }
        [TestMethod]
        public void CloneListaSeansowTest()
        {
            Sala s = new Sala();
            Film f = new Film();
            Seans se = new Seans(f, DateTime.Now, s);
            Zamowienie z = new Zamowienie(se);
            ListaSeansow ls = new ListaSeansow();
            ls.DodajSeans(se);
            ListaSeansow ls1 = new ListaSeansow();
            ls1 = ls.Clone() as ListaSeansow;
            Assert.AreEqual(ls.lista_seansow[0].data_i_godzina_rozpoczecia, ls1.lista_seansow[0].data_i_godzina_rozpoczecia);
        }
        [TestMethod]
        public void CloneListaFilmow()
        {
            Film f1 = new Film();
            Film f2 = new Film();
            Film f3 = new Film();
            ListaFilmow l = new ListaFilmow();
            l.DodajFilm(f1);
            l.DodajFilm(f2);
            l.DodajFilm(f3);
            ListaFilmow lclone = new ListaFilmow();
            lclone = l.Clone() as ListaFilmow;
            Assert.AreEqual(l.lista_filmow[0].tytul, lclone.lista_filmow[0].tytul);
        }
        [TestMethod]
        public void ObliczanieGodzinyZakonczeniaSeansuTest()
        {
            Film film = new Film();
            Sala sala = new Sala();
            Seans seans = new Seans(film, new DateTime(2019, 12, 12, 12, 0, 0), sala);
            DateTime zakonczenie = new DateTime();
            zakonczenie = seans.Data_i_godzina_rozpoczecia.AddMinutes(film.Czas_trwania);
            Assert.AreEqual(zakonczenie, seans.data_i_godzina_zakonczenia);
        }
        [TestMethod]
        public void UsuwanieBiletuTest()
        {
            Sala s = new Sala();
            Film f = new Film();
            Seans se = new Seans(f, DateTime.Now, s);
            Zamowienie z = new Zamowienie(se);
            z.DodajBilet(new BiletNormalny(), 5);
            z.UsunBilet(5);
            Assert.AreEqual(0,z.lista_biletow.Count);
        }
        [TestMethod]
        public void ObliczanieCenyZamowieniaTest()
        {
            BiletUlgowy b0 = new BiletUlgowy();
            BiletUlgowy b1 = new BiletUlgowy();
            BiletUlgowy b2 = new BiletUlgowy();
            BiletUlgowy b3 = new BiletUlgowy();
            Sala s = new Sala();
            Film f = new Film();
            Seans se = new Seans(f, DateTime.Now, s);
            Zamowienie z = new Zamowienie(se);
            z.DodajBilet(b0,1);
            z.DodajBilet(b1,2);
            z.DodajBilet(b2,3);
            z.DodajBilet(b3,4);
            int sumab = 0;
            sumab +=  b0.Suma();
            sumab += b1.Suma();
            sumab += b2.Suma();
            sumab += b3.Suma();
            Assert.AreEqual(sumab, z.SumaZamowienia());
        }
        [TestMethod]
        public void PobieranieDatyRozpoczeciaSeansuTest()
        {
            Film film = new Film();
            Sala sala = new Sala();
            Seans s = new Seans(film, new DateTime(2019, 12, 12, 12, 0, 0), sala);
            Assert.AreEqual(s.data_i_godzina_rozpoczecia, new DateTime(2019, 12, 12, 12, 0, 0));
            
        }
        [TestMethod]
        public void PobieranieCzasuTrwaniaFilmuTest()
        {
            Film f = new Film("A", "B", 50);
            Assert.AreEqual(f.Czas_trwania,50);
        }
        [TestMethod]
        public void SprawdzenieTypuTytuluTest()
        {
            Film film = new Film("A", "B", 50);
            string a = "anna";
            Assert.AreEqual(film.tytul.GetType(), film.tytul.GetType());
        }
        [TestMethod]
        public void SprawdzenieTypuMiejscaTest()
        {
            Film film = new Film();
            Sala sal = new Sala();
            Seans seans = new Seans(film, DateTime.Now, sal);
            Zamowienie z = new Zamowienie(seans);
            BiletUlgowy b = new BiletUlgowy();
            z.DodajBilet(b, 5);
            int a = 1;
            Assert.AreEqual(a.GetType(), b.Miejsce.GetType());
        }
    }
}
