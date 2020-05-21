using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionCode
{
    public class Triangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public Triangle()
        {

        }
        public Triangle(double a, double b, double c)
        {
            SetSides(a, b, c);
        }
        public void SetSides(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new FormatException();
            if ((a + b) < c)
                throw new ArgumentException();
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Area()
        {
            double per = (a + b + c) / 2;
            double area = Math.Sqrt(per * (per - a) * (per - b) * (per - c));
            return Math.Round(area, 2);
        }
        public static void Main(string[] args)
        {

        }
    }
}
