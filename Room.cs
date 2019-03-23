using System;
using System.Collections.Generic;


namespace TextAdventure
{

public class Room
{
// public Room northNeighbor {get;set;}
// public Room eastNeighbor {get;set;}
// public Room southNeighbor {get;set;}
// public Room westNeighbor {get;set;}
public Door northDoor {get; set;}
public Door eastDoor {get; set;}
public Door southDoor {get; set;}
public Door westDoor {get; set;}
public String roomID {get; set;}
public List<Item> roomInventory { get; set; } = new List<Item>();
// public bool isLocked {get;set;}
// public bool isHidden {get;set;}
public string roomDescription {get;set;}

public Room(string description)
{

// isLocked = locked;
// isHidden = hidden;
roomDescription = description;

}

}





}