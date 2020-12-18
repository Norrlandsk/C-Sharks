using System;


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
        public string Name { get => name; }
        public string CivilStatus { get => civilStatus; }
        public string MonthOfBirth { get => monthOfBirth; }
        public string TypeOfAccomodation { get => typeOfAccomodation; }
        public int Age { get => age; }
        public string FavoriteHobby { get => favoriteHobby; }
        public string FavoriteCandy { get => favoriteCandy; }
        public string PostHighSchoolEducation { get => postHighSchoolEducation; }
        public string FavoriteSeason { get => favoriteSeason; }
        public string FoodPreference { get => foodPreference; }
        public string FavoriteAnimal { get => favoriteAnimal; }
        public string DriveInProgramming { get => driveInProgramming; }




        //Override of Member class ToString() for use when listing all properties
        public override string ToString()
        {

            return
                    $"Name: {Name}\n" +
                    $"Civil status: {CivilStatus}\n" +
                    $"Type of Accomodation: {TypeOfAccomodation}\n" +
                    $"Age: {Age}\n" +
                    $"Favorite hobby: {FavoriteHobby}\n" +
                    $"Favorite candy: {FavoriteCandy}\n" +
                    $"Post High School Education: {PostHighSchoolEducation}\n" +
                    $"Favorite season: {FavoriteSeason}\n" +
                    $"Food preferences: {FoodPreference}\n" +
                    $"Favorite animal: {FavoriteAnimal}\n" +
                    $"Drive in programming: {DriveInProgramming}\n\n";
        }



    }
}
