using Demo.Principle.Solid.OCP.Abstract;

namespace Demo.Principle.Solid.OCP.Models
{
    public class Triangle : Figure
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public override double Area()
        {
            var area = (bs * h) / 2;

            return area;
        }

        public override double Perimeter()
        {
            var per = a + b + c;

            return per;
        }
    }
}
