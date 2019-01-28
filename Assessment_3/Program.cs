using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assessment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string findfile = ("C:\\temp\\Practice.Dat");
            get_file_fromPath(findfile);
           

            Console.WriteLine(rectangleWords(get_file_fromPath(findfile)));

            Console.ReadKey();

            }//END MAIN
         static string rectangleWords (string input) {
            string temp = "";
            for (int i = 0; i < input.Length; i++){
                temp = temp + input[i];
                if (input[i] == 32)
                {
                   
                    Console.WriteLine();
                    Console.Write("*  " + temp + "  *");
                   
                }
                    
            }


            return temp;
        }
         static string get_file_fromPath(string path) {
             string line = "";
             StreamReader in_file = new StreamReader(path);
                   while (!in_file.EndOfStream){
                   line = in_file.ReadLine();
                   }
              in_file.Close();
              return line;
          }
    }//END CLASS
}//END NAMESPACE
