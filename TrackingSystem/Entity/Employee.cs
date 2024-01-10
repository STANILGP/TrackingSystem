using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem
{
    public class Employee
    {
        private int id { get; set; }
        private string userName { get; set; }
        private string password { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string role { get; set; }
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

        public int GetID()
        {
            return id;
        }
        public string GetUserName()
        {
            return userName;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
