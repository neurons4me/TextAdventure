# TextAdventure
An OOP Engine for Text Based Adventure Games

## Roadmap
* World class to encapsulate all the parts of the world generation. Can have methods to help maintain hash table registries of Items, Rooms, Monsters, etc. for efficient access. 
* Implement Door class with bidirectionality and durability
* Implement crafting system. Need to put a list/hash table somewhere for the valid combinations of items linked to a child item. Method needs to remove parent items from inventory (maybe implement it so that not all items have to be consumable in the process?) and add the child item(s) to inventory.
