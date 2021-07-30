using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student myStudent1 = new Student("Megan Daubenmier", 001, 1, 4.0);
            //myStudent1.AddGrade(3, 3.4);
            //Console.WriteLine(myStudent.Gpa);
            Console.WriteLine(myStudent1.ToString());

            Student myStudent2 = new Student("Meg Daubenmier", 001, 1, 4.0);
            myStudent1.Equals(myStudent2);

            Teacher myTeacher1 = new Teacher("Mark", "Daubenmier", "CompSci", 30);

            List<Student> myStudents = new List<Student>();
            myStudents.Add(myStudent1);
            myStudents.Add(myStudent2);

            Course myCourse1 = new Course("CompSci")
            {
                Instructor = myTeacher1, 
                enrolledStudents = myStudents
            };

            Console.WriteLine(myCourse1.ToString());

    }
}
}
