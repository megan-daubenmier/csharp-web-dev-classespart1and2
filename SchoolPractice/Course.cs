using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public Teacher Instructor { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }

        public Course(Teacher instructor, string name, List<Student> students)
        {
            Instructor = instructor;
            CourseName = name;
            Students = students;
        }
    }
}
