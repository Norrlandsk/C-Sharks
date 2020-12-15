using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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


        public void GetSpecificInfo(int switchChoice)
        {
            
            switch (switchChoice)
            {

                case 1:
                    Console.WriteLine( $"{this.Name}: {this.CivilStatus}");
                    break;
                case 2:
                    Console.WriteLine(  $"{this.Name}: {this.MonthOfBirth}");
                    break;
                case 3:
                    Console.WriteLine($"{this.Name}: {this.TypeOfAccomodation}");
                    break;
                case 4:
                    Console.WriteLine($"{this.Name}: {this.Age}");
                    break;
                case 5:
                    Console.WriteLine($"{this.Name}: {this.FavoriteHobby}");
                    break;
                case 6:
                    Console.WriteLine($"{this.Name}: {this.favoriteCandy}");
                    break;
                case 7:
                    Console.WriteLine($"{this.Name}: {this.PostHighSchoolEducation}");
                    break;
                case 8:
                    Console.WriteLine($"{this.Name}: {this.FavoriteSeason}");
                    break;
                case 9:
                    Console.WriteLine($"{this.Name}: {this.FoodPreference}");
                    break;
                case 10:
                    Console.WriteLine($"{this.Name}: {this.FavoriteAnimal}");
                    break;
                case 11:
                    Console.WriteLine($"{this.Name}: {this.DriveInProgramming}");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }

        public override string ToString()
        {

            return
                    $">Name: {Name}\n" +
                    $">Civil status: {CivilStatus}\n" +
                    $">Type of Accomodation: {TypeOfAccomodation}\n" +
                    $">Age: {Age}\n" +
                    $">Favorite hobby: {FavoriteHobby}\n" +
                    $">Favorite candy: {FavoriteCandy}\n" +
                    $">Post High School Education: {PostHighSchoolEducation}\n" +
                    $">Favorite season: {FavoriteSeason}\n" +
                    $">Food preferences: {FoodPreference}\n" +
                    $">Favorite animal: {FavoriteAnimal}\n" +
                    $">Drive in programming: {DriveInProgramming}\n\n";
        }



    }
}
