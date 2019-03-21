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

public static void movePlayer(Int16 direction)
{

    // move player from main can be moved here
    // references to currentPlayer in that code can be changed to references to 'this'
    // that code does not presently handle the fact that an entire room does not have to be locked or hidden from all sides
    // each room should have a sub property to account for sides being locked or not
    // could be as simple as having isLocked and isHidden in 4 element arrays and accessing the appropriate one for each check
    // that is however not very readable so a sep
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