using System;
using System.Collections.Generic;
using System.Dynamic;

namespace C_Sharks
{

    class Program
    {



        static void Main(string[] args)
        {
            Setup();

        }

        public static void Setup()
        {
            Console.WriteLine(">Welcome to The C-Sharks Archives!\n\n");
            bool incorrectPassword = true;
            while (incorrectPassword)
            {
                Console.Write($">Input password:");
                string passWord = Console.ReadLine();
                if (passWord == "C-Sharks")
                {

                    incorrectPassword = false;
                }
                else
                    Console.WriteLine(">Incorrect password!\n\n");

            }
            Console.Clear();
            Console.WriteLine(">Correct password!\n\n");
            Console.WriteLine(">What would you like to do now?\n\n" +
                ">[1] Show member list\n" +
                ">[2] Show all members info\n" +
                ">[3] Show specific member's info\n" +
                ">[4] Show specific info about all members\n" +
                ">[5] Delete member from list\n" +
                ">[6] Quit The C-Sharks Archives");
            string menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    NewMethod();
                    break;
                case "2": 

                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Invalid input!");

                    break;

            }

        }

        
    }
}
