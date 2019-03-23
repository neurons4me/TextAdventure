# TextAdventure
An OOP Engine for Text Based Adventure Games

## Roadmap
* World class to encapsulate all the parts of the world generation. Can have methods to help maintain hash table registries of Items, Rooms, Monsters, etc. for efficient access. A world level registration by object type would let us call all of a particular type by itterating through the registrated list/array of objects and calling a method on them (eg. onTick() to perform whatever action they are supposed to perform as time marches on)
* ~~Implement Door class with bidirectionality and durability~~
* Implement crafting system. Need to put a list/hash table somewhere for the valid combinations of items linked to a child item. Method needs to remove parent items from inventory (maybe implement it so that not all items have to be consumable in the process?) and add the child item(s) to inventory.
  *Possible approach:
    1. make list of Item objects you want to combine
    2. pull the name property of those objects and make a list of strings
    3. sort the list
    4. combine it all into a single string
    5. toLower or toUpper (doesnt matter as long as you're consistent) the resulting string
    6. check it against hash table that contains this string as the key and the new crafted object (or a call to it's constructor) as the value.
    7. If value is null then the Item combination is not a valid crafting
    8. Else if a valid object was found check if each item isConsumable, if it is remove it from the Player or Room (some Items may not be pocketable like a large table but still should be able to be used so crafting needs to search both contexts) and decrement the duribillity if applicable (a method within Item to handle it's durability decrease, or destruction... onUseInCrafting()).
    9. Once valid reactant Items are dealt with add the product Item to it's appropriate context (if canPickUp == true then put in Players inventory, otherwise it goes to the room).
* Implement Monster classes. HuntingMonster, WanderingMonster, StationaryMonster should all inherit from Monster.
  1. HuntingMonster will act as a kind of timer on the game. The hunting monster(s) will be next to impossible to survive and the player should be running from it in most cases. Will be able to move between rooms (taking time to destroy doors on the way). Will give "audible" warnings to player character regarding proximity. Will need some kind of pathfinding algo to find way to player (probably with some chance of not making the optimal pick each time to keep things non determinisitc. Will also need to use some variant of pathfinding algo in setup to make sure monster is optimal distance from player. 
  2. WanderingMonster(s) will be easier to kill than the hunting monster. Will not track the player but will move randomly. Probably best to not have these monsters destroying doors (can be small, limber, or flying monsters that don't need doors to get between rooms).
  3. StationaryMonster(s) will be easy to kill. Will not tack player or move  at all.
* Implement Event class to handle world events. Instances will be tracked and handled by World. Will have props and methods to allow implementation of events firing on a basis of mtth (mean time to happen) with a min and max time to happen options. A constant time trigger should be there as well. Event instances should track how many times they are allowed to fire and how many times they have fired.
* Methods needed:
 1. lookAround() - pulls in the description of the room, it's items, it's doors, and any monsters and returns a formatted version for display : belongs in Player
 2. dropItem(Item) - drop an item in Player inventory and add it to Room inventory : belongs in Player
 3. unlockDoor(Item) - check the validKeys list of the Door for the Item presented as a key and unlocks if valid and returns feedback: belongs in Door
