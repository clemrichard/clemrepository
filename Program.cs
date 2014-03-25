using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loto
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int[] monTab = new int{6};
            Console.WriteLine("LE LOTO\n");
            Console.WriteLine(System.DateTime.Now);
            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                monTab[i] = rand.Next();
                Console.WriteLine(monTab[i]);
            }
            

        }
    }
}
