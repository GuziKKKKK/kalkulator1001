using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator1001
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnozenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. SQRT");


                int menuOption = Convert.ToInt16(Console.ReadLine());
                if (menuOption == 0)
                {
                    break;
                }

                
            }
               
               
        }
    }
}
