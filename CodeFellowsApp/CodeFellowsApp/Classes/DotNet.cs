using System;
using System.Linq;

namespace CodeFellowsApp.Classes
{
    // The class is public which means it can be accessed from all assemblies and their derivatives 
    public class DotNet : Course
    {
        // Properties defined only in this derived class
        public string FrameWork { get; set; }
        public int CsharpVersion { get; set; }

        // Default constructor for Python class
        public DotNet(int code, string name, Instructor instructor)
        {
            this.Code = code;
            this.LanguageName = name;
            this.Instructor = instructor;
        }

        // Must override method since it's marked as an Abstract in the Course Class
        public override int CheckDifficulty(string[] technologiesUsed)
        {
            Console.WriteLine("The loveliest and easiest language on earth :)... 1 out of 10 is the difficulty level.");
            return 1;
        }

        // Optional overriding method because it's marked as Virtual in the Course class .. This method offers discount to students
        public sealed override int Discount(int percentage)
        {
            int extraDiscount = 10;

            // If more than 20 students, offer extra discount
            if (this.StudentsEnrolled != null && this.StudentsEnrolled.Length > 20)
            {
                return base.Discount(percentage) + extraDiscount / 100;
            }
            return base.Discount(percentage);
        }

        // Overriding method from course class
        public override bool CheckDayIfThereIsClass(string day)
        {
            return this.ClassDays.Contains(day);
        }
    }
}
