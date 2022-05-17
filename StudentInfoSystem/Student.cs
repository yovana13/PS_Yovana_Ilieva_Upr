using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class Student
    {
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Speciality { get; set; }
        public string Degree { get; set; }
        public string Status { get; set; }
        public string FNumber { get; set; }
        public int Course { get; set; }
        public int Potok { get; set; }
        public int Group { get; set; }
        public int studentId { get; set; }

        public Student(string name, string middleName, string lastName, string faculty, string speciality, string degree, string status, string fNumber, int course, int potok, int group)
        {
            this.Name = name;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Faculty = faculty;
            this.Degree = degree;
            this.Speciality = speciality;
            this.Status = status;
            this.FNumber = fNumber;
            this.Course = course;
            this.Potok = potok;
            this.Group = group;

        }

        public static Student GetStudent()
        {
            var student = new Student("Ana", "Taseva", "Ilieva", "KSI", "FKST", "bakalavar", "redovno", "123219012", 3, 2, 31);
            return student;

        }
    }
}
