using System;
using System.Net;
using System.Collections.Generic;

namespace TextAdventure{

public class Player
{

public Int16 location {get; set;}

//public List<string> playerInventory {get; set;}

public List<Item> playerInventory { get; set; } = new List<Item>();

public String name {get ; set;}

public Int16 hitPoints {get; set;}

public Player()
{
    //Set default starting values

    location = 1;
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

    location = 1;
    name = customName;
    Item item01 = new Item("rusty nail");
    Item item02 = new Item("soggy flannel hat");

    playerInventory.Add(item01);
    playerInventory.Add(item02);
    hitPoints = 100;

}

}



}