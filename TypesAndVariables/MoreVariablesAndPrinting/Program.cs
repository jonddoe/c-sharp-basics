using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name, Eyes, Teeth, Hair;
            int Age, HeightInInches, WeightInLbs;
            double HeightInCms, WeightInKgs;

            Name = "Zed A. Shaw";
            Age = 35;
            HeightInInches = 74; // inches
            WeightInLbs = 180; // lbs
            HeightInCms = Math.Round(HeightInInches * 2.54, 2);
            WeightInKgs = Math.Round(WeightInLbs * 0.453592, 2);
            Eyes = "Blue";
            Teeth = "White";
            Hair = "Brown";

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + HeightInInches + " inches tall. Or " + HeightInCms + " centimeters tall.");
            Console.WriteLine("He's " + WeightInLbs + " pounds heavy. Or " + WeightInKgs + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + Age + ", " + HeightInInches + ", and " + WeightInLbs
                              + " I get " + (Age + HeightInInches + WeightInLbs) + ".");

            Console.ReadKey();
        }
    }
}