using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }
        [Required]
        public string Email { get; set; }
        
        public Trainer Trainer { get; set; }
        public WorkoutType workoutType { get; set; }
        public Customer(string First_Name, string Last_Name, string Email)
        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Email = Email;
        }
    }
}
