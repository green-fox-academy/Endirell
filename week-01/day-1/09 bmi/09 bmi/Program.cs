using System;


namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            //double massInKg = 81.2;
            //double heightInM = 1.78;

            Console.WriteLine("BMI Calculator for adults\n");

            Mass:                       
            Console.WriteLine("Your mass in Kilogramms:");
            string Kg = Console.ReadLine();
            double d;
            if (!Double.TryParse(Kg, out d))
            {
                Console.WriteLine("\nWrong input! Type in numbers\n");
                goto Mass;
            }
                  
            double massInKg = Convert.ToDouble(Kg);

            if (massInKg < 30)
            {
                Console.WriteLine("\nGo to the doctor ASAP!!!!\n");
                goto End;
            }
            if (massInKg > 300)
            {
                Console.WriteLine("\nGo to the doctor ASAP!!!!\n");
                goto End;
            }
            
            Height:
            Console.WriteLine("\nYour height in Meters:");
            string M = Console.ReadLine();
            double f;
            if (!Double.TryParse(Kg, out f))
            {
                Console.WriteLine("\nWrong input! Type in numbers\n");

                goto Height;
            }

            double heightInM = Convert.ToDouble(M);

            if (heightInM < 1.3 && heightInM >= 0.5)
            {
                Console.WriteLine("\nYou suffer from dwarfism, consult your doctor for your ideal weight\n");
                goto End;
            }


            if (heightInM < 0.5)
            {
                Console.WriteLine("\nYou are not a human specimen\n");
                goto End;
            }


            if (heightInM > 2.3 && heightInM <= 2.8)
            {
                Console.WriteLine("\nYou suffer from gigantism, consult your doctor for your ideal weight\n");
                goto End;
            }

            if (heightInM > 2.8)

            {
                Console.WriteLine("\nYou are not a human specimen\n");
                goto End;
            }

            double bmi = (massInKg / Math.Pow(heightInM, 2));

            double result = Math.Round(bmi, 2);


            Console.WriteLine("\nYour BMI is:");

            Console.WriteLine(result);


            if (bmi < 15)
            {
                Console.WriteLine("Very severely underweight!\nGo to the doctor ASAP!!!!\n");
            }

            if (bmi >= 15 && bmi <= 16)
            {
                Console.WriteLine("Severely underweight!\n");
            }

            if (bmi >= 15 && bmi <= 16)
            {
                Console.WriteLine("Severely underweight!\n");
            }

            if (bmi > 16 && bmi <= 18.5)
            {
                Console.WriteLine("Underweight\n");
            }

            if (bmi > 18.5 && bmi <= 25)
            {
                Console.WriteLine("Normal (healthy weight)\n");
            }

            if (bmi > 25 && bmi <= 30)
            {
                Console.WriteLine("Overweight\n");
            }

            if (bmi > 30 && bmi <= 35)
            {
                Console.WriteLine("Moderately obese\n");
            }

            if (bmi > 35 && bmi <= 40)
            {
                Console.WriteLine("Severely obese!\n");
            }

            if (bmi > 40)
            {
                Console.WriteLine("Very severely obese!\nGo to the doctor ASAP!!!!\n");
            }


            End:
            Console.WriteLine("Type Y for exit\nType R for calulate another BMI");
            string exit = Console.ReadLine();
            string exiter1 ="Y";
            string exiter2 = "y";
            string redo1 = "R";
            string redo2 = "r";

            if (exit.Equals(exiter1))
            {
                Console.WriteLine(" ");
                goto Final;
            }

            if (exit.Equals(exiter2))
            {
                Console.WriteLine(" ");
                goto Final;
            }

            if (exit.Equals(redo1))
            {
                Console.Clear();
                goto Mass;
            }

            if (exit.Equals(redo2))
            {
                Console.Clear();
                goto Mass;
            }

            else
            {
                Console.Clear();
                goto End;
            }

            Final:
            Console.Clear();
            //exit program somehow!!!

        }
    }
}