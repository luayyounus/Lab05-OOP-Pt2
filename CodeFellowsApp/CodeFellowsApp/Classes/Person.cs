using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    // Abstract class will prevent this class from being instantiated and pass on the properties to derived classes
    // The class is internal which means it's accessed inside the assembly - All classes in this solution
    internal abstract class Person : CodeFellows
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }

        // Virtual property is making this property optional to be re-implemented even though it's not initialized in this class
        public virtual int YearsOfExperience { get; set; }
    }
}
