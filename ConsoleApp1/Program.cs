﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Warrior
    {
        public int Health;
        public int Armor;
        public int Damage;
        public Warrior(int health, int armor, int damage)
        {
            Health = health;
            Armor = armor;
            Damage = damage;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }
        public void ShowInfo ()
        {
            Console.WriteLine(Health);
        }
    }
    class Knight : Warrior
    {
        public Knight (int health, int armor, int damage ) : base (health, armor, damage) { }
        public void Pray ()
        {
            Armor += 2;
            Health += 5;

        }
    }
    class Barbarian : Warrior
    {
        public Barbarian(int health, int armor, int damage, int attackSpeed) : base(health, armor, damage * attackSpeed) { }
        public void Shout()
        {
            Armor -= 2;
            Health += 10;
        }
        public void HelthStatus()
        {
            Console.WriteLine(Health);
        }

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Knight knight = new Knight(100,10,10);
            Barbarian barbarian = new Barbarian (100,10,10);

            knight.TakeDamage(40);
            barbarian.TakeDamage(50);

            Console.WriteLine("Здоровье рыцаря после атаки: ");
            knight.ShowInfo();

            Console.WriteLine("Здоровье варвара после атаки: ");
            barbarian.ShowInfo();    



        }
    }
        
}
