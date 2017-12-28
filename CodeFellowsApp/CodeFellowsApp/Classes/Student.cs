using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    internal class Student : Person
    {
        public String Background { get; set; }
        public String[] ListOfTechInterest { get; set; }
        public int[] NumberOfApplicationsCreated { get; set; }
        public bool SocialPerson { get; set; }

        public string Study()
        {
            return "I study 15 hours a day";
        }
    }
}
