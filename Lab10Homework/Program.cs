using System;
using System.Runtime.InteropServices;

namespace Lab10Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester!");
            Console.Write("Enter radius:  ");
            var radius = double.Parse(Console.ReadLine());

            //here I'm checking to see if the USER INPUT IS VALID - can't get it to work

            //double isInt = Double.TryParse(radius, out isInt);
            //if (!isInt)

            //{
            //    Console.WriteLine("Error - incorrect input - try again");
            //    return;
            //}

            //here I'm calling the objects from the Circle.cs class
            Circle circle1 = new Circle(radius);

            //here I'm printing the circumference and area
            Console.WriteLine($"Circumference:   {circle1.CalculateFormattedCircumference()}");
            Console.WriteLine($"Area:  {circle1.CalculateFormattedArea()}");

            //here I'm asking if they want to continue -- NEED TO FINISH THIS
            Console.WriteLine("Continue? (y/n): ");

        }
    }
}
