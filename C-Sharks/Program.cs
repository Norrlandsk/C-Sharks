using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading;
//using System.Linq;

namespace C_Sharks
{

    class Program
    {
        public static List<Member> operativeMemberList = MemberList();


        static void Main(string[] args)
        {
            Setup();

        }

        //Method for starting up the application
        public static void Setup()
        {
            Console.WriteLine(">Welcome to The C-Sharks Archives!\n\n");
            /* bool incorrectPassword = true;
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

             }*/
            bool isRunning = true;
            while (isRunning)
            {
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
                        ListAllMembers();
                        break;
                    case "2":
                        ListAllMemberInfo();
                        break;
                    case "3":
                        SpecificMemberInfo();

                        break;
                    case "4":
                        ListSpecificInfo();
                        break;
                    case "5":
                        DeleteMember();
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

        public static List<Member> DeleteMember()
        {
            Console.WriteLine("Who do you wish to delete? :(");

            for (int i = 0; i < operativeMemberList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {operativeMemberList[i].Name} ");
            }
            int menuChoiceDeleteMember = Convert.ToInt32(Console.ReadLine());

            operativeMemberList.RemoveAt(menuChoiceDeleteMember - 1);
            return operativeMemberList;

        }

        private static void ListSpecificInfo()
        {
            Console.WriteLine($"What information would you like to list?\n\n" +
                $"[1] Civil status\n\n" +
                $"[2] Month of birth\n\n" +
                $"[3] Type of accomodation\n\n" +
                $"[4] Age\n\n" +
                $"[5] Favorite hobby\n\n" +
                $"[6] Favorite candy\n\n" +
                $"[7] Post High School education\n\n" +
                $"[8] Favorite season\n\n" +
                $"[9] Food preferences\n\n" +
                $"[10] Favorite animal\n\n" +
                $"[11] Drive in programming\n\n");

            int menuChoiceOfSpecificInfo = Convert.ToInt32(Console.ReadLine());

            switch (menuChoiceOfSpecificInfo)
            {
                case 1:
                    foreach (var item in operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.CivilStatus}\n");
                    }
                    break;
                case 2:
                    foreach (var item in operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.MonthOfBirth}\n");
                    }
                    break;
                case 3:
                    foreach (var item in operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.TypeOfAccomodation}\n");
                    }
                    break;
                case 4:
                    foreach (var item in operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.Age}\n");
                    }
                    break;
                case 5:
                    foreach (var item in operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.FavoriteHobby}\n");
                    }
                    break;
                case 6:
                    foreach (var item in operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.FavoriteHobby}\n");
                    }
                    break;
                case 7:
                    foreach (var item in operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.PostHighSchoolEducation}\n");
                    }
                    break;
                case 8:
                    foreach (var item in operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.FavoriteSeason}\n");
                    }
                    break;
                case 9:
                    foreach (var item in operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.FoodPreference}\n");
                    }
                    break;
                case 10:
                    foreach (var item in operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.FavoriteAnimal}\n");
                    }
                    break;
                case 11:
                    foreach (var item in operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.DriveInProgramming}\n");
                    }
                    break;
                default:
                    break;
            }
        }

        public static void SpecificMemberInfo()
        {

            Console.WriteLine("Which member would you like to know more about?");

            for (int i = 0; i < operativeMemberList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {operativeMemberList[i].Name} ");
            }
            int menuChoiceSpecificMember = Convert.ToInt32(Console.ReadLine());
            switch (menuChoiceSpecificMember)
            {
                case 1:
                    Console.Write(
                $">Name: {operativeMemberList[menuChoiceSpecificMember - 1].Name}\n" +
                $">Civil status:{operativeMemberList[menuChoiceSpecificMember - 1].CivilStatus}\n" +
                $">Type of Accomodation: {operativeMemberList[menuChoiceSpecificMember - 1].TypeOfAccomodation}\n" +
                $">Age: {operativeMemberList[menuChoiceSpecificMember - 1].Age}\n" +
                $">Favorite hobby:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteHobby}\n" +
                $">Favorite candy:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteCandy}\n" +
                $">Post High School Education:{operativeMemberList[menuChoiceSpecificMember - 1].PostHighSchoolEducation}\n" +
                $">Favorite season: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteSeason}\n" +
                $">Food preferences: {operativeMemberList[menuChoiceSpecificMember - 1].FoodPreference}\n" +
                $">Favorite animal: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteAnimal}\n" +
                $">Drive in programming: {operativeMemberList[menuChoiceSpecificMember - 1].DriveInProgramming}\n" +
                "\n\n"
                );
                    break;
                case 2:

                    Console.Write(
              $">Name: {operativeMemberList[menuChoiceSpecificMember - 1].Name}\n" +
              $">Civil status:{operativeMemberList[menuChoiceSpecificMember - 1].CivilStatus}\n" +
              $">Type of Accomodation: {operativeMemberList[menuChoiceSpecificMember - 1].TypeOfAccomodation}\n" +
              $">Age: {operativeMemberList[menuChoiceSpecificMember - 1].Age}\n" +
              $">Favorite hobby:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteHobby}\n" +
              $">Favorite candy:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteCandy}\n" +
              $">Post High School Education:{operativeMemberList[menuChoiceSpecificMember - 1].PostHighSchoolEducation}\n" +
              $">Favorite season: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteSeason}\n" +
              $">Food preferences: {operativeMemberList[menuChoiceSpecificMember - 1].FoodPreference}\n" +
              $">Favorite animal: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteAnimal}\n" +
              $">Drive in programming: {operativeMemberList[menuChoiceSpecificMember - 1].DriveInProgramming}\n" +
              "\n\n"
                    );
                    break;
                case 3:
                    Console.Write(
                $">Name: {operativeMemberList[menuChoiceSpecificMember - 1].Name}\n" +
                $">Civil status:{operativeMemberList[menuChoiceSpecificMember - 1].CivilStatus}\n" +
                $">Type of Accomodation: {operativeMemberList[menuChoiceSpecificMember - 1].TypeOfAccomodation}\n" +
                $">Age: {operativeMemberList[menuChoiceSpecificMember - 1].Age}\n" +
                $">Favorite hobby:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteHobby}\n" +
                $">Favorite candy:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteCandy}\n" +
                $">Post High School Education:{operativeMemberList[menuChoiceSpecificMember - 1].PostHighSchoolEducation}\n" +
                $">Favorite season: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteSeason}\n" +
                $">Food preferences: {operativeMemberList[menuChoiceSpecificMember - 1].FoodPreference}\n" +
                $">Favorite animal: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteAnimal}\n" +
                $">Drive in programming: {operativeMemberList[menuChoiceSpecificMember - 1].DriveInProgramming}\n" +
                "\n\n"
                );
                    break;
                case 4:
                    Console.Write(
                 $">Name: {operativeMemberList[menuChoiceSpecificMember - 1].Name}\n" +
                 $">Civil status:{operativeMemberList[menuChoiceSpecificMember - 1].CivilStatus}\n" +
                 $">Type of Accomodation: {operativeMemberList[menuChoiceSpecificMember - 1].TypeOfAccomodation}\n" +
                 $">Age: {operativeMemberList[menuChoiceSpecificMember - 1].Age}\n" +
                 $">Favorite hobby:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteHobby}\n" +
                 $">Favorite candy:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteCandy}\n" +
                 $">Post High School Education:{operativeMemberList[menuChoiceSpecificMember - 1].PostHighSchoolEducation}\n" +
                 $">Favorite season: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteSeason}\n" +
                 $">Food preferences: {operativeMemberList[menuChoiceSpecificMember - 1].FoodPreference}\n" +
                 $">Favorite animal: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteAnimal}\n" +
                 $">Drive in programming: {operativeMemberList[menuChoiceSpecificMember - 1].DriveInProgramming}\n" +
                 "\n\n"
                 );
                    break;
                case 5:
                    Console.Write(
             $">Name: {operativeMemberList[menuChoiceSpecificMember - 1].Name}\n" +
             $">Civil status:{operativeMemberList[menuChoiceSpecificMember - 1].CivilStatus}\n" +
             $">Type of Accomodation: {operativeMemberList[menuChoiceSpecificMember - 1].TypeOfAccomodation}\n" +
             $">Age: {operativeMemberList[menuChoiceSpecificMember - 1].Age}\n" +
             $">Favorite hobby:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteHobby}\n" +
             $">Favorite candy:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteCandy}\n" +
             $">Post High School Education:{operativeMemberList[menuChoiceSpecificMember - 1].PostHighSchoolEducation}\n" +
             $">Favorite season: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteSeason}\n" +
             $">Food preferences: {operativeMemberList[menuChoiceSpecificMember - 1].FoodPreference}\n" +
             $">Favorite animal: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteAnimal}\n" +
             $">Drive in programming: {operativeMemberList[menuChoiceSpecificMember - 1].DriveInProgramming}\n" +
             "\n\n"

             );
                    break;
                case 6:
                    Console.Write(
                $">Name: {operativeMemberList[menuChoiceSpecificMember - 1].Name}\n" +
                $">Civil status:{operativeMemberList[menuChoiceSpecificMember - 1].CivilStatus}\n" +
                $">Type of Accomodation: {operativeMemberList[menuChoiceSpecificMember - 1].TypeOfAccomodation}\n" +
                $">Age: {operativeMemberList[menuChoiceSpecificMember - 1].Age}\n" +
                $">Favorite hobby:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteHobby}\n" +
                $">Favorite candy:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteCandy}\n" +
                $">Post High School Education:{operativeMemberList[menuChoiceSpecificMember - 1].PostHighSchoolEducation}\n" +
                $">Favorite season: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteSeason}\n" +
                $">Food preferences: {operativeMemberList[menuChoiceSpecificMember - 1].FoodPreference}\n" +
                $">Favorite animal: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteAnimal}\n" +
                $">Drive in programming: {operativeMemberList[menuChoiceSpecificMember - 1].DriveInProgramming}\n" +
                "\n\n"
                );
                    break;
                case 7:
                    Console.Write(
                $">Name: {operativeMemberList[menuChoiceSpecificMember - 1].Name}\n" +
                $">Civil status:{operativeMemberList[menuChoiceSpecificMember - 1].CivilStatus}\n" +
                $">Type of Accomodation: {operativeMemberList[menuChoiceSpecificMember - 1].TypeOfAccomodation}\n" +
                $">Age: {operativeMemberList[menuChoiceSpecificMember - 1].Age}\n" +
                $">Favorite hobby:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteHobby}\n" +
                $">Favorite candy:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteCandy}\n" +
                $">Post High School Education:{operativeMemberList[menuChoiceSpecificMember - 1].PostHighSchoolEducation}\n" +
                $">Favorite season: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteSeason}\n" +
                $">Food preferences: {operativeMemberList[menuChoiceSpecificMember - 1].FoodPreference}\n" +
                $">Favorite animal: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteAnimal}\n" +
                $">Drive in programming: {operativeMemberList[menuChoiceSpecificMember - 1].DriveInProgramming}\n" +
                "\n\n"
                );
                    break;
                case 8:
                    Console.Write(
                $">Name: {operativeMemberList[menuChoiceSpecificMember - 1].Name}\n" +
                $">Civil status:{operativeMemberList[menuChoiceSpecificMember - 1].CivilStatus}\n" +
                $">Type of Accomodation: {operativeMemberList[menuChoiceSpecificMember - 1].TypeOfAccomodation}\n" +
                $">Age: {operativeMemberList[menuChoiceSpecificMember - 1].Age}\n" +
                $">Favorite hobby:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteHobby}\n" +
                $">Favorite candy:{operativeMemberList[menuChoiceSpecificMember - 1].FavoriteCandy}\n" +
                $">Post High School Education:{operativeMemberList[menuChoiceSpecificMember - 1].PostHighSchoolEducation}\n" +
                $">Favorite season: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteSeason}\n" +
                $">Food preferences: {operativeMemberList[menuChoiceSpecificMember - 1].FoodPreference}\n" +
                $">Favorite animal: {operativeMemberList[menuChoiceSpecificMember - 1].FavoriteAnimal}\n" +
                $">Drive in programming: {operativeMemberList[menuChoiceSpecificMember - 1].DriveInProgramming}\n" +
                "\n\n"
                );
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

        }

        public static void ListAllMemberInfo()
        {
            foreach (var item in operativeMemberList)
            {
                Console.Write(
                    $">Name: {item.Name}\n" +
                    $">Civil status: {item.CivilStatus}\n" +
                    $">Type of Accomodation: {item.TypeOfAccomodation}\n" +
                    $">Age: {item.Age}\n" +
                    $">Favorite hobby: {item.FavoriteHobby}\n" +
                    $">Favorite candy: {item.FavoriteCandy}\n" +
                    $">Post High School Education: {item.PostHighSchoolEducation}\n" +
                    $">Favorite season: {item.FavoriteSeason}\n" +
                    $">Food preferences: {item.FoodPreference}\n" +
                    $">Favorite animal: {item.FavoriteAnimal}\n" +
                    $">Drive in programming: {item.DriveInProgramming}\n" +
                    "\n\n"
                    );
            }
        }

        public static void ListAllMembers()
        {
            foreach (var item in operativeMemberList)
            {
                Console.WriteLine($"{item.Name}\n ");
            }
        }

        //Method for creating objects for all group members and returning List containing objects
        public static List<Member> MemberList()
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

            memberList.Sort((x, y) => x.Age.CompareTo(y.Age));
            
            return memberList;
        }

    }
}
