using System;
using System.Collections.Generic;

namespace TextAdventure
{
    public class DisplayToConsole
    {
        // Can set the console window size with Console.SetWindowSize()
        public static void initDisplay()
        {
            Console.SetWindowSize(120, 40);
            Console.SetBufferSize(120, 40);
            Console.Clear();
            Console.Title = "Text Adventure";
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