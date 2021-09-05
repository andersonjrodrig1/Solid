namespace Demo.Principle.Solid.OCP.Abstract
{
    public abstract class Figure
    {
        public double bs { get; set; }
        public double h { get; set; }

        public abstract double Area();
        public abstract double Perimeter();
    }
}
