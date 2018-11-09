using SLExcercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SLExcercise.Enum;

namespace SLExcercise.Domain
{
    public class Board : IBoard
    {
        private readonly IList<Snake> _snakes;
        private readonly IList<Ladder> _ladders;
        public Board()
        {
            //A board contains more than one snake and ladder
            _snakes = new List<Snake>();
            _ladders = new List<Ladder>();

            //Add a default snake
            _snakes.Add(new Snake(12, 2));

            //Add a default ladder
            _ladders.Add(new Ladder(2, 12));
        }
        public void Move(Player player, int moveSpace)
        {
            var newTokenPosition = player.TokenPosition + moveSpace;
            //Check if a snake exist
            var snake = _snakes.FirstOrDefault(s => s.Start.Equals(newTokenPosition));
            if(snake != null)
            {
                player.TokenPosition = snake.End;
                return;
            }
            //Check if a ladder exist
            var ladder = _ladders.FirstOrDefault(s => s.Start.Equals(newTokenPosition));
            if (ladder != null)
            {
                player.TokenPosition = ladder.End;
                return;
            }

            //Otherwise move it to a new location
            if(newTokenPosition <= 100)
            {
                player.TokenPosition = newTokenPosition;
            }
            if(player.TokenPosition == 100)
            {
                //Declare the winner
                player.SetStatus(Status.Won);
            }
        }
        
    }
}
