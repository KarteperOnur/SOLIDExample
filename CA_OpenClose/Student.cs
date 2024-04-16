using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCPBad
{
    public class Student
    {
        
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static void AddStudent() 
        { 
        Student student = new Student();
            student.ID = 1;
            student.FirstName = "Abc";
            student.LastName = "Cde";
        }


    }
}
