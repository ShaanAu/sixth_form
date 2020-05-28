using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompHw
{
    class MainClass
    {
        public static void error()
        {
            Console.WriteLine("Looks like the number of tickets you have purchased exceeds the maximun amount of tickets that can be purchased of 2");
        }
        public static void error1()
        {
            Console.WriteLine("Looks like you the number of tickets you wish to purchase doesn't exist");
        }
        public static void cancel()
        {
            Console.WriteLine("We are just going to need some details before cancelling your booking.");
            Console.WriteLine("Enter your name again");
            string name = Console.ReadLine();
            if (name1 == name)
            {
                Console.WriteLine("Now enter your email adress again");
                string email1 = Console.ReadLine();
                if (email1 == email)
                {
                    Console.WriteLine("enter phone number again");
                    int phonen = Convert.ToInt32(Console.ReadLine());
                    if (phonen == phone)
                    {
                        list.Remove(name1);
                        Console.WriteLine("You are no longer booked in");
                    }
                    else
                    {Console.WriteLine("better luck next time"); }

                }
                else
                {
                   Console.WriteLine("better luck nexxt time");
                }

            }
            else
            {
                Console.WriteLine("better luck next time");
            }
        }
        public static int tickets = 25;
        public static string name1;
        public static string email;
        public static int phone;
        public static List<string> list = new List<string>();

        static void Main(string[] args)
        {
          


            Console.WriteLine("Please enter how many tickets you wish to purchase");
            int no_tickets = Convert.ToInt32(Console.ReadLine());

            if (tickets - no_tickets < 0)
            {
                Console.WriteLine("Sorry it looks like we are out of tickets, better luck next time!");
            }

            if (no_tickets <= 0)
            {
                error1();
                return;
            }
            else if (no_tickets == 1 || no_tickets == 2)
            {
                Console.WriteLine("We just need to confirm some details with you");
                tickets = tickets - no_tickets;

            }
            else
            {
                error();
                return;
            }

            int tic = no_tickets;
            int tic2 = no_tickets;

            do
            {
            repeat1:
                Console.WriteLine("Enter your full name");
                name1 = Console.ReadLine();

                no_tickets--;
                if (name1.Length > 25)
                {
                    no_tickets++;
                    Console.WriteLine("Enter a name under 25 characters, as the named in unsuitable for our booking system.");
                    goto repeat1;
                }
                else
                {
                    list.Add(name1);
                }
            repeat:
                Console.WriteLine("Enter a Phone number we can contact you with");
                 phone = Convert.ToInt32(Console.ReadLine());
                tic--;
                if (phone.ToString().Length == 10)
                {
                    Console.WriteLine(phone.ToString() + " phone number is valid!");
                }
                else
                {
                    Console.WriteLine("phone number is invalid pleases try again using 10 numbers.");
                    tic++;
                    goto repeat;

                }
            repeat3:
                Console.WriteLine("Enter a valid email adress");
                 email = Console.ReadLine();
                tic2--;
                if (email.Contains("@"))
                {
                    Console.WriteLine(email + "is valid, well done");
                }
                else
                {
                    Console.WriteLine("Email adress is invalid, please enter a valid email adress which includes @.");
                    tic2++;
                    goto repeat3;
                }


            } while (no_tickets == 0 && tic == 0 && tic2 == 0);


            string lnam = string.Join(",", list.ToArray());
            Console.WriteLine(lnam);

            Console.WriteLine("Oops,did you make a mistake, would you like to cancel your booking, type in yes if you would like to?");
            string canceland = Console.ReadLine();

            if (canceland == "yes")
            {
                cancel();
            }

        }

    }
}