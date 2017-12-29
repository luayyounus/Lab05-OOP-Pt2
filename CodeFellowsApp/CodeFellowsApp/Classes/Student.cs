using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    public class Student : Person
    {
        public String Background { get; set; }
        public String[] ListOfTechInterest { get; set; }
        public int[] NumberOfApplicationsCreated { get; set; }
        public bool SocialPerson { get; set; }

        public string Study()
        {
            return "I study 15 hours a day";
        }

        // Overriden method from Student Class
        public override void WatchMovie()
        {
            if (this.Name != null)
                Console.WriteLine($"{this.Name} loves Horror movies!");

            Console.WriteLine("CF students don't have the time to watch a movie");
        }

        public void StudyHard()
        {
            Console.WriteLine("True story about a good student.");
        }
    }
}
