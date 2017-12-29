using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFellowsApp.Classes
{
    internal class ClassRoom : CodeFellows
    {
        // Properties that complete a class room at the Code fellows
        public byte Id { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }
        public int NumberOfChairs { get; set; }
        public int NumberOfTables { get; set; }
        public bool ProjectorAvailable { get; set; }
        public bool WhiteboardAvailable { get; set; }

        // Cohort is a class type
        public Cohort CurrentCohort { get; set; }

        public void TurnLights()
        {
            Console.WriteLine("Lights are turned on!");
        }
    }
}
