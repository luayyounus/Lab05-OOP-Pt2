using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    // Class is set public which means it can be accessed from everywhere in the project and other projects
    public class Cohort : CodeFellows
    {
        // Every cohort should include the following properties
        public DateTime StartDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public Instructor CurrentInstructor { get; set; }
        public Student[] CurrentStudents { get; set; }

        // Concrete method to calculate graduates, Null-coalesing is used in the method
        public int CalculateGraduates()
        {
            return CurrentStudents?.Length ?? 0;
        }
    }
}
