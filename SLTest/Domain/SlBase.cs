using System;
using System.Collections.Generic;
using System.Text;

namespace SLExcercise.Domain
{
    public class SlBase
    {
        public SlBase(int start, int end)
        {
            Start = start;
            End = end;
        }
        public int Start { get; }
        public int End { get; }

    }
}
