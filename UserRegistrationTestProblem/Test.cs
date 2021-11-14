﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserTestMS
{
    public class Test
    {
        public string message;
        public Test(string message)
        {
            this.message = message;

        }
        public string validFirstName()
        {
            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";//Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(firstname);

            if (regex.IsMatch(message))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public string LastName(string name)
        {
            string lastname = "^[A-Z]{1}[a-zA-Z]{2}$";//Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(lastname);

            if (regex.IsMatch(name))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public string ValidEmail(string mail)
        {
            string emailid = "^[a-z]{3}[.][a-z0-9]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$"; //Expression for Email Id format
            Regex regex = new Regex(emailid);

            if (regex.IsMatch(mail))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public static void mobileNumber(string number)
        {
            string mobileNumber = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";//Expression for Validating mobileFormating
            Regex regex = new Regex(mobileNumber);

            if (regex.IsMatch(number))
            {
                Console.WriteLine(number + "Valid");
            }
            else
            {
                Console.WriteLine(number + "InValid");
            }
        }
        public static string passwordFormat(string pass)
        {
            string pwd = "^[a-zA-Z0-9]{8,}$";
            Regex regex = new Regex(pwd);//creating a regex named obj with regular pwd.
            if (regex.IsMatch(pass))
            {
                return "Valid";
            }
            else
            {
                return "Valid";
            }
        }
        public static string UpperCase(string pass)
        {
            string pwd = "^(?=.*[A-Z])[a-zA-Z0-9]{8,}$";
            Regex regex = new Regex(pwd);
            if (regex.IsMatch(pass))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public static string OneNumeric(string pass)
        {
            string pwd = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";
            Regex regex = new Regex(pwd);
            if (regex.IsMatch(pass))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public string SpecialCharcter(string pass)
        {
            string pwd = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{10,}$";
            Regex regex = new Regex(pwd);
            if (regex.IsMatch(pass))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public static void sampleEmail(string[] name)
        {
            string email = "^[a-zA-Z0-9]+[+-._]{0,1}[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]*[@][a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}([.]?[a-zA-Z]{2,3}){0,1}$";
            Regex regex = new Regex(email);//Expression for Validating regular exp email different format.
            foreach (var word in name)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + " is valid.");
                }
                else
                {
                    Console.WriteLine(word + " is invalid.");
                }
            }
        }
    }
}
