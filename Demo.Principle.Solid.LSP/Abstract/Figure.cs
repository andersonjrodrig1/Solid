namespace Demo.Principle.Solid.LSP.Abstract
{
    public abstract class Figure
    {
        public Figure(int height, int large)
        {
            Height = height;
            Large = large;
        }

        public int Height { get; set; }
        public int Large { get; set; }

        public abstract int Area();
    }
}
