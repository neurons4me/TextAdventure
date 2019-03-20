using System;
using System.Collections.Generic;


namespace TextAdventure
{

public class Room
{
public Int16 northNeighbor {get;set;}
public Int16 eastNeighbor {get;set;}
public Int16 southNeighbor {get;set;}
public Int16 westNeighbor {get;set;}
public Int16 roomNumber {get; set;}
public List<string> roomInventory { get; set; } = new List<string>();
public bool isLocked {get;set;}
public bool isHidden {get;set;}
public string roomDescription {get;set;}

public Room(Int16 north, Int16 east, Int16 south, Int16 west, Int16 roomID, List<string> items, bool locked, bool hidden, string description)
{
northNeighbor = north;
eastNeighbor = east;
southNeighbor = south;
westNeighbor = west;
roomNumber = roomID;
roomInventory = items;
isLocked = locked;
isHidden = hidden;
roomDescription = description;
// TODO add method on init to register this instances room number to a reference to this room so we can look up each instance by the roomo number

}

}





}