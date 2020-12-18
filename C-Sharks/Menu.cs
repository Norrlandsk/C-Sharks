using System;


namespace C_Sharks
{

    //Collects all menus used in Runtime.Setup()
    class Menu
    {

        //Lists all members, the last one without a comma
        public static void ListAllMembersWithComma()
        {
            Runtime.EraseAndContinueWithoutPrompt();

            //Loops through all objects of operativeMemberList. IF it is the last object, write property Name without comma, ELSE, write Name with comma
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
            Runtime.EraseAndContinueWithPrompt();
        }



        //Lists all information of all members
        public static void ListAllMemberInfo()
        {
            Runtime.EraseAndContinueWithoutPrompt();

            //Loops through all objects in operativeMemberList. Calls class Member.ToString() override to get object's properties
            foreach (var item in Runtime.operativeMemberList)
            {
                Console.WriteLine(item.ToString());
                Design.CreateSingleBorder();
            }

            Runtime.EraseAndContinueWithPrompt();
        }



        //Gives user choice of listing all information about a specific member shown in a menu
        public static void SpecificMemberInfo()
        {
            Runtime.EraseAndContinueWithoutPrompt();
            Design.CreateDoubleBorder();

           
            Console.WriteLine("Which member would you like to know more about?\n\n");
            int i;

            //Loops through all objects in operativeMemberList, using iterator variable in FOR-loop to number objects, creating a dynamic menu depending on how many objects in list
            for (i = 0; i < Runtime.operativeMemberList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {Runtime.operativeMemberList[i].Name} ");
            }
            Design.CreateDoubleBorder();

            //Prints properties of object chosen by user, calling ConfirmCorrectInput() for prompt to make sure chosen number is 1. Not out of range of List, and 2. Is is a number.
            Console.WriteLine(Runtime.operativeMemberList[Runtime.ConfirmCorrectInput(Runtime.operativeMemberList.Count) - 1].ToString());
            Runtime.EraseAndContinueWithPrompt();




        }



        //Gives user choice of listing a specific information shown in a menu
        public static void ListSpecificInfo()
        {
            Runtime.EraseAndContinueWithoutPrompt();
            Design.CreateDoubleBorder();

            //Lists all properties of class Member
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
            Design.CreateDoubleBorder();

            //User prompt with ConfirmCorrectInput to ensure user gives valid input
            int menuChoiceOfSpecificInfo = Runtime.ConfirmCorrectInput(11);
            Runtime.EraseAndContinueWithoutPrompt();

            //Prints the chosen property of all member objects in operativeMemberList
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


            Runtime.EraseAndContinueWithPrompt();
        }



        //Gives user choice of deleting a member shown in a menu
        public static void DeleteMember()
        {
            Runtime.EraseAndContinueWithoutPrompt();
            Design.CreateDoubleBorder();
            Console.WriteLine("Who do you want to remove? (Think carefully, it's irrevocable!)\n\n");

            //Loops through all objects in operativeMemberList, using iterator variable in FOR-loop to number objects, creating a dynamic menu depending on how many objects in list
            for (int i = 0; i < Runtime.operativeMemberList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {Runtime.operativeMemberList[i].Name} ");
            }

            //Last menu item is always a choice of not removing an object from operativeMemberList
            Console.WriteLine($"[{Runtime.operativeMemberList.Count + 1}] I changed my mind, I don't want to remove anybody");
            Design.CreateDoubleBorder();

            int menuChoiceDeleteMember = Runtime.ConfirmCorrectInput(Runtime.operativeMemberList.Count + 1);

            //IF user chooses to not remove anybody
            if (menuChoiceDeleteMember == Runtime.operativeMemberList.Count + 1)
            {
                Console.WriteLine("Nobody was removed");
                Runtime.EraseAndContinueWithPrompt();

            }

            //ELSE if user chooses to remove somebody
            else
            {
                Console.WriteLine($"\n\n{Runtime.operativeMemberList[menuChoiceDeleteMember - 1].Name} is removed");
                Runtime.operativeMemberList.RemoveAt(menuChoiceDeleteMember - 1);

                Runtime.EraseAndContinueWithPrompt();
            }
        }







    }
}
