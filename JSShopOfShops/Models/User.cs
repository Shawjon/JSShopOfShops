using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace JSShopOfShops.Models
{
    public class User
    {
        public User()
        {
            FirstName = "Test";
        }

        public User(string firstName, string lastName, string email, string password,string confirmPassword,string favColor)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
            FavColor = favColor;
        }
        [Required]
        [RegularExpression("^([A-z])$",ErrorMessage ="Must be letters in the Alphabet")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Password must be longer than 3 characters and no longer than 20 ")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }
        public string FavColor { get; set; }
    }
    
}