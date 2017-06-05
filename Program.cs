using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            string ss = "acabaabaabcacaa";
            string pp =      "abaabcac";
            var arrayss = ss.ToCharArray();
            var arraypp = pp.ToCharArray();
            string ss1 = string.Empty;
            for (int i = 0; i <= arrayss.Length-arraypp.Length; i++)
            {
                if(i==5)
                     ss1 = string.Empty;
                bool IsOk = true;
                for (int j = 0; j < arraypp.Length; j++)
                {
                    if (arrayss[i + j] != arraypp[j])
                    {
                        IsOk = false;
                        break; ;
                    }
                }
                if (IsOk)
                {
                    Console.Write(i + 1);
                    break;
                }
            }
            Console.ReadLine();
         
        }
    }
}
