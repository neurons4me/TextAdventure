using System;
using System.Collections.Generic;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {

            Player playerOne = new Player("Adam");

            // temporary builders for the first test rooms
            // TODO all of this setup needs to go in a factory method eventually
            
            Item item01 = new Item("the holy hand grenade of antioch");
            Item item02 = new Item("a piece of moldy bread that looks like jesus");
            item02.itemAliases.Add("a piece of moldy bread that looks like jesus");
            Room RoomOne = new Room(false, false, "this is just an ordinary room really");
            RoomOne.roomInventory.Add(item01);
            RoomOne.roomInventory.Add(item02);
            


            Item item03 = new Item("a used sanitary napkin");
            Item item04 = new Item("a ticket stub from a 1989 metalica concert");
            Room RoomTwo = new Room(true, true, "this is a new room and the world is full of posibilities");
            RoomTwo.roomInventory.Add(item03);
            RoomTwo.roomInventory.Add(item04);
            
            // set up room relationships
            RoomTwo.westNeighbor = RoomOne;
            RoomOne.eastNeighbor = RoomTwo;



            Room currentRoom = RoomOne;
            // Start the main game logic loop here


            // temp test of the basic function of moving to another room assuming east was selected as movement dirrection
            if (currentRoom.eastNeighbor != null && currentRoom.eastNeighbor.isHidden != true)
            {
                if (currentRoom.eastNeighbor.isLocked != true)
                {

                    currentRoom = currentRoom.eastNeighbor;
                    Console.WriteLine("You have entered a new room." + currentRoom.roomDescription);

                }
                else
                {
                    Console.WriteLine("The door is locked buddy... pall... dude.");
                }

            }
            else
            {
                Console.WriteLine("There is no exit there");
            }

            // player picks up item from room
        
            Item itemToMove = null;
            string itemAlias = "a piece of moldy bread that looks like jesus"; // TODO move this to it's own function and have itemAlias as a param
            
            // searches the room inventory list of items for an item that has an alias matching the search term
            foreach (Item item in currentRoom.roomInventory)
            {
                if (item.itemAliases.Contains(itemAlias))
                {
                    itemToMove = item;
                }
            }
            // if a valid match was found above and we will remove it from the 
            if (itemToMove != null)
            {

            currentRoom.roomInventory.Remove(itemToMove);
            playerOne.playerInventory.Add(itemToMove);

            Console.WriteLine("You have pocketed the " + itemToMove.itemName);


            }
            



        }
    }
}
