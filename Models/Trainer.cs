using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public enum WorkoutType { Weight_training, Swimming, Basketball, Yoga, Cycling };
    public class Trainer : Employee
    {
        public WorkoutType workoutType { get; set; }
        public Trainer(string First_Name, string Last_Name, string Email, string Title, WorkoutType workoutType)
            : base(First_Name, Last_Name, Email, Title)
        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Email = Email;
            this.Title = Title;
            this.workoutType = workoutType;
        }
    }
}
