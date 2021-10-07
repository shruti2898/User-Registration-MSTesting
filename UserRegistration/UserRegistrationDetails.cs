using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserRegistrationDetails
    {   //UC1
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        //UC2
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";
        //UC4
        public static string Regex_MobileNumber = "^[0-9]{2}[ ]?[6-9][0-9]{9}$";
        //UC5 to UC8
        public static string Regex_Password = @"^(?=.{8,}$)(?=.*?[0-9])(?=.*[A-Z])[a-zA-Z0-9]*[#!@$^&-][a-zA-Z0-9]*$";       
        //UC3 and UC9
        public static string Regex_Email = "^[a-z][a-z0-9]{2,}([-.+]{1}[a-z0-9]{3})?[@][a-z0-9]{1,}[.][a-z]{3}([.][a-z]{2,3})?$";

        public bool ValidateFirstName(string firstName)
        {
            try
            {
                if (firstName.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.Empty_Message, "Name should not be empty.");
                }
                else if (Regex.IsMatch(firstName, Regex_FirstName))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.NULL_Message, "Name should not be null.");
            }

        }
        public bool ValidateLastName(string lastName)
        {
            try
            {
                if (Regex.IsMatch(lastName, Regex_LastName))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Empty_Message, "Last name should not be empty.");
            }
        }
        public bool ValidateEmail(string email)
        {
            try
            {
                if (Regex.IsMatch(email, Regex_Email))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Empty_Message, "Email should not be empty.");

            }
        }
        public bool ValidateMobileNumber(string mobile)
        {
            try
            {
                if (Regex.IsMatch(mobile, Regex_MobileNumber))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Empty_Message, "Mobile number should not be empty.");

            }
        }
        public bool ValidatePassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, Regex_Password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.Empty_Message, "Password should not be empty.");
            }
        }

    }
}
