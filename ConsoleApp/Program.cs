using System;

namespace ConsoleApp
{
// The job of this program is to calculate your meal prep time and
// give you the remaining time your food has to cook based off your
// preparation time, the number of minutes it takes to cook your food
// and how long your food has been cooking for.
// You should be able to use chef time as much as you want
// until you decide to quit the loop.

    
    class Program
    {
        static void Main(string[] args)
        {
            Cheftime cheftime = new Cheftime();
            Console.WriteLine("=========================================================================");
            Console.WriteLine("Welcome to Chef Time!");
            
            do
            {
                cheftime.userInfo();
                cheftime.resultToHours();
                cheftime.cookingTimeConversion();
                cheftime.mealPrepTimeConversion();
 
                Console.Write("Do you want to continue using Chef Time? (Y/N): ");
            } 
            while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine();
            Console.WriteLine("Thank you for using Chef Time!");
            Console.WriteLine("=========================================================================");
        }
    }
}