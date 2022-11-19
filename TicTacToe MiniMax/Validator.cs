using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_MiniMax
{
    static class Validator
    {
        /// <summary>
        /// Checks if game is over. Verifies that all cells are not empty
        /// </summary>
        /// <param name="grid">
        /// Grid representing the current state of the game 
        /// </param>
        private static bool checkIfOver(Player[] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                //Check horizontal lines
                if (grid[i] == Player.Null)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if someone won or draw. Returns null otherwise
        /// </summary>
        /// <param name="grid">
        /// Grid representing the current state of the game 
        /// </param>
        public static Nullable<Player> CheckWin(Player[] grid)
        {
            //check wins perpendicularly
            for (var i = 0; i < 3; i++)
            {
                //Check horizontal lines
                if (grid[3 * i] != Player.Null && 
                    grid[3 * i] == grid[3 * i + 1] && 
                    grid[3 * i] == grid[3 * i + 2])
                {
                    return grid[3 * i];
                }
                //Check vertical lines
                if (grid[i] != Player.Null && 
                    grid[i] == grid[i + 3] && 
                    grid[i] == grid[i + 6])
                {
                    return grid[i];
                }
            }

            //check wins diagonally
            if (grid[0] != Player.Null && 
                grid[0] == grid[4] && 
                grid[0] == grid[8])
            {
                return grid[0];
            }
            if (grid[6] != Player.Null && 
                grid[6] == grid[4] && 
                grid[6] == grid[2])
            {
                return grid[6];
            }

            if (checkIfOver(grid))
            {
                return Player.Draw;
            }
            return null;
        }
    }
}
