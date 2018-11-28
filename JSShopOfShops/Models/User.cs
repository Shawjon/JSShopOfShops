using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSShopOfShops.Models
{
    public class User
    {
        public User()
        {
            FirstName = "Test";
        }

        public User(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
        [Required]
        [RegularExpression("^([A-z])$",ErrorMessage ="Must be letters in the Alphabet")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}