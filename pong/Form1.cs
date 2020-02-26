using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        private bool moveUp;
        private bool moveDown;
        int score1 = 0;
        int score2 = 0;
        int ballx = 5;
        int bally = 5;
        int ballspeed = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Player1Score.Text = "" + score1;
            Player2Score.Text = "" + score2;

            Ball.Top -= bally;
            Ball.Left -= ballx;

            Player2.Top += ballspeed;

            if (score1 < 5)
            {
                if (Player2.Top < 0  || Player2.Top > 455)
                {
                    ballspeed = -ballspeed;
                }
            }

            else
            {
                Player2.Top = Ball.Top + 30;
            }

            if (Ball.Left < 0)
            {
                Ball.Left = 434;
                ballx = -ballx;
                //ballx -= 2;
                score2++;
            }

            if (Ball.Left + Ball.Width > ClientSize.Width)
            {
                Ball.Left = 434;
                ballx = -ballx;
                //ballx += 2;
                score1++;
            }



            if (Ball.Top < 0 || Ball.Top + Ball.Height > ClientSize.Height)
            {
                bally = -bally;
            }

            if (Ball.Bounds.IntersectsWith(Player1.Bounds) || Ball.Bounds.IntersectsWith(Player2.Bounds))
            {
                ballx = -ballx;
            }

            if (moveUp == true && Player1.Top > 1)
            {
                Player1.Top -= 8;
            }

            if (moveDown == true && Player1.Bottom < 455)
            {
                Player1.Top += 8;
            }

            if (score1 > 10)
            {
                GameTimer.Stop();
                MessageBox.Show("Player 1 wins!");
            }

            if (score2 > 10)
            {
                GameTimer.Stop();
                MessageBox.Show("Player 2 wins!");
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
        }
    }
}
