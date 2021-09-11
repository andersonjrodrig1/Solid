using Demo.Principle.Solid.ISP.Entity;
using Demo.Principle.Solid.ISP.Interface;
using System;

namespace Demo.Principle.Solid.ISP.Service
{
    public class EmailService : IEmailService
    {
        public void SenderEmail(Email email)
        {
            Console.WriteLine("Email enviado!");
        }
    }
}
