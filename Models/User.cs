
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchFlix_Frontend.Models
{
    public class User
    {
        public Guid _id { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
        public string Email { get; set; }
        public string Shows { get; set; }

        public User()
        {

        }
        public User(string Name, string Pwd, string Email, string Shows)
        {
            this.Name = Name;
            this.Pwd = Pwd;
            this.Email = Email;
            this.Shows = Shows;
        }
    }
}
