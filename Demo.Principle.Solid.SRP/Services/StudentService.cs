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

        public void AddStudent(int id, string name)
        {
            var student = new Student
            {
                Id = id,
                Name = name
            };

            _studentRepository.AddStudent(student);
        }

        public Student GetStudentById(int id) => _studentRepository.GetStudentById(id);
        public IList<Student> GetStudents() => _studentRepository.GetStudents();
    }
}
