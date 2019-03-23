using System;
using System.Net;
using System.Collections.Generic;

namespace TextAdventure
{

public class Door
{

public Room northRoom {get; set;}
public Room eastRoom {get; set;}
public Room southRoom {get; set;}
public Room westRoom {get; set;}
public bool isLockedFromNorth {get; set;}
public bool isLockedFromEast {get; set;}
public bool isLockedFromSouth {get; set;}
public bool isLockedFromWest {get; set;}
public bool isHiddenFromNorth {get; set;}
public bool isHiddenFromEast {get; set;}
public bool isHiddenFromSouth {get; set;}
public bool isHiddenFromWest {get; set;}
public Int16 barricadeDurabilityFromNorth {get; set;}
public Int16 barricadeDurabilityFromEast {get; set;}
public Int16 barricadeDurabilityFromSouth {get; set;}
public Int16 barricadeDurabilityFromWest {get; set;}
public Int16 durability {get; set;}
public String description {get; set;}
public bool isOpen {get; set;}
public List<Item> validKeys {get; set;}


public Door(bool isNorthSouth ,Room northOrWestRoom ,Room southOrEastRoom)
{
    
    if (isNorthSouth)
    {
        northRoom = northOrWestRoom;
        southRoom = southOrEastRoom;
        
        isLockedFromNorth = false;
        isLockedFromSouth = false;
        
        isHiddenFromNorth = false;
        isHiddenFromSouth = false;

        barricadeDurabilityFromNorth = 0;
        barricadeDurabilityFromSouth = 0;

    }
    else
    {
        westRoom = northOrWestRoom;
        eastRoom = southOrEastRoom;
        
        isLockedFromWest = false;
        isLockedFromEast = false;
        
        isHiddenFromWest = false;
        isHiddenFromEast = false;

        barricadeDurabilityFromWest = 0;
        barricadeDurabilityFromEast = 0;

    }
    
    
    durability = 100;
    
    isOpen = false;




}

public String unlockDoor(Item putativeKey)
{
    // when Player method calls this make sure to handle the door not being locked at all there... Door does not readily know which direction it is being tried from so it is best handled in Player since it knows that
    // this method assumes it is receiving a valid, non-null Item that may or may not unlock the door; it returns a string with the output and changes the state of the door if valid

    String outputResponse = "You couldn't unlock the door with the " + putativeKey.itemName + ".";
    
    if (validKeys.Contains(putativeKey))
    {
    isLockedFromNorth = false;
    isLockedFromSouth = false;
    isLockedFromEast = false;
    isLockedFromWest = false;
    outputResponse = "You have unlocked the door!"; 
    }

    return outputResponse;
}

public void destroyDoor()
{
}

public void openDoor()
{
    isOpen = true;

    isLockedFromNorth = false;
    isLockedFromSouth = false;
    isHiddenFromNorth = false;
    isHiddenFromSouth = false;
    barricadeDurabilityFromNorth = 0;
    barricadeDurabilityFromSouth = 0;
    isLockedFromEast = false;
    isLockedFromWest = false;
    isHiddenFromEast = false;
    isHiddenFromWest = false;
    barricadeDurabilityFromEast = 0;
    barricadeDurabilityFromWest = 0;

}

}



}

