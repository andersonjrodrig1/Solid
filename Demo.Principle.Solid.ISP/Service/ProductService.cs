using Demo.Principle.Solid.ISP.Entity;
using Demo.Principle.Solid.ISP.Interface;
using System;

namespace Demo.Principle.Solid.ISP.Service
{
    public class ProductService : IProductService
    {
        public void RegisterProduct(Product product)
        {
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
    }
}
