using System;

namespace CodeFellowsApp.Classes
{
    // Derived class from Person Abstract class
    internal class Admission : Person
    {
        // This method is inheriting from the Grand parent class (Code Fellows) by calling CodeOfConduct method 
        public void ProvideInformation()
        {
            Console.WriteLine($"We are Code Fellows and our Code of conduct is: {this.CodeOfConduct()}");
        }
    }
}
