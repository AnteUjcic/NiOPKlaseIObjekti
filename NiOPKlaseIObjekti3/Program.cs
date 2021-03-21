using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiOPKlaseIObjekti3
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaX x = new KlasaX();
            for (x.index = 0; x.index < 100; x.index++)
            {
                x.array[x.index] = x.index + 1;
            }
            Console.WriteLine("50. broj u polju array = " + x.array[49]);
            


        }
    }
}
