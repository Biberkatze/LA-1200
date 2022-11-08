using System;
using System.Diagnostics.Tracing;
using System.IO;

namespace LA_1200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inPathG = @"List_G.txt";
            string inPathE = @"List_E.txt";
            string textG = File.ReadAllText(inPathG);
            string textE = File.ReadAllText(inPathE);
            string[] linesG = textG.Split("\r\n");
            string[] linesE = textE.Split("\r\n");
            List<int> gaggao = new List<int>();
            //List<string> WrongWords = new List<string>();
            String[] answers = new string[20];
            int counter = 0;
            int wordcounter = 0;

            Console.WriteLine("Welcome to this Vacabluary learning Programm!");
            Console.WriteLine("Translate the following words to german.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

            bool learning = true;
            
            while(learning)
            {
                Random number = new Random();  //random rumber
                int x = number.Next(1, 21);
                x -= 1;
                if (gaggao.Contains(x))
                {
                }
                else
                {
                    Console.WriteLine(linesE[x]);
                    gaggao.Add(x);
                    string answer = Console.ReadLine();
                    if (answer == linesG[x])
                    {
                        Console.WriteLine("Your answer is correct :)");
                        counter++;
                        wordcounter++;
                        answers[x] = answer;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is false :(");
                        wordcounter++;
                        //WrongWords.Add(answer);
                        answers[x] = answer;
                    }
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                    if(wordcounter == 20)
                    {
                        learning = false;
                        Console.WriteLine("Score: " + counter + "/20");
                        Console.WriteLine("Your wrong answers:");
                        //WrongWords.ForEach(Console.WriteLine);
                        for(int i = 0; i < answers.Length; i++)
                        {
                            Console.WriteLine(answers[i] + "  |  " + linesG[i]);
                        }

                        Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Doyou want to try again? [y|n]");
                        bool again = true;
                        while(again)
                        {
                            try
                            {
                                answer = Console.ReadLine();
                                if (answer != "y" && answer != "n")
                                {
                                    throw new Exception();
                                }
                                if (answer == "y")
                                {
                                    learning = true;
                                }
                                again = false;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input, please try again.");
                            }
                        }
                    }  
                }
            }
        }
    }
}