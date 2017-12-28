using System;

namespace CodeFellowsApp.Classes
{
    // The class is internal which means it's accessed inside the assembly - All classes in this solution
    internal class DotNet : Course
    {
        // Properties defined only in this derived class
        public string Name { get; set; }
        public string FrameWork { get; set; }
        public int CsharpVersion { get; set; }

        // Default constructor for Python class
        public DotNet(byte code, string name, Instructor instructor)
        {
            this.Code = code;
            this.Name = name;
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
            if (this.StudentsEnrolled.Length > 20)
            {
                return base.Discount(percentage) + extraDiscount / 100;
            }
            return base.Discount(percentage);
        }
    }
}
