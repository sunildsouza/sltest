using System;
using System.Collections.Generic;
using System.Text;

namespace SLExcercise.Interfaces
{
    public interface IGame
    {
        void Start();

        void AddPlayer(IPlayer player);
    }
}
