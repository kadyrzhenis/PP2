using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 using System.Threading.Tasks;  
 
 namespace Example6
{ 
     class Program
     { 
         static void Main(string[] args)
         {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');
            // int[] a = new int[n];

            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.ReadKey();
              
         } 
     } 
 } 
