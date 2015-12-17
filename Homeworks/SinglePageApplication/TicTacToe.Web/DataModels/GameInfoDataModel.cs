namespace TicTacToe.Web.DataModels
{
    using System;
    using System.Linq.Expressions;
    using TicTacToe.Models;

    public class GameInfoDataModel
    {
        public static Expression<Func<Game, GameInfoDataModel>> FromGame
        {
            get
            {
                return g => new GameInfoDataModel
                {
                    Id = g.Id,
                    Board = g.Board,
                    FirstPlayerName = g.FirstPlayer.UserName,
                    SecondPlayerName = g.SecondPlayer.UserName,
                    State = g.State
                };
            }
        }

        public Guid Id { get; set; }

        public string Board { get; set; }

        public string FirstPlayerName { get; set; }

        public string SecondPlayerName { get; set; }

        public GameState State { get; set; }
    }
}