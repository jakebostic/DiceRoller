using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice Roller");
            Console.WriteLine();
       
            string choice = getChoice("Roll the dice? (y/n): ");
            while (choice.Equals("y"))
            {
                int die1 = rollDie();
                int die2 = rollDie();
                printDice(die1, die2);

                choice = getChoice("Roll again? (y/n): ");
            }
           
        }

        private static String getChoice(String prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private static int rollDie()
        {
            Random rnd = new Random();
            return (int)rnd.Next(1, 6) + 1;
        }

        private static void printDice(int die1, int die2)
        {
            int total = die1 + die2;
            Console.WriteLine();
            Console.Write("Die 1: " + die1 + "\n");
            Console.Write("Die 2: " + die2 + "\n");
            Console.Write("Total: " + total + "\n");
            specialMessage(total);
            Console.WriteLine();
        }

        private static void specialMessage(int total)
        {
            switch (total)
            {
                case 2:
                    Console.WriteLine("Snake Eyes!");
                    Console.WriteLine();
                    break;
                case 12:
                    Console.WriteLine("Boxcars!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
