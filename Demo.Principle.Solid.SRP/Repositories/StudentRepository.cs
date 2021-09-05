using Demo.Principle.Solid.SRP.DALL;
using Demo.Principle.Solid.SRP.Entities;
using System.Collections.Generic;

namespace Demo.Principle.Solid.SRP.Repositories
{
    public class StudentRepository
    {
        private readonly StudentDao _studentDao;
        
        public StudentRepository()
        {
            _studentDao = new StudentDao();
        }

        public void AddStudent(Student student) => _studentDao.Add(student);
        public IList<Student> GetStudents() => _studentDao.GetAll();
    }
}
