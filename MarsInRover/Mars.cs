using System;
using System.Collections.Generic;
using System.Text;

namespace MarsInRover
{
    public class Mars: IMap
    {
        public Coordinate mapSize;
       

        public Mars()
        {
            mapSize = new Coordinate() { x = 10, y = 10 };
        }

        public Mars(Coordinate mapSize)
        {
            this.mapSize = mapSize;
        }

        public int x { get; set; }
        public int y { get; set; }
    }
}
