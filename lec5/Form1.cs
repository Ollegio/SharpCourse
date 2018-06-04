using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using lec5.Entities;

namespace lec5
{
    public partial class Form1 : Form
    {
        public static Game game;

        public Form1()
        {
            InitializeComponent();
            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 3; j++)
            {
                buttonMatrix[i, j] = new Button()
                {
                    BackColor = SystemColors.ButtonHighlight,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(50 + j * 30, 50 + i * 30),
                    Name = $"{i}-{j}",
                    Size = new Size(25, 25),
                    TabIndex = 0,
                    UseVisualStyleBackColor = false,
                };
                buttonMatrix[i, j].Click += button_Click;
            }

            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 3; j++)
                buttonPanel.Controls.Add(buttonMatrix[i, j]);

            Start();
        }

        private void Start()
        {
            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 3; j++)
            {
                buttonMatrix[i, j].Text = "";
                buttonMatrix[i, j].Enabled = true;
            }

            game = new Game();
            currentTurnLabel.Text = game.CurrentTurn.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var coords = ((Button) sender).Name.Split('-');
            var x = int.Parse(coords.First());
            var y = int.Parse(coords.Last());
            ((Button) sender).Text = game.CurrentTurn.ToString();
            ((Button) sender).Enabled = false;

            if (game.MakeMove(x, y))
            {
                Program.gameModel.Games.Add(new GameEntity
                    {
                        Date = DateTime.Now,
                        Winner = game.CurrentTurn.ToString()
                    }
                );
                Program.gameModel.SaveChanges();
                if (MessageBox.Show($@"Победил игрок {game.CurrentTurn.ToString()}. Повторить игру?", @"Игра закончена",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Start();
                else
                    Close();
            }
            currentTurnLabel.Text = game.CurrentTurn.ToString();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultsForm = new Results();
            resultsForm.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.gameModel.Dispose();
        }
    }
}
