using Demo.Principle.Solid.SRP.Entities;
using Demo.Principle.Solid.SRP.Repositories;
using System.Collections.Generic;

namespace Demo.Principle.Solid.SRP.Services
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public void AddStudent(int studentId, string name)
        {
            var student = new Student
            {
                Id = studentId,
                Name = name
            };

            _studentRepository.AddStudent(student);
        }

        public IList<Student> GetStudents() => _studentRepository.GetStudents();
    }
}
