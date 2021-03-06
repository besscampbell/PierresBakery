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
            if (breadOrder.Loaves % 3 == 2)
            {
                Console.WriteLine("Are you sure you wouldn't like to get one more loaf? It would be free with our buy 2 get 1 free deal. If you would like to add another loaf press ['Y' for yes] or press ['Enter' for no].");
                string moreBread = Console.ReadLine();
                if (moreBread == "Y" || moreBread == "y")
                {
                    breadOrder.AddLoaf();
                }
            }
            breadOrder.TotalBread(); 
            if (breadOrder.Loaves >= 12)
            {
                breadOrder.AddLoaf();
                Console.WriteLine("Thanks for being such a great customer! Here's a loaf on me!");
            }
            Console.WriteLine("And how many pastries can I get you today?");
            string strPastries = Console.ReadLine();
            Pastry pastryOrder = new Pastry(int.Parse(strPastries));
            if (pastryOrder.Pastries % 3 == 2)
            {
                Console.WriteLine("Are you sure you wouldn't like to get one more pastry? It would cost only $1 more! If you would like to add another pastry press ['Y' for yes] or press ['Enter' for no].");
                string anotherPastry = Console.ReadLine();
                if (anotherPastry == "Y" || anotherPastry == "y")
                {
                    pastryOrder.AddPastry();
                }
            }
            pastryOrder.TotalPastries();
            if (pastryOrder.Pastries >= 12)
            {
                pastryOrder.AddPastry();
                Console.WriteLine("Thanks for being such a great customer! I threw and extra pastry in there for you!");
            }
            Console.WriteLine($"So that's {breadOrder.Loaves} loa{(breadOrder.Loaves == 1 ? "f" : "ves")} for ${breadOrder.BreadTotal} and {pastryOrder.Pastries} pastr{(pastryOrder.Pastries == 1 ? "y" : "ies")} for ${pastryOrder.PastryTotal} your total comes to ${breadOrder.BreadTotal + pastryOrder.PastryTotal}. Is that all for you today? Press ['Y' for yes] or press ['Enter' for no].");
            string finalQuestion = Console.ReadLine();
            if (finalQuestion == "Y" || finalQuestion == "y")
            {
                Console.WriteLine("Thank you so much for visiting Pierre's! We look forward to your next visit!");
            }
            else
            {
                Main();
            }
        }
    }
}