using System;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BmiCalculator
    {
        public const double OBESELEVELS = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;
        public double Index { get; set; }

        //Metric Details

        public double kilograms { get; set; }
        public int Centimetres { get; set; }

        //Imperial Details

        public int stones { get; set; }
        public int Inches { get; set; }


        private double metres;

        ///<sumary>
        ///Prompt the user to select Imperial or Metric
        ///units. Input the User's height and weight and
        ///then Calculate their BMI value.
        ///Output which weight category they fall into. 
        /// </sumary>
        public void CalculateIndex()
        {
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");
            UnitSystems unitSystems = SelectUnits();
            if (unitSystems == UnitSystems.Metric)
            {
                InputMetricDeatils();
                CalculateMetricBMI();
            }
            else
            {
                InputImperialDetails();
                CalculateImperialBMI();
            }

            Console.WriteLine(GetHealthMessage());
            Console.WriteLine(GetBameMesssage());

        }



            ///<summary>
            ///Prompt the user to select imperial or metric
            ///units for entering their weight and height
            /// </summary>

            private UnitSystems SelectUnits()
            {
                string[] choices = new string[]
                {
                    "Metric Units",
                    "Imperial Units"
                };

                int choice = ConsoleHelper.SelectChoice(choices);
                if (choice == 1)
                {
                    return UnitSystems.Metric
                }

                else return UnitSystems.Imperial;
            }

            ///<summary>
            ///Input the users height in feet and inches
            ///and their weight in stones and pounds
            /// </summary>

            private void InputImperialDetails()
            {
                Console.WriteLine(" Enter your Height to the nearest feet and inches ");
                Console.WriteLine();

                Feet = (int)ConsoleHelper.InputNumber("Enter your height in feet > ");
                Inches = (int)ConsoleHelper.InputNumber)"Enter your height in inches > ");

            Console.WriteLine();
            Console.WriteLine("Enter your weight to the nearest stones and pounds");
            Console.WriteLine();

            Stone = (int)ConsoleHelper.InputNumber("Enter your weight in stones > ");
            Pounds = (int)ConsoleHelper.InputNumber("Enter your weight in pounds > ");


        }

    
        public void CalculateMetricBMI()
        {
            Index = kilograms / (metres * metres);
        }

        public void CalculateImperailBMI()
        {
            Inches += Feet * InchesInFeet;
            Pounds += stones * PoundsInStones;

            Index = (double)Pounds * 703 / (Inches * Inches);
        }











        ///<summary>
        ///Input the Users height in metres and
        ///their weight in Kilograms
        /// </summary>

        private void InputMetricDeatils()
        {
            Centimetres = (int)ConsoleHelper.InputNumber("" +
                "\n Enter your height in centimetres > ");
            metres = (double)Centimetres / 100;

            kilograms = ConsoleHelper.InputNumber("" +
                "Enter your weight in kilograms > ");
        }

        ///<summary>
        ///Output the users BMi and their weight
        ///category from underweight to obese.
        /// </summary>
        public string GetHealthMessage()
        {
            StringBuilder message = new StringBuilder("\n");

            if (Index < Underweight)
            {
                message.Append($"Your BMI is {Index:0.00}," +
                    $"You are in the normal range!");
            }
            else if (Index <= NormalRange)
            {
                message.Append($" Your BMI is {Index:0.00}," +
                    $"You are in the normal range");
            }
            else if (Index <= Overweight)
            {
                message.Append($" Your BMI is {Index:0.00}," +
                    $"You are overweight!");
            }
            else if (Index <= obeselevel1)
            {
                message.Append($" Your BMI is {Index:0.00}," +
                   $"You are obese class I");
            }
            else if (Index <= obeselevel2)
            {
                message.Append($" Your BMI is {Index:0.00}," +
                   $"You are obese class II");
            }
            else if (Index <= obeselevel3)
            {
                message.Append($" Your BMI is {Index:0.00}," +
                   $"You are obese class III");
            }

            return message.ToString();

        }
        ///<summary>
        ///Output a message for BAE users who are
        ///at higher risk 
        /// </summary>

        public string GetBameMesssage()
        {
            StringBuilder message = new StringBuilder("\n");
            message.Append("If you are Black, Asian or other minority");
            message.Append("ethnic groups, you hae a higher risk");
            message.Append("\n");
            message.Append("\t Adults 23.0 or more are at increased risk");
        }



    }
}
