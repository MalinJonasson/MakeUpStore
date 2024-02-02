using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMakeUpStore
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public Cart MyCart { get; set; }


        public User(int id, string name, string email, string password, string userName) 
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            UserName = userName;
        }
    }
}
