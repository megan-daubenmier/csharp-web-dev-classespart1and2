﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Course Subject { get; set; }
        public int YearsTeaching { get; set; }

        public Teacher(string firstName, string lastName, Course subject, int numYears)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
            this.YearsTeaching = numYears;
        }
    }
}
