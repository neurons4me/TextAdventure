# TextAdventure
An OOP Engine for Text Based Adventure Games

## Roadmap
* World class to encapsulate all the parts of the world generation. Can have methods to help maintain hash table registries of Items, Rooms, Monsters, etc. for efficient access. A world level registration by object type would let us call all of a particular type by itterating through the registrated list/array of objects and calling a method on them (eg. onTick() to perform whatever action they are supposed to perform as time marches on)
* Implement Door class with bidirectionality and durability
* Implement crafting system. Need to put a list/hash table somewhere for the valid combinations of items linked to a child item. Method needs to remove parent items from inventory (maybe implement it so that not all items have to be consumable in the process?) and add the child item(s) to inventory.
* Implement Monster classes. HuntingMonster, WanderingMonster, StationaryMonster should all inherit from Monster.
  1. HuntingMonster will act as a kind of timer on the game. The hunting monster(s) will be next to impossible to survive and the player should be running from it in most cases. Will be able to move between rooms (taking time to destroy doors on the way). Will give "audible" warnings to player character regarding proximity. Will need some kind of pathfinding algo to find way to player (probably with some chance of not making the optimal pick each time to keep things non determinisitc. Will also need to use some variant of pathfinding algo in setup to make sure monster is optimal distance from player. 
  2. WanderingMonster(s) will be easier to kill than the hunting monster. Will not track the player but will move randomly. Probably best to not have these monsters destroying doors (can be small, limber, or flying monsters that don't need doors to get between rooms).
  3. StationaryMonster(s) will be easy to kill. Will not tack player or move  at all.
