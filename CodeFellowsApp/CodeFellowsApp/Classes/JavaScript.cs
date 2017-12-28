using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    // The class is internal which means it's accessed inside the assembly - All classes in this solution
    internal class JavaScript : Course
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
    }
}
