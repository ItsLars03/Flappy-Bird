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

        int pipeSpeed = 10;
        int gravity = 5;
        int score = 0;
        int totalscore = 0;
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

            Random rnd = new Random();
            int pipeheight = rnd.Next(170, 270);

            if (pipeBottom.Left < -15)
            {
                pipeBottom.Top = pipeheight;
                pipeBottom.Left = 700;
                score++;
            }

            Random rnd2 = new Random();
            int pipeheighttop = rnd2.Next(-9, 10);

            if (pipeTop.Left < -80)
            {
                pipeTop.Top = pipeheighttop;
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25)
                {

                lives = lives - 1;
                totalscore = totalscore + score;
                LabelTotaleScore.Text = "Totalescore: " + totalscore;
                livesEndText.Text = "Levens: " + lives;
                endGame();
            }

            if(lives == 0) 
            {
                StartNewGame.Visible = false;
                rePlay.Visible = true;
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }

            if (score > 10)
            {
                pipeSpeed = 20;
            }

            if (score > 15)
            {
                pipeSpeed = 25;
            }

            if (score > 20)
            {
                pipeSpeed = 30;
            }

            if (score > 25)
            {
                pipeSpeed = 35;
            }

            if (score > 30)
            {
                pipeSpeed = 40;
            }

            if (score > 35)
            {
                pipeSpeed = 45;
            }


        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -7;
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 7;
            }


        }
      
        private void endGame()
        {
            gameTime.Stop();
            panelGameover.Visible = true;
            StartNewGame.Visible = true;
            close.Enabled = true;
            StartNewGame.Enabled = true;
        }

        private void startGame()
        { 
            panelGameover.Visible = false;
            StartNewGame.Enabled = false;
            gameTime.Enabled = true;
            //Size size = new Size(2, 100);
            //pipeBottom.Size = size;
            close.Enabled = false;
            pipeSpeed = 10;
            //StartButton.Enabled = false;
            gameTime.Start();
            score = score - score; //Hiermee reset ik de score van de huidige ronde
            panel1.Visible = false;
            button1.Enabled = false;
            livesEndText.Visible = true;
            scoreText.Visible = true;
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
            flappyBird.Top = 105;
            pipeTop.Left = 631;
            pipeBottom.Left = 631;

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

        private void totaleScore_Click(object sender, EventArgs e)
        {
            
        }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void rePlay_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}
