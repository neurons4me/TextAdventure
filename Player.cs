using System;
using System.Net;
using System.Collections.Generic;

namespace TextAdventure{

public class Player
{

public Room currentRoom {get; set;}
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
    item01.canBeDropped = true;
    item01.canBeDropped = false;
    Item item02 = new Item("soggy flannel hat");

    playerInventory.Add(item01);
    playerInventory.Add(item02);
    hitPoints = 100;

}


public List<string> buildDirectionTips()
{
    List<string> outputList = new List<string>();
    if (this.currentRoom.northDoor != null && this.currentRoom.northDoor.isHiddenFromSouth) {outputList.Add("NORTH");}
    if (this.currentRoom.eastDoor != null && this.currentRoom.eastDoor.isHiddenFromWest) {outputList.Add("EAST");} 
    if (this.currentRoom.southDoor != null && this.currentRoom.southDoor.isHiddenFromNorth) {outputList.Add("SOUTH");} 
    if (this.currentRoom.westDoor != null && this.currentRoom.westDoor.isHiddenFromEast) {outputList.Add("WEST");}
    return outputList;
}

public void movePlayer(Int16 chosenDirection)
{            
            
            switch (chosenDirection)
            {
                case 1:
                

                if (currentRoom.northDoor != null && currentRoom.northDoor.isHiddenFromSouth != true)
                {
                if (currentRoom.northDoor.isLockedFromSouth != true)
                {
                    if (currentRoom.northDoor.isOpen != true)
                    {
                    currentRoom.northDoor.openDoor();
                    Console.WriteLine("You have opened the door.");
                    }
                    currentRoom = currentRoom.northDoor.northRoom;
                    Console.WriteLine("You have entered a new room. " + currentRoom.roomDescription);
                }
                else
                    {
                        Console.WriteLine("The door is locked.");
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
                   
                    if (currentRoom.eastDoor.isOpen != true)
                    {
                    currentRoom.eastDoor.openDoor();
                    Console.WriteLine("You have opened the door. ");
                    }
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
                    
                    if (currentRoom.southDoor.isOpen != true)
                    {
                    currentRoom.southDoor.openDoor();
                    Console.WriteLine("You have opened the door. ");
                    }
                    
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
                    if (currentRoom.westDoor.isOpen != true)
                    {
                    currentRoom.westDoor.openDoor();
                    Console.WriteLine("You have opened the door. ");
                    }
                    
                    currentRoom.westDoor.openDoor();
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
                // Item exists in current context and can be taken
                currentRoom.roomInventory.Remove(itemToMove);
                this.playerInventory.Add(itemToMove);
                ItemResponse responseObject = new ItemResponse(1, itemToMove,this);
                DisplayToConsole.displayItemResponse(responseObject);
                
            }
            else if (itemToMove == null)
            {
                // Item does not exist in current context
                ItemResponse responseObject = new ItemResponse(2, this);
                DisplayToConsole.displayItemResponse(responseObject);
            }
            else
            {
                // Item exists in current context but cannot be taken
                ItemResponse responseObject = new ItemResponse(3, itemToMove,this);
                DisplayToConsole.displayItemResponse(responseObject);
            }

}
public void dropItem(String itemSearchString)
{
    Item itemToMove = null;            
            // searches the Player inventory list of items for an item that has an alias matching the search term
            foreach (Item item in this.playerInventory)
            {
                if (item.itemAliases.Contains(itemSearchString))
                {
                    itemToMove = item;
                }
            }
            if (itemToMove != null && itemToMove.canBeDropped)
            {
                // Item exists in current context and can be taken
                playerInventory.Remove(itemToMove);
                currentRoom.roomInventory.Add(itemToMove);
                ItemResponse responseObject = new ItemResponse(10, itemToMove, this);
                DisplayToConsole.displayItemResponse(responseObject);
            }
            else if (itemToMove == null)
            {
                // Item does not exist in current context
                ItemResponse responseObject = new ItemResponse(11, itemToMove, this);
                DisplayToConsole.displayItemResponse(responseObject);
            }
            else
            {
                // Item exists in current context but cannot be taken
                ItemResponse responseObject = new ItemResponse(12, itemToMove, this);
                DisplayToConsole.displayItemResponse(responseObject);
            }
}

public String lookAround()
// TODO needs to gracefully handle null objects
// TODO needs to return a responseObject for handling by DisplayToConsole

{
    String itemDescriptions = "";

    foreach (Item item in this.currentRoom.roomInventory)
    {
        itemDescriptions = item.itemContext + " " + item.shortDescription;
    }
    
    
    String doorsDescription = this.currentRoom.combinedDoorsDescription();

    String outputString = this.currentRoom.roomDescription + itemDescriptions + doorsDescription;



    
    return outputString;
}
}
}