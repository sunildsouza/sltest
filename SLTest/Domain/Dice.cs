using SLExcercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace SLExcercise.Domain
{
    public class Dice : IDice
    {
        public int Roll()
        {
            return new Random().Next(1, 6);
        }
    }
}
