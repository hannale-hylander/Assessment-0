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

            Console.WriteLine("unordered");
            for(int i =0; i<test.Length; i++)
            {
                Console.Write(test[i]);
                
            }

            Console.WriteLine();
            BubbleSort(test);
            Console.WriteLine("");
            Console.WriteLine("ordered");
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i]);
            }
            // BubbleSort(test);

            Console.ReadKey();

        }//END MAIN

            
        

        static void BubbleSort(int[] CrazyArray) {
            bool sorted = false;
            while (!sorted) {
                sorted = true;
                for (int i =1; i < CrazyArray.Length; i++) { 
                      if (CrazyArray [i] < CrazyArray[i-1]) {
                         SwapArray(i, (i-1), CrazyArray);
                         sorted = false;
                      }
                }
            }
        }
            static int [] SwapArray(int i, int j, int[] ary_Numbers) {
            int temp = 0;
            temp = ary_Numbers[i];
            ary_Numbers[i] = ary_Numbers[j];
            ary_Numbers[j] = temp;
            return ary_Numbers;
        }

         

    }//END CLASS
}//END NAMESPACE
