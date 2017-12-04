using System.Collections.Generic;
using Kata.Prod.Moves;

namespace Kata.Prod
{
    public class GameEngine
    {
        private readonly Dictionary<GameMove, GameMove>  _winningMoves = new Dictionary<GameMove, GameMove>
        {
            { GameMove.Scissors, GameMove.Paper},
            { GameMove.Paper, GameMove.Rock},
            { GameMove.Rock, GameMove.Scissors}
        };

        public GameResult Play(GameMove player, GameMove opponent)
        {
           
            if (PlayerWins(player, opponent))
            {
                return GameResult.Win;
            }

            if (PlayerDraws(player, opponent))
            {
                return GameResult.Draw;
            }

            return GameResult.Loose;
        }

        private bool PlayerDraws(GameMove player, GameMove opponent)
        {
            return player == opponent;
        }

        private bool PlayerWins(GameMove playerMove, GameMove opponentMove)
        {
            _winningMoves.TryGetValue(playerMove, out var canidateOpponentMove);
            return PlayerBeatOpponent(opponentMove, canidateOpponentMove);
        }

        private static bool PlayerBeatOpponent(GameMove opponent, GameMove toWinOpponmentMustHAvePlayed)
        {
            return opponent == toWinOpponmentMustHAvePlayed;
        }
    }
}