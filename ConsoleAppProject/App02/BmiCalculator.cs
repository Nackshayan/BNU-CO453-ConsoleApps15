using System;
using System.Text;

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
        public const string Stone = "Stone";
        public const string Kilograms = "Kilograms";

        public const string Feet = "Feet";
        public const string Metres = "Metres";
    
        public const string Metric = "Metric";
        public const string Imperial = "Imperial";

        public const int PoundsInStone = 14;
        public const int CentimetresInMetres = 100;
        public const int InchesInFeet = 12;

        public const string Underweight = "Underweight";
        public const string Normal = "Normal";
        public const string Overweight = "Overweight";
        public const string ObeseClassOne = "Obese Class One";
        public const string ObeseClassTwo = "Obese Class Two";
        public const string ObeseClassThree = "Obese Class Three";

        public const double IndexUnderweight = 18.50;
        public const double IndexNormal = 24.90;
        public const double IndexOverweight = 29.90;
        public const double IndexObeseClassOne = 34.90;
        public const double IndexObeseClassTwo = 39.90;
        public const double IndexObeseClassThree = 40.00;

        public double Height { get; set; }
        public string UnitType { get; set; }
        public string WeightUnit { get; set; }
        public string HeightUnit { get; set; }
        public double Weight { get; set; }

        public double Index { get; set; }
        public string IndexMeaning;

        /// <summary>
        /// BMi Calculator Constructor
        /// </summary>
        public BmiCalculator()
        {
            Index = 0;
            Weight = 0.0;
            Height = 0.0;

            UnitType = null;
            WeightUnit = null;
            HeightUnit = null;
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

            UnitType = SelectUnitType($" Please select between {UnitTypes.Imperial} and {UnitTypes.Metric} units > ");

            Console.WriteLine($"\n Calculating BMI from {WeightUnit} and {HeightUnit}");

            Weight = InputWeight($"\n Please enter the weight in {WeightUnit} > ");
            Height = InputHeight($"\n Please enter the height  in {HeightUnit} > ");

            CalculateIndex();
            GetBmiMeaning();
            OutputBmi();
        }

        /// <summary>
        /// Method to output the BMI based on the imput weight and
        /// height in the selected units, to the user.
        /// </summary>
        private void OutputBmi()
        {
            Console.WriteLine($"\n Using the weight {Weight} {WeightUnit}" +
                $" and height {Height} {HeightUnit}");
            Console.WriteLine($" Your BMI is {Index}!\n");
            Console.WriteLine($" This means you are {IndexMeaning}!");
        }

        /// <summary>
        /// Method to find the users weight status based on their BMI
        /// </summary>
        public string GetBmiMeaning()
        {
            if (Index <= IndexUnderweight)
            {
                IndexMeaning = Underweight;
            }
            else if (Index >= IndexUnderweight && Index <= IndexNormal)
            {
                IndexMeaning = Normal;
            }
            else if (Index >= IndexNormal && Index <= IndexOverweight)
            {
                IndexMeaning = Overweight;
            }
            else if (Index >= IndexOverweight && Index <= IndexObeseClassOne)
            {
                IndexMeaning = ObeseClassOne;
            }
            else if (Index >= IndexObeseClassOne && Index <= IndexObeseClassTwo)
            {
                IndexMeaning = ObeseClassTwo;
            }
            else if (Index >= IndexObeseClassThree)
            {
                IndexMeaning = ObeseClassThree;
            }

            return IndexMeaning;
        }

        /// <summary>
        /// Method to calculate the BMI based on the input
        /// height and weight in the user selected units.
        /// </summary>
        private void CalculateIndex()
        {
            if(WeightUnit == Kilograms && HeightUnit == Metres)
            {
                Index = Weight / (Height * Height);
               
            }
            else if(WeightUnit == Stone && HeightUnit == Feet)
            {
                Index = ((Weight * PoundsInStone) * 703) / ((Height * InchesInFeet) * (Height * InchesInFeet));
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

            UnitType = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {UnitType}");
            return UnitType;
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
                HeightUnit = Metres;
                WeightUnit = Kilograms;
                return Metric;
            }
            else if (choice.Equals("2"))
            {
                HeightUnit = Feet;
                WeightUnit = Stone;
                return Imperial;
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
            Console.WriteLine($" 1. {Metric}");
            Console.WriteLine($" 2. {Imperial}");
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
