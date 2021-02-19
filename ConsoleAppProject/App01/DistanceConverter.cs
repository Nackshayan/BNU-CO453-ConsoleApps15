using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt a unser to input a unit of distance
    /// and will calculate and output the equivalent distance in
    /// a different unit.
    /// </summary>
    /// <author>
    /// Kate Gordon version 0.3
    /// </author>
    public class DistanceConverter
    {
        // constants
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;

        // attributes
        private double feet;
        private double miles;
        private double metres;

        /// <summary>
        /// Call methods for converting miles to feet
        /// </summary>       
        public void ConvertMilesToFeet()
        {
            OutputHeading();
            Console.WriteLine("Converting Miles to Feet!\n");
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Call methods for converting feet to miles
        /// </summary>  
        public void ConvertFeetToMiles()
        {
            OutputHeading();
            Console.WriteLine("Converting Feet to Miles!\n");
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
            Console.WriteLine("Converting Miles to Metres!\n");
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
        /// Method to calculate feet in miles
        /// </summary>  
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// Method to calculate miles in feet
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// Method to calculate metres in miles
        /// </summary>
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        /// <summary>
        /// Method to output feet
        /// </summary>  
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles are " + feet + " feet!");
        }

        /// <summary>
        /// Method to output miles
        /// </summary>  
        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet are " + miles + " miles!");
        }

        /// <summary>
        /// Method to output metres
        /// </summary>  
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
