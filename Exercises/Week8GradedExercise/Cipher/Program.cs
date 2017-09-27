using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("What type of cipher do you want to use?\n" +
                    "Enter 1 to use just a key to encrypt.\n" +
                    "Enter 2 to use the key and the message to encrypt.\n" +
                    "Enter X to exit.");
                input = Console.ReadLine();
                if (input == "1")
                    EncryptKey();
                if (input == "2")
                    EncryptKeyMessage();
            } while (input.ToLower() != "x");
        }
        static void EncryptKey()
        {
            Regex rgx = new Regex("[^a-zA-Z]");

            Console.WriteLine("This application takes a key and the key is stripped down\n" +
                "to only letters (You can use as many letters as you want).\n" +
                "The application then encrypts the message you type in using the key.");

            char[] key = null;
            do
            {
                Console.Write("Enter the key: ");
                key = rgx.Replace(Console.ReadLine().ToUpper(), "").ToArray();
                if (key.Length > 0)
                {
                    if (char.IsLetter(key[0]))
                        break;
                }
                else
                    Console.WriteLine("Please use at least one letter.");
            } while (true);

            Console.Write("Enter the message: ");

            char[] message = rgx.Replace(Console.ReadLine().ToUpper(), "").ToArray();

            for (int i = 0; i < message.Length; i++)
            {
                message[i] = (char)((((message[i] + key[(i % key.Length)]) - 65) % 26) + 65);
            }
            string tryme = new string(message);
            Console.WriteLine($"{tryme}");
        }
        static void EncryptKeyMessage()
        {
            Regex rgx = new Regex("[^a-zA-Z]");

            Console.WriteLine("This application takes a key and the key is stripped down\n" +
                "to only letters (You can use as many letters as you want).\n" +
                "The application then encrypts the message you type in using\n" +
                "the key and the message.");

            char[] key = null;
            do
            {
                Console.Write("Enter the key: ");
                key = rgx.Replace(Console.ReadLine().ToUpper(), "").ToArray();
                if (key.Length > 0)
                {
                    if (char.IsLetter(key[0]))
                        break;
                }
                else
                    Console.WriteLine("Please use at least one letter.");
            } while (true);

            Console.Write("Enter the message: ");

            char[] message = rgx.Replace(Console.ReadLine().ToUpper(), "").ToArray();

            for (int i = 0; i < message.Length; i++)
            {
                if (i < key.Length)
                    message[i] = (char)((((message[i] + key[i]) - 65) % 26) + 65);
                else
                    message[i] = (char)((((message[i] + message[(i - key.Length)]) - 65) % 26) + 65);
            }
            string tryme = new string(message);
            Console.WriteLine($"{tryme}");
        }
    }

}
