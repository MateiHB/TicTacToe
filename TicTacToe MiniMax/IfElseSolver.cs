using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_MiniMax
{
    class IfElseSolver : Solver
    {
        /// <summary>
        /// Given inputs, returns next move that AI will perform
        /// </summary>
        /// <param name="grid">
        /// Grid representing the current state of the game 
        /// </param>
        /// <param name="player">
        /// Which player is the AI currently simulating
        /// </param>
        public override int getNextMove(Player[] grid, Player player)
        {
            Player enemy = player.SwitchPlayer();
            List<int> allOptions = getAllOptions(grid);

            //check 1 move win
            foreach (int choice in allOptions)
            {
                int length = grid.Length;
                Player[] tempGrid = new Player[length];
                Array.Copy(grid, tempGrid, length);
                tempGrid[choice] = player;
                if (Validator.CheckWin(tempGrid) == player)
                {
                    return choice;
                }
            }

            //check 1 move lose
            foreach (int choice in allOptions)
            {
                int length = grid.Length;
                Player[] tempGrid = new Player[length];
                Array.Copy(grid, tempGrid, length);
                tempGrid[choice] = enemy;
                if (Validator.CheckWin(tempGrid) == enemy)
                {
                    return choice;
                }
            }

            var index = random.Next(0, allOptions.Count);
            return allOptions[index];
        }
    }
}