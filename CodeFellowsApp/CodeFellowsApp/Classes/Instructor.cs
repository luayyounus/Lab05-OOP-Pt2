using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    public class Instructor : Person
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

        // Overriding a virtual method
        public override int CountFavoriteSports()
        {
            return base.CountFavoriteSports() + this.LevelOfWillingnessToTeach;
        }

        // Override Watch Movie and sealing it to not be overriden
        public sealed override void WatchMovie()
        {
            Console.Write(this.Name != null ? $"{this.Name} loves Comedy movies!" : "Teachers don't watch movies");
        }
    }
}
