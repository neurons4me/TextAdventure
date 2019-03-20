using System;
using System.Net;
using System.Collections.Generic;

namespace TextAdventure
{

public class Item
{


    public string longDescription {get; set;}
    public string shortDescription {get; set;}
    public List<String> itemAliases { get; set; } = new List<String>();
    public string itemContext {get; set;}
    public Int16 durability {get; set;}
    public string itemName {get; set;}

// TODO probably will need a list of possible actions as a field too

    
    public Item(string name)
    {
        itemName = name;
    }


}





}
