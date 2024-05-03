using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock___Paper___Scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputComputer;
            int randomInt;
            //int ScorePlayer = 0;
            //int ScoreComputer = 0;
            bool PlayAgain = true;

            while (PlayAgain)
            {
                int ScorePlayer = 0;
                int ScoreComputer = 0;


                while (ScorePlayer < 3 && ScoreComputer < 3)


                {



                    Console.Write("Input Your Choice:  ");
                    inputPlayer = Console.ReadLine();
                    //inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputComputer = "rock";
                            Console.WriteLine("Computer Choose Rock.");
                            if (inputPlayer == "rock")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Player Is Win!!\n\n");
                                ScorePlayer++;
                            }
                            else if (inputPlayer == "scissor")
                            {
                                Console.WriteLine("Computer Is Win...\n\n");
                                ScoreComputer++;
                            }
                            break;

                        case 2:

                            inputComputer = "paper";
                            Console.WriteLine("Computer Choose Paper.");

                            if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (inputPlayer == "rock")
                            {
                                Console.WriteLine("Computer Is Win!!\n\n");
                                ScoreComputer++;
                            }
                            else if (inputPlayer == "scissor")
                            {
                                Console.WriteLine("Player Is Win...\n\n");
                                ScorePlayer++;
                            }
                            break;

                        case 3:
                            inputComputer = "scissor";
                            Console.WriteLine("Computer Choose Scissor.");
                            if (inputPlayer == "scissor")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Computer Is Win!!\n\n");

                                ScoreComputer++;
                            }
                            else if (inputPlayer == "rock")
                            {
                                Console.WriteLine("Player Is Win..!!\n\n");
                                ScorePlayer++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid Entry!!");
                            break;


                    }

                    Console.WriteLine("\n\nScores:\t PLAYER:{0}\t COMPUTER:{1}\t ", ScorePlayer, ScoreComputer); 


                }

                Console.WriteLine($"Player Score {ScorePlayer}");
                Console.WriteLine($"Computer Score {ScoreComputer}");

                if (ScorePlayer == 3)
                {
                    Console.WriteLine("---------------\n PLAYER WON..!!!");
                }
                else if (ScoreComputer == 3)
                {
                    Console.WriteLine("---------------\n COMPUTER WON!!!...");
                }
                else
                {

                }
                Console.WriteLine("Do You Want To Play Again?! (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    PlayAgain = true;
                    Console.Clear(); //To Clear The Screen

                }
                else if (loop == "n")
                {
                    PlayAgain = false;
                }
               
            }

        }
    }


}
