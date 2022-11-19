using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_MiniMax
{
    class RandomSolver : Solver
    {
        /// <summary>
        /// Gets next move performed by AI. Move is randomly chosen.
        /// </summary>
        /// <param name="grid">
        /// Grid representing the current state of the game 
        /// </param>
        /// <param name="player">
        /// Which player is the AI currently simulating
        /// </param>
        public override int getNextMove(Player[] grid, Player player)
        {
            List<int> allOptions = getAllOptions(grid);
            var index = random.Next(0, allOptions.Count);
            return allOptions[index];
        }
    }
}
