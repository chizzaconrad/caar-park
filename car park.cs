using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace car_park
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                List<double> prices = new List<double>();
                prices.Add(0);
                prices.Add(1.00);
                prices.Add(2.00);
                prices.Add(3.00);
                prices.Add(4.00);
                prices.Add(5.00);
                prices.Add(6.00);
                prices.Add(10.00);
                List<double> times = new List<double>();
                times.Add(0);
                times.Add(0.5);
                times.Add(1);
                times.Add(2);
                times.Add(3);
                times.Add(4);
                times.Add(6);
                times.Add(12);
                int x = 0;
                string answer = "";
                int choice = 0;
                string registration = "";
                do
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("###############################################\n\n W E L C O M E  T O  B O B ' S  C A R  P A R K \n\n###############################################\n");
                    Console.WriteLine("Please enter car registration");
                    registration = Console.ReadLine();
                    Console.WriteLine("registration entered: " + registration);
                    Console.WriteLine("is this correct?    (y/n)");
                    answer = Console.ReadLine();
                    if (answer == "n")
                    {
                        Console.WriteLine("");
                    }
                    if (answer == "y")
                    {
                        x = 1;
                    }
                } while (x == 0);
                do
                {


                    Console.WriteLine("Please select a duration:        (Enter a number 1-7)");
                    Console.WriteLine("1.\t\tUp to 30 mins\t\t£1\n2.\t\tUp to 1 hour\t\t£2\n3.\t\tUp to 2 hours\t\t£3\n4.\t\tUp to 3 hours\t\t£4\n5.\t\tUp to 4 hours\t\t£5\n6.\t\tUp to 6 hours\t\t£6\n7.\t\tUp to 12 hours\t\t£10");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("you would like to stay for " + times[choice] + " hours costing £" + prices[choice] + " Y/N");
                    answer = Console.ReadLine();
                    if (answer == "n")
                    {
                        x = 0;
                    }
                } while (x == 0);
                double coins = 0;
                Console.WriteLine("please enter coins to the value of £" + (prices[choice]));
                string amount = ("amount entered (£" + coins + ")");
                coins = double.Parse(Console.ReadLine());
                double change = coins - (prices[choice]);

                Console.WriteLine("your change is £" + change);
                Console.WriteLine("press enter to print your ticket");
                Console.ReadLine();
                Console.WriteLine("printing...");
                Thread.Sleep(2000);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(6, 3);
                Console.WriteLine("B O B ' S   C A R   P A R K");
                Console.SetCursorPosition(1, 6);
                Console.WriteLine("registration:  " + registration);
                Console.SetCursorPosition(1, 8);
                DateTime current = DateTime.Now;
                DateTime exit = current.AddHours(times[choice]);
                Console.WriteLine("Entry:" + current);
                Console.SetCursorPosition(1, 10);
                Console.WriteLine("Fee: £" + prices[choice]);
                Console.SetCursorPosition(1, 12);
                Console.WriteLine("expiry: " + exit);
                Console.SetCursorPosition(8, 15);
                Console.WriteLine("have a nice day!");
                Thread.Sleep(2000);
                Console.WriteLine("\nThank you for parking at Bob's Car Park, screen will refresh shortly.");
                Thread.Sleep(5000);
            }
            

        }
    }
}
