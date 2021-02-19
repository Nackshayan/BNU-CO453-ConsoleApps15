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
        public const double METRES_IN_MILES = 1609.34;

        private double feet;
        private double miles;
        private double metres;

        /// <summary>
        /// Call methods for converting miles to feet
        /// </summary>       
        public void ConvertMilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Call methods for converting feets to miles
        /// </summary>  
        public void ConvertFeetToMiles()
        {
            OutputHeading();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        /// <summary>
        /// Call methods for converting miles to metres
        /// </summary>  
        public void ConvertMilesToMetres()
        {
            OutputHeading();
            InputMiles();
            CalculateMetres();
            OutputMetres();
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
        /// Prompt the user to enter the distance in feet
        /// Input the feet as a double number
        /// </summary>
        private void InputFeet()
        {
            Console.WriteLine("Please enter the number of feet >");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>  
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>  
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles are " + feet + " feet!");
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet are " + miles + " miles!");
        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles are " + metres + " metres!");
        }

        /// <summary>
        /// Print method to print a heading for the Distance Converter
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n ****************************** ");
            Console.WriteLine("        Distance Converter        ");
            Console.WriteLine("          by Kate Gordon          ");
            Console.WriteLine(" ****************************** \n");
        }
    }

}
