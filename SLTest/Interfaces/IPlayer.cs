using SLExcercise.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SLExcercise.Interfaces
{
    public interface IPlayer
    {
        void Play();
        void SetStatus(Status status);
        void Roll();
    }

}
