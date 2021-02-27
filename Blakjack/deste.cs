using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deste
    {
        Kart[] kartlar = new Kart[52];
        int cekilenKS = 0;//cekilen kart sayisi;

        public void Olustur()
        {
            string[] turler = new string[4] { "Maca", "Sinek", "Kupa", "Karo" };
            string[] sayilar = new string[13] { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int[] puanlar = new int[13] { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 15, 20 };

            int k = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 13; j++)
                {
                    kartlar[k] = new Kart();
                    kartlar[k].turu = turler[i];
                    kartlar[k].sayisi = sayilar[j];
                    kartlar[k].puani = puanlar[j];
                    k++;
                }

        }

        public void desteYaz()
        {//test amaçlı

            for (int k = 0; k < 52; k++)
                kartlar[k].bilgiYaz();
        }

        public void karistir()
        {
            Random sayiGen = new Random();
            for (int k = 0; k < 52; k++)
            {
                int rIndis = sayiGen.Next(0, 52);
                Kart gecici = kartlar[k];
                kartlar[k] = kartlar[rIndis];
                kartlar[rIndis] = gecici;
            }
        }

        public Kart kartCek()
        {
            // return kartlar[cekilenKS++];
            return kartlar[cekilenKS++];


        }
    }
}
