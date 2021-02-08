using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blakjack
{
    class Oyun
    {
        Deste destemiz = new Deste();
        int o1p = 0;
        int o2p = 0;

        public void baslat()
        {
            destemiz.Olustur();
            destemiz.karistir();
        }

        public void oyna()
        {
            Kart o1k1 = destemiz.kartCek();
            Kart o2k1 = destemiz.kartCek();
            Kart o1k2 = destemiz.kartCek();
            Kart o2k2 = destemiz.kartCek();

            Console.WriteLine("Oyuncu1 eli \n------------");
            o1k1.bilgiYaz();
            o1k2.bilgiYaz();
            o1p = o1k1.puani + o1k2.puani;
            Console.WriteLine("Oyuncu1 toplam puan:" + o1p);

            Console.WriteLine("\nOyuncu2 eli \n------------");
            o2k1.bilgiYaz();
            o2k2.bilgiYaz();
            o2p = o2k1.puani + o2k2.puani;
            Console.WriteLine("Oyuncu2 toplam puan:" + o2p);

            Console.WriteLine("\nSonuç:");
            if (o1p > o2p)
                Console.WriteLine("oyuncu1 kazandı");
            else if (o2p > o1p)
                Console.WriteLine("oyuncu2 kazandi");
            else
                Console.WriteLine("puanlar esit");
            Console.ReadKey();

        }
    }
}
