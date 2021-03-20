using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        int lives = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;
            scoreTextEndScreen.Text = "Score: " + score;

            if (pipeBottom.Left < -50)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if(pipeTop.Left < -80)
            {
                pipeTop.Left = 950;
                score++;
            }

            if(flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25)
            {

                lives = lives - 1;
                livesEndText.Text = "Levens: " + lives;
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 15;
            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void endGame()
        {
            gameTime.Stop();
            panelGameover.Visible = true; 
        }

        private void startGame()
        {
            gameTime.Start();
            panelGameover.Visible = false;
        }

        private void pipeBottom_Click(object sender, EventArgs e)
        {

        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }

        private void panelGameover_Paint(object sender, PaintEventArgs e)
        {

        }
         
        private void scoreTextEndScreen_Click(object sender, EventArgs e)
        {
            
        }

        private void StartNewGame_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void restartGame(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    } 
}
