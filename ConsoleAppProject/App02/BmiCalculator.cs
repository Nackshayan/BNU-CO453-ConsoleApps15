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
        private int calculation;
        private int weight;
        private int height;
        private double bmi;

        /// <summary>
        /// Constructor for BmiConverter
        /// </summary>
        public BmiCalculator()
        {
            unitType = null;
            weightUnit = null;
            heightUnit = null;
            weight = 0;
            height = 0;
        }

        /// <summary>
        /// This method will output the Body Mass Index
        /// based on the data provided by the user.
        /// </summary>
        public void CalculateBodyMassIndex()
        {
            OutputHeading();

            unitType = SelectUnit(" Please select between Metric and Imperial > ");
                
            Console.WriteLine($"\n Calculating BMI using {unitType}");

            InputWeight($"\n Please enter your weight in {weightUnit} > ");
            InputHeight($"\n Please enter your height in {heightUnit} > ");

            CalculateBmi();
            OutputBodyMassIndex();
        }

        /// <summary>
        /// To calculate the Body Mass Index based on the
        /// 
        /// </summary>
        /// <returns></returns>
        private double CalculateBmi()
        {
            {
                if (unitType == METRIC)
                {
                    weightUnit = KILOGRAMS;
                    heightUnit = CENTIMETERS;

                   calculation = weight / ((height / 100) ^ 2);

                    bmi = Convert.ToInt32(calculation);
                }
                else if (unitType == IMPERIAL)
                {
                    weightUnit = STONE;
                    heightUnit = FEET;

                    calculation = (weight * 703) / (height ^ 2);

                    bmi = Convert.ToInt32(calculation);
                }
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
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
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
            Console.WriteLine($"\n {bmi}!");
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
