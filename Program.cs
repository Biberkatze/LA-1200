using System;
using System.IO;

namespace LA_1200
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string inPath = @"List.txt";
            string text = File.ReadAllText(inPath);
            string[] lines = text.Split(";");
            int mode;
            int i = 0;

            Console.WriteLine("Welcome to this Vacabluary learning Programm!");
            

            for (i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(";");
                Console.Write(words[0]);
            }



        }
    }
}