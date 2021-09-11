using Demo.Principle.Solid.LSP.Abstract;
using System;

namespace Demo.Principle.Solid.LSP.Models
{
    public class Square : Figure
    {
        public Square(int height, int large) : base(height, large)
        {
            if (height != large)
                throw new Exception("Os dois lados do quadrado precisam ser iguais");
        }

        public override int Area()
        {
            var result = Height * Large;

            return result;
        }
    }
}
