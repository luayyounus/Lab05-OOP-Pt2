using System;
using CodeFellowsApp.Classes;

namespace CodeFellowsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cohort is derived from Code Fellows - it is the class that holds properties of different class types
            Cohort dotNetCohort = new Cohort();

            Instructor amanda = new Instructor();
            amanda.Name = "Amanda";

            dotNetCohort.CurrentInstructor = amanda;
            dotNetCohort.GraduationDate = DateTime.Today;

            Student luay = new Student
            {
                Name = "Luay",
                Background = "Tennis",
                SocialPerson = true,
                Location = "Seattle"
            };
            Student ariel = new Student
            {
                Name = "Ariel",
                Background = "Tech",
                SocialPerson = true,
                Location = "Seattle"
            };
            Student jeff = new Student
            {
                Name = "Jeff",
                Background = "Media",
                SocialPerson = true,
                Location = "Seattle"
            };

            dotNetCohort.CurrentStudents = new Student[]{ luay, ariel, jeff };

            // Teacher assistant inherits from Person and Code Fellows base classes
            TeacherAssistant ta = new TeacherAssistant();
            ta.Name = "Austin";
            ta.Id = 29;
            ta.SchoolName = "Code Fellows";

            Console.WriteLine("\n Current Dot Net Cohort " +
                              "\n ---------------------");
            Console.Write($"\n Instructor: {dotNetCohort.CurrentInstructor.Name} - ");
            amanda.WatchMovie();
            Console.Write($"\n TA: {ta.Name} with Id: {ta.Id}; ");
            ta.WatchMovie();
            Console.WriteLine($"\n Student 1: {dotNetCohort.CurrentStudents[0].Name}" +
                              $" Student 2: {dotNetCohort.CurrentStudents[1].Name}" +
                              $" Student 3: {dotNetCohort.CurrentStudents[2].Name}" +
                              "\n\nIf you want to know more");
            dotNetCohort.Goal();

            Console.ReadLine();
        }
    }
}
