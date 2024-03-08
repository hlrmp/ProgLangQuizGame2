using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgLangQuizGame2
{
    internal class GuesingGame
    {

        public static void Main(string[] args)
        {
            string Word1 = "cat";

            string[,] words = new string[,]
            {
                {
                    "cat"
                },
                {
                    "sun"
                },
                {
                    "run"
                },
                {
                    "dog"
                },
                {
                    "pen"
                },
                {
                    "chain"
                },
                {
                    "board"
                },
                {
                    "word"
                },
                {
                    "game"
                },
                {
                    "palm"
                }
            };

            string[,] line = new string[,]
            {
                {
                    " "
                },
                {
                    "-"
                },
                {
                    "--"
                },
                {
                    "---"
                },
                {
                    "----"
                },
                {
                    "-----"
                },
                {
                    "------"
                },
                {
                    "-------"
                },
                {
                    "--------"
                },
                {
                    "----------"
                }
            };


            bool take = true;
            int times = 1;
            int score = 0;
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Guess the Word based on the letters provided");
                Console.WriteLine("                               ");
                Console.ResetColor();


                do
                {

                    Random rand = new Random();
                    int randomNumber = rand.Next(1, 10);
                    string randomWord = words[randomNumber, 0];

                    int guessWordLength = randomWord.Length;
                    int gw = guessWordLength -  1;

                  
                    int len = guessWordLength - 2;

                    Console.ForegroundColor = ConsoleColor.Green;
                    string NumberOfLines = line[len, 0];
                    Console.ResetColor();

                    string guesWordTextLast = randomWord.Substring(gw);
                    string guesWordTextFirst = randomWord.Substring(0, 1);



                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Clue: ");
                    Console.WriteLine("This is "+ guessWordLength + " Letter Word");
                    Console.ResetColor();

                  
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(guesWordTextFirst + NumberOfLines + guesWordTextLast);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    string answer = Console.ReadLine();
                    Console.ResetColor();
                    Console.WriteLine("                               ");




                    if (randomWord == answer.ToLower())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("correct !!!");
                        Console.ResetColor();
                        Console.WriteLine("                               ");

                        score++;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wromg !!!");
                        Console.ResetColor();
                        Console.WriteLine("                               ");


                    }


                    Console.WriteLine("Finish press any key  , Procede press 1");
                    int pros = int.Parse(Console.ReadLine());

                    if (pros == 1)
                    {
                        times++;
                    }
                    else
                    {
                        take = false;
                    }


                }
                while (take == true);
                {
                                          



                }
            }
            catch (Exception e)
            {
                // Console.WriteLine("Error " + e.Message);

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("-------------------------------");
                Console.WriteLine("    Your Score: " + score + " / " + times + "          ");
                Console.WriteLine("    No. of Takes: " + times + "            ");
                Console.WriteLine("-------------------------------");
                Console.ResetColor();
                Console.WriteLine("                               ");


               


                // take = false;




            }



        }

        
    }
}
