using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bronze bronze = new Bronze("Jelena", "Cvetkovic", 0);
                Silver silver = new Silver("Jelena", "Cvetkovic", 600);
                Gold gold = new Gold("Jelena", "Cvetkovic", 1500);
                Console.WriteLine(bronze.Purchase(150));
                Console.WriteLine(silver.Purchase(850));
                Console.WriteLine(gold.Purchase(1300));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
