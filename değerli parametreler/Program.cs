using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace değerli_parametreler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sinifim s = new sinifim();
            s.selamla();
            s.selamla("samed");
        }
    }
    class sinifim
    {
        public void selamla(string ad = "samed")
        {
            Console.WriteLine("Merhaba :" + ad);
        }
    }
    
}
