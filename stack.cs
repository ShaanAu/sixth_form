using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proceduralProgramming
{
    class Program
    {
        public const int MAXSIZE = 5;
        public static int[] data = new int[MAXSIZE];
        public static int stackTop;

        public static void Main(string[] args)
        {
            string menu;
            stackTop = -1;

            do
            {
                menu = showMenu();

                switch (menu())
                {   //push chosen
                    case 1:
                        
                            if (!stackFull())
                            {
                                pushData();
                            }
                            else
                            {
                                Console.WriteLine("Sorry, stack is full");
                            }
                            break;
                        
                        
                    //pop chosen
                    case 2:
                        
                            if (!stackEmpty())
                            {
                                popData();
                            }
                            else
                            {
                                Console.WriteLine("Sorry, stack is empty");
                            }
                            break;
                        
                    //display chosen
                    case 3:
                        
                            if (!stackEmpty())
                            {
                                showStack();
                            }
                            else
                            {
                                Console.WriteLine("Sorry, stack is empty");
                            }
                            break;

                }

            } while (menu == "x" && menu == "X");
            Console.WriteLine("Good bye");

        }
        //show the stack simulator menu and get choice from user
        public static string showMenu()
        {

            string option;
            Console.WriteLine("Stack Simulator");
            Console.WriteLine(" 1 - Push Data");
            Console.WriteLine(" 2 - Pop Data");
            Console.WriteLine(" 3 - Show Stack");
            Console.WriteLine(" X - Exit");
            Console.WriteLine("Enter Choice 1, 2, 3 or X");
            option = Console.ReadLine();
            return option;
        }

        //is the stack empty?
        public static bool stackEmpty()
        {
            if (stackTop == -1)
                return true;
            else
                return false;
        }

        //is the stack full?
        public static Boolean stackFull()
        {
            if (stackTop == (MAXSIZE - 1))
                return true;
            else
                return false;
        }

        //push data onto stack
        public static void pushData()
        {
            stackTop++;
            Console.WriteLine("Enter new data");

            data[stackTop] = Convert.ToInt32(Console.ReadLine());
        }

        //pop data from stack
        public static void popData()
        {
            int poppedData = data[stackTop];
            Console.WriteLine("Popped data is" + poppedData);
            stackTop--;
        }

        //display stack 
        public static void showStack()
        {
            Console.WriteLine("Stack top");
            for (int i = stackTop; i < 0; i--)
            {
                Console.WriteLine("The element at position " + i + " is " + data[i]);
            }
        }

    }
}


