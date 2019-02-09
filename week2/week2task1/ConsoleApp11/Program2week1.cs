using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i -1])
                {
                    Console.WriteLine("No");

                }
                else
                {
                    Console.WriteLine("Yes");
                }
                Console.ReadKey();
            }
            
                }
                
            }
        }
   

