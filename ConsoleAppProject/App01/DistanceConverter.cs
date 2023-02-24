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
            OutputHeading();

            Console.WriteLine("Converting Miles to Feet");
            Console.WriteLine();

            InputMiles();

            CalculateFeet();

            OutputFeet();

        }

        public void FeetToMiles()
        {
            OutputHeading();

            Console.WriteLine("Converting Feet to Miles");
            Console.WriteLine();

            InputMiles();

            CalculateFeet();

            OutputFeet();

        }

        public void MilesToMetres()
        {
            OutputHeading();

            InputMiles();

            CalculateFeet();

            OutputFeet();

        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number.
        /// </summary>
        
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void InputMetres()
        {
            Console.Write("Please enter the number of metres >");
            string value = Console.ReadLine();
            metres  = Convert.ToDouble(value);
        }



        private void InputFeet()
        {
            Console.Write("Please enter the number of feet >");
            string value = Console.ReadLine();
            feet  = Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void CalculateMetres()
        {
            metres = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is " + feet + "feet!");
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + "feet is " + feet + "miles!");
        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + "miles is " + metres  + "metres!");
        }

        private void OutputHeading()
        {
            Console.WriteLine("/n---------------------------------------------");
            Console.WriteLine("             Distance Converter       ");
            Console.WriteLine("           By Mohammad Qasim Matloob  ");
            Console.WriteLine("---------------------------------------------\n");


            Console.WriteLine("Converting Miles to Feet");
            Console.WriteLine();


        }

    }
}
