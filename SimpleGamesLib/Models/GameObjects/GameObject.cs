using System.Collections.Generic;
using SimpleGamesLib.Enums;

namespace SimpleGamesLib
{
    public abstract class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Removable { get; set; }
        public ObjectType Type { get; set; }

        //public GameObject()
        //{
            
        //}

        public GameObject(bool removable, int x, int y)
        {
            X = x;
            Y = y;
            Removable = removable;
        }

        //static List<GameObject> _objects = new List<GameObject>()
        //{
        //    new GameObject("Boulder", false),
        //    new GameObject("Bush", true),
        //    new GameObject("Chest", true)
        //};

    }
}