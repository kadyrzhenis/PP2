using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static bool IsPrime(int q)
        {
            bool ee = true;
            if (q == 1)
                return false;
            for(int i = 2; i < q; i++)
            {
                if (q % i == 0)
                {
                    ee = false;
                    return ee;
                }
       
            }
            return ee;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string s= Console.ReadLine();
            string[] arr = s.Split(' ');
            int[] array = new int[a];
            int qwe = 0;
            List<int> prime = new List<int>();
            for (int i = 0; i < a; i++)
            {
                array[i] = int.Parse(arr[i]);
                if (IsPrime(array[i]))
                {
                    prime.Add(array[i]);
                    qwe++;
                }
            }
            Console.WriteLine(qwe);
            for(int i = 0; i < qwe; i++)
            {
                Console.Write(prime[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
