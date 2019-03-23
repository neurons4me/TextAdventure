using System;
using System.Collections.Generic;


namespace TextAdventure
{

public class Room
{
public Door northDoor {get; set;}
public Door eastDoor {get; set;}
public Door southDoor {get; set;}
public Door westDoor {get; set;}
public List<Item> roomInventory { get; set; } = new List<Item>();
public string roomDescription {get;set;}

public Room(string description)
{

roomDescription = description;

}

private Int16 doorCount()
{
    Int16 count = 0;
    
    if (this.northDoor != null)
    {
        count += 1;
    }
    if (this.eastDoor != null)
    {
        count += 1;
    }
    if (this.southDoor != null)
    {
        count += 1;
    }
    if (this.westDoor != null)
    {
        count += 1;
    }
    return count;
}

public String combinedDoorsDescription()
{
    String outputString = "";
    if (this.northDoor != null && this.northDoor.isHiddenFromSouth != true)
    {
        outputString += "There is a " + this.northDoor.description + " to the north. ";
    }
    if (this.eastDoor != null && this.eastDoor.isHiddenFromWest != true)
    {
        outputString += "There is a " + this.eastDoor.description + " to the east. ";
    }
    if (this.southDoor != null && this.northDoor.isHiddenFromNorth!= true)
    {
        outputString += "There is a " + this.southDoor.description + " to the south. ";
    }
    if (this.westDoor != null && this.northDoor.isHiddenFromEast != true)
    {
        outputString += "There is a " + this.westDoor.description + " to the west. ";
    }
    
    
    return outputString;


}


}





}