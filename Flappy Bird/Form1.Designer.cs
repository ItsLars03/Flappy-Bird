
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
            this.LabelTotaleScore = new System.Windows.Forms.Label();
            this.scoreTextEndScreen = new System.Windows.Forms.Label();
            this.livesEndText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rePlay = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.StartNewGame = new System.Windows.Forms.Button();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.panelGameover.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
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
            this.scoreText.Visible = false;
            this.scoreText.Click += new System.EventHandler(this.scoreText_Click);
            // 
            // gameTime
            // 
            this.gameTime.Interval = 20;
            this.gameTime.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // panelGameover
            // 
            this.panelGameover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGameover.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelGameover.Controls.Add(this.pictureBox1);
            this.panelGameover.Controls.Add(this.rePlay);
            this.panelGameover.Controls.Add(this.LabelTotaleScore);
            this.panelGameover.Controls.Add(this.close);
            this.panelGameover.Controls.Add(this.scoreTextEndScreen);
            this.panelGameover.Controls.Add(this.StartNewGame);
            this.panelGameover.Location = new System.Drawing.Point(242, 125);
            this.panelGameover.Name = "panelGameover";
            this.panelGameover.Size = new System.Drawing.Size(842, 465);
            this.panelGameover.TabIndex = 5;
            this.panelGameover.Visible = false;
            this.panelGameover.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGameover_Paint);
            // 
            // LabelTotaleScore
            // 
            this.LabelTotaleScore.AutoSize = true;
            this.LabelTotaleScore.BackColor = System.Drawing.Color.AntiqueWhite;
            this.LabelTotaleScore.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotaleScore.Location = new System.Drawing.Point(27, 170);
            this.LabelTotaleScore.Name = "LabelTotaleScore";
            this.LabelTotaleScore.Size = new System.Drawing.Size(316, 45);
            this.LabelTotaleScore.TabIndex = 12;
            this.LabelTotaleScore.Text = "Totalescore: 0";
            this.LabelTotaleScore.Click += new System.EventHandler(this.totaleScore_Click);
            // 
            // scoreTextEndScreen
            // 
            this.scoreTextEndScreen.AutoSize = true;
            this.scoreTextEndScreen.BackColor = System.Drawing.Color.AntiqueWhite;
            this.scoreTextEndScreen.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextEndScreen.Location = new System.Drawing.Point(27, 125);
            this.scoreTextEndScreen.Name = "scoreTextEndScreen";
            this.scoreTextEndScreen.Size = new System.Drawing.Size(190, 45);
            this.scoreTextEndScreen.TabIndex = 6;
            this.scoreTextEndScreen.Text = "Score: 0";
            // 
            // livesEndText
            // 
            this.livesEndText.AutoSize = true;
            this.livesEndText.BackColor = System.Drawing.Color.Khaki;
            this.livesEndText.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesEndText.Location = new System.Drawing.Point(932, 732);
            this.livesEndText.Name = "livesEndText";
            this.livesEndText.Size = new System.Drawing.Size(220, 45);
            this.livesEndText.TabIndex = 8;
            this.livesEndText.Text = "Levens: 3";
            this.livesEndText.Visible = false;
            this.livesEndText.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 705);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Flappy_Bird.Properties.Resources.Knipsel1;
            this.pictureBox4.Image = global::Flappy_Bird.Properties.Resources.ezgif_4_e501105a429d;
            this.pictureBox4.Location = new System.Drawing.Point(573, 253);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(147, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Flappy_Bird.Properties.Resources.unnamed1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(494, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 107);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Flappy_Bird.Properties.Resources.Knipsel1;
            this.pictureBox3.Image = global::Flappy_Bird.Properties.Resources.title1;
            this.pictureBox3.Location = new System.Drawing.Point(354, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(561, 188);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Flappy_Bird.Properties.Resources.javascript_flappybird_stap12;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1273, 702);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flappy_Bird.Properties.Resources.game_over;
            this.pictureBox1.Location = new System.Drawing.Point(229, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // rePlay
            // 
            this.rePlay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.875F);
            this.rePlay.ForeColor = System.Drawing.Color.Black;
            this.rePlay.Location = new System.Drawing.Point(35, 305);
            this.rePlay.Name = "rePlay";
            this.rePlay.Size = new System.Drawing.Size(246, 138);
            this.rePlay.TabIndex = 13;
            this.rePlay.Text = "Nieuwe ronde";
            this.rePlay.UseVisualStyleBackColor = true;
            this.rePlay.Visible = false;
            this.rePlay.Click += new System.EventHandler(this.rePlay_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(287, 305);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(246, 138);
            this.close.TabIndex = 11;
            this.close.Text = "Stoppen";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // StartNewGame
            // 
            this.StartNewGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.875F);
            this.StartNewGame.ForeColor = System.Drawing.Color.Black;
            this.StartNewGame.Location = new System.Drawing.Point(35, 305);
            this.StartNewGame.Name = "StartNewGame";
            this.StartNewGame.Size = new System.Drawing.Size(246, 138);
            this.StartNewGame.TabIndex = 1;
            this.StartNewGame.Text = "Opnieuw";
            this.StartNewGame.UseVisualStyleBackColor = true;
            this.StartNewGame.Click += new System.EventHandler(this.StartNewGame_Click);
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(543, -72);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(147, 281);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            this.pipeTop.Click += new System.EventHandler(this.pipeTop_Click);
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.LightSkyBlue;
            this.flappyBird.Image = global::Flappy_Bird.Properties.Resources.ezgif_4_e501105a429d;
            this.flappyBird.Location = new System.Drawing.Point(105, 257);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(102, 103);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.flappyBird_Click);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.MediumBlue;
            this.ground.Image = global::Flappy_Bird.Properties.Resources.ground1;
            this.ground.Location = new System.Drawing.Point(-3, 700);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1346, 165);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(543, 390);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(147, 399);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            this.pipeBottom.Click += new System.EventHandler(this.pipeBottom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1267, 844);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGameover);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.livesEndText);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            this.panelGameover.ResumeLayout(false);
            this.panelGameover.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
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
        internal System.Windows.Forms.Button StartNewGame;
        private System.Windows.Forms.Label livesEndText;
        internal System.Windows.Forms.Button close;
        private System.Windows.Forms.Label LabelTotaleScore;
        internal System.Windows.Forms.Button rePlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

