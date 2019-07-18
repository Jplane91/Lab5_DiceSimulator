using System;

namespace DiceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = SideGenerator();
            Console.WriteLine("You have chosen " + input + " sides to be on the dice\n");
            RollTheDice(input);
        }


        public static int SideGenerator() //Get input from user for the number of sides
        {
            Console.WriteLine("How many sides would you like to be on each dice?");
            return int.Parse(Console.ReadLine());
        }

        static void RollTheDice(int input)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Would you like to roll the dice? (Yes or No)");
                string userAnswer = Console.ReadLine().ToLower();


                if (userAnswer == "yes" || userAnswer == "y")
                {
                    bool go = true;
                    while (go)
                    {
                        Random random = new Random();
                        int sides = input + 1;
                        int num1 = random.Next(1, sides);
                        int num2 = random.Next(1, sides);
                        Console.WriteLine("\nThe first die is " + num1);
                        Console.WriteLine("\nThe second die is " + num2);

                        if (num1 == 1 && num1 == 1)
                        {
                            Console.WriteLine("You rolled snake eyes");
                            go = true;
                        }

                        else if (num1 == 6 && num2 == 6)
                        {
                            Console.WriteLine("You rolled box cars");
                            go = true;

                        }

                        else
                        {
                            go = true;
                        }

                        Console.WriteLine("\nWould you like to roll again?");
                        string userAnswer1 = Console.ReadLine().ToLower();
                        if (userAnswer1 == "yes" || userAnswer1 == "y")
                        {
                            go = true;
                        }

                        else if (userAnswer1 == "no" || userAnswer1 == "n")
                        {
                            Console.WriteLine("Have a good day");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine("That wasn't an option");
                            Console.ReadKey();
                        }

                    }
                }

                else if (userAnswer == "no" || userAnswer == "n")
                {
                    Console.WriteLine("Have a good day");
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("That wasn't a valid option");
                    loop = true;
                }
            }

        }
    }

}

