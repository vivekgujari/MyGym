using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class WorkoutClass
    {
        public string Name { get; set; }
        public string Instructor { get; set; }
        public float Duration { get; set; }

        public WorkoutClass(string Name, string Instructor, float Duration)
        {
            this.Name = Name;
            this.Instructor = Instructor;
            this.Duration = Duration;
        }
    }
}
