using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhulJaSimSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand1 = new Random();
            Random rand2 = new Random();

            bool gateSwitch = true;
            string userInput = string.Empty;
            bool getInput = true;

            Console.WriteLine("*********************************************** \n Lets play KHUL JA SIM SIM............... \n***********************************************");
            while (true)
            {                
                Console.WriteLine("\nDo you trust your instincts and you always stick with your first choice? Give answer in yes or no. \nIf you want to exit the game, write exit");

                while (getInput)
                {
                    getInput = false;
                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "yes")
                    {
                        gateSwitch = false;
                    }
                    else if (userInput == "no")
                    {
                        gateSwitch = true;
                    }
                    else if (userInput == "exit")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input try again!!!!!!");
                        getInput = true;
                    }
                }

                long numOfTest = 0;
                Console.WriteLine("Ok!!!....Now tell me how many times you wanna play this game.Enter an whole number");

                getInput = true;
                while (getInput)
                {
                    getInput = false;
                    if (!long.TryParse(Console.ReadLine(), out numOfTest))
                    {
                        getInput = true;
                        Console.WriteLine("How can you get this wrong??...Just enter integer such as 20000000.Try again!!!!!");
                    }
                }

                if (numOfTest > 100000)
                    Console.WriteLine("Wait while we get your results for you");
                int carPos = 2;
                int choice = 0;
                long winCount = 0;
                for (long i = 0; i < numOfTest; i++)
                {
                    carPos = rand2.Next(1, 4);
                    choice = rand1.Next(1, 4);

                    if (gateSwitch)
                    {
                        if (carPos != choice)
                        {
                            winCount++;
                        }
                    }
                    else if (carPos == choice)
                    {
                        winCount++;
                    }
                }

                Console.WriteLine("You won {0} times out of {1}", winCount, numOfTest);
                Console.WriteLine("Your winning percentage is {0} %", (((double)winCount / numOfTest) * 100));
                Console.WriteLine("****************************************************");
            }
        }
    }
}

