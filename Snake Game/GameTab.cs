using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Snake_Game
{
    public partial class GameTab : Form

    {
        public int score;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "****************************",
            BasePath = "https://*************.firebaseio.com/"
        };
        IFirebaseClient client;
        bool left, right, up, down;
        int snakeLength, appleH, appleW, snakeHeadLeft, snakeHeadTop, snakeSize;

        private void GameTab_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {

            }

        }

        Random random = new Random();

        

        List<SnakeBit> snakeBody = new List<SnakeBit>();
        List<PictureBox> snakeBoxes = new List<PictureBox>();
       
        


        
        private void setupGame()
        {
         

            
            snakeLength = 0;
            appleW = random.Next(groupBox.Left , groupBox.Left + groupBox.Width - apple.Width);
            appleH = random.Next(groupBox.Top , groupBox.Top + groupBox.Height - apple.Height);
            apple.Left = appleW;
            apple.Top = appleH;
            snakeSize = snakeHead.Size.Width;
           // left = false;
           // right = false;
           // up = false;
           // down = false;
            timer1.Start();

        }

        

        public GameTab()
        {
            InitializeComponent();
            setupGame();
            

                /* if(apple.Bounds.IntersectsWith(snakeHead.Bounds))
                 {
                     appleW = random.Next(0, 564);
                     appleH = random.Next(0, 442);
                     apple.Left = appleW;
                     apple.Top = appleH;
                 } */

            }

            private void GameTab_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    left = true;
                    break;
                case Keys.Right:
                    right = true;
                    break;
                case Keys.Up:
                    up = true;
                   
                    break;
                case Keys.Down:
                    down = true;
                    
                    break;
            }

        }

        private void GameTab_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    left = false;
                    break;
                case Keys.Right:
                    right = false;
                    break;
                case Keys.Up:
                    up = false;
                    break;
                case Keys.Down:
                    down = false;
                    break;
            }

        }

        private void timerEvent(object sender, EventArgs e)
        {
            snakeHeadLeft = snakeHead.Left;
            snakeHeadTop = snakeHead.Top;
            if (left || right || up || down)
            {  
                if (left == true)
                {
                    if (snakeHead.Left >= groupBox.Left)
                    {
                        snakeHead.Left -= snakeHead.Width;
                    }
                    else
                    {
                        snakeHead.Left = groupBox.Left + groupBox.Width - snakeHead.Width;
                    }
                }

                // Right boundary
                else if (right == true)
                {
                    if (snakeHead.Right <= groupBox.Right /*+ groupBox.Width - snakeHead.Width*/)
                    {
                        snakeHead.Left += snakeHead.Width;
                    }
                    else
                    {
                        snakeHead.Left = groupBox.Left;
                    }
                }

                // Top boundary
               else if (up == true)
                {
                    if (snakeHead.Top >= groupBox.Top)
                    {
                        snakeHead.Top -= snakeHead.Height;
                    }
                    else
                    {
                        snakeHead.Top = groupBox.Top + groupBox.Height - snakeHead.Height;
                    }
                }

                // Bottom boundary
               else if (down == true)
                {
                    if (snakeHead.Bottom <= groupBox.Bottom)
                    {
                        snakeHead.Top += snakeHead.Height;
                    }
                    else
                    {
                        snakeHead.Top = groupBox.Top;
                    }
                }
                bool gameOver = false;

                for (int i = 0; i < snakeBoxes.Count && gameOver!=true; i++)
                {
                    if(snakeHead.Bounds.IntersectsWith(snakeBoxes.ElementAt<PictureBox>(i).Bounds))
                        {
                        gameOver = true;
                        timer1.Stop();
                        DialogResult result = MessageBox.Show("GAME OVER", "Score: "+score, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                           
                            this.Close();
                        }
                    }
                }
                    bool first = true;
                if (snakeLength > 0)
                {
                    for (int i = 0; i < snakeBoxes.Count; i++)
                    {
                        if (first)
                        {
                         snakeBody.ElementAt<SnakeBit>(i).snakeX = snakeBoxes.ElementAt<PictureBox>(i).Left;
                         snakeBody.ElementAt<SnakeBit>(i).snakeY = snakeBoxes.ElementAt<PictureBox>(i).Top;
                         snakeBoxes.ElementAt<PictureBox>(i).Left = snakeHeadLeft;
                         snakeBoxes.ElementAt<PictureBox>(i).Top = snakeHeadTop;
                         first = false;

                         }
                        else
                        {
                            snakeBody.ElementAt<SnakeBit>(i).snakeX = snakeBoxes.ElementAt<PictureBox>(i).Left;
                            snakeBody.ElementAt<SnakeBit>(i).snakeY = snakeBoxes.ElementAt<PictureBox>(i).Top;
                            snakeBoxes.ElementAt<PictureBox>(i).Left = snakeBody.ElementAt<SnakeBit>(i - 1).snakeX;
                            snakeBoxes.ElementAt<PictureBox>(i).Top = snakeBody.ElementAt<SnakeBit>(i - 1).snakeY;
                        }
                        snakeBoxes.ElementAt<PictureBox>(i).BringToFront();
                    }
                }

            }
            if (apple.Bounds.IntersectsWith(snakeHead.Bounds))
            {
                appleW = random.Next(groupBox.Left, groupBox.Left + groupBox.Width-apple.Width);
                appleH = random.Next(groupBox.Top, groupBox.Top + groupBox.Height-apple.Height);
                apple.Left = appleW;
                apple.Top = appleH;

                score++;
                scoreLabel.Text = "Score: " + score;

                SnakeBit snakeBit = new SnakeBit(snakeHead.Left, snakeHead.Top);
                snakeBody.Add(snakeBit);
                snakeLength++;

                PictureBox snakeBox = new PictureBox();
                this.Controls.Add(snakeBox);
                snakeBox.Location = new Point(snakeBit.snakeX, snakeBit.snakeY);
                snakeBox.Size = new Size(snakeSize, snakeSize);
                snakeBox.Margin = new Padding(0);
                snakeBox.BackColor = Color.SpringGreen;
                snakeBox.BringToFront();
                snakeBoxes.Add(snakeBox);


            }
            



        }
       
       
        

  
    }
}
