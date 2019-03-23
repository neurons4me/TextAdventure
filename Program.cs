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
            item02.itemAliases.Add("moldy bread");
            item02.canPickUp = true;
            Room RoomOne = new Room("this is the central room");
            RoomOne.roomInventory.Add(item01);
            RoomOne.roomInventory.Add(item02);

            Item item03 = new Item("a used sanitary napkin");
            Item item04 = new Item("a ticket stub from a 1989 metalica concert");
            Room RoomTwo = new Room("this is the eastern room");
            RoomTwo.roomInventory.Add(item03);
            RoomTwo.roomInventory.Add(item04);

            Item item05 = new Item("+2 magic pencil sharpener");
            Item item06 = new Item("a garden gnome in a leather suit");
            Room RoomThree = new Room("this is the northern room");
            RoomThree.roomInventory.Add(item05);
            RoomThree.roomInventory.Add(item06);

            Item item07 = new Item("a rock with a name");
            Item item08 = new Item("a ticket stub from a 2078 rolling stones concert");
            Room RoomFour = new Room("this is the southern room");
            RoomFour.roomInventory.Add(item07);
            RoomFour.roomInventory.Add(item08);

            Item item09 = new Item("just a little bit of navel fluff");
            Item item10 = new Item("someone's broken sonic screwdirver");
            Room RoomFive = new Room("this is the western room");
            RoomFive.roomInventory.Add(item09);
            RoomFive.roomInventory.Add(item10);
            
            // set up room/door relationships
            Door DoorOne = new Door(false ,RoomFive, RoomOne);
            RoomOne.westDoor = DoorOne;
            RoomFive.eastDoor = DoorOne;
            DoorOne.isHiddenFromWest = true;

            Door DoorTwo = new Door(true, RoomThree, RoomOne);
            RoomOne.northDoor = DoorTwo;
            RoomThree.southDoor = DoorTwo;
            
            Door DoorThree = new Door(false ,RoomOne, RoomTwo);
            RoomOne.eastDoor = DoorThree;
            RoomTwo.westDoor = DoorThree;

            Door DoorFour = new Door(true ,RoomOne, RoomFour);
            RoomOne.southDoor = DoorFour;
            RoomFour.northDoor = DoorFour;
            DoorFour.isLockedFromNorth = true;

            //Room currentRoom = RoomOne;

            // Set start room for player
            playerOne.currentRoom = RoomOne;

            // Start the main game logic loop here


            // playerOne.takeItem("moldy bread");

            // playerOne.movePlayer(1);

        bool stayInMainLoop = true;

        while (stayInMainLoop)
        {
            
            string playerInput = Console.ReadLine();

            // rudimentary parsing for interactive testing purpose
            // not to be allowed to be a messy sea of if statements in final product!
            // a parsing static function or two or three or ten would be the better way to go
            // breaking up input into tokens to be parsed like a command line parses arguments and options
            
            if (playerInput == "go north")
            {
            playerOne.movePlayer(1);
            }
            if (playerInput == "go east")
            {
            playerOne.movePlayer(2);
            }
            if (playerInput == "go south")
            {
            playerOne.movePlayer(3);
            }
            if (playerInput == "go west")
            {
            playerOne.movePlayer(4);
            }
            if (playerInput == "quit")
            {
            stayInMainLoop = false;
            }
            if (playerInput == "reset")
            {
            playerOne.currentRoom = RoomOne;
            }
        
        
        
        
        
        
        }

        }
    }
}
