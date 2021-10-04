using System;

namespace NutriApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(int id, string username, string password, string first, string last)
        {
            Id = id;
            Username = username;
            Password = password;
            FirstName = first;
            LastName = last;
        }
    }
}
