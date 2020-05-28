using System;

namespace CompHWEASTER
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool replay = true;
            do
            {


                int succes = 0;
                int go = 0;
                string t = "t";
                string[,] array = new string[9, 9];

                Random looped = new Random();
                int loope = looped.Next(0, 101);

                for (int i = 0; i < loope; i++)
                {
                    Random xrand = new Random();
                    int xrandNum = xrand.Next(0, 10);
                    Random yrand = new Random();

                    int yrandNum = xrand.Next(0, 10);
                    t = array[xrandNum, yrandNum];
                }

                Console.WriteLine("Enter the x coordinate where you think x is");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the y coordinate where you think x is");
                int y = Convert.ToInt32(Console.ReadLine());

                string guess = array[x, y];

                if (guess == t)
                {
                    Console.WriteLine("Succes");
                    succes++;
                }
                else 
                {
                    Console.WriteLine("incorrect");
                }

                go++;

                if (go == 10)
                {
                    Console.WriteLine("no of treasure found is = " + succes);

                }



                Console.WriteLine("Would you like to quit");
                string ans = Console.ReadLine();

                if (ans == "yes")
                {
                    replay = false;
                }
            } while (replay == true);

        }
    }
}
