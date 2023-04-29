using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaAut.Model;
using WypozyczalniaAut.Logic;

namespace WypozyczalniaAut.Logic
{
    public class Filtracja
    {//przykładowe filtry
        public static ParametryFiltracji parametryFiltrowania = new ParametryFiltracji();
        public static List<Samochód> Filter(ParametryFiltracji parametry, List<Samochód> wszystkiePojazdy)
        {
            List<Samochód> filtredList = new List<Samochód>();
            Garaż garaz = new Garaż();

            switch (parametry.garaż)
            {
                case "HALA1":
                    garaz = Garaż.HALA1;
                    break;
                case "HALA2":
                    garaz = Garaż.HALA2;
                    break;
                case "HALA3":
                    garaz = Garaż.HALA3;
                    break;
                case "Wypozyczono":
                    garaz = Garaż.Wypozyczono;
                    break;
                case "":
                    break;

            }
            foreach (Samochód pojazd in wszystkiePojazdy)
            {


                bool filterMarka = parametry.Marka == "" || pojazd.Marka ==parametry.Marka;
                bool filterModel = parametry.Model == "" || pojazd.Model ==parametry.Model;
                bool filterPojemnosc = parametry.Pojemnosc == 0 || (pojazd.PojemnoscSilnika <= (parametry.Pojemnosc+500) && pojazd.PojemnoscSilnika >= (parametry.Pojemnosc));
                bool filterGaraż = parametry.garaż == "" || pojazd.garażowanie == garaz;

                if (filterMarka& filterModel & filterPojemnosc & filterGaraż)
                {
                    filtredList.Add(pojazd);
                }
            }
            return filtredList;
        }

        public static List<string> Marki()
        {
            List<string> marki = new List<string>();
            int i = 0;
            bool NIEznalezionoWLiscie = false;
            foreach (Samochód auto in ObslugaBazy.ListaSamochodow)
            {

                if (i == 0)
                {
                    marki.Add(auto.Marka);
                }
                else
                {
                    foreach (string marka in marki)
                    {
                        if (marka == auto.Marka)
                        {
                            NIEznalezionoWLiscie = false;
                        }
                        else
                        {
                            NIEznalezionoWLiscie = true;
                        }
                    }

                }
                if (NIEznalezionoWLiscie == true)
                {
                    marki.Add(auto.Marka);
                }
            }

            return marki;
        }

        public static List<string> Modele()
        {   
            List<string> modele = new List<string>();
            int i = 0;
            bool NIEznalezionoWLiscie = false;
            foreach (Samochód auto in ObslugaBazy.ListaSamochodow) 
            {

                if (i == 0)
                {
                    modele.Add(auto.Model);
                }
                else
                { 
                    foreach(string model in modele)
                    {
                        if (model == auto.Model)
                        {
                            NIEznalezionoWLiscie = false;
                        }
                        else
                        {
                            NIEznalezionoWLiscie = true;
                        }
                    }
                    
                }
                if (NIEznalezionoWLiscie == true)
                {
                    modele.Add(auto.Model);
                }
            }
            return modele;
        }

        public static List<decimal> PojemnosciDolneGranice()
        {
            List<decimal> pojemnosc = new List<decimal>();
            for (decimal i = 1000; i < 5600; i += 500)
            {
                pojemnosc.Add(i);
            }
            return pojemnosc;

        }

        public static List<string> garaz()
        {
            List<string> garaz = new List<string>();
            garaz.Add(Garaż.HALA1.ToString());
            garaz.Add(Garaż.HALA2.ToString());
            garaz.Add(Garaż.HALA3.ToString());
            garaz.Add(Garaż.Wypozyczono.ToString());
            return garaz;
        }


    }
}
