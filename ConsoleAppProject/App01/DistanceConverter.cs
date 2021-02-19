using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and will calculate and output
    /// the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Kate Gordon version 0.6
    /// </author>
    public class DistanceConverter
    {
        // constants
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        // attributes
        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        /// <summary>
        /// Constructor for Distance Converter
        /// </summary>
        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>       
        public void ConvertDistance()
        {
            OutputHeading($"Converting {fromUnit} to {toUnit}!\n");

            fromDistance = InputDistance($"Please entre the number of {fromUnit} > ");

            //CalculateMetres();
            OutputDistance();
        }

        /// <summary>
        /// Prompt the user to enter the fromDistance
        /// distance.
        /// Input the miles as a double number
        /// </summary>  
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// This method will output the dstance calculated
        /// by the conversion methods
        /// </summary>  
        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit}" +
                $" is {toDistance} {toUnit}!");
        }

        /// <summary>
        /// This method will output a heading for the 
        /// Distance Converter
        /// </summary>
        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n ****************************** ");
            Console.WriteLine("  ******************************  ");
            Console.WriteLine("        Distance Converter        ");
            Console.WriteLine("          by Kate Gordon          ");
            Console.WriteLine(" ******************************   ");
            Console.WriteLine(" ****************************** \n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }

}
