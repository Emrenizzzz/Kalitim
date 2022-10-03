using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Hayvanlar:Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon geçirirler.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.Beslenme();
            base.Solunum();
            base.Boşaltım();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçarlar.");
        }
    }
}
