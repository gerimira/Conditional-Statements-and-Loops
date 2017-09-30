using System;

namespace Theatre_Promotions
{
    class Program
    {
        public static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticketChildren = 0;
            int ticketAdults = 0;
            int ticketSeniors = 0;

            switch (day)
            {
                case "Weekday":
                    ticketChildren = 12;
                    ticketAdults = 18;
                    ticketSeniors = 12;
                    break;
                case "Weekend":
                    ticketChildren = 15;
                    ticketAdults = 20;
                    ticketSeniors = 15;
                    break;
                case "Holiday":
                    ticketChildren = 5;
                    ticketAdults = 12;
                    ticketSeniors = 10;
                    break;

            }

            if (age >= 0 && age <= 18)
            {
                Console.WriteLine($"{ticketChildren}$");
            }
            else if (age > 18 && age <= 64)
            {
                Console.WriteLine($"{ticketAdults}$");
            }
            else if (age > 64 && age <= 122)
            {
                Console.WriteLine($"{ticketSeniors}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }


        }
    }
}
