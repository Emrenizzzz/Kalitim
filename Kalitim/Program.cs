﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.FotosentezYapmak();
            tohumluBitki.TohumlaUreme();

            Console.WriteLine("*************************************");
            
            Kuslar kus = new Kuslar();
            kus.Adaptasyon();
            kus.Ucmak();

        }
    }
}
