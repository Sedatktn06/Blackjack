﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {

            Oyun oyunumuz = new Oyun();
            oyunumuz.baslat();
            oyunumuz.oyna();

        }
    }
}
