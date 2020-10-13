using System;

namespace App_1
{
    class Program
    {
        public static int score = 0;
        public static void Main()
        {
          choice();
            Console.ReadLine();
        }
        public static void choice()
        {
            Console.Clear();
            Console.WriteLine("Game Menu");
            Console.WriteLine("press 1 for Game 1- multiple choice questions");
            Console.WriteLine("2 Game 2");
            Console.WriteLine("3 Game 3");
            Console.WriteLine("0 Exit Game menu system");
            Console.Write("Enter a number 0-3 to choose a Game: ");
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
            Question1();
            Question2();
            Question3();
            Console.WriteLine("Your total score is " + score);
            Console.ReadLine();
        }

        public static void Question1()
        {
            Console.WriteLine("What's the first prime number");
            Console.WriteLine("a) 1");
            Console.WriteLine("b) 2");
            Console.WriteLine("c) 3");
            Console.WriteLine("d) 0");
            Console.WriteLine("Enter your option character(e.g-a/b/c/d)");
            
            char answer = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            if (answer == 'b')
            {
                score = score + 1;
            }
            Console.WriteLine("");

        }
        public static void Question2()
        {
            Console.WriteLine("Calculate 3+6-244+334*0");
            Console.WriteLine("a) 239");
            Console.WriteLine("b) 99");
            Console.WriteLine("c) 0");
            Console.WriteLine("d) 576");
            Console.WriteLine("Enter your option character(e.g-a/b/c/d)");
            char answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'c')
            {
                score = score + 1;
            }
            Console.WriteLine("");
        }
        public static void Question3()
        {
            Console.WriteLine("Round 4.875 to one decimal point ");
            Console.WriteLine("a) 4.9");
            Console.WriteLine("b) 4.7");
            Console.WriteLine("c) 5.0");
            Console.WriteLine("d) 4.5");
            Console.WriteLine("Enter your option character(e.g-a/b/c/d)");
            char answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'a')
            {
                score = score + 1;
            }
            Console.WriteLine("");
            Console.WriteLine("");
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
        
    }
}
