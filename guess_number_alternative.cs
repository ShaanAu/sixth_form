using System;

namespace CVGFR
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool noExit = true;
            while (noExit)
            {

                Random random1 = new Random();
                int points = 0;
                int min = 1;
                int max = 1000;

                int[] myArray = new int[10];
                for (int i = 0; i < myArray.Length; i++)
                {
                    
                    myArray[i] = random1.Next(min, max + 1);

                    Console.WriteLine(myArray[i]);
                    Console.WriteLine("Is the next number higher or lower, put h for higher or l for lower");
                    string answer_1 = Console.ReadLine();
                    if (myArray[i=i+1] < myArray[i] && answer_1 == "h")
                    {
                        points++;
                    }
                    if (myArray[i=i+1] > myArray[i] && answer_1 == "l")
                    {
                        points++;
                    }



                }

                Console.WriteLine("number of points you have are " + points);

                Console.WriteLine(" Do you want to exit ? ");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    noExit = false;
                }
                else
                {
                    noExit = true;
                }


            }
        }
    }
}




