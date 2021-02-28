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

        private double weight;
        private double height;
        private string unitType;
        private string weightUnit;
        private string heightUnit;
        private double bmi;
        private object bmiMeaning;

        /// <summary>
        /// BMi Calculator Constructor
        /// </summary>
        public BmiCalculator()
        {
            bmi = 0;
            weight = 0.0;
            height = 0.0;

            unitType = null;
            weightUnit = null;
            heightUnit = null;
        }

        /// <summary>
        /// 
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

        private void OutputBmi()
        {
            Console.WriteLine($"\n {weight} {weightUnit}" +
                $" is {height} {heightUnit}");
            Console.WriteLine($"Your BMI is {bmi}!\n");
            Console.WriteLine($"This means you are {bmiMeaning}!");
        }

        private void BmiMeaning()
        {
            if(bmi <= 18.50)
            {
                bmiMeaning = UNDERWEIGHT;
            }
            else if(bmi >= 18.5 && bmi <= 24.9)
            {
                bmiMeaning = NORMAL;
            }
            else if(bmi >= 25.0 && bmi <= 29.9)
            {
                bmiMeaning = OVERWEIGHT;
            }
            else if(bmi >= 30.0 && bmi <= 34.9)
            {
                bmiMeaning = OBESE_CLASS_ONE
            }
            else if(bmi >= 35 && bmi <= 39.9)
            {
                bmiMeaning = OBESE_CLASS_TWO
            }
            else if(bmi >= 40)
            {
                bmiMeaning = OBESE_CLASS_THREE;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateBmi()
        {
            if(weightUnit == KILOGRAMS && heightUnit == METRES)
            {
                bmi = weight / (height * height);
               
            }
            else if(weightUnit == STONE && heightUnit == FEET)
            {
                bmi = ((weight * POUNDS_IN_STONE) * 703) / ((height * INCHES_IN_FEET) * (height * INCHES_IN_FEET));
            }

            bmi = Convert.ToInt32(bmi);
        }

        /// <summary>
        /// 
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
