using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    public class Student : Person
    {
        public string Background { get; set; }
        public string[] ListOfTechInterest { get; set; }
        public int[] NumberOfApplicationsCreated { get; set; }
        public bool SocialPerson { get; set; }

        public string Study()
        {
            return "I study 15 hours a day";
        }

        public override void Goal()
        {
            Console.WriteLine("Inheriting from the code Fellows very base class.");
            base.Goal();
        }

        // Overriden method from Student Class
        public override void WatchMovie()
        {
            if (this.Name != null)
                Console.WriteLine($"{this.Name} loves Horror movies!");

            Console.WriteLine("CF students don't have the time to watch a movie");
        }
    }
}
