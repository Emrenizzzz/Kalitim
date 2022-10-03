using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Bitkiler:Canlilar
    {
        public void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void TohumlaUreme()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla ürerler.");
        }
    }
}
