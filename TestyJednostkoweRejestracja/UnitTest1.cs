using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using wypożyczalnia_pracownik;
using WypozyczalniaAut.Model;
using WypozyczalniaAut.Logic;
using WypozyczalniaSamochodow;
using System.Collections.Generic;
using WypozyczalniaAut;

namespace TestyJednostkoweRejestracja
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void NiepelnoletniTest1()
        {
            //C:\Users\wikto\Desktop\3 semestr\Inżynieria Oprogramowania1\BazaDanychDoTestow
            // Arrange
            bool expectedResult = false;
            OtwieranieNowychOkien Rejestracja = new OtwieranieNowychOkien();
            Klient nowyKlient = new Klient();
            string PlikBazaTestowa = @"..\..\..\BazaDanychDoTestow\UserListTest.csv";
            bool AkceptacjaRegulaminu = true;
            string powtorzoneHaslo = "12341234";
            int Id = 0;
            string Imie = "Jan";
            string Nazwisko = "Kowalski";
            string Pesel = "85225874112";
            string NrPrawaJazdy = "X7336541";
            string haslo = "12341234";
            string Email = "janKowalski22@gmail.com";
            string login = "Janjan222";
            string komunikat = "";

            DateTime dataUrodzenia = new DateTime(2011, 1, 13); ;

            StatusKlienta statusKlienta;
            nowyKlient.Id = Id;
            nowyKlient.Imie = Imie;
            nowyKlient.Nazwisko = Nazwisko;
            nowyKlient.Pesel = Pesel;
            nowyKlient.NrPrawaJazdy = NrPrawaJazdy;
            nowyKlient.haslo = haslo;
            nowyKlient.Email = Email;
            nowyKlient.login = login;
            nowyKlient.DataUrodzenia = dataUrodzenia;
            //Act

            bool ActuaklResult = Rejestracja.TworzenieNowegoPrfilu(nowyKlient, PlikBazaTestowa, powtorzoneHaslo, AkceptacjaRegulaminu, ref komunikat);

            //Assert
            Assert.AreEqual(expectedResult, ActuaklResult);
        }

        [TestMethod]
        public void ZlePowtorzoneHasloTest2()
        {
            //C:\Users\wikto\Desktop\3 semestr\Inżynieria Oprogramowania1\BazaDanychDoTestow
            // Arrange
            bool expectedResult = false;
            OtwieranieNowychOkien Rejestracja = new OtwieranieNowychOkien();
            Klient nowyKlient = new Klient();
            string PlikBazaTestowa = @"..\..\..\BazaDanychDoTestow\UserListTest.csv";
            bool AkceptacjaRegulaminu = true;
            string powtorzoneHaslo = "123412345";
            int Id = 0;
            string Imie = "Jan";
            string Nazwisko = "Kowalski";
            string Pesel = "85225874113";
            string NrPrawaJazdy = "X7896543";
            string haslo = "12341234";
            string Email = "janKowalski22@gmail.com";
            string login = "Janjan222";
            string komunikat = "";
            DateTime dataUrodzenia = new DateTime(1980, 1, 13); ;

            StatusKlienta statusKlienta;
            nowyKlient.Id = Id;
            nowyKlient.Imie = Imie;
            nowyKlient.Nazwisko = Nazwisko;
            nowyKlient.Pesel = Pesel;
            nowyKlient.NrPrawaJazdy = NrPrawaJazdy;
            nowyKlient.haslo = haslo;
            nowyKlient.Email = Email;
            nowyKlient.login = login;
            nowyKlient.DataUrodzenia = dataUrodzenia;
            //Act

            bool ActuaklResult = Rejestracja.TworzenieNowegoPrfilu(nowyKlient, PlikBazaTestowa, powtorzoneHaslo, AkceptacjaRegulaminu, ref komunikat);

            //Assert
            Assert.AreEqual(expectedResult, ActuaklResult);
        }
        [TestMethod]
        public void PoprawneDaneRejestracjiTest3()
        {
            //C:\Users\wikto\Desktop\3 semestr\Inżynieria Oprogramowania1\BazaDanychDoTestow
            // Arrange
            bool expectedResult = true;
            OtwieranieNowychOkien Rejestracja = new OtwieranieNowychOkien();
            Klient nowyKlient = new Klient();
            string PlikBazaTestowa = @"..\..\..\BazaDanychDoTestow\UserListTest.csv";
            bool AkceptacjaRegulaminu = true;
            string powtorzoneHaslo = "12341234";
            int Id = 0;
            string Imie = "Jan";
            string Nazwisko = "Kowalski";
            string Pesel = "85225874211";
            string NrPrawaJazdy = "X7896549";
            string haslo = "12341234";
            string Email = "janKowalski22@gmail.com";
            string login = "Janjan222";
            string komunikat = "";
            DateTime dataUrodzenia = new DateTime(1999, 1, 13); ;

            StatusKlienta statusKlienta;
            nowyKlient.Id = Id;
            nowyKlient.Imie = Imie;
            nowyKlient.Nazwisko = Nazwisko;
            nowyKlient.Pesel = Pesel;
            nowyKlient.NrPrawaJazdy = NrPrawaJazdy;
            nowyKlient.haslo = haslo;
            nowyKlient.Email = Email;
            nowyKlient.login = login;
            nowyKlient.DataUrodzenia = dataUrodzenia;
            //Act

            bool ActuaklResult = Rejestracja.TworzenieNowegoPrfilu(nowyKlient, PlikBazaTestowa, powtorzoneHaslo, AkceptacjaRegulaminu, ref komunikat);

            //Assert
            Assert.AreEqual(expectedResult, ActuaklResult);
        }
        [TestMethod]
        public void ZlyEmailTest4()
        {
            //C:\Users\wikto\Desktop\3 semestr\Inżynieria Oprogramowania1\BazaDanychDoTestow
            // Arrange
            bool expectedResult = false;
            OtwieranieNowychOkien Rejestracja = new OtwieranieNowychOkien();
            Klient nowyKlient = new Klient();
            string PlikBazaTestowa = @"..\..\..\BazaDanychDoTestow\UserListTest.csv";
            bool AkceptacjaRegulaminu = true;
            string powtorzoneHaslo = "12341234";
            int Id = 0;
            string Imie = "Jan";
            string Nazwisko = "Kowalski";
            string Pesel = "85225874115";
            string NrPrawaJazdy = "X7896543";
            string haslo = "12341234";
            string Email = "janKowalski22gmail.com";
            string login = "Janjan222";
            string komunikat = "";
            DateTime dataUrodzenia = new DateTime(1999, 1, 13); ;

            StatusKlienta statusKlienta;
            nowyKlient.Id = Id;
            nowyKlient.Imie = Imie;
            nowyKlient.Nazwisko = Nazwisko;
            nowyKlient.Pesel = Pesel;
            nowyKlient.NrPrawaJazdy = NrPrawaJazdy;
            nowyKlient.haslo = haslo;
            nowyKlient.Email = Email;
            nowyKlient.login = login;
            nowyKlient.DataUrodzenia = dataUrodzenia;
            //Act

            bool ActuaklResult = Rejestracja.TworzenieNowegoPrfilu(nowyKlient, PlikBazaTestowa, powtorzoneHaslo, AkceptacjaRegulaminu, ref komunikat);

            //Assert
            Assert.AreEqual(expectedResult, ActuaklResult);
        }
        [TestMethod]
        public void BrakAkceptacjiRegulaminuTest5()
        {
            //C:\Users\wikto\Desktop\3 semestr\Inżynieria Oprogramowania1\BazaDanychDoTestow
            // Arrange
            bool expectedResult = false;
            OtwieranieNowychOkien Rejestracja = new OtwieranieNowychOkien();
            Klient nowyKlient = new Klient();
            string PlikBazaTestowa = @"..\..\..\BazaDanychDoTestow\UserListTest.csv";
            bool AkceptacjaRegulaminu = false;
            string powtorzoneHaslo = "12341234";
            int Id = 0;
            string Imie = "Jan";
            string Nazwisko = "Kowalski";
            string Pesel = "85225874116";
            string NrPrawaJazdy = "X7896222";
            string haslo = "12341234";
            string Email = "janKowalski22gmail.com";
            string login = "Janjan222";
            string komunikat = "";
            DateTime dataUrodzenia = new DateTime(1999, 1, 13); ;

            StatusKlienta statusKlienta;
            nowyKlient.Id = Id;
            nowyKlient.Imie = Imie;
            nowyKlient.Nazwisko = Nazwisko;
            nowyKlient.Pesel = Pesel;
            nowyKlient.NrPrawaJazdy = NrPrawaJazdy;
            nowyKlient.haslo = haslo;
            nowyKlient.Email = Email;
            nowyKlient.login = login;
            nowyKlient.DataUrodzenia = dataUrodzenia;
            //Act

            bool ActuaklResult = Rejestracja.TworzenieNowegoPrfilu(nowyKlient, PlikBazaTestowa, powtorzoneHaslo, AkceptacjaRegulaminu, ref komunikat);

            //Assert
            Assert.AreEqual(expectedResult, ActuaklResult);
        }
        [TestMethod]
        public void IstniejacyPeselTest6()
        {
            //C:\Users\wikto\Desktop\3 semestr\Inżynieria Oprogramowania1\BazaDanychDoTestow
            // Arrange
            bool expectedResult = false;
            OtwieranieNowychOkien Rejestracja = new OtwieranieNowychOkien();
            Klient nowyKlient = new Klient();
            string PlikBazaTestowa = @"..\..\..\BazaDanychDoTestow\UserListTest.csv";
            bool AkceptacjaRegulaminu = true;
            string powtorzoneHaslo = "12341234";
            int Id = 0;
            string Imie = "Jan";
            string Nazwisko = "Kowalski";
            string Pesel = "85225874117";
            string NrPrawaJazdy = "X7896533";
            string haslo = "12341234";
            string Email = "janKowalski22@gmail.com";
            string login = "Janjan222";
            string komunikat = "";
            DateTime dataUrodzenia = new DateTime(1999, 1, 13); ;

            StatusKlienta statusKlienta;
            nowyKlient.Id = Id;
            nowyKlient.Imie = Imie;
            nowyKlient.Nazwisko = Nazwisko;
            nowyKlient.Pesel = Pesel;
            nowyKlient.NrPrawaJazdy = NrPrawaJazdy;
            nowyKlient.haslo = haslo;
            nowyKlient.Email = Email;
            nowyKlient.login = login;
            nowyKlient.DataUrodzenia = dataUrodzenia;
            //Act

            bool ActuaklResult = Rejestracja.TworzenieNowegoPrfilu(nowyKlient, PlikBazaTestowa, powtorzoneHaslo, AkceptacjaRegulaminu, ref komunikat);

            //Assert
            Assert.AreEqual(expectedResult, ActuaklResult);
        }
        [TestMethod]
        public void IstaniejacyNumerPrawaJazdyTest7()
        {
            //C:\Users\wikto\Desktop\3 semestr\Inżynieria Oprogramowania1\BazaDanychDoTestow
            // Arrange
            bool expectedResult = false;
            OtwieranieNowychOkien Rejestracja = new OtwieranieNowychOkien();
            Klient nowyKlient = new Klient();
            string PlikBazaTestowa = @"..\..\..\BazaDanychDoTestow\UserListTest.csv";
            bool AkceptacjaRegulaminu = true;
            string powtorzoneHaslo = "12341234";
            int Id = 0;
            string Imie = "Marek";
            string Nazwisko = "Kowalski";
            string Pesel = "85225874118";
            string NrPrawaJazdy = "X7896541";
            string haslo = "12341234";
            string Email = "marekKowalski23@gmail.com";
            string login = "marekmarek23";
            string komunikat = "";
            DateTime dataUrodzenia = new DateTime(1996, 1, 13); ;

            StatusKlienta statusKlienta;
            nowyKlient.Id = Id;
            nowyKlient.Imie = Imie;
            nowyKlient.Nazwisko = Nazwisko;
            nowyKlient.Pesel = Pesel;
            nowyKlient.NrPrawaJazdy = NrPrawaJazdy;
            nowyKlient.haslo = haslo;
            nowyKlient.Email = Email;
            nowyKlient.login = login;
            nowyKlient.DataUrodzenia = dataUrodzenia;
            //Act

            bool ActuaklResult = Rejestracja.TworzenieNowegoPrfilu(nowyKlient, PlikBazaTestowa, powtorzoneHaslo, AkceptacjaRegulaminu, ref komunikat);

            //Assert
            Assert.AreEqual(expectedResult, ActuaklResult);
        }
        [TestMethod]
        public void IstaniejacyLoginTest8()
        {
            //C:\Users\wikto\Desktop\3 semestr\Inżynieria Oprogramowania1\BazaDanychDoTestow
            // Arrange
            bool expectedResult = false;
            OtwieranieNowychOkien Rejestracja = new OtwieranieNowychOkien();
            Klient nowyKlient = new Klient();
            string PlikBazaTestowa = @"..\..\..\BazaDanychDoTestow\UserListTest.csv";
            bool AkceptacjaRegulaminu = true;
            string powtorzoneHaslo = "12341234";
            int Id = 0;
            string Imie = "Marek";
            string Nazwisko = "Kowalski";
            string Pesel = "85225874119";
            string NrPrawaJazdy = "X7896541";
            string haslo = "12341234";
            string Email = "marekKowalski22@gmail.com";
            string login = "butybutybuty";
            string komunikat = "";
            DateTime dataUrodzenia = new DateTime(1996, 1, 13); ;

            StatusKlienta statusKlienta;
            nowyKlient.Id = Id;
            nowyKlient.Imie = Imie;
            nowyKlient.Nazwisko = Nazwisko;
            nowyKlient.Pesel = Pesel;
            nowyKlient.NrPrawaJazdy = NrPrawaJazdy;
            nowyKlient.haslo = haslo;
            nowyKlient.Email = Email;
            nowyKlient.login = login;
            nowyKlient.DataUrodzenia = dataUrodzenia;
            //Act

            bool ActuaklResult = Rejestracja.TworzenieNowegoPrfilu(nowyKlient, PlikBazaTestowa, powtorzoneHaslo, AkceptacjaRegulaminu, ref komunikat);

            //Assert
            Assert.AreEqual(expectedResult, ActuaklResult);
        }
        [TestMethod]
        public void BlednyFormatPrawaJazdyTest9()
        {
            //C:\Users\wikto\Desktop\3 semestr\Inżynieria Oprogramowania1\BazaDanychDoTestow
            // Arrange
            bool expectedResult = false;
            OtwieranieNowychOkien Rejestracja = new OtwieranieNowychOkien();
            Klient nowyKlient = new Klient();
            string PlikBazaTestowa = @"..\..\..\BazaDanychDoTestow\UserListTest.csv";
            bool AkceptacjaRegulaminu = true;
            string powtorzoneHaslo = "12341234";
            int Id = 0;
            string Imie = "Marek";
            string Nazwisko = "Kowalski";
            string Pesel = "85225874120";
            string NrPrawaJazdy = "X789";
            string haslo = "12341234";
            string Email = "marekKowalski22@gmail.com";
            string login = "marus222";
            string komunikat = "";
            DateTime dataUrodzenia = new DateTime(1996, 1, 13); ;

            StatusKlienta statusKlienta;
            nowyKlient.Id = Id;
            nowyKlient.Imie = Imie;
            nowyKlient.Nazwisko = Nazwisko;
            nowyKlient.Pesel = Pesel;
            nowyKlient.NrPrawaJazdy = NrPrawaJazdy;
            nowyKlient.haslo = haslo;
            nowyKlient.Email = Email;
            nowyKlient.login = login;
            nowyKlient.DataUrodzenia = dataUrodzenia;
            //Act

            bool ActuaklResult = Rejestracja.TworzenieNowegoPrfilu(nowyKlient, PlikBazaTestowa, powtorzoneHaslo, AkceptacjaRegulaminu, ref komunikat);

            //Assert
            Assert.AreEqual(expectedResult, ActuaklResult);
        }
    }
}
