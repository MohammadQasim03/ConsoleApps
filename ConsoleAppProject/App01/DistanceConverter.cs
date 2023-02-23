using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// (1) Output a heading with the name of the application and the name of the programmer
    /// (2) Input any valid distance measured in miles
    /// (3) Convert that distance into feet
    /// (4) Output the equivalent distance in feet
    /// (5) Input a distancedistancein of feet and convert it to miles
    /// (6) Input a distance in miles and convert it to metres 
    /// </summary>
    /// <author>
    /// Mohammad Qasim Matloob 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;


        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
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

        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {

        }
    }
}
