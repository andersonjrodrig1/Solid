using Demo.Principle.Solid.LSP.Abstract;

namespace Demo.Principle.Solid.LSP.Models
{
    public class Retangle : Figure
    {
        public Retangle(int height, int large) : base(height, large)
        {
        }

        public override int Area()
        {
            var result = Height * Large;

            return result;
        }
    }
}
