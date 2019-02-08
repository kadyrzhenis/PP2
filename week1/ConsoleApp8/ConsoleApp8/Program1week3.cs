using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 using System.Threading.Tasks;  
 
 namespace Example6
{ 
     class Program
     { /// <summary>
     /// САНДАРДЫ ДУБЛИКАТТАП ШЫҒАРУ
     /// </summary>
     /// <param name="args"></param>
         static void Main(string[] args)
         {
            int n = int.Parse(Console.ReadLine());//САН ЕНГІЗУ
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');//АРАСЫ ПРОБЕЛМЕН КЕЛГЕН САНДАРДЫ ЖАЗУ
          

            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < 2; ++j)//САНДАРДЫ ДУБЛИКАТТАДЫҚ
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.ReadKey();
              
         } 
     } 
 } 
