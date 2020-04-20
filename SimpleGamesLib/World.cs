using System;
using System.Collections.Generic;

namespace SimpleGamesLib
{
    public class World
    {
        public int X { get; set; }
        public int Y { get; set; }

        public List<Creature> Creatures { get; set; }
        public List<GameObject> Objects { get; set; }

        public World(int x = 20, int y = 20)
        {
            X = x;
            Y = y;
            GenerateWorld();
        }

        private void GenerateWorld()
        {
            //TODO this
        }
    }
}
