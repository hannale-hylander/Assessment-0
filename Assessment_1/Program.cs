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
        static void curseCount(string tempPath)
        {
            int count = 0;
            string Line = "";
            StreamReader in_file = new StreamReader(tempPath);
            while (!in_file.EndOfStream)
            {

                Line = Line + in_file.ReadLine() + " ";
            }//END WHILE
            in_file.Close();

            string[] splitText = Line.Split(' ', '\t', '\n');

            foreach (string word in splitText)
            {
                string testWord = word.ToLower();
                if (testWord.Contains("//")
                {
                    count++;
                    Console.WriteLine(testWord);

                }//END IF


            }//END FOREACH
            Console.WriteLine(count);
        }//END FUNCTION
    }//END CLASS
}//END NAMESPACE
