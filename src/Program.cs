using System;
using System.Linq;
using Trestlebridge.Actions;
using Trestlebridge.Models;

namespace Trestlebridge
{
    class Program
    {
        static void DisplayBanner()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            Farm Trestlebridge = new Farm();

            while (true)
            {
                DisplayBanner();
                Console.WriteLine("1. Create Facility");
                Console.WriteLine("2. Purchase Animals");
                Console.WriteLine("3. Purchase Seeds");
                Console.WriteLine("4. Display Farm Status");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.WriteLine("Choose a FARMS option");
                Console.Write("> ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    DisplayBanner();
                    CreateFacility.CollectInput(Trestlebridge);
                }
                else if (option == "2")
                {
                    DisplayBanner();
                    PurchaseStock.CollectInput(Trestlebridge);
                }
                else if (option == "3")
                {
                    DisplayBanner();
                    PurchaseSeed.CollectInput(Trestlebridge);
                }
                else if (option == "4")
                {
                    DisplayBanner();
                    Console.WriteLine(Trestlebridge);
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Today is a great day for farming. May you drown in the great Kraken's infinite love.");
                    Console.WriteLine(@"              
                 7... 7                 
              77.......7                
             7...........               
             .............7             
           I...............:7           
           .................            
  777       ...............7       7    
 7.I~.7      7...........7      7.~7.7  
 77  .,       ...........       ,.      
     .7       ...........       7.7     
    ..7       ...........        ..     
   7.7        ...........        7.     
  7=.         ...........        7..    
   ..  7      7:........         7..    
   I...~..7    .,......,    7..:...,    
  7...77 7.    +.......,    .   7...7   
  :. ...77  7 I.........I7  777...7.,   
  .. 7~.........................~7 ..   
  7.77 777++7......7......7?=77   7.7   
   7..7   7........7........    7..+    
     ?......7+..7..7..7..+7......?      
           7+.., .. ..77..+7            
          7=... 7.. .. 7....            
          ..+..  ..7..7 ,.+..7          
        7..I~.7 7..7..7 7.~7..7         
      7...  ..7 +.? ?.= 7..  ...7       
    I..+    ,.7 ..   .. 7.,7  77..I     
   ..77     I.7 ..   .. 7.I      7..7   
  ,.7       7.: ..  7..7:.        7..   
 7.=7 7.7~.77....     .... 7.:7.   7.7  
 7.       .?  ...     ...7 7.7     7.7  
 7.77    7.7  ..7      .. 77.      7.7  
  ..7  77..   ..7     7..7  ..7   7..   
   :.....77  ~.?.     .7.:   7......7   
             ..77    777..              
             :.7       7.:              
             7.7       7.7              
              .:       7.7              
              ..       ..7              
              7.7      .7               
               .7    77.7               
                .    7.7                
               7,7   7.7                
                 .7  .                   
                         GlassGiant.com
                    ");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Welcome to timeout.");
                    Console.WriteLine("Your mom and I are very disappointed.");
                    Console.WriteLine();
                    Console.WriteLine($"Invalid option: {option}");
                    Console.ReadLine();
                }
            }
        }
    }
}
