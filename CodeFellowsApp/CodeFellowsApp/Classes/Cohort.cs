using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    // The class is internal which means it's accessed inside the assembly
    internal class Cohort : CodeFellows
    {
        // Every cohort should include the following properties
        public DateTime StartDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public Instructor CurrentInstructor { get; set; }
        public Student[] CurrentStudents { get; set; }
    }
}
