using System;

namespace App_1
{
    class Program
    {
        public static void Main()
        {
            choice();
            Console.ReadLine();
        }
        public static void choice()
        {
            Console.Clear();
            Console.WriteLine("Game Menu");
            Console.WriteLine("1 Game 1");
            Console.WriteLine("2 Game 2");
            Console.WriteLine("3 Game 3");
            Console.WriteLine("4 Game 4");
            Console.WriteLine("0 Exit Game menu system");
            Console.Write("Enter a number 1~4 to choose a Game: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Game1();
                    break;
                case "2":
                    Game2();
                    break;
                case "3":
                    Game3();
                    break;
                case "4":
                    Game4();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Thanks for using this menu system!");
                    break;
            }
        }
        public static void Game1()
        {
            Console.Clear();
            Console.WriteLine("This is Game 1");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            choice();
        }
        public static void Game2()
        {
            Console.Clear();
            Console.WriteLine("This is Game 2");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            choice();
        }
        public static void Game3()
        {
            Console.Clear();
            Console.WriteLine("This is Game 3");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            choice();
        }
        public static void Game4()
        {
            Console.Clear();
            Console.WriteLine("This is Game 4");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            choice();
        }
    }
}
