using System;
using System.Threading;

namespace C_Sharks
{


    //Collects all design and layout methods
    class Design
    {

        //Sets the header inside the console window for use in EraseAndContinueWithPrompt() and EraseAndContinueWithoutPrompt() methods in class Runtime
        public static string Title = "The C-Sharks Archives\n\n\n";



        //Customises the console window
        public static void ConsoleDesign()
        { 
            Console.Title = "The C-Sharks Archives";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }



        //Displays the ASCII title screen
        public static void TitleScreen()
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
            Thread.Sleep(2000);
        }



        //Creates a console window-wide border of single dots dynamically to the width of the console window
        public static void CreateSingleBorder()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(".");
            }
        }



        //Creates a console window-wide border of double dots dynamically to the width of the console window
        public static void CreateDoubleBorder()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("..");
            }
        }
    }

}
