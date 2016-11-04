using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Move
    {
        public static bool canGo = true;

        /**
        * This method takes the new location and assigns it to the player's current location.
        */
        public static void ChangeLocation(Room location)
        {
            Player.CurrentLocation = location;

        }

        /**
         * Move the player to a location.
         */
        public static void MoveTo(Room location)
        {
            // The player can enter this location
            ChangeLocation(location);

        }

        /**
         * If the player were to die or for any reason we need to send the player
         * back to the starting postion this will be the method called to do so.
         */
        public static void MoveHome()
        {
            MoveTo(World.Location[0]);
        }

        /**
         * The move method to move the player to the next room
         */
        public static void MoveToNew(string input)
        {
            int ele = World.Location.IndexOf(Player.CurrentLocation);
            switch (input)
            {                
                case "north" :
                    if (Player.CurrentLocation.LocationToNorth != -1)
                    {
                        MoveTo(World.Location[Player.CurrentLocation.LocationToNorth]);
                    }
                    else
                    {
                        canGo = false;
                    }                
                    break;
                case "east":
                    if(Player.CurrentLocation.LocationToEast != -1)
                    {
                        MoveTo(World.Location[Player.CurrentLocation.LocationToEast]);
                    }
                    else
                    {
                        canGo = false;
                    }                    
                    break;
                case "south":
                    if (Player.CurrentLocation.LocationToSouth != -1)
                    {
                        MoveTo(World.Location[Player.CurrentLocation.LocationToSouth]);
                    }
                    else
                    {
                        canGo = false;
                    }
                    break;
                case "west":
                    if (Player.CurrentLocation.LocationToWest != -1)
                    {
                        MoveTo(World.Location[Player.CurrentLocation.LocationToWest]);
                    }
                    else
                    {
                        canGo = false;
                    }
                    break;
            }
        }        
    }
}
