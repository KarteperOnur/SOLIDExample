using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCPValid
{
    public class StudentRepository : IStudentRepository
    {
        public void AddStudent(Student student)
        {
            Student _student = new Student
            {
                ID = 1,
                FirstName = "Abc",
                LastName = "Cde"
            };
        }
    }
}
