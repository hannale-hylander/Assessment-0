using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesmnt_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            {
                Console.WriteLine("This program is designed to see if two words or numbers are palindrones,");
                Console.WriteLine("meaning that they are the same backwards and forwards");
                string userInput1 = prompt("Please enter the word or number");
                string userInput2 = userInput1;

                if (SameLengthCheck(userInput1, userInput2) == true)
                {
                    if (IsPalindrome(userInput1, userInput2) == true)
                    {
                        Console.WriteLine("Palindrones!");
                    }
                      else if (IsPalindrome(userInput1, userInput2) == false)
                      {
                              Console.WriteLine("Not palindrones");
                      }
                }
          

            }
            Console.ReadKey();
        }//END MAIN

        //FUNCTION FOR CHECKING TO SEE IF THEY ARE PALINDRONES
        static bool IsPalindrome(string test1, string test2) {

           if (backwards(test1) == test2){
                return true;
            }

            return false;
        }//END FUNCTION
        //BACKWARDS FUNCTION
        static string backwards(string x)
        {
            string word = "";
            for (int i = (x.Length - 1); i >= 0; i--)
            {
                word = word + x[i];
            }
            return word;

        }//END FUNCTION


        //FUNCTION FOR CHECKING TO SEE IF THEY ARE THE SAME LENGTH
        static bool SameLengthCheck(string test1, string test2)
        {
            if (test1.Length == test2.Length)
            {
                return true;
            }
            else {
                return false;
            }
        }//END FUNCTION
            static string prompt(string msg) {
            Console.WriteLine(msg + " ");
            return Console.ReadLine();
        }

    }//END CLASS
}//END NAMESPACE
