using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Title { get; set; }
        

        public Employee(string First_Name, string Last_Name, string Email, string Title)
        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Title = Title;
            this.Email = Email;
        }
    }
}
