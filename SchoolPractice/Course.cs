using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }

        public Course(string topic)
        {
            Topic = topic;
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor) &&
                   EqualityComparer<List<Student>>.Default.Equals(enrolledStudents, course.enrolledStudents);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Instructor, enrolledStudents);
        }


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.

        public override string ToString()
        {
            string courseString = "Course: " + Topic + "\nTeacher: " + Instructor.FirstName + " " + Instructor.LastName + "\nStudents:\n";
            foreach (Student s in enrolledStudents)
            {
                courseString += s.Name + "\n";
            }
            return courseString;
        }
    }
}
