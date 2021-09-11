using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Principle.Solid.ISP.Entity
{
    public class Email
    {
        public string Sender { get; set; }
        public string[] Destination { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
    }
}
