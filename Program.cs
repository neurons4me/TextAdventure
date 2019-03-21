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
            Room RoomOne = new Room(false, false, "this is the central room");
            RoomOne.roomInventory.Add(item01);
            RoomOne.roomInventory.Add(item02);

            Item item03 = new Item("a used sanitary napkin");
            Item item04 = new Item("a ticket stub from a 1989 metalica concert");
            Room RoomTwo = new Room(false, false, "this is the eastern room");
            RoomTwo.roomInventory.Add(item03);
            RoomTwo.roomInventory.Add(item04);

            Item item05 = new Item("+2 magic pencil sharpener");
            Item item06 = new Item("a garden gnome in a leather suit");
            Room RoomThree = new Room(false, false, "this is the northern room");
            RoomThree.roomInventory.Add(item05);
            RoomThree.roomInventory.Add(item06);

            Item item07 = new Item("a rock with a name");
            Item item08 = new Item("a ticket stub from a 2078 rolling stones concert");
            Room RoomFour = new Room(false, false, "this is the southern room");
            RoomFour.roomInventory.Add(item07);
            RoomFour.roomInventory.Add(item08);

            Item item09 = new Item("just a little bit of navel fluff");
            Item item10 = new Item("someone's broken sonic screwdirver");
            Room RoomFive = new Room(false, false, "this is the western room");
            RoomFive.roomInventory.Add(item09);
            RoomFive.roomInventory.Add(item10);
            
            // set up room relationships
            RoomOne.eastNeighbor = RoomTwo;
            RoomOne.northNeighbor = RoomThree;
            RoomOne.southNeighbor = RoomFour;
            RoomOne.westNeighbor = RoomFive;

            RoomTwo.westNeighbor = RoomOne;

            RoomThree.southNeighbor = RoomOne;

            RoomFour.northNeighbor = RoomOne;

            RoomFive.eastNeighbor = RoomOne;



            //Room currentRoom = RoomOne;

            // Set start room for player
            playerOne.currentRoom = RoomOne;

            // Start the main game logic loop here


            playerOne.takeItem("moldy bread");

            playerOne.movePlayer(1);



        }
    }
}
