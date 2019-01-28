using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            string[] temp;
            StreamReader in_file = new StreamReader("C:\\temp\\Program.cs");
      
            while (!in_file.EndOfStream)
            {
                line = in_file.ReadLine();
               
                 char letter = (char)in_file.Read();
                Console.Write(letter);
                if (letter == '/' + '/')
                {
                    Console.WriteLine(letter);
                }
            }
            in_file.Close();


            Console.ReadKey();

        }//END MAIN
        static void splitText (string tempPath)
        {
            int count = 0;
            string Line = "";
            StreamReader in_file = new StreamReader(tempPath);
            while (!in_file.EndOfStream)
            {

                Line = Line + in_file.ReadLine() + " ";
            }//END WHILE
            in_file.Close();

            string[] splitText = Line.Split('/' );

            foreach (string word in splitText)
            {
                if (word.Contains("//"))
                {
                    count++;
                    
                    Console.WriteLine(word);

                }//END IF


            }//END FOREACH
            Console.WriteLine(count);
        }//END FUNCTION
    }//END CLASS
}//END NAMESPACE
