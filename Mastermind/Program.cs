using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var UserNums = new List<int>();
            var computerNums = new List<int>();
            int randomNumber = new int();
            int turn = new int();

            Console.WriteLine("Welcome to MasterMind");
            Console.WriteLine("Guess a four digit number based on numbers from 1-6");
            Console.WriteLine("You have ten attempts to guess correctly");
            Console.WriteLine("Press any key to begin");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i <= 3; i++)
            {
                randomNumber = rand.Next(1, 6);
                computerNums.Add(randomNumber);
            }
            
            
            bool correctAnswer;
            turn = 1;

            do
            {
                turn++;
                correctAnswer = true;
                UserNums = new List<int>();

                for (int i = 0; i <= 3; i++)
                {
                    
                    Console.WriteLine("Guess a digit");
                    string userInput = Console.ReadLine();
                    UserNums.Add(Convert.ToInt32(userInput));
                }
                Console.ReadKey();

                foreach (var item in UserNums)
                {
                    Console.Write(item);
                    
                    
                }

                Console.WriteLine(" Were the numbers you entered" + " " + "Press any key to continue");
                Console.WriteLine("+ indicates right number and position, - means right number wrong postion, blank is both wrong");
                

                for (int i = 0; i <= 3; i++)
                {
                    if (UserNums[i] == computerNums[i])
                    {
                        Console.Write("+");
                    }

                    else if (computerNums.Contains(UserNums[i]))
                    {
                        correctAnswer = false;
                        Console.Write("-");
                    }

                    else
                    {
                        correctAnswer = false;
                        Console.Write(" ");
                    }

                    if (correctAnswer.Equals(true) && i == 3)
                    {
                        Console.WriteLine("Congrats you won!");
                        break;
                       
                    }

                    else if (turn == 11)
                    {
                        Console.WriteLine("Sorry, you lose");
                        break;
                    }
                } Console.WriteLine();
            } while (turn < 11 && correctAnswer == false);

            Console.WriteLine("Thanks for playing");
            Console.Write("Press any key to finish");
            Console.ReadKey(true);

        }
    }
}
