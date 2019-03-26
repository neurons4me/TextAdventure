using System.Collections.Generic;

namespace TextAdventure
{
    public class DungeonMap
    {
        private List<Room> Rooms {get; set;}

        private List<Door> Doors {get; set;}


    public void addRoom (Room roomToAdd)
    {
        this.Rooms.Add(roomToAdd);
    }

    public void addDoor (Door doorToAdd)
    {
        this.Doors.Add(doorToAdd);
    }


        

    }

    
}