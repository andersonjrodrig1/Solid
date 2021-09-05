using Demo.Principle.Solid.OCP.Abstract;
using System;

namespace Demo.Principle.Solid.OCP.Models
{
    public class Square : Figure
    {
        public int l { get; set; }

        public override double Area()
        {
            var area = Math.Pow(l, 2);

            return area;
        }

        public override double Perimeter()
        {
            var perimeter = 4 * l;

            return perimeter;
        }
    }
}
