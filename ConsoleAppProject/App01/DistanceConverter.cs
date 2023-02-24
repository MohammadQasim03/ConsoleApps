using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// (1) Output a heading with the name of the application and the name
    /// of the programmer
    /// (2) Input any valid distance measured in miles
    /// (3) Convert that distance into feet
    /// (4) Output the equivalent distance in feet
    /// (5) Input a distancedistancein of feet and convert it to miles
    /// (6) Input a distance in miles and convert it to metres 
    /// </summary>
    /// <author>
    /// Mohammad Qasim Matloob 0.3
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";


        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// This Method will input the distance mesaured in miles
        /// Calculate the same Distance in feet, and output the
        /// Distance in Feet.
        /// </summary>
        /// 
        public void MilesToFeet()
        {
            OutputHeading($"Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Please enter the number of {fromUnit}> ");
            CalculateFeet();
            OutputDistance(fromDistance , fromUnit, toDistance , toUnit);

        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number.
        /// </summary>
        
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }


        /// <summary>
        /// 
        /// </summary>
        private void OutputDistance(
            Double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
          Console.WriteLine($" {fromDistance} {fromUnit} " +
              $"is {toDistance} {toUnit}!");
        }

        private void OutputHeading(string prompt)
        {
            Console.WriteLine("/n---------------------------------------------");
            Console.WriteLine("             Distance Converter       ");
            Console.WriteLine("           By Mohammad Qasim Matloob  ");
            Console.WriteLine("---------------------------------------------\n");


            Console.WriteLine(prompt);
            Console.WriteLine();


        }

    }
}
