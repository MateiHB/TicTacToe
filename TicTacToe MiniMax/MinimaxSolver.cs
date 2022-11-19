using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_MiniMax
{
   
    class MinimaxSolver : Solver
    {
        /// <summary>
        /// Gets next move performed by AI. Move is chosen by Minimax algorithm.
        /// </summary>
        /// <param name="grid">
        /// Grid representing the current state of the game 
        /// </param>
        /// <param name="player">
        /// Which player is the AI currently simulating
        /// </param>
        public override int getNextMove(Player[] grid, Player player)
        {
            (int, float) solution = minimax(grid, player, 0, 0);
            return solution.Item1;
        }

        /// <summary>
        /// Performs the Minimax algorithm and returns best option 
        /// </summary>
        /// <param name="grid">
        /// Grid representing the current state of the game
        /// </param>
        /// <param name="player">
        /// Which player is the AI currently simulating
        /// </param>
        /// <param name="alpha">
        /// Value of alpha
        /// </param>
        /// <param name="beta">
        /// Value of beta
        /// </param>
        /// <returns></returns>
        private (int, int) minimax(Player[] grid, Player player, float alpha, float beta)
        {
            var win = Validator.CheckWin(grid);

            //check if over
            if (win != null)
            {
                if (win == Player.X)
                {
                    return (-1, -1);
                }
                if (win == Player.O)
                {
                    return (-1, 1);
                }
                else
                {
                    return (-1, 0);
                }
            }

            var options = getAllOptions(grid);
            var bestIndex = -1;
            int bestScore;

            if (player == Player.O)
            {
                bestScore = int.MinValue;
                foreach (var option in options)
                {
                    var gridTemp = (Player[])grid.Clone();
                    gridTemp[option] = Player.O;
                    var value = minimax(gridTemp, Player.X, alpha, beta);
                    if (bestScore < value.Item2)
                    {
                        bestIndex = option;
                        bestScore = value.Item2;
                    }
                    alpha = Math.Max(bestScore, alpha);
                    if (alpha > beta)
                    {
                        break;
                    }
                }
            }
            else
            {
                bestScore = int.MaxValue;
                foreach (var option in options)
                {
                    var gridTemp = (Player[])grid.Clone();
                    gridTemp[option] = Player.X;
                    var value = minimax(gridTemp, Player.O, alpha, beta);
                    if (bestScore > value.Item2)
                    {
                        bestIndex = option;
                        bestScore = value.Item2;
                    }
                    beta = Math.Min(bestScore, beta);
                    if (alpha > beta)
                    {
                        break;
                    }
                }
            }
            return (bestIndex, bestScore);
        }
    }
}
