using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentInfoSystem
{
    internal class StudentData
    {
        //public static List<Student> TestStudents = new List<Student>();
        public static List<Student> TestStudents { get; private set; }

        public static void AddStudents()
        {
            TestStudents.Add(new Student("Ana", "Taseva", "Ilieva", "KSI", "FCST", "bakalavar", "redovno", "123219012", 3, 2, 31));
        }

        public static Student checkStudent(string facNum)
        {
            StudentInfoContext context = new StudentInfoContext();
            Student result = (from st in context.Students where st.FNumber == facNum select st).First();
            return result;
        }
    }
}
