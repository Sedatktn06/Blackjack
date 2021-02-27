using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Kart
    {
        public string turu;
        public string sayisi;
        public int puani;

        public void bilgiYaz()
        {
            Console.WriteLine("{0}-{1},p:{2}", turu, sayisi, puani);
            Console.ReadKey();
        }
    }
}
