using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double preparationTime = 0;
                double expectedMinutes = 0;
                double remainingMinutes = 0;
                double cookingResult = 0;
                double totalMealPrepTime = 0;
                double hoursResult1 = 0;
                double hoursResult2 = 0;
            
                Console.WriteLine("=========================================================================");
                Console.WriteLine("Welcome to Chef Time!");
            
                Console.WriteLine();
                Console.Write("Enter the anticipated preparation time in minutes: ");
                preparationTime = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the number of minutes your food is supposed to be cooking: ");
                expectedMinutes = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the number of minutes your food has been cooking: ");
                remainingMinutes = Convert.ToDouble(Console.ReadLine());
                cookingResult = expectedMinutes - remainingMinutes;
                totalMealPrepTime = preparationTime + expectedMinutes;
            
                hoursResult1 = cookingResult / 60;
                hoursResult2 = totalMealPrepTime / 60;
            
                if (cookingResult < 60)
                {
                    Console.WriteLine();
                    Console.WriteLine("Your remaining cooking time: " + cookingResult + " minutes");
                }
                else if (cookingResult == 60)
                {   
                    Console.WriteLine();
                    Console.WriteLine("Your remaining cooking time: " + hoursResult1 + " hour" );
                } 
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Your remaining cooking time: " + Math.Round(hoursResult1, 1) + " hours");
                }

                if (totalMealPrepTime < 60)
                {
                    Console.WriteLine("Your total meal prep time: " + totalMealPrepTime + " minutes");
                }
                else if (totalMealPrepTime == 60)
                {
                    Console.WriteLine("Your total meal prep time: " + hoursResult2 + " hour" );
                } 
                else
                {
                    Console.WriteLine("Your total meal prep time: " + Math.Round(hoursResult2, 1) + " hours");
                } 
            
                Console.Write("Do you want to continue using Chef Time? (Y/N): ");   
                
            } while (Console.ReadLine().ToUpper() == "Y");
            
            Console.WriteLine();
            Console.WriteLine("Thank you for using Chef Time!");
            Console.WriteLine("=========================================================================");
        }
    }
}