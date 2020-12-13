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

        internal static void Sort(Func<object, object, int> p)
        {
            throw new NotImplementedException();
        }
    }
}
