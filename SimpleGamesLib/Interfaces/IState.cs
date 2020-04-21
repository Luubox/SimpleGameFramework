using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGamesLib.Interfaces
{
    public interface IState
    {
        void Interact(Creature creature);
    }
}
