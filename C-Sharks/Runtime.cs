using System;
using System.Collections.Generic;
using System.Threading;

namespace C_Sharks
{

    //Collects all methods regarding program flow; setting up the application, password handling, error handling, etc
    class Runtime
    {


        //Initialises the list used throughout the application by calling a method
        public static List<Member> operativeMemberList = InitMemberList();
        


        //Starts the application in Program.Main and gives user access to the root menu
        public static void Setup()
        {
            Design.ConsoleDesign();
            EnterPassword();
            Design.TitleScreen();

            bool isRunning = true;
            while (isRunning)
            {
                EraseAndContinueWithoutPrompt();
                Design.CreateDoubleBorder();
                Console.WriteLine
                    (
                    $"What would you like to do now?\n\n" +
                    $"[1] Show member list\n" +
                    $"[2] Show all member's info\n" +
                    $"[3] Show specific member's info\n" +
                    $"[4] Show specific info about all members\n" +
                    $"[5] Delete member from list\n" +
                    $"[6] Quit The C-Sharks Archives"
                    );
                Design.CreateDoubleBorder();

                //User prompt with ConfirmCorrectInput() to ensure valid input from user
                int RootMenuChoice = ConfirmCorrectInput(6);
                EraseAndContinueWithoutPrompt();


                switch (RootMenuChoice)
                {
                    case 1:

                        Menu.ListAllMembersWithComma();
                        break;
                    case 2:

                        Menu.ListAllMemberInfo();
                        break;
                    case 3:

                        Menu.SpecificMemberInfo();

                        break;
                    case 4:

                        Menu.ListSpecificInfo();
                        break;
                    case 5:

                        Menu.DeleteMember();
                        break;
                    case 6:

                        Console.WriteLine("Shutting down the application...");
                        isRunning = false;
                        break;

                }




            }
        }



        //Prompts the user for the correct password until correct
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
                    Thread.Sleep(1200);
                    Console.Clear();
                }

            }
            Console.WriteLine("Correct password!");
            Thread.Sleep(1200);
            Console.Clear();
        }



        //A method for changing between screens by pushing Enter
        //Clears the console window, and sets the title on top and center of the console window, and prompts user to push Enter to continue
        public static void EraseAndContinueWithPrompt()
        {

            Console.WriteLine("\n\nPress enter to continue...");
            Console.Read();
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Design.Title.Length / 2)) + "}", Design.Title));

        }



        //Clears the console window, and sets the title on top and center of the console window
        public static void EraseAndContinueWithoutPrompt()
        {


            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Design.Title.Length / 2)) + "}", Design.Title));
        }



        //Verifies that user input is in correct format, and not out of range
        public static int ConfirmCorrectInput(int allowedRange)
        {

            int confirmedChoice;
            do
            {
                //User prompt
                string menuChoiceString = Console.ReadLine();

                
                bool successfulConversion = Int32.TryParse(menuChoiceString, out confirmedChoice);

                //IF TryParse() successfully parses menuChoiceString, AND the variable is within allowed range of the menu in question: break out of DO WHILE loop and RETURN confirmedChoice
                if (successfulConversion && confirmedChoice <= allowedRange)
                {

                    EraseAndContinueWithoutPrompt();
                    break;
                }

                //ELSE IF user previously pressed Enter (in the case of changing screens with EraseAndContinue() method). This ensures that ELSE case is not entered unwanted
                else if (menuChoiceString == "")
                {
                    EraseAndContinueWithoutPrompt();
                    break;
                }

                //ELSE if user input is either out of range of menu or not a number, continue DO WHILE loop 
                else
                {

                    Console.Write("\nInvalid input! Try again:");

                }


            } while (true);
            return confirmedChoice;
        }



        //Creates objects for all group members and returns List containing the objects
        public static List<Member> InitMemberList()
        {

            //Instancing all wanted objects of class Member with constructor 
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

            //Create memberList and add all objects of class Member
            List<Member> memberList = new List<Member>() { Tove, Oskar, Elias, Viktor, Johan, Christopher, Robert, Fisnik };


            //Sorting memberList alphabetically after property Name with Sort() method  
            memberList.Sort((x, y) => x.Name.CompareTo(y.Name));

            return memberList;
        }
    }
}
