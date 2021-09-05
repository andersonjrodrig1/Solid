using Demo.Principle.Solid.OCP.Abstract;
using System;

namespace Demo.Principle.Solid.OCP.Models
{
    public class Circle : Figure
    {
        public int r { get; set; }
        public int d { get; set; }

        public override double Area()
        {
            var area = Math.PI * Math.Pow(r, 2);

            return area;
        }

        public override double Perimeter()
        {
            var perimeter = Math.PI * r;

            return perimeter;
        }

        public double Diameter()
        {
            var diameter = 2 * r;

            return diameter;
        }
    }
}
