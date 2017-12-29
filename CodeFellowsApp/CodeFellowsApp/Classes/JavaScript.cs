using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFellowsApp.Classes
{
    // Class is set public which means it can be accessed from everywhere in the project and other projects
    public class JavaScript : Course
    {
        // Properties defined only in this derived class
        public int VersionTaught { get; set; }
        public string CurrentStack { get; set; }

        // Must override method since it's marked as an Abstract in the Course Class
        public override int CheckDifficulty(string[] technologiesUsed)
        {
            Console.WriteLine("This is an overriden method inside the JavaScript inherited from Course class. Abstract is cool and I will return -1.");
            return -1;
        }

        // Overriding method from course class
        public override bool CheckDayIfThereIsClass(string day)
        {
            return this.ClassDays.Contains(day);
        }
    }
}
