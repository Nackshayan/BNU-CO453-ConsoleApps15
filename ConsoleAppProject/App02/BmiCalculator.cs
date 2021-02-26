using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This App calculates a users body mass index, which
    /// the user can then use to find out if there are any health
    /// risks that may apply.
    /// </summary>
    /// <author>
    /// Kate Gordon version 0.1
    /// </author>
    public class BmiCalculator
    {
        // constants
        public const string STONE = "Stone";
        public const string POUNDS = "Pounds";
        public const string KILOGRAMS = "Kilograms";

        public const string FEET = "Feet";
        public const string INCHES = "Inches";
        public const string CENTIMETERS = "Centimeters";

        public const string METRIC = "metric";
        public const string IMPERIAL = "Imperial";
           

        // attributes
        private string unitType;
        private string weightUnit;
        private string heightUnit;
        private int weight;
        private int height;
        private double BMI;

        /// <summary>
        /// Constructor for Distance Converter
        /// </summary>
        public BmiCalculator()
        {
            unitType = METRIC;
            weight = 0;
            height = 0;
        }

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>
        public void CalculateBodyMassIndex()
        {
            OutputHeading();

            unitType = SelectUnit(" Please select between Metric and Imperial > ");
                

            Console.WriteLine($"\n Calculating bmi in {unitType}");

                InputWeight($"\n Please enter your weight {weightUnit} > ");
                InputHeight($"\n Please enter your height {heightUnit} > ");

            CalculateBmi();
            OutputBodyMassIndex();
        }

        private void CalculateBmi()
        {
            if (unitType == METRIC)
            {
                BMI = weight/ ((height / 100)^2);
            }
            else if (unitType == IMPERIAL)
            {
                BMI = (weight * 703) / (height ^ 2);
            }     
        }

        /// <summary>
        /// Display a menu of distance units and then
        /// prompt the user to select one and return it.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unitType}");
            return unitType;
        }

        /// <summary>
        /// Returns the selected unit of distance
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private static string ExecuteChoice(string choice)
        {

            if (choice.Equals("1"))
            {
                return METRIC;
            }
            else if (choice.Equals("2"))
            {
                return IMPERIAL;
            }
            else
            {
                Console.WriteLine("\n Invalid Choice!");
                Console.WriteLine("\n Please use digits 1 to 3.");
                return null;
            }
        }

        /// <summary>
        /// This method displays the options to the user
        /// and prompts the user to select an option for
        /// both the from unit and to unit.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {METRIC}");
            Console.WriteLine($" 2. {IMPERIAL}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Prompt the user to enter their weight
        /// Input the weight as a whole number
        /// </summary>  
        private double InputWeight(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

        private double InputHeight(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

    /// <summary>
    /// This method will output the dstance calculated
    /// by the conversion methods
    /// </summary>  
    private void OutputBodyMassIndex()
        {
            Console.WriteLine($"\n {weight} {weightUnit}" +
                $"  {height} {heightUnit}\n");
            Console.WriteLine($"\n {BMI}!");
        }

        /// <summary>
        /// This method will output a heading for the 
        /// BMI Calculator
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n ****************************** ");
            Console.WriteLine(" ******************************  ");
            Console.WriteLine("       BMI Calculator        ");
            Console.WriteLine("         by Kate Gordon          ");
            Console.WriteLine(" ******************************   ");
            Console.WriteLine(" ****************************** \n");
        }
    }
}
