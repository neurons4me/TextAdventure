using System;
using System.Net;
using System.Collections.Generic;

namespace TextAdventure{

public class Player
{

public Int16 location {get; set;}

//public List<string> playerInventory {get; set;}

public List<string> playerInventory { get; set; } = new List<string>();

public String name {get ; set;}

public Int16 hitPoints {get; set;}

public Player()
{
    //Set default starting values

    location = 1;
    name = "Default Dave";
    //List<string> playerInventory = new List<string>();
    playerInventory.Add("rusty nail");
    playerInventory.Add("soggy flannel hat");
    hitPoints = 100;

}

public Player(string customName)
{
    //Set default starting values with a player supplied name

    location = 1;
    name = customName;
    //List<string> playerInventory = new List<string>();
    playerInventory.Add("rusty nail");
    playerInventory.Add("soggy flannel hat");
    hitPoints = 100;

}

}



}