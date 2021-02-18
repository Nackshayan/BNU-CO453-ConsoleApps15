using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App allows a user to easily convert a given distance
    /// from one unit of distance to another.
    /// This class offers methods for converting a given distance
    /// measured in miles to the equivallent distance in feet.
    /// </summary>
    /// <author>
    /// Kate Gordon version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        private double feet;
        private double miles;

        /// <summary>
        /// Call all other methods
        /// </summary>       
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>  
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>  
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>  
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }
    }

}
