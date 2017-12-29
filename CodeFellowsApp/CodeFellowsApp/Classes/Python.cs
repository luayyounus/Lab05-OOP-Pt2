using System;
using System.Linq;

namespace CodeFellowsApp.Classes
{
    internal class Python : Course
    {
        // Properties defined only in this derived class
        public string Name { get; set; }
        public bool NoSemiColon { get; set; }
        public int LifeSpan { get; set; }
        public bool Rating { get; set; }

        // Default constructor for Python class
        public Python(byte code, string name, Instructor instructor)
        {
            this.Code = code;
            this.Name = name;
            this.Instructor = instructor;
        }

        // The method is Sealed which means we can't override it any further even if this class is Abstract
        // The method is also overriden from the Course class since it's marked as Abstract over there
        public sealed override int CheckDifficulty(string[] technologiesUsed)
        {
            int level = technologiesUsed.Length;
            Console.WriteLine(level > 5
                ? "This class is hard based on the technologies entered."
                : "This class is a breeze. Go ahead and study it!");
            return level;
        }

        // Overriding method from course class
        public override bool CheckDayIfThereIsClass(string day)
        {
            return this.ClassDays.Contains(day);
        }

        // Method defined only in the class - It returns false by default or true if assigned
        public bool CheckIfPythonIsPopular()
        {
            return this.Rating;
        }
    }
}
