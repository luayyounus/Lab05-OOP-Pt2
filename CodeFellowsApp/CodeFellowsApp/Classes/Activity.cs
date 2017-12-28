using System;

namespace CodeFellowsApp.Classes
{
    // Derived class from Code Fellows Abstract base class
    internal class Activity : CodeFellows
    {
        public int PowerHourAttendees { get; set; }

        // Private properties for Ping Pong players
        private Student playerOne { get; set; }
        private Student playerTwo { get; set; }

        // public method for activity to use when instantiated
        public void PlayPingPing(Student studentOne, Student studentTwo)
        {
            this.playerOne = studentOne;
            this.playerTwo = studentTwo;
            Console.WriteLine($"{playerOne} plays against {playerTwo} every day!");
        }

        // Power hour segment every friday
        public void WatchLearnFromPowerHour()
        {
            Console.WriteLine("There are {0} attendees at this power hour.", this.PowerHourAttendees);
        }
    }
}
