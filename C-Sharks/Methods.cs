using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace C_Sharks
{
    class Methods



    {
         public static List<Member> operativeMemberList = Methods.InitMemberList();
         const int SleepTime = 1200;
         public static string Title = "The C-Sharks Archives";
        //Method for starting up the application
        public static void Setup()
        {
            Console.Title = "The C-Sharks Archives";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            EnterPassword();
            WelcomeMessage();

            bool isRunning = true;
            while (isRunning)
            {
                EraseAndContinueWithoutWait();

                Console.WriteLine
                    (
                    "What would you like to do now?\n\n" +
                    "[1] Show member list\n" +
                    "[2] Show all members info\n" +
                    "[3] Show specific member's info\n" +
                    "[4] Show specific info about all members\n" +
                    "[5] Delete member from list\n" +
                    "[6] Quit The C-Sharks Archives"
                    );
                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":

                        Methods.ListAllMembersWithComma();
                        break;
                    case "2":

                        Methods.ListAllMemberInfo();
                        break;
                    case "3":

                        Methods.SpecificMemberInfo();

                        break;
                    case "4":

                        Methods.ListSpecificInfo();
                        break;
                    case "5":

                        Methods.DeleteMember();
                        break;
                    case "6":

                        Console.WriteLine("Shutting down the application...");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");

                        break;
                }
                



            }
        }

        private static void EnterPassword()
        {
            bool correctPassWordGiven = false;
            while (!correctPassWordGiven)
            {
                Console.Write($"Input password:");
                string passWord = Console.ReadLine();
                Console.Clear();
                if (passWord == "C-Sharks")
                {

                    correctPassWordGiven = true;
                }
                else
                {
                    Console.WriteLine("Incorrect password!");
                    Thread.Sleep(SleepTime);
                    Console.Clear();
                }

            }
            Console.WriteLine("Correct password!");
            Thread.Sleep(SleepTime);
            Console.Clear();
        }

        private static void WelcomeMessage()
        {
            string graphic = @"
                      _____ _          
                     |_   _| |         
                       | | | |__   ___ 
                       | | | '_ \ / _ \
                       | | | | | |  __/
                       \_/ |_| |_|\___|
                                       
                                       
        _____       _____ _                _        
       /  __ \     /  ___| |              | |       
       | /  \/_____\ `--.| |__   __ _ _ __| | _____ 
       | |  |______|`--. \ '_ \ / _` | '__| |/ / __|
       | \__/\     /\__/ / | | | (_| | |  |   <\__ \
        \____/     \____/|_| |_|\__,_|_|  |_|\_\___/
                                                    
                                                    
            ___           _     _                
           / _ \         | |   (_)               
          / /_\ \_ __ ___| |__  ___   _____  ___ 
          |  _  | '__/ __| '_ \| \ \ / / _ \/ __|
          | | | | | | (__| | | | |\ V /  __/\__ \
          \_| |_/_|  \___|_| |_|_| \_/ \___||___/
                                                 ";
            Console.WriteLine(graphic);
            EraseAndContinue();
        }

        private static void EraseAndContinue()
        {
            Console.WriteLine("\n\nPress enter to continue...");
            Console.Read();
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Title.Length / 2)) + "}", Title));
            Thread.Sleep(SleepTime);
        }
        private static void EraseAndContinueWithoutWait()
        {
           
            
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Title.Length / 2)) + "}", Title));
        }


        //Method for printing out all Name fields in class Member
        public static void ListAllMembersWithComma()
        {
            EraseAndContinueWithoutWait();
            for (int i = 0; i < operativeMemberList.Count; i++)
            {
                if (i == operativeMemberList.Count - 1)
                {
                    Console.Write($"{operativeMemberList[i].Name}");
                }
                else
                {
                    Console.Write($"{operativeMemberList[i].Name}, ");
                }
            }
            EraseAndContinue();
        }
        //Method for printing out all fields of all objects in class Member
        public static void ListAllMemberInfo()
        {
            EraseAndContinueWithoutWait();
            foreach (var item in operativeMemberList)
            {
                Console.WriteLine(item.ToString());
            }
            EraseAndContinue();
        }

        public static void SpecificMemberInfo()
        {
            EraseAndContinueWithoutWait();
            Console.WriteLine("Which member would you like to know more about?\n\n");
            int i;
            for (i = 0; i < operativeMemberList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {operativeMemberList[i].Name} ");
            }
            int menuChoiceSpecificMember = Convert.ToInt32(Console.ReadLine());
            EraseAndContinueWithoutWait();
            Console.WriteLine(operativeMemberList[menuChoiceSpecificMember - 1].ToString());
            EraseAndContinue();
        }
        public static void ListSpecificInfo()
        {
            EraseAndContinueWithoutWait();
            Console.WriteLine($"What information would you like to list?\n\n" +
                $"[1] Civil status\n" +
                $"[2] Month of birth\n" +
                $"[3] Type of accomodation\n" +
                $"[4] Age\n" +
                $"[5] Favorite hobby\n" +
                $"[6] Favorite candy\n" +
                $"[7] Post High School education\n" +
                $"[8] Favorite season\n" +
                $"[9] Food preferences\n" +
                $"[10] Favorite animal\n" +
                $"[11] Drive in programming\n");

            int menuChoiceOfSpecificInfo = Convert.ToInt32(Console.ReadLine());
            EraseAndContinueWithoutWait();
            for (int i = 0; i < operativeMemberList.Count; i++)
            {
                operativeMemberList[i].GetSpecificInfo(menuChoiceOfSpecificInfo);
            }
            EraseAndContinue();
        }


        public static void DeleteMember()
        {
            EraseAndContinueWithoutWait();
            Console.WriteLine("Who do you wish to delete? :(\n\n");

            for (int i = 0; i < operativeMemberList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {operativeMemberList[i].Name} ");
            }
            int menuChoiceDeleteMember = Convert.ToInt32(Console.ReadLine());

            operativeMemberList.RemoveAt(menuChoiceDeleteMember - 1);
            Console.WriteLine($"{menuChoiceDeleteMember - 1} is deleted");
            EraseAndContinue();
        }
        //Method for creating objects for all group members and returning List containing objects
        public static List<Member> InitMemberList()
        {
            Member Tove = new Member(
               "Tove Seger",
               "Gift",
               "December",
               "Villa",
               28,
               "Löpning",
               "Saltlakrits",
               "Biomedicin, inriktning: fysisk träning",
               "Sommar",
               "Vegetariskt",
               "Hund",
               "Viljan att skapa en kreativ och intellektuell tillvaro, oberoende av fasta klockslag"
               );

            Member Oskar = new Member(
                "Oskar Kling",
                "Sambo",
                "November",
                "Lägenhet",
                30,
                "Datorspel",
                "Kexchoklad",
                "Ett år Ekonomi. Ett år Software Engineer",
                "Höst",
                "Kött, helst biff",
                "Hund och katt",
                "Kreativt, roligt, kontroll och problemlösning");

            Member Elias = new Member(
                "Elias Hjelm",
                "Sambo",
                "Augusti",
                "Lägenhet",
                22,
                "Datorspel",
                "Choklad",
                "Halvår Interaktionsdesigner",
                "Sommar",
                "Veganskt",
                "Hund",
                "Att få arbeta med något som är kreativt och som jag alltid kan utvecklas inom");

            Member Viktor = new Member(
                 "Viktor Salmberg",
                 "Singel",
                 "Januari",
                 "Lägenhet",
                 30,
                 "Spela gitarr",
                 "Choklad",
                 "Arabiska",
                 "Höst",
                 "Vegetariskt, och bacon",
                 "Katt",
                 "Kicken att förstå nya koncept och möjligheten till ett utvecklande arbetsliv.");

            Member Johan = new Member(
                "Johan Rohdin",
                "Sambo",
                "Mars",
                "Lägenhet",
                27,
                "Poker och fotboll",
                "Blandgodis",
                "Två år Nätverksdrift",
                "Vinter",
                "Pasta",
                "Hund",
                "Egna arbetstider, roligt och intressant");

            Member Christopher = new Member(
                "Christopher Brizet",
                "Sambo",
                "September",
                "Villa",
                35,
                "Gitarr, spel, läsa",
                "Sötlakrits",
                "Ett år Installationstekniker",
                "Höst",
                "Stinky french cheeses",
                "Korp",
                "Planera, skapa och ett enormt svängrum för kreativitet (plus fantasin om att erövra världen)");

            Member Robert = new Member(
                "Robert Bunjako",
                "Gift",
                "November",
                "Lägenhet",
                35,
                "Fiska",
                "Mjölkchoklad",
                "IT-Säkerhet",
                "Sommar",
                "Pasta",
                "Hund",
                "Kombinera tidigare utbildning med nya kunskaper för att släppa los den kreativa kraften och styra/forma egna framtiden"
                );

            Member Fisnik = new Member(
                  "Fisnik Balija",
                  "Flickvän",
                  "Februari",
                  "Villa",
                  32,
                  "Fotboll",
                  "Choklad",
                  "Masterexamen i Geologi",
                  "Sommar",
                  "Allätare, föredrar kött",
                  "Hund",
                  "Fascineras av hur något så enkelt men samtidigt komplicerat kan skapa något kraftfullt och användbart. Vidare så är programmering oerhört utmanande, spännande och framförallt roligt!"
                  );
            List<Member> memberList = new List<Member>() { Tove, Oskar, Elias, Viktor, Johan, Christopher, Robert, Fisnik };

            memberList.Sort((x, y) => x.Name.CompareTo(y.Name));

            return memberList;
        }
    }
}
