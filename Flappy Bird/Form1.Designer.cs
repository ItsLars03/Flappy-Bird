
namespace Flappy_Bird
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.panelGameover = new System.Windows.Forms.Panel();
            this.textGameOver = new System.Windows.Forms.Label();
            this.scoreTextEndScreen = new System.Windows.Forms.Label();
            this.StartNewGame = new System.Windows.Forms.Button();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.livesEndText = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panelGameover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Khaki;
            this.scoreText.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(4, 732);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(190, 45);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            this.scoreText.Click += new System.EventHandler(this.scoreText_Click);
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 20;
            this.gameTime.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // panelGameover
            // 
            this.panelGameover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGameover.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelGameover.Controls.Add(this.close);
            this.panelGameover.Controls.Add(this.restart);
            this.panelGameover.Controls.Add(this.livesEndText);
            this.panelGameover.Controls.Add(this.textGameOver);
            this.panelGameover.Controls.Add(this.scoreTextEndScreen);
            this.panelGameover.Controls.Add(this.StartNewGame);
            this.panelGameover.Location = new System.Drawing.Point(250, 115);
            this.panelGameover.Name = "panelGameover";
            this.panelGameover.Size = new System.Drawing.Size(842, 465);
            this.panelGameover.TabIndex = 5;
            this.panelGameover.Visible = false;
            this.panelGameover.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGameover_Paint);
            // 
            // textGameOver
            // 
            this.textGameOver.AutoSize = true;
            this.textGameOver.Font = new System.Drawing.Font("Comic Sans MS", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGameOver.ForeColor = System.Drawing.Color.Red;
            this.textGameOver.Location = new System.Drawing.Point(251, 27);
            this.textGameOver.Name = "textGameOver";
            this.textGameOver.Size = new System.Drawing.Size(374, 82);
            this.textGameOver.TabIndex = 7;
            this.textGameOver.Text = "Game over! ";
            // 
            // scoreTextEndScreen
            // 
            this.scoreTextEndScreen.AutoSize = true;
            this.scoreTextEndScreen.BackColor = System.Drawing.Color.AntiqueWhite;
            this.scoreTextEndScreen.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextEndScreen.Location = new System.Drawing.Point(27, 142);
            this.scoreTextEndScreen.Name = "scoreTextEndScreen";
            this.scoreTextEndScreen.Size = new System.Drawing.Size(190, 45);
            this.scoreTextEndScreen.TabIndex = 6;
            this.scoreTextEndScreen.Text = "Score: 0";
            this.scoreTextEndScreen.Click += new System.EventHandler(this.scoreTextEndScreen_Click);
            // 
            // StartNewGame
            // 
            this.StartNewGame.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNewGame.ForeColor = System.Drawing.Color.Black;
            this.StartNewGame.Location = new System.Drawing.Point(35, 305);
            this.StartNewGame.Name = "StartNewGame";
            this.StartNewGame.Size = new System.Drawing.Size(246, 138);
            this.StartNewGame.TabIndex = 1;
            this.StartNewGame.Text = "Opnieuw";
            this.StartNewGame.UseVisualStyleBackColor = true;
            this.StartNewGame.Click += new System.EventHandler(this.StartNewGame_Click);
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(1066, 433);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(110, 270);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            this.pipeBottom.Click += new System.EventHandler(this.pipeBottom_Click);
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(1066, -4);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(110, 200);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            this.pipeTop.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::Flappy_Bird.Properties.Resources.ezgif_4_e501105a429d;
            this.flappyBird.Location = new System.Drawing.Point(105, 257);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(102, 103);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.MediumBlue;
            this.ground.Image = global::Flappy_Bird.Properties.Resources.ground1;
            this.ground.Location = new System.Drawing.Point(-3, 700);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1796, 165);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Image = global::Flappy_Bird.Properties.Resources.module_clouds_2x;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1764, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // livesEndText
            // 
            this.livesEndText.AutoSize = true;
            this.livesEndText.BackColor = System.Drawing.Color.AntiqueWhite;
            this.livesEndText.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesEndText.Location = new System.Drawing.Point(27, 200);
            this.livesEndText.Name = "livesEndText";
            this.livesEndText.Size = new System.Drawing.Size(220, 45);
            this.livesEndText.TabIndex = 8;
            this.livesEndText.Text = "Levens: 0";
            this.livesEndText.Click += new System.EventHandler(this.label1_Click);
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.ForeColor = System.Drawing.Color.Black;
            this.restart.Location = new System.Drawing.Point(287, 305);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(246, 66);
            this.restart.TabIndex = 9;
            this.restart.Text = "Herstart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restartGame);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(287, 377);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(246, 66);
            this.close.TabIndex = 11;
            this.close.Text = "Stoppen";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1674, 844);
            this.Controls.Add(this.panelGameover);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            this.panelGameover.ResumeLayout(false);
            this.panelGameover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Panel panelGameover;
        private System.Windows.Forms.Label scoreTextEndScreen;
        private System.Windows.Forms.Label textGameOver;
        internal System.Windows.Forms.Button StartNewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label livesEndText;
        internal System.Windows.Forms.Button restart;
        internal System.Windows.Forms.Button close;
    }
}

