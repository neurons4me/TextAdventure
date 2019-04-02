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
            // TODO once the properties to include are fairly stable move these details to an external file for perisistance
            
            Item item01 = new Item("hand grenade");
            Item item02 = new Item("moldy bread");
            item02.itemAliases.Add("bread");
            item02.canPickUp = true;
            item01.shortDescription = "the holy Hand Grenade of Antioch!";
            item02.shortDescription = "a slice of Wonderbread with a mold patch that looks like Jesus Christ!";
            item01.itemContext = "On the floor in the corner there is";
            item02.itemContext = "Under a loose floorboard in the middle of the room you see";
            Room RoomOne = new Room("This is a large central room. The walls are composed of malachite and granite with fine golden veins snaking all around.");
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
            DoorOne.description = "A red wooden door";

            Door DoorTwo = new Door(true, RoomThree, RoomOne);
            RoomOne.northDoor = DoorTwo;
            RoomThree.southDoor = DoorTwo;
            DoorTwo.description = "A blue wooden door";
            
            Door DoorThree = new Door(false ,RoomOne, RoomTwo);
            RoomOne.eastDoor = DoorThree;
            RoomTwo.westDoor = DoorThree;
            DoorThree.description = "A large iron door";

            Door DoorFour = new Door(true ,RoomOne, RoomFour);
            RoomOne.southDoor = DoorFour;
            RoomFour.northDoor = DoorFour;
            DoorFour.isLockedFromNorth = true;
            DoorFour.description = "A magical shimmering door";

            // Set start room for player
            playerOne.currentRoom = RoomOne;

            // Start the main game logic loop here

        bool stayInMainLoop = true;

        DisplayToConsole.titleScreen();

        while (stayInMainLoop)
        {
            Console.WriteLine("What do you want to do?");
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
            if (playerInput == "look around")
            {
            Console.WriteLine(playerOne.lookAround());
            }

        
        
        
        
        
        
        }

        }
    }
}
