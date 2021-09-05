using Demo.Principle.Solid.SRP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Principle.Solid.SRP.DALL
{
    public class StudentDao : BaseDao<Student>
    {
        public IList<Student> students = new List<Student>();
    }
}
