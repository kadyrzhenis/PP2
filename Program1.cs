using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {

        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                Console.Write("[*]");
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
