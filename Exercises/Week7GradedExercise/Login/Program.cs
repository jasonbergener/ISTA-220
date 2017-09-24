using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Week7GradedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application allows users to create usernames and passwords.\n" +
                "It stores the usernames, but the passwords are kept as a MD5 hash.\n" +
                "Passwords are case sensitive, but usernames are not.\n" +
                "Enter the username \"exit\" to quit the application.");
            using (MD5 md5Hash = MD5.Create())
            {
                Dictionary<string, byte[]> logins = new Dictionary<string, byte[]>();
                do
                {
                    string userName = "";
                    Console.Write("Enter your username: ");
                    userName = Console.ReadLine().ToLower();
                    if (userName == "exit")
                        break;
                    if (logins.ContainsKey(userName))
                    {
                        Console.Write("Enter your password: ");
                        if (logins[userName].SequenceEqual(GetPassword(md5Hash)))
                        {
                            Console.WriteLine("Login Confirmed.");
                        }
                        else Console.WriteLine("The password did not match.");
                    }
                    else
                    {
                        do
                        {
                            Console.Write("Username not found.\n" +
                                "If you want to create a new login, enter Y.\n" +
                                "If you want to try entering your username again, enter N.\n" +
                                ":> ");
                            string input = Console.ReadLine();
                            if (input.ToLower() == "y")
                            {
                                do
                                {
                                    Console.Write("Enter your password: ");
                                    byte[] pw = GetPassword(md5Hash);
                                    Console.Write("Confirm your password: ");
                                    if (pw.SequenceEqual(GetPassword(md5Hash)))
                                    {
                                        Console.WriteLine("User login successfully created.");
                                        logins.Add(userName, pw);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The passwords did not match.");
                                    }
                                } while (true);
                                break;
                            }
                            else if (input.ToLower() == "n")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("That wasn't Y or N.");
                            }
                        } while (true);
                    }
                } while (true);
            }
        }
        static byte[] GetPassword(MD5 hash)
        {
            string password = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        password = password.Substring(0, (password.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return hash.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}
