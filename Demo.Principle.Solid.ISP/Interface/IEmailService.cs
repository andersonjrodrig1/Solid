using Demo.Principle.Solid.ISP.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Principle.Solid.ISP.Interface
{
    public interface IEmailService
    {
        void SenderEmail(Email email);
    }
}
