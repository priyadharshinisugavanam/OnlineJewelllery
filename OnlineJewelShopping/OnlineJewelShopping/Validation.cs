using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace OnlineJewelShopping
{
    


        class Validation
        {
            string userName;
            string phoneNumber;
            string mailId;
            string password;

            public string GetName()
            {

                try
                {
                    userName = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "Re-enter the name");
                    GetName();
                }
                if (userName.Length < 4)
                {
                    Console.WriteLine("Entered name is too small");
                    Console.WriteLine("Enter the name in correct format");
                    GetName();
                }
                if (userName != null)
                {
                    int index = 3;
                    for (int i = 0; i < userName.Length - 2; i++)
                    {
                        if ((userName.Substring(i, index).Equals(userName.Substring(i, index)) == false))
                        {
                            Console.WriteLine("Invalid string");
                            GetName();
                        }
                    }
                }
                Regex check = new Regex(@"^[A-Za-z\s]{1,}[\.]{0,1}[A-Za-z\s]{0,}$");
                if (check.IsMatch(userName) == false)
                {
                    Console.WriteLine("Enter the correct name");
                    GetName();
                }
                return (userName);
            }
            public string GetPhoneNumber()
            {

                try
                {
                    phoneNumber = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "Re-enter the phone number");
                    GetPhoneNumber();
                }
                Regex check = new Regex(@"^[6789]\d{9}$");
                if (check.IsMatch(phoneNumber) == false)
                {
                    Console.WriteLine("Invalid phone number");
                    Console.WriteLine("Enter the phone number in correct format");
                    GetPhoneNumber();
                }
                return phoneNumber;
            }
            public string GetMail()
            {

                try
                {
                    mailId = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "Re-enter the mail address");
                    GetMail();
                }
                Regex check = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (check.IsMatch(mailId) == false)
                {
                    Console.WriteLine("Invalid email id Re-enter the mail address");
                    Console.WriteLine("Re-enter the mail address");
                    Console.WriteLine("The Format shoud have a caps letter,a special character and number");
                    GetMail();
                }
                return mailId;
            }

            public string GetPassword()
            {

                try
                {
                    password = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "Re-enter the password");
                    GetPassword();
                }
                Regex regex = new Regex(@"^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$");
                if ((regex.IsMatch(password)) == false)
                {
                    Console.WriteLine("Enter the password in correct format");
                    GetPassword();
                }
                return password;
            }

        }
    }



