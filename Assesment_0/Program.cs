using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_0
{
    class Program
    {
        static Random Rnd = new Random();
        static void Main(string[] args)
        {

            int[] test = { 0, 1, 1, 0, 1, 0, 1, 0, 0, 1 };
            SortArray(test);
            Console.ReadKey();

        }//END MAIN
        static void SortArray(int[] test1)
        {
            
            for (int i = 0; i < test1.Length; i++)
            {
                if (test1[i] == 0)
                {
                    Console.Write(test1[i]);
                }

                for (int j = 0; j < test1.Length; j++)
                {
                    if (test1[j] == 1) { }
                
                    Console.Write(test1[i]);
                }
            }
        }//END FUNCTION
    }//END CLASS
}//END NAMESPACE
