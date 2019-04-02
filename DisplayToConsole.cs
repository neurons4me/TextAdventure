using System;
using System.Collections.Generic;
using System.Threading;

namespace TextAdventure
{
    public class DisplayToConsole
    {
        // Can set the console window size with Console.SetWindowSize()
        public static void initDisplay()
        {
            try
            {
            Console.SetWindowSize(120, 40);
            Console.SetBufferSize(120, 40);
            Console.ForegroundColor = (ConsoleColor)0;
            Console.BackgroundColor = (ConsoleColor)0;
                
            }
            catch (System.PlatformNotSupportedException)
            {
            Console.WriteLine("Can not automatically set window size in linux. Please set your console to 120 wide by 40 tall.");
            Console.WriteLine("Press enter when ready");
            Console.ReadLine();
            
            }
            for (int i = 0; i <= 40; i++)
            {
                Console.WriteLine("");
            }
            Console.Clear();
            Console.Title = "Text Adventure";
        }

        public static void titleScreen()
        {
            initDisplay();
            List<String> titleScreenLines = new List<String> {"╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║               ┌──────────────────────────────────────────────────────────────────────────────────────┐               ║","║               │                                                                                      │               ║","║               │                     Escape the Dungeon: A Text Adventure Game                        │               ║","║               │                                Written and Designed by                               │               ║","║               │                                       Adam McDaniel                                  │               ║","║               │                                                                                      │               ║","║               └──────────────────────────────────────────────────────────────────────────────────────┘               ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║                                                                                                                      ║","║ Hit Enter When Ready                                                                                                 ║","╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝"};
            foreach (String line in titleScreenLines)
            {
            Console.BackgroundColor = (ConsoleColor)8;
            Console.ForegroundColor = (ConsoleColor)15;
            Console.Write(line);
            Thread.Sleep(100);
            }
            Console.ReadLine();
            Console.Clear();


        }

        public static String wrapText(string textToWrap, Int16 charWrapValue)
        {
            string newLine = Environment.NewLine;
            // insert newline at the closest word before charWrapValue characters to the line
            String[] splitString = textToWrap.Split();
            String outputString = "";
            int charCounter = 0;
            foreach (string word in splitString)
            {
                charCounter += word.Length + 1;

                if (charCounter >= charWrapValue)
                {
                    charCounter = word.Length;
                    outputString += newLine;
                    outputString += word;
                    outputString += " ";
                }
                else
                {
                    outputString += word;
                    outputString += " ";
                }
            }
             
            return outputString;
        }

        public static void displayItemResponse (ItemResponse responseObject)
        {
        Int16 mode = responseObject.itemInteractMode;

        switch(mode)
        {
            case 1 : 
            Console.WriteLine("You have taken the " + responseObject.itemToTakeorDrop.itemName + " and added it to your inventory.");
            break;

            case 2 : 
            Console.WriteLine("That item is not here.");
            break;

            case 3 : 
            Console.WriteLine("The " + responseObject.itemToTakeorDrop.itemName +  " can not be picked up.");
            break;

            case 10 : 
            Console.WriteLine("You have removed the " + responseObject.itemToTakeorDrop.itemName + " from your inventory");
            break;

            case 11 : 
            Console.WriteLine("You can not drop that which you do not possess.");
            break;

            case 12 : 
            Console.WriteLine("The " + responseObject.itemToTakeorDrop.itemName + " can not be dropped. You are stuck with it.");
            break;
        }
        displayCommandSuggestions(responseObject.commandTips);
        }

        public static void displayCommandSuggestions(List<string> tips)
        {
            Console.WriteLine("Try one of these commands:");
            foreach (string tip in tips)
            {
                Console.WriteLine(tip);
            }

        }
    }



}