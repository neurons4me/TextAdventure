using System;
using System.Net;
using System.Collections.Generic;

namespace TextAdventure{

public class Player
{

public Room currentRoom {get; set;}

//public List<string> playerInventory {get; set;}

public List<Item> playerInventory { get; set; } = new List<Item>();

public String name {get ; set;}

public Int16 hitPoints {get; set;}

public Player()
{
    //Set default starting values

    name = "Default Dave";
    
    Item item01 = new Item("rusty nail");
    Item item02 = new Item("soggy flannel hat");

    playerInventory.Add(item01);
    playerInventory.Add(item02);
    
    hitPoints = 100;

}

public Player(string customName)
{
    //Set default starting values with a player supplied name

    name = customName;
    Item item01 = new Item("rusty nail");
    Item item02 = new Item("soggy flannel hat");

    playerInventory.Add(item01);
    playerInventory.Add(item02);
    hitPoints = 100;

}

public void movePlayer(Int16 chosenDirection)
{

    // that code does not presently handle the fact that an entire room does not have to be locked or hidden from all sides
    // each room should have a sub property to account for sides being locked or not
    // could be as simple as having isLocked and isHidden in 4 element arrays and accessing the appropriate one for each check
    // probably the best way to aproach it would be to have door be its own model that knows what rooms it belongs to and it's status on either side
    // If I do it that way I'll have to do some logic rewrite below but this way allows for doors that are hidden or locked on only one side

            //
            
            
            switch (chosenDirection)
            {
                case 1:
                

                if (currentRoom.northDoor != null && currentRoom.northDoor.isHiddenFromSouth != true)
                {
                if (currentRoom.northDoor.isLockedFromSouth != true)
                {
                    currentRoom = currentRoom.northDoor.northRoom;
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

                break;

                case 2:
                

                if (currentRoom.eastDoor != null && currentRoom.eastDoor.isHiddenFromWest != true)
                {
                if (currentRoom.eastDoor.isLockedFromWest != true)
                {

                    currentRoom = currentRoom.eastDoor.eastRoom;
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

                break;

                case 3:
                

                if (currentRoom.southDoor != null && currentRoom.southDoor.isHiddenFromNorth != true)
                {
                if (currentRoom.southDoor.isLockedFromNorth != true)
                {

                    currentRoom = currentRoom.southDoor.southRoom;
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

                break;
                case 4:
                

                if (currentRoom.westDoor != null && currentRoom.westDoor.isHiddenFromEast != true)
                {
                if (currentRoom.westDoor.isLockedFromEast != true)
                {

                    currentRoom = currentRoom.westDoor.westRoom;
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

                break;

            }




}




public void takeItem(string itemSearchString)
{
Item itemToMove = null;            
            // searches the room inventory list of items for an item that has an alias matching the search term
            foreach (Item item in currentRoom.roomInventory)
            {
                if (item.itemAliases.Contains(itemSearchString))
                {
                    itemToMove = item;
                }
            }
            // if a valid match was found above and we will remove it from the room and add it to the player only as long as the item can be picked up
            
            
            if (itemToMove != null && itemToMove.canPickUp)
            {
                if (itemToMove.canPickUp)
                {
                currentRoom.roomInventory.Remove(itemToMove);
                this.playerInventory.Add(itemToMove);
                Console.WriteLine("You have pocketed the " + itemToMove.itemName);
                }
                else
                {
                    Console.WriteLine("You can't pick that up.");
                }
            }
            else
            {
                Console.WriteLine("That thing is not here.");
            }

}



}
}