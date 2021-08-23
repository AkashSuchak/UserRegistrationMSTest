using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationMSTest
{
    public class Validation
    {
        const string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}";
        public bool FirstAndLastName(string firstName)
        {            
            //Display NOTE            
            Console.WriteLine("NOTE : Name start with Capital and has Minimum 3 characters : ");           
            
            //Return True or False
            return Regex.IsMatch(firstName, REGEX_NAME);                        
        }
    }
}
