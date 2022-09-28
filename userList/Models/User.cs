using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace userList.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateTime { get; set; }
        public double Salary { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Role { get; set; }
        public User(int id, string middleName, string name, string lastName, DateTime dateTime, double salary, string login, string password, string role)
        {
            Id = id;
            MiddleName = middleName;
            Name = name;
            LastName = lastName;
            DateTime = dateTime;
            Salary = salary;
            Login = login;
            Password = password;
            Role = role;
        }
        public User()
        {
            Id = 0;
            MiddleName = string.Empty;
            Name = string.Empty;
            LastName = string.Empty;
            DateTime = DateTime.Date;
            Salary = 0;
            Login = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
        }

        private string ConvertHashPassword(string password)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            return Convert.ToBase64String(hash);
        }
    }
}
