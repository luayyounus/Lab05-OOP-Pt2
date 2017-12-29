using System;
namespace CodeFellowsApp.Classes
{
    // Abstract class will prevent this class from being instantiated and pass on the properties to derived classes
    public abstract class Person : CodeFellows
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public int YearsOfExperience { get; set; }

        // Virtual property is making this property optional to be re-implemented even though it's not initialized in this class
        public virtual int CountFavoriteSports()
        {
            return this.Name.Length / 2;
        }

        // Abstract method
        public abstract void WatchMovie();
    }
}
