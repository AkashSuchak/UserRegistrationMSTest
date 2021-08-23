using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationMSTest
{
    public class Validation
    {
        const string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}";
        const string REGEX_EMAIL_ID = @"^[A-Za-z0-9]+([\.+\-_][A-Za-z0-9]+)*@[a-zA-Z0-9]+\.?[A-Za-z]+\.?[A-Za-z]{2,}$";

        //First Name
        public bool FirstName(string firstName)
        {            
            //Display NOTE            
            Console.WriteLine("NOTE : Name start with Capital and has Minimum 3 characters : ");           
            
            //Return True or False
            return Regex.IsMatch(firstName, REGEX_NAME);                        
        }
        //Last Name
        public bool LastName(string lastName)
        {
            //Display NOTE            
            Console.WriteLine("NOTE : Name start with Capital and has Minimum 3 characters : ");

            //Return True or False
            return Regex.IsMatch(lastName, REGEX_NAME);
        }
        //Email - ID
        public bool Email(string email)
        {            
            //Return True or False
            return Regex.IsMatch(email, REGEX_EMAIL_ID);
        }
    }
}
