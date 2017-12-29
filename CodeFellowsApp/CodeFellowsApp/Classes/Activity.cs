using System;

namespace CodeFellowsApp.Classes
{
    // Derived class from Code Fellows Abstract base class
    internal class Activity : CodeFellows
    {
        public int PowerHourAttendees { get; set; }

        // Private properties for Ping Pong players
        private Student PlayerOne { get; set; }
        private Student PlayerTwo { get; set; }

        // public method for activity to use when instantiated
        public void PlayPingPing(Student studentOne, Student studentTwo)
        {
            this.PlayerOne = studentOne;
            this.PlayerTwo = studentTwo;
            Console.WriteLine($"{PlayerOne} plays against {PlayerTwo} every day!");
        }

        // Power hour segment every friday
        public void WatchPowerHour()
        {
            Console.WriteLine("There are {0} attendees at this power hour.", this.PowerHourAttendees);
        }
    }
}
