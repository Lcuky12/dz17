using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceCrystal = 10;
            int gold;
            int purchase;

            Console.WriteLine(" Сколько кристаллов вам нужно? ");
            purchase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Сколько у вас золота? ");
            gold = Convert.ToInt32(Console.ReadLine());
            gold -= priceCrystal * purchase;
            Console.WriteLine(" У вас осталось золота " + gold);
            Console.WriteLine(" У вас кристаллов " + purchase);
        }
    }
}
