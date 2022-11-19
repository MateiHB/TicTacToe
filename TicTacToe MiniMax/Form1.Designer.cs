
namespace TicTacToe_MiniMax
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.upLeftButton = new System.Windows.Forms.Button();
            this.upMiddleButton = new System.Windows.Forms.Button();
            this.upRightButton = new System.Windows.Forms.Button();
            this.middleLeftButton = new System.Windows.Forms.Button();
            this.middleMiddleButton = new System.Windows.Forms.Button();
            this.middleRightButton = new System.Windows.Forms.Button();
            this.downLeftButton = new System.Windows.Forms.Button();
            this.downMiddleButton = new System.Windows.Forms.Button();
            this.downRightButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.comboBoxSolver = new System.Windows.Forms.ComboBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.upLeftButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.upMiddleButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.upRightButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.middleLeftButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.middleMiddleButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.middleRightButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.downLeftButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.downMiddleButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.downRightButton, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(135, 130);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 591);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // upLeftButton
            // 
            this.upLeftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.upLeftButton.Location = new System.Drawing.Point(3, 3);
            this.upLeftButton.Name = "upLeftButton";
            this.upLeftButton.Size = new System.Drawing.Size(197, 191);
            this.upLeftButton.TabIndex = 0;
            this.upLeftButton.UseVisualStyleBackColor = true;
            this.upLeftButton.Click += new System.EventHandler(this.upLeftButton_Click);
            // 
            // upMiddleButton
            // 
            this.upMiddleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upMiddleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.upMiddleButton.Location = new System.Drawing.Point(206, 3);
            this.upMiddleButton.Name = "upMiddleButton";
            this.upMiddleButton.Size = new System.Drawing.Size(197, 191);
            this.upMiddleButton.TabIndex = 1;
            this.upMiddleButton.UseVisualStyleBackColor = true;
            this.upMiddleButton.Click += new System.EventHandler(this.upMiddleButton_Click);
            // 
            // upRightButton
            // 
            this.upRightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.upRightButton.Location = new System.Drawing.Point(409, 3);
            this.upRightButton.Name = "upRightButton";
            this.upRightButton.Size = new System.Drawing.Size(199, 191);
            this.upRightButton.TabIndex = 2;
            this.upRightButton.UseVisualStyleBackColor = true;
            this.upRightButton.Click += new System.EventHandler(this.upRightButton_Click);
            // 
            // middleLeftButton
            // 
            this.middleLeftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.middleLeftButton.Location = new System.Drawing.Point(3, 200);
            this.middleLeftButton.Name = "middleLeftButton";
            this.middleLeftButton.Size = new System.Drawing.Size(197, 191);
            this.middleLeftButton.TabIndex = 3;
            this.middleLeftButton.UseVisualStyleBackColor = true;
            this.middleLeftButton.Click += new System.EventHandler(this.middleLeftButton_Click);
            // 
            // middleMiddleButton
            // 
            this.middleMiddleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleMiddleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.middleMiddleButton.Location = new System.Drawing.Point(206, 200);
            this.middleMiddleButton.Name = "middleMiddleButton";
            this.middleMiddleButton.Size = new System.Drawing.Size(197, 191);
            this.middleMiddleButton.TabIndex = 4;
            this.middleMiddleButton.UseVisualStyleBackColor = true;
            this.middleMiddleButton.Click += new System.EventHandler(this.middleMiddleButton_Click);
            // 
            // middleRightButton
            // 
            this.middleRightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.middleRightButton.Location = new System.Drawing.Point(409, 200);
            this.middleRightButton.Name = "middleRightButton";
            this.middleRightButton.Size = new System.Drawing.Size(199, 191);
            this.middleRightButton.TabIndex = 5;
            this.middleRightButton.UseVisualStyleBackColor = true;
            this.middleRightButton.Click += new System.EventHandler(this.middleRightButton_Click);
            // 
            // downLeftButton
            // 
            this.downLeftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.downLeftButton.Location = new System.Drawing.Point(3, 397);
            this.downLeftButton.Name = "downLeftButton";
            this.downLeftButton.Size = new System.Drawing.Size(197, 191);
            this.downLeftButton.TabIndex = 6;
            this.downLeftButton.UseVisualStyleBackColor = true;
            this.downLeftButton.Click += new System.EventHandler(this.downLeftButton_Click);
            // 
            // downMiddleButton
            // 
            this.downMiddleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downMiddleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.downMiddleButton.Location = new System.Drawing.Point(206, 397);
            this.downMiddleButton.Name = "downMiddleButton";
            this.downMiddleButton.Size = new System.Drawing.Size(197, 191);
            this.downMiddleButton.TabIndex = 7;
            this.downMiddleButton.UseVisualStyleBackColor = true;
            this.downMiddleButton.Click += new System.EventHandler(this.downMiddleButton_Click);
            // 
            // downRightButton
            // 
            this.downRightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.downRightButton.Location = new System.Drawing.Point(409, 397);
            this.downRightButton.Name = "downRightButton";
            this.downRightButton.Size = new System.Drawing.Size(199, 191);
            this.downRightButton.TabIndex = 8;
            this.downRightButton.UseVisualStyleBackColor = true;
            this.downRightButton.Click += new System.EventHandler(this.downRightButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(882, 853);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSolver, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.newGameButton, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(135, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(611, 121);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelScore, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(206, 43);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(197, 34);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelScore.Location = new System.Drawing.Point(101, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(93, 34);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "0 vs 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSolver
            // 
            this.comboBoxSolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSolver.FormattingEnabled = true;
            this.comboBoxSolver.Items.AddRange(new object[] {
            "Random",
            "If/else ",
            "Minimax"});
            this.comboBoxSolver.Location = new System.Drawing.Point(3, 43);
            this.comboBoxSolver.Name = "comboBoxSolver";
            this.comboBoxSolver.Size = new System.Drawing.Size(197, 24);
            this.comboBoxSolver.TabIndex = 1;
            this.comboBoxSolver.SelectedIndexChanged += new System.EventHandler(this.comboBoxSolver_SelectedIndexChanged);
            // 
            // newGameButton
            // 
            this.newGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newGameButton.Location = new System.Drawing.Point(409, 43);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(199, 34);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "Start new game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 853);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.ComboBox comboBoxSolver;
        private System.Windows.Forms.Button upLeftButton;
        private System.Windows.Forms.Button upMiddleButton;
        private System.Windows.Forms.Button upRightButton;
        private System.Windows.Forms.Button middleLeftButton;
        private System.Windows.Forms.Button middleMiddleButton;
        private System.Windows.Forms.Button middleRightButton;
        private System.Windows.Forms.Button downLeftButton;
        private System.Windows.Forms.Button downMiddleButton;
        private System.Windows.Forms.Button downRightButton;
        private System.Windows.Forms.Button newGameButton;
    }
}

