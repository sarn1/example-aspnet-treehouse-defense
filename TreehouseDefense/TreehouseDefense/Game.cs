﻿using System;

namespace TreehouseDefense
{
    class Game
    {
        static void Main()
        {
            // convention is to name classes with upper case first letter, so you can name the object by their type (class) 
            //object is an instance of a class
            Tower tower = new Tower();

            Map map = new Map(8,5);
            // map.Width = 8;  //can not do, due to readonly access

            Point point = new Point(9, 6);
            Point point2 = new Point(2, 3);


            Console.WriteLine(map.Width);
            Console.WriteLine(map.OnMap(point));    //not in bound
            Console.WriteLine(map.OnMap(point2));   //in bound
            
            Console.WriteLine("---------Overload----------");
            Console.WriteLine(point.DistanceTo(2, 3));
            Console.WriteLine(point.DistanceTo(point2));


            Console.WriteLine("---------Inheritance----------");
            MapLocation mappoint = new MapLocation(4, 2, map);
            Console.WriteLine("MapLocation using Point class's distance to: " + mappoint.DistanceTo(point2) );
            Console.WriteLine(mappoint is MapLocation);
            Console.WriteLine(mappoint is Point);

            Console.WriteLine("----------Exception---------");
            //exception
            try
            {
                //maplocation throws exception in the constructor (MapLocation.cs)
                MapLocation mapLocation = new MapLocation(1000, 1000, map);
            } 
            catch(Exception)
            {
                Console.WriteLine("Not on the map!"); 
            }





            Console.ReadLine();
        }
    }
}
