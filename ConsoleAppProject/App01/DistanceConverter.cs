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

        private double miles;

        private double feet;

        private double metres; 


        /// <summary>
        /// This Method will input the distance mesaured in miles
        /// Calculate the same Distance in feet, and output the
        /// Distance in Feet.
        /// </summary>
        /// 
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("Please enter the number of miles > ");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));

        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance("Please enter the number of feet > ");
            CalculateFeet();
            OutputDistance(feet , nameof(feet), miles, nameof(miles));

        }

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            metres  = InputDistance("Please enter the number of metre > ");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), metres , nameof(metres));

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
        private void alculateFeet()
        {
            feet  = miles * FEET_IN_MILES;
        }

        private void CalculateMiles()
        {
            miles = feet  * FEET_IN_MILES;
        }

        private void CalculateMetres()
        {
            metres = miles * FEET_IN_MILES;
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
