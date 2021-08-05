using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee
    {
        public int Employee_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
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
