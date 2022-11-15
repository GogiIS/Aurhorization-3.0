using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurhorization_3._0.Core
{
    internal class User
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public User()
        {
            Firstname=string.Empty;
            Middlename=string.Empty;    
            Lastname=string.Empty;  
            Login=string.Empty; 
            Password=string.Empty;
        }

        public User(string firstname, string middlename, string lastname, string login, string password)
        {
            Firstname = firstname;
            Middlename = middlename;
            Lastname = lastname;
            Login = login;
            Password = password;
        }
        public override string ToString()
        {
            return $"{Firstname} {Middlename} {Lastname} {Login} {Password}";
        }
    }
}
