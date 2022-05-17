using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS_31_Yovana_Ilieva_Upr2_working;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            foreach (var student in StudentData.TestStudents) {
                if(student.FNumber == user.facultyNumber)
                {
                    Console.WriteLine("Found student");
                    return student;
                }
            }

            return null;
        }
    }
}
