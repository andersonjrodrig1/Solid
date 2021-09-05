using Demo.Principle.Solid.SRP.DALL;
using Demo.Principle.Solid.SRP.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Principle.Solid.SRP.Repositories
{
    public class StudentRepository
    {
        private readonly StudentDao _studentDao;
        
        public StudentRepository()
        {
            _studentDao = new StudentDao();
        }

        public void AddStudent(Student student) => _studentDao.students.Add(student);
        public IList<Student> GetStudents() => _studentDao.students.ToList();
        public Student GetStudentById(int id) => _studentDao.students?.FirstOrDefault(s => s.Id == id);
    }
}
