using System;

namespace Models
{
    public class Customer
    {
        public int Customer_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public Trainer Trainer { get; set; }
        public WorkoutType workoutType { get; set; }
        public Customer(string First_Name, string Last_Name, string Email, Trainer Trainer, WorkoutType workoutType)
        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Email = Email;
            this.Trainer = Trainer;
            this.workoutType = workoutType;
        }
    }
}
