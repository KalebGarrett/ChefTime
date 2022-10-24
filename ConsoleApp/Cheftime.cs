using System;

namespace ConsoleApp
{
    public class Cheftime
    {
        public double preparationTime = 0;
        public double expectedMinutes = 0;
        public double remainingMinutes = 0;
        public double cookingResult = 0;
        public double totalMealPrepTime = 0;
        public double cookingConversion = 0;
        public double mealPrepConversion = 0;

        public void userInfo()
        {
            Console.WriteLine();
            Console.Write("Enter the anticipated preparation time in minutes: ");
            preparationTime = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of minutes your food is supposed to be cooking: ");
            expectedMinutes = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of minutes your food has been cooking: ");
            remainingMinutes = Convert.ToDouble(Console.ReadLine());
            cookingResult = expectedMinutes - remainingMinutes;
            totalMealPrepTime = preparationTime + expectedMinutes;
        }

        public void resultToHours()
        {
            cookingConversion = cookingResult / 60;
            mealPrepConversion = totalMealPrepTime / 60;
        }

        public void cookingTimeConversion()
        {
            if (cookingResult < 60)
            {
                Console.WriteLine();
                Console.WriteLine("Your remaining cooking time: " + cookingResult + " minutes");
            }
            else if (cookingResult == 60)
            {   
                Console.WriteLine();
                Console.WriteLine("Your remaining cooking time: " + cookingConversion + " hour" );
            } 
            else
            {
                Console.WriteLine();
                Console.WriteLine("Your remaining cooking time: " + Math.Round(cookingConversion, 1) + " hours");
            }
        }    
            
        public void mealPrepTimeConversion()    
        { 
            if (totalMealPrepTime < 60)
            {
                Console.WriteLine("Your total meal prep time: " + totalMealPrepTime + " minutes");
            }
            else if (totalMealPrepTime == 60)
            {
                Console.WriteLine("Your total meal prep time: " + mealPrepConversion + " hour" );
            } 
            else
            {
                Console.WriteLine("Your total meal prep time: " + Math.Round(mealPrepConversion, 1) + " hours");
            } 
        }
    }
}