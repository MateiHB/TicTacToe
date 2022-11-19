using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_MiniMax
{
    public partial class TicTacToe : Form
    {
        private Player[] grid;
        private (int, int) score;
        private Player player;
        private Button[] buttons;
        private Solver solver;

        public TicTacToe()
        {
            InitializeComponent();
            buttons = new Button[]{upLeftButton, upMiddleButton, upRightButton,
                        middleLeftButton, middleMiddleButton, middleRightButton,
                        downLeftButton, downMiddleButton, downRightButton};

            comboBoxSolver.SelectedIndex = 0;
            this.solver = new RandomSolver();
            score = (0, 0);
            player = Player.X;
            reset();
            freezeAllButtons();
        }

        /// <summary>
        /// Reset the game 
        /// </summary>
        private void reset()
        {
            //Clear Xs and Os
            grid = new Player[9];

            foreach (var b in buttons)
            {
                b.Text = "";
            }
            player = Player.X;
        }

        /// <summary>
        /// Lock all buttons
        /// </summary>
        private void freezeAllButtons()
        {
            //Disable all buttons
            foreach (var b in buttons)
            {
                b.Enabled = false;
            }
        }

        /// <summary>
        /// Unlock all buttons
        /// </summary>
        private void unfreezeAllButtons()
        {
            //Enable all buttons
            foreach (var b in buttons)
            {
                b.Enabled = true;
            }
        }

        /// <summary>
        /// Play a move 
        /// </summary>
        /// <param name="gridIndex">
        /// Index of cell to change
        /// </param>
        private void playerPlay(int gridIndex)
        {
            if (grid[gridIndex] == Player.Null)
            {
                grid[gridIndex] = player;
                buttons[gridIndex].Text = player.ToString();
                //check win
                var win = Validator.CheckWin(grid);
                if (win != null)
                {
                    Win(win.Value);
                    return;
                }

                //play ai
                player = player.SwitchPlayer();
                int nextMove = this.solver.getNextMove(grid, player);
                grid[nextMove] = player;
                buttons[nextMove].Text = player.ToString();

                //check win
                var winAi = Validator.CheckWin(grid);
                if (winAi != null)
                {
                    Win(winAi.Value);
                    return;
                }
                player = player.SwitchPlayer();
            }
        }

        /// <summary>
        /// Announce winner and change score
        /// </summary>
        /// <param name="player">
        /// Player who won or Draw
        /// </param>
        private void Win(Player player)
        {
            if (player == Player.Draw)
            {
                DialogResult message = MessageBox.Show("Draw!", "Game over", MessageBoxButtons.OK);
            }
            if (player == Player.X)
            {
                score.Item1 += 1;
                DialogResult message = MessageBox.Show("Player X won!", "Game over", MessageBoxButtons.OK);
            }
            if (player == Player.O)
            {
                score.Item2 += 1;
                DialogResult message = MessageBox.Show("Player O won!", "Game over", MessageBoxButtons.OK);
            }

            this.labelScore.Text = String.Format("{0} vs {1}", score.Item1, score.Item2);
            freezeAllButtons();
        }

        
        #region Button Events
        private void upLeftButton_Click(object sender, EventArgs e)
        {
            playerPlay(0);
        }

        private void upMiddleButton_Click(object sender, EventArgs e)
        {
            playerPlay(1);
        }

        private void upRightButton_Click(object sender, EventArgs e)
        {
            playerPlay(2);
        }

        private void middleLeftButton_Click(object sender, EventArgs e)
        {
            playerPlay(3);
        }

        private void middleMiddleButton_Click(object sender, EventArgs e)
        {
            playerPlay(4);
        }

        private void middleRightButton_Click(object sender, EventArgs e)
        {
            playerPlay(5);
        }

        private void downLeftButton_Click(object sender, EventArgs e)
        {
            playerPlay(6);
        }

        private void downMiddleButton_Click(object sender, EventArgs e)
        {
            playerPlay(7);
        }

        private void downRightButton_Click(object sender, EventArgs e)
        {
            playerPlay(8);
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            reset();
            unfreezeAllButtons();
        }

        private void comboBoxSolver_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.comboBoxSolver.SelectedIndex;
            if (index == 0) { this.solver = new RandomSolver(); }
            if (index == 1) { this.solver = new IfElseSolver(); }
            if (index == 2) { this.solver = new MinimaxSolver(); }
        }
        #endregion

    }

    public enum Player
    {
        Null,
        X,
        O,
        Draw
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Switches player from O to X or from X to O
        /// </summary>
        /// <param name="player">
        /// Current player
        /// </param>
        /// <returns></returns>
        public static Player SwitchPlayer(this Player player)
        {
            if (player == Player.X) { return Player.O; }
            else if (player == Player.O) { return Player.X; }
            else { throw new Exception("Player Error"); }
        }
    }
}
