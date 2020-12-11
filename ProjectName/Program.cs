using System;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery! Today we have my famous country loaf for $5 or if you buy 2 you get one free. We also have the always delightful berry danish for $2 or 3 for $5.");
            Console.WriteLine("How many loaves of bread would you like?");
            string strLoaves = Console.ReadLine();
            Bread breadOrder = new Bread(int.Parse(strLoaves)); 
            

        }
    }
}