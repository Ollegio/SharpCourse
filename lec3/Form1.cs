using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lec3
{
    public partial class Form1 : Form
    {
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

            Game.Init();
            currentTurnLabel.Text = Game.CurrentTurn.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var coords = ((Button) sender).Name.Split('-');
            var x = int.Parse(coords.First());
            var y = int.Parse(coords.Last());
            ((Button) sender).Text = Game.CurrentTurn.ToString();
            ((Button) sender).Enabled = false;

            if (Game.MakeMove(x, y))
            {
                if (MessageBox.Show($@"Победил игрок {Game.CurrentTurn.ToString()}. Повторить игру?", @"Игра закончена",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Start();
                else
                    Close();
            }
            currentTurnLabel.Text = Game.CurrentTurn.ToString();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
