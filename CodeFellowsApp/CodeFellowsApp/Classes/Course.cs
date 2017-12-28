using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    // The class is abstract which means it can not be instantiated but the derived classes will use its methods and properties
    internal abstract class Course : CodeFellows
    {
        // Properties to be assigned in the derived classes
        public byte Code { get; set; }
        public int CoursePrice { get; set; }
        public int CourseLengthInWeeks { get; set; }
        public string[] TechnologiesUsed { get; set; }
        public Student[] StudentsEnrolled { get; set; }
        public Instructor Instructor { get; set; }
        public TeacherAssistant[] TeacherAssistant { get; set; }

        // Defining Abstract Method to be implemented in the derived classes
        public abstract int CheckDifficulty(string[] technologiesUsed);

        // Virtual method implemented to be optionally used in the derived classes
        public virtual int Discount(int percentage)
        {
            // Return the price from this class property
            return this.CoursePrice * percentage / 100;
        }
    }
}
