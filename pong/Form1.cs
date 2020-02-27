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
        private bool moveUpP1, moveUpP2;
        private bool moveDownP1, moveDownP2;
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

            if (moveUpP1 == true && Player1.Top > 1)
            {
                Player1.Top -= 8;
            }

            if (moveDownP1 == true && Player1.Bottom < 455)
            {
                Player1.Top += 8;
            }

            if (moveUpP2 == true && Player2.Top > 1)
            {
                Player2.Top -= 8;
            }

            if (moveDownP2 == true && Player2.Bottom < 455)
            {
                Player2.Top += 8;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveUpP1 = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDownP1 = false;
            }

            if (e.KeyCode == Keys.W)
            {
                moveUpP2 = false;
            }

            if (e.KeyCode == Keys.S)
            {
                moveDownP2 = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveUpP1 = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDownP1 = true;
            }

            if (e.KeyCode == Keys.W)
            {
                moveUpP2 = true;
            }

            if (e.KeyCode == Keys.S)
            {
                moveDownP2 = true;
            }
        }
    }
}
