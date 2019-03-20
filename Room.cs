using System;
using System.Collections.Generic;


namespace TextAdventure
{

public class Room
{
public Room northNeighbor {get;set;}
public Room eastNeighbor {get;set;}
public Room southNeighbor {get;set;}
public Room westNeighbor {get;set;}
public List<Item> roomInventory { get; set; } = new List<Item>();
public bool isLocked {get;set;}
public bool isHidden {get;set;}
public string roomDescription {get;set;}

public Room(bool locked, bool hidden, string description)
{

isLocked = locked;
isHidden = hidden;
roomDescription = description;

}

}





}