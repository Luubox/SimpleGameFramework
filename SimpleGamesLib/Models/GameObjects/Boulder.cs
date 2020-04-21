using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGamesLib.Models.GameObjects
{
    class Boulder : GameObject
    {
        public Boulder(bool removable, int x, int y) : base(removable, x, y)
        {
        }
    }
}
