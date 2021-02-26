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
        public class DistanceConverter
        {
            // constants
            public const string STONE = "Stone";
            public const string POUNDS = "Pounds";
            public const string KILOGRAMS = "Kilograms";

            public const string FEET = "Feet";
            public const string INCHES = "Inches";
            public const string CENTIMETERS = "Centimeters";
           

            // attributes
            private string unit;

            /// <summary>
            /// Constructor for Distance Converter
            /// </summary>
            public DistanceConverter()
            {
                unit = INCHES;
                unit = FEET;
            }

            /// <summary>
            /// This method will input the distance measured in miles
            /// calculate the same distance in feet, and output the
            /// distance in feet.
            /// </summary>       
            public void ConvertDistance()
            {
                OutputHeading();

                unit = SelectUnit(" Please select the from distance unit > ");
                unit = SelectUnit(" Please select the to distance unit > ");

                Console.WriteLine($"\n Converting {unit} to {unit}");

                fromDistance = InputDistance($"\n Please entre the number of {unit} > ");

                CalculateDistance();
                OutputDistance();
            }

            private void CalculateDistance()
            {
                if (unit == INCHES && unit == FEET)
                {
                    toDistance = fromDistance * FEET_IN_MILES;
                }
                else if (unit == FEET && unit == INCHES)
                {
                    toDistance = fromDistance / FEET_IN_MILES;
                }
                else if (unit == INCHES && unit == CENTIMETERS)
                {
                    toDistance = fromDistance * METRES_IN_MILES;
                }
                else if (unit == CENTIMETERS && unit == INCHES)
                {
                    toDistance = fromDistance / METRES_IN_MILES;
                }
                else if (unit == CENTIMETERS && unit == FEET)
                {
                    toDistance = fromDistance * FEET_IN_METRES;
                }
                else if (unit == FEET && unit == CENTIMETERS)
                {
                    toDistance = fromDistance / FEET_IN_METRES;
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
                    return FEET;
                }
                else if (choice.Equals("2"))
                {
                    return CENTIMETERS;
                }
                else if (choice.Equals("3"))
                {
                    return INCHES;
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
                Console.WriteLine($" 1. {FEET}");
                Console.WriteLine($" 2. {CENTIMETERS}");
                Console.WriteLine($" 3. {INCHES}");
                Console.WriteLine();

                Console.WriteLine(prompt);
                string choice = Console.ReadLine();
                return choice;
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
                Console.WriteLine($"\n {fromDistance} {unit}" +
                    $" is {toDistance} {unit}!\n");
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
}
}
