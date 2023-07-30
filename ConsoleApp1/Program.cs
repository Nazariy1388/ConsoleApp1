using System;
using System.Collections.Generic;
using System.Linq;
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
        public void ResiceCash (int amount)
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
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy bob = new Guy() { Cash = 100, Name = "Bob" };
           
            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();
                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.WriteLine("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ResiceCash(cashGiven);
                    }
                    else if (whichGuy == "Bob")
                    {
                        int cashGieven = bob.GiveCash(amount);
                        joe.ResiceCash(cashGieven);
                    }
                    else
                    {
                        Console.WriteLine("Pleas enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exitas;dlfj).");
                }
            }

        }
    }
}
