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
            OutputHeading("Converting Miles to Feet!\n");
           
            miles = InputDistance("Please entre the number of miles > ");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        /// <summary>
        /// Call methods for converting feet to miles
        /// </summary>  
        public void ConvertFeetToMiles()
        {
            OutputHeading("Converting Feet to Miles!\n");

            feet = InputDistance("Please entre the number of feet > ");

            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        /// <summary>
        /// Call methods for converting miles to metres
        /// </summary>  
        public void ConvertMilesToMetres()
        {
            OutputHeading("Converting Miles to Metres!\n");

            miles = InputDistance("Please entre the number of miles > ");

            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>  
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
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
        private void OutputDistance(
            double fromDistance, string fromUnit, 
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit}" +
                $" is {toDistance} {toUnit}!");
        }

        /// <summary>
        /// Print method to print a heading for the Distance Converter
        /// </summary>
        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n ****************************** ");
            Console.WriteLine("        Distance Converter        ");
            Console.WriteLine("          by Kate Gordon          ");
            Console.WriteLine(" ****************************** \n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }

}
