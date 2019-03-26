using System;

namespace TextAdventure
{
    class MapBuilder
    {
        public static DungeonMap buildMap ()
        {
            DungeonMap outputMap = new DungeonMap();

            // make an array of Room
            // make a list (stack) to track which rooms we've visited
            // add current room to stack
            // check neighbor rooms to see if they have been visited
            // as long as there is an unvisited neighbor room randomly pick one of the unvisited rooms
            // add a door to the wall in the direction of the next room
            // add a randomized number of doors to any additional visited rooms
            // add current room to stack
            // move to the next room and make that the current room
            //... repeat until depth limit is reached (could be full grid or partial) OR UNTIL there are no unvisited neighbors
            // IF there are no unvisited neighbors AND depth limit is not reached THEN pop Room off stack and set previous room to current room
            // ... repead until depth limit is reached



            return outputMap;
        }

        // helper methods
    
    }


}