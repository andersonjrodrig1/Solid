using Demo.Principle.Solid.LSP.Abstract;
using Demo.Principle.Solid.LSP.Models;
using System;

namespace Demo.Principle.Solid.LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(10, 10);
            var retangle = new Retangle(5, 10);

            ShowFigure("Quadrado", square);
            ShowFigure("Retangulo", retangle);

            Console.ReadKey();
        }

        private static void ShowFigure(string figureName, Figure figure) =>
            Console.WriteLine($"\nCalculo da área da figura: {figureName}\n" +
                $"Altura: {figure.Height}\n" +
                $"Largura: {figure.Large}\n" +
                $"Área: {figure.Area()}");
    }
}
