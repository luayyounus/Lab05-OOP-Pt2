using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    public class TeacherAssistant : Person
    {
        public string Role { get; set; }
        public bool RecentGraduate { get; set; }

        public string LevelOfWillingnessToTeach()
        {
            string ta =
                $"TAs are students' best friends, they try as hard as an instructor to clarify obscurity. Job Title inherited from Person is {this.JobTitle}";
            return ta;
        }

        // Overriden Method from Person
        public override void WatchMovie()
        {
            Console.WriteLine("TA are allowed partially to watch Tv");
        }
    }
}
