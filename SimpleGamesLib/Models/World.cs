using System;
using System.Collections.Generic;

namespace SimpleGamesLib
{
    public class World
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public List<Creature> Creatures { get; set; }
        public List<GameObject> Objects { get; set; }

        public World(int height = 20, int width = 20)
        {
            Height = height;
            Width = width;
            GenerateWorld();
        }

        private void GenerateWorld()
        {
            //TODO this
        }
    }
}
