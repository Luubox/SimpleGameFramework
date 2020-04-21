using System;
using System.Collections.Generic;
using System.Text;
using SimpleGamesLib.Models;

namespace SimpleGamesLib.Interfaces
{
    public interface IState
    {
        void Interact(Creature creature);
    }
}
