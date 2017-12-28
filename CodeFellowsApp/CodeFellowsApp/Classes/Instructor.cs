using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    internal class Instructor : Person
    {
        public string FavoriteProgrammingLanguage { get; set; }
        public int LevelOfWillingnessToTeach { get; set; }
        public bool ComputerScienceDegreeHolder { get; set; }

        // Method for instructor class that inherits the Name from Person class
        public string TeachStudents(int numberOfStudents)
        {
            string teacherStatement = this.Name + " teaches " + numberOfStudents + " for this cohort.";
            return teacherStatement;
        }
    }
}
