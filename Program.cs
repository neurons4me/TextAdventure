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
            List<string> roomOneItems = new List<string>();
            roomOneItems.Add("holy hand grenade of Antioch");
            roomOneItems.Add("moldy bread");

            Room RoomOne = new Room(0, 2, 0, 0, 1, roomOneItems, false, false, "this is just an ordinary room really");

            List<string> roomTwoItems = new List<string>();
            roomTwoItems.Add("a used sanitary napkin");
            roomTwoItems.Add("a ticket stub for a metalica concert");

            Room RoomTwo = new Room(0, 0, 0, 1, 2, roomTwoItems, false, false, "this is a new room and the world is full of posibilities");

            Room currentRoom = RoomOne;


            //
            Int32 targetRoomNumber = currentRoom.eastNeighbor;
            if (currentRoom.eastNeighbor != 0 && currentRoom.isHidden != true)
            {
                if (currentRoom.isLocked != true)
                {
                    // to properly make this work need to make helper function to find which instance of Room has the targetRoomNumber
                    currentRoom = RoomTwo;
                    Console.WriteLine("You habe entered a new room." + currentRoom.roomDescription);

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


        }
    }
}
