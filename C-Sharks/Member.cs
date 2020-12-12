using System;
using System.Collections.Generic;

namespace C_Sharks
{
    public class Member
    {

        //Fields
        private string name;
        private string civilStatus;
        private string monthOfBirth;
        private string typeOfAccomodation;
        private int age;
        private string favoriteHobby;
        private string favoriteCandy;
        private string postHighSchoolEducation;
        private string favoriteSeason;
        private string foodPreference;
        private string favoriteAnimal;
        private string driveInProgramming;
        


        //Constructor
        public Member(
            string name,
            string civilStatus,
            string monthOfBirth,
            string typeOfAccomodation,
            int age,
            string favoriteHobby,
            string favoriteCandy,
            string postHighSchoolEducation,
            string favoriteSeason,
            string foodPreference,
            string favoriteAnimal,
            string driveInProgramming
            )
        {
            this.name = name;
            this.civilStatus = civilStatus;
            this.monthOfBirth = monthOfBirth;
            this.typeOfAccomodation = typeOfAccomodation;
            this.age = age;
            this.favoriteHobby = favoriteHobby;
            this.favoriteCandy = favoriteCandy;
            this.postHighSchoolEducation = postHighSchoolEducation;
            this.favoriteSeason = favoriteSeason;
            this.foodPreference = foodPreference;
            this.favoriteAnimal = favoriteAnimal;
            this.driveInProgramming = driveInProgramming;

        }

        //Properties
        public string Name { get => name; set => name = value; }
        public string CivilStatus { get => civilStatus; set => civilStatus = value; }
        public string MonthOfBirth { get => monthOfBirth; set => monthOfBirth = value; }
        public string TypeOfAccomodation { get => typeOfAccomodation; set => typeOfAccomodation = value; }
        public int Age { get => age; set => age = value; }
        public string FavoriteHobby { get => favoriteHobby; set => favoriteHobby = value; }
        public string FavoriteCandy { get => favoriteCandy; set => favoriteCandy = value; }
        public string PostHighSchoolEducation { get => postHighSchoolEducation; set => postHighSchoolEducation = value; }
        public string FavoriteSeason { get => favoriteSeason; set => favoriteSeason = value; }
        public string FoodPreference { get => foodPreference; set => foodPreference = value; }
        public string FavoriteAnimal { get => favoriteAnimal; set => favoriteAnimal = value; }
        public string DriveInProgramming { get => driveInProgramming; set => driveInProgramming = value; }
        
        //Method for creating objects for all group members and returning List containing objects
        public static List<Member> CreateMemberList()
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
            //memberList.Sort();
            return memberList;
        }


    }
}
