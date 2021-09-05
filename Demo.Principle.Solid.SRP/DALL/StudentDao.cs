using Demo.Principle.Solid.SRP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Principle.Solid.SRP.DALL
{
    public class StudentDao : BaseDao<Student>
    {
        public IList<Student> students = new List<Student>();

        public override void Add(Student student) => students.Add(student);
        public override void Remove(Student student) => students.Remove(student);
    }
}
