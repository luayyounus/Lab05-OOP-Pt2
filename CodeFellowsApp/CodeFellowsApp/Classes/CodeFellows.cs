using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    // The class is abstract which means it can not be instantiated but the derived classes will use its methods and properties
    // Public access modifier means this class can be accessed from anywhere in the computer/website/service
    public abstract class CodeFellows
    {
        public string SchoolName { get; set; }
        public string Location { get; set; }
        public string Industry { get; set; }
        public string CodeOfConduct { get; set; }

        public string GetCodeOfConduct()
        {
            if(this.CodeOfConduct == null)
                return "We lead with humility and empathy to create safe and inclusive environments where people learn and lives are transformed";

            return this.CodeOfConduct;
        }

        public string GetScheduleToday()
        {
            string today = $"Come to Code Fellows at this location: {Location}";
            return today;
        }

        public virtual void Goal()
        {
            Console.WriteLine("Call 206-123-4567");
        }
    }
}
