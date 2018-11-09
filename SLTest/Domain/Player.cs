using SLExcercise.Enum;
using SLExcercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SLExcercise.Domain
{
    public class Player : IPlayer
    {
        private readonly IDice _dice;
        private readonly IBoard _board;
        public Player(IDice dice, IBoard board)
        {
            //Player has access to a dice to roll it.
            _dice = dice;
            //Player also access to the board to move the token
            _board = board;
            Status = Status.NotStarted;
        }
        public void Play()
        {
            var tokenIncrement = 1;
            if (Status == Status.Playing)
            {
                tokenIncrement = _dice.Roll();
            }
            else
            {
                Status = Status.Playing;
            }

            _board.Move(this, tokenIncrement);
        }

        public void Roll()
        {
            //Same method names, but should delegate the rolling logic to Dice, that's what its role is
            RolledResult = _dice.Roll();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; protected set; }
        public int TokenPosition { get; set; }
        public int RolledResult { get; protected set; }

        public void SetStatus(Status status)
        {
            Status = status;
        }

    }
}
