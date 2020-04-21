using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGamesLib.Models.GameObjects
{
    class Chest : GameObject
    {
        public Chest(bool removable, int x, int y) : base(removable, x, y)
        {
        }
    }
}
