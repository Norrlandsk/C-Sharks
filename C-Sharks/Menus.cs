using System;


namespace C_Sharks
{
    class Menus
    {

        //Lists all members, the last one without a comma
        public static void ListAllMembersWithComma()
        {
            Runtime.EraseAndContinueWithoutPrompt();

            for (int i = 0; i < Runtime.operativeMemberList.Count; i++)
            {
                if (i == Runtime.operativeMemberList.Count - 1)
                {
                    Console.Write($"{Runtime.operativeMemberList[i].Name}\n");
                }
                else
                {
                    Console.Write($"{Runtime.operativeMemberList[i].Name}, ");
                }
            }
            Runtime.EraseAndContinue();
        }



        //Lists all information of all members
        public static void ListAllMemberInfo()
        {
            Runtime.EraseAndContinueWithoutPrompt();

            foreach (var item in Runtime.operativeMemberList)
            {
                Console.WriteLine(item.ToString());
                Design.CreateThinBorder();
            }

            Runtime.EraseAndContinue();
        }



        //Gives user choice of listing all information about a specific member shown in a menu
        public static void SpecificMemberInfo()
        {
            Runtime.EraseAndContinueWithoutPrompt();
            Design.CreateBorder();
            Console.WriteLine("Which member would you like to know more about?\n\n");
            int i;
            for (i = 0; i < Runtime.operativeMemberList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {Runtime.operativeMemberList[i].Name} ");
            }
            Design.CreateBorder();

            Console.WriteLine(Runtime.operativeMemberList[Runtime.ConfirmCorrectInput(Runtime.operativeMemberList.Count) - 1].ToString());
            Runtime.EraseAndContinue();




        }



        //Gives user choice of listing a specific information shown in a menu
        public static void ListSpecificInfo()
        {
            Runtime.EraseAndContinueWithoutPrompt();
            Design.CreateBorder();
            Console.WriteLine
                (
                $"What information would you like to list?\n\n" +
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
                $"[11] Drive in programming"
                );
            Design.CreateBorder();

            int menuChoiceOfSpecificInfo = Runtime.ConfirmCorrectInput(11);
            Runtime.EraseAndContinueWithoutPrompt();


            switch (menuChoiceOfSpecificInfo)
            {

                case 1:
                    foreach (var item in Runtime.operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.CivilStatus}\n");
                    }
                    break;
                case 2:
                    foreach (var item in Runtime.operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.MonthOfBirth}\n");
                    }
                    break;
                case 3:
                    foreach (var item in Runtime.operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.TypeOfAccomodation}\n");
                    }
                    break;
                case 4:
                    foreach (var item in Runtime.operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.Age}\n");
                    }
                    break;
                case 5:
                    foreach (var item in Runtime.operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.FavoriteHobby}\n");
                    }
                    break;
                case 6:
                    foreach (var item in Runtime.operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.FavoriteCandy}\n");
                    }
                    break;
                case 7:
                    foreach (var item in Runtime.operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.PostHighSchoolEducation}\n");
                    }
                    break;
                case 8:
                    foreach (var item in Runtime.operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.FavoriteSeason}\n");
                    }
                    break;
                case 9:
                    foreach (var item in Runtime.operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.FoodPreference}\n");
                    }
                    break;
                case 10:
                    foreach (var item in Runtime.operativeMemberList)
                    {
                        Console.WriteLine($"{item.Name}: {item.FavoriteAnimal}\n");
                    }
                    break;
                case 11:
                    foreach (var item in Runtime.operativeMemberList)
                    {

                        Console.WriteLine($"{item.Name}: {item.DriveInProgramming}\n");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }


            Runtime.EraseAndContinue();
        }



        //Gives user choice of deleting a member shown in a menu
        public static void DeleteMember()
        {
            Runtime.EraseAndContinueWithoutPrompt();
            Design.CreateBorder();
            Console.WriteLine("Who do you wish to remove? (Think carefully, it's irrevocable!)\n\n");

            for (int i = 0; i < Runtime.operativeMemberList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {Runtime.operativeMemberList[i].Name} ");
            }
            Console.WriteLine($"[{Runtime.operativeMemberList.Count + 1}] I changed my mind, I don't want to remove anybody");
            Design.CreateBorder();

            int menuChoiceDeleteMember = Runtime.ConfirmCorrectInput(Runtime.operativeMemberList.Count + 1);
            if (menuChoiceDeleteMember == Runtime.operativeMemberList.Count + 1)
            {
                Console.WriteLine("Nobody was removed");
                Runtime.EraseAndContinue();

            }
            else
            {
                Console.WriteLine($"\n\n{Runtime.operativeMemberList[menuChoiceDeleteMember - 1].Name} is removed");
                Runtime.operativeMemberList.RemoveAt(menuChoiceDeleteMember - 1);

                Runtime.EraseAndContinue();
            }
        }







    }
}
