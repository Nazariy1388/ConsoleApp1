using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Guy
    {
        public string Name;
        public int Cash;
        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash} bucks.");
        }
        public int GiveCash (int amount)
        {
            if (amount<= 0)
            {
                Console.WriteLine("It's not valid amount");
                return 0;
            }
            if (amount>Cash)
            {
                Console.WriteLine("I don't have enough cach to give you");
                return 0;
            }
            Cash = Cash - amount;
            return amount;
        }
        public void ResieveCash (int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("It's not valid amount");
            }
            else
            {
                Cash = Cash + amount;
            }
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            double odds = .75;
            Random random = new Random();
            Guy player = new Guy() { Cash = 100, Name = "The player" };
            Console.WriteLine("Welcome to the casino. The odds are" + odds );

            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.WriteLine("How much do you want to bet: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("You win" + winnings);
                            player.ResieveCash(winnings);
                        } else
                        {
                            Console.WriteLine("Bad luck, you lose.");
                        }
                    }
                } else
                {
                    Console.WriteLine("Plesae enter a valid number. ");
                }
            }
            Console.WriteLine("The house always wins. ");
        }
    }
}
