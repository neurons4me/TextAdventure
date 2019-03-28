using System.Collections.Generic;
using System;

namespace TextAdventure
{

    
    public abstract class TextBasedResponse
    {
        public List<string> commandTips {get; set;}

    }
    public class MovementResponse : TextBasedResponse
    {
        
    }

    public class LookAroundResponse : TextBasedResponse
    {

    }

    public class DropItemResponse : TextBasedResponse
    {

    }
        
    public class ItemResponse : TextBasedResponse
    {
        public Int16 itemInteractMode {get; private set;}
        // 0 = Error: item interaction mode not set
        // 1 = take item
        // 2 = item to take not found
        // 3 = item to take can not be taken
        // 10 = drop item
        // 11 = item to drop not found
        // 12 = item to take can not be dropped
        public Item itemToTakeorDrop {get; private set;}
        public Player currentPlayer {get; private set;}

        public ItemResponse (Int16 mode, Item item, Player player)
        {
        itemInteractMode = mode;
        itemToTakeorDrop = item;
        currentPlayer = player;
        buildDirectionTips();
        }

        public ItemResponse (Int16 mode, Player player)
        {
        itemInteractMode = mode;
        currentPlayer = player;
        buildDirectionTips();
        }

public void buildDirectionTips()
{
    List<string> outputList = new List<string>();
    if (this.currentPlayer.currentRoom.northDoor != null && this.currentPlayer.currentRoom.northDoor.isHiddenFromSouth) {commandTips.Add("GO NORTH");}
    if (this.currentPlayer.currentRoom.eastDoor != null && this.currentPlayer.currentRoom.eastDoor.isHiddenFromWest) {commandTips.Add("GO EAST");} 
    if (this.currentPlayer.currentRoom.southDoor != null && this.currentPlayer.currentRoom.southDoor.isHiddenFromNorth) {commandTips.Add("GO SOUTH");} 
    if (this.currentPlayer.currentRoom.westDoor != null && this.currentPlayer.currentRoom.westDoor.isHiddenFromEast) {commandTips.Add("GO WEST");}

    commandTips.Add("LOOK AROUND");
}

    }


}