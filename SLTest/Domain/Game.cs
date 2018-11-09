using SLExcercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SLExcercise.Domain
{
    public class Game
    {
        private readonly IBoard _board;
        public Game(IBoard board)
        {
            Players = new List<Player>();
            _board = board;
        }

        public void Start(Player player)
        {
            if(Players.Count == 0)
            {
                throw new Exception("Please add at least one player to the game");
            }

            var playerToStart = GetFirstPlayerToPlay();
            if(player.Id.Equals(playerToStart.Id))
            {
                _board.Move(player, 1);
            }
            else
            {
                throw new Exception("Invalid Player To Start");
            }
            
        }

        public Player GetFirstPlayerToPlay()
        {
            if(Players.Count == 1)
            {
                return Players.First();
            }
            var allUnique = Players.GroupBy(x => x.RolledResult).All(g => g.Count() == 1);
            if(allUnique)
            {
                //Return the top scorer
                return Players.OrderByDescending(i => i.RolledResult).First();
            }
            else
            {
                //No player found
                return null;
            }
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        protected virtual IList<Player> Players { get; set; }

        public IBoard Board
        {
            get
            {
                return _board;
            }
        }
    }
}
