using System;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery! Today we have our famous country loaf for $5 or if you buy 2 you get 1 free. We also have the always delightful berry danish for $2 or 3 for $5.");
            Console.WriteLine("How many loaves of bread would you like?");
            string strLoaves = Console.ReadLine();
            Bread breadOrder = new Bread(int.Parse(strLoaves));
            Console.WriteLine("And how many pastries can I get you today?");
            string strPastries = Console.ReadLine();
            Pastry pastryOrder = new Pastry(int.Parse(strPastries));
            breadOrder.TotalBread();
            pastryOrder.TotalPastries();
            Console.WriteLine($"So that's {breadOrder.Loaves} loaves for ${breadOrder.BreadTotal} and {pastryOrder.PastryTotal} pastries for ${pastryOrder.PastryTotal} your total comes to ${breadOrder.BreadTotal + pastryOrder.PastryTotal}. Thank you so much for visiting Pierre's!");
        }
    }
}