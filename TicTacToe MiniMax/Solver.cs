using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_MiniMax
{
    class Solver
    {
        protected Random random = new Random();

        /// <summary>
        /// Given inputs, returns next move that AI will perform
        /// </summary>
        /// <param name="grid">
        /// Grid representing the current state of the game 
        /// </param>
        /// <param name="player">
        /// Which player is the AI currently simulating
        /// </param>
        public virtual int getNextMove(Player[] grid, Player player)
        {
            throw new Exception("No algorithm was chosen");
        }

        /// <summary>
        /// Returns all possible next moves 
        /// </summary>
        /// <param name="grid">
        /// Grid representing the current state of the game 
        /// </param>
        protected List<int> getAllOptions(Player[] grid)
        {
            List<int> listOptions = new List<int>();
            for (int i=0; i<grid.Length; i++)
            {
                if (grid[i] == Player.Null)
                {
                    listOptions.Add(i);
                }
            }
            return listOptions;
        }
    }
}
