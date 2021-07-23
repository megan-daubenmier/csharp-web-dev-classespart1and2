using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string Instructor { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }

        public Course(string instructor, string name, List<Student> students)
        {
            Instructor = instructor;
            CourseName = name;
            Students = students;
        }
    }
}
