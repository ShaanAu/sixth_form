using System;

namespace newdom
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool noExit = true;
            while (noExit)
            {
                Random random1 = new Random();
                int min = 1;
                int max = 100;
                int rnum1 = random1.Next(min, max);

                int points = 200;
                int tries = 0;
                core:
                Console.WriteLine("Guess a random number between 1 and 100 ");
               int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > rnum1)
                {
                    Console.WriteLine("Your guess is higher");
                    tries = tries + 1;
                    points = points - 20;
                }
                else if (guess < rnum1)
                {
                    Console.WriteLine("Your guess is lower");
                    tries = tries + 1;
                    points = points - 20;
                }

                if (guess == rnum1)
                {
                    Console.WriteLine("Congragulations you have taken" + tries);
                    Console.Write("Number of points you have are" + points);
                }
                if (guess > rnum1 || guess < rnum1)
                {
                    goto core;
               }
            }

        }

    }
}
