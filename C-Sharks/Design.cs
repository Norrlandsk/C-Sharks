using System;
using System.Threading;

namespace C_Sharks
{
    class Design
    {

        //Sets the title of the console window
        public static string Title = "The C-Sharks Archives\n\n\n";



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



        //Creates a console window-wide border of single dots
        public static void CreateThinBorder()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(".");
            }
        }



        //Creates a console window-wide border of double dots
        public static void CreateBorder()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("..");
            }
        }
    }

}
