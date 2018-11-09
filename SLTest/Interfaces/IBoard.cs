using SLExcercise.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SLExcercise.Interfaces
{
    public interface IBoard
    {
        void Move(Player player, int moveSpace);

    }
}
