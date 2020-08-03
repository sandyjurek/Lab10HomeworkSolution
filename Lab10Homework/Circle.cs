using System;

namespace Lab10Homework
{
    public class Circle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        private string FormatNumber(double x)
        {
            return Math.Round(x,2).ToString();
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
    }
}
