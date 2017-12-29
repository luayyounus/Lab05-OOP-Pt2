using System;

namespace CodeFellowsApp.Classes
{
    // Derived class from Person Abstract class
    internal class Admission : Person
    {
        public string NickName { get; set; }
        public bool FastReply { get; set; }

        // This method is inheriting from the Grand parent class (Code Fellows) by calling CodeOfConduct method 
        public void ProvideInformation()
        {
            Console.WriteLine($"We are Code Fellows and our Code of conduct is: {this.GetCodeOfConduct()}");
        }

        // public method by admissions
        public void ChangeLife(Student student)
        {
            Console.WriteLine(student.Name + "'s life is changed.");
        }

        // overriden and sealed method after inheriting
        public override void WatchMovie()
        {
            Console.WriteLine("Admission team Watch TV everyday");
        }
    }
}
