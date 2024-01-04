using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem
{
    public class Employee
    {
        private int id;
        private string userName;
        private string password;
        private string firstName;
        private string lastName;
        private string role;
        public Employee(int ID,string UserName,string Password, string FirstName,string LastName,string Role) 
        {
            this.id = ID;
            this.userName = UserName;
            this.password = Password;
            this.firstName = FirstName; 
            this.lastName = LastName;
            this.role = Role;
        }
        public string ToString()
        {
            return $"Employee:{userName} {password} {firstName} {lastName} {role}";
        }
    }
}
