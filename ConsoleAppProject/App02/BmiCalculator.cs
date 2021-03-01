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
        public const string KILOGRAMS = "Kilograms";

        public const string FEET = "Feet";
        public const string METRES = "Metres";
    
        public const string METRIC = "Metric";
        public const string IMPERIAL = "Imperial";

        public const int POUNDS_IN_STONE = 14;
        public const int CENTIMETERS_IN_METRES = 100;
        public const int INCHES_IN_FEET = 12;

        public const string UNDERWEIGHT = "Underweight";
        public const string NORMAL = "Normal";
        public const string OVERWEIGHT = "Overweight";
        public const string OBESE_CLASS_ONE = "Obese Class One";
        public const string OBESE_CLASS_TWO = "Obese Class Two";
        public const string OBESE_CLASS_THREE = "Obese Class Three";

        private double Index;
        private object IndexMeaning;

        /// <summary>
        /// BMi Calculator Constructor
        /// </summary>
        public BmiCalculator()
        {
            Index = 0;
            weight = 0.0;
            height = 0.0;

            unitType = null;
            weightUnit = null;
            heightUnit = null;
        }

        /// <summary>
        /// This method will input the weight and height measured in
        /// metric or imperial units, calculate the BMI based on the 
        /// weight and height measurments, and output the
        /// BMI
        /// </summary>
        public void CalculateBodyMassIndex()
        {
            OutputHeading();

            unitType = SelectUnitType(" Please select between Imperical and Metric units > ");

            Console.WriteLine($"\n Calculating BMI from {weightUnit} and {heightUnit}");

            weight = InputWeight($"\n Please enter the weight in {weightUnit} > ");
            height = InputHeight($"\n Please enter the height  in {heightUnit} > ");

            CalculateBmi();
            OutputBmi();
        }

        /// <summary>
        /// Method to output the BMI based on the imput weight and
        /// height in the selected units, to the user.
        /// </summary>
        private void OutputBmi()
        {
            Console.WriteLine($"\n {weight} {weightUnit}" +
                $" is {height} {heightUnit}");
            Console.WriteLine($"Your BMI is {Index}!\n");
            Console.WriteLine($"This means you are {IndexMeaning}!");
        }

        /// <summary>
        /// Method to find the users weight status based on their BMI
        /// </summary>
        private void BmiMeaning()
        {
            if(Index <= 18.50)
            {
                IndexMeaning = UNDERWEIGHT;
            }
            else if(Index >= 18.5 && Index <= 24.9)
            {
                IndexMeaning = NORMAL;
            }
            else if(Index >= 25.0 && Index <= 29.9)
            {
                IndexMeaning = OVERWEIGHT;
            }
            else if(Index >= 30.0 && Index <= 34.9)
            {
                IndexMeaning = OBESE_CLASS_ONE;
            }
            else if(Index >= 35 && Index <= 39.9)
            {
                IndexMeaning = OBESE_CLASS_TWO;
            }
            else if(Index >= 40)
            {
                IndexMeaning = OBESE_CLASS_THREE;
            }
        }

        /// <summary>
        /// Method to calculate the BMI based on the input
        /// height and weight in the user selected units.
        /// </summary>
        private void CalculateBmi()
        {
            if(weightUnit == KILOGRAMS && heightUnit == METRES)
            {
                Index = weight / (height * height);
               
            }
            else if(weightUnit == STONE && heightUnit == FEET)
            {
                Index = ((weight * POUNDS_IN_STONE) * 703) / ((height * INCHES_IN_FEET) * (height * INCHES_IN_FEET));
            }

            Index = Convert.ToInt32(Index);
        }

        /// <summary>
        /// Display a menu of unit types to the user, prompt
        /// the user to select one and return it.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private string SelectUnitType(string prompt)
        {
            string choice = DisplayChoices(prompt);

            unitType = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unitType}");
            return unitType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                heightUnit = METRES;
                weightUnit = KILOGRAMS;
                return METRIC;
            }
            else if (choice.Equals("2"))
            {
                heightUnit = FEET;
                weightUnit = STONE;
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
        /// 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private string DisplayChoices(string prompt)
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
        /// 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private double InputHeight(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private double InputWeight(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
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
