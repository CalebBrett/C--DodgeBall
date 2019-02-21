using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DodgeBall
{
    public partial class Form1 : Form
    {        
        
        public int my1;
        public int mx1;
        public int my2;
        public int mx2;
        public int my3;
        public int mx3;
        public int my4;
        public int mx4;
        public int my5;
        public int mx5;
        public int lvlnum = 1;
        public int SPEED = 10;
        public const int PS = 10;
        public Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            label1.Text = ("Level " + lvlnum);
            mx1 = rand.Next(-SPEED, SPEED);
            my1 = rand.Next(-SPEED, SPEED);
            mx2 = rand.Next(-SPEED, SPEED);
            my2 = rand.Next(-SPEED, SPEED);
            mx3 = rand.Next(-SPEED, SPEED);
            my3 = rand.Next(-SPEED, SPEED);
            mx4 = rand.Next(-SPEED, SPEED);
            my4 = rand.Next(-SPEED, SPEED);
            mx5 = rand.Next(-SPEED, SPEED);
            my5 = rand.Next(-SPEED, SPEED);
        }
        
        public void GameTimer_Tick(object sender, EventArgs e)
        {
            ball1.Top += my1;
            ball1.Left += mx1;
            ball2.Top += my2;
            ball2.Left += mx2;
            ball3.Top += my3;
            ball3.Left += mx3;
            ball4.Top += my4;
            ball4.Left += mx4;
            ball5.Top += my5;
            ball5.Left += mx5;
            Colitions(ball1);
            Colitions(ball2);
            Colitions(ball3);
            Colitions(ball4);
            Colitions(ball5);
            label1.Text = ("Level " + lvlnum);
            if (mx1 == 0 )
            {
                mx1 = 3;
            }
            if( my1 == 0 )
            {
                my1 = 3;
            }
            if( mx2 == 0 )
            {
                mx2 = 3;
            }
            if( my2 == 0 )
            {
                my2 = 3;
            }
            if( mx3 == 0 )
            {
                mx3 = 3;
            }
            if( my3 == 0 )
            {
                my3 = 3;
            }
            if( mx4 == 0 )
            {
                mx4 = 3;
            }
            if( my4 == 0 )
            {
                my4 = 3;
            }
            if( mx5 == 0 )
            {
                mx5 = 3;
            }
            if( my5 == 0)
            {
                my5 = 3;
            } 

        }

        private void lvl_Tick(object sender, EventArgs e)
        {
            lvlnum++;
            if (lvlnum == 2) 
            {
                GameTimer.Interval = 20;
            }
            if (lvlnum == 3)
            {
                ball1.Height = 35;
                ball1.Width = 35;
                ball2.Height = 35;
                ball2.Width = 35;
                ball3.Height = 35;
                ball3.Width = 35;
                ball4.Height = 35;
                ball4.Width = 35;
                ball5.Height = 35;
                ball5.Width = 35;
            }
            if (lvlnum == 4)
            {
                ball1.Height = 40;
                ball1.Width = 40;
                ball2.Height = 40;
                ball2.Width = 40;
                ball3.Height = 40;
                ball3.Width = 40;
                ball4.Height = 40;
                ball4.Width = 40;
                ball5.Height = 40;
                ball5.Width = 40;
            }
            if (lvlnum == 5) 
            {
                ball1.Height = 45;
                ball1.Width = 45;
                ball2.Height = 45;
                ball2.Width = 45;
                ball3.Height = 45;
                ball3.Width = 45;
                ball4.Height = 45;
                ball4.Width = 45;
                ball5.Height = 45;
                ball5.Width = 45;
            }
            if (lvlnum == 6)
            {
                GameTimer.Interval = 15;
            }
            if (lvlnum == 7)
            {
                ball1.Height = 50;
                ball1.Width = 50;
                ball2.Height = 50;
                ball2.Width = 50;
                ball3.Height = 50;
                ball3.Width = 50;
                ball4.Height = 50;
                ball4.Width = 50;
                ball5.Height = 50;
                ball5.Width = 50;
            }
            if (lvlnum == 8) 
            {
                ball1.Height = 55;
                ball1.Width = 55;
                ball2.Height = 55;
                ball2.Width = 55;
                ball3.Height = 55;
                ball3.Width = 55;
                ball4.Height = 55;
                ball4.Width = 55;
                ball5.Height = 55;
                ball5.Width = 55;
            }
            if (lvlnum == 9) 
            {
                ball1.Height = 60;
                ball1.Width = 60;
                ball2.Height = 60;
                ball2.Width = 60;
                ball3.Height = 60;
                ball3.Width = 60;
                ball4.Height = 60;
                ball4.Width = 60;
                ball5.Height = 60;
                ball5.Width = 60;
            }
            if (lvlnum == 10) 
            {
                 win1();
            }
            if (lvlnum == 11)
            {
                GameTimer.Interval = 20;
            }
            if (lvlnum == 12)
            {
                ball1.Height = 35;
                ball1.Width = 35;
                ball2.Height = 35;
                ball2.Width = 35;
                ball3.Height = 35;
                ball3.Width = 35;
                ball4.Height = 35;
                ball4.Width = 35;
                ball5.Height = 35;
                ball5.Width = 35;
            }
            if (lvlnum == 13)
            {
                ball1.Height = 45;
                ball1.Width = 45;
                ball2.Height = 45;
                ball2.Width = 45;
                ball3.Height = 45;
                ball3.Width = 45;
                ball4.Height = 45;
                ball4.Width = 45;
                ball5.Height = 45;
                ball5.Width = 45;
            }
            if (lvlnum == 14)
            {
                ball1.Height = 50;
                ball1.Width = 50;
                ball2.Height = 50;
                ball2.Width = 50;
                ball3.Height = 50;
                ball3.Width = 50;
                ball4.Height = 50;
                ball4.Width = 50;
                ball5.Height = 50;
                ball5.Width = 50;
            }
            if (lvlnum == 15)
            {
                GameTimer.Interval = 30;
            }
            if (lvlnum == 716)
            {
                GameTimer.Interval = 10;
            }
            if (lvlnum == 17)
            {
                ball1.Height = 55;
                ball1.Width = 55;
                ball2.Height = 55;
                ball2.Width = 55;
                ball3.Height = 55;
                ball3.Width = 55;
                ball4.Height = 55;
                ball4.Width = 55;
                ball5.Height = 55;
                ball5.Width = 55;
            }
            if (lvlnum == 18)
            {
                ball1.Height = 60;
                ball1.Width = 60;
                ball2.Height = 60;
                ball2.Width = 60;
                ball3.Height = 60;
                ball3.Width = 60;
                ball4.Height = 60;
                ball4.Width = 60;
                ball5.Height = 60;
                ball5.Width = 60;
            }
            if (lvlnum == 19)
            {
               
            }
            if(lvlnum == 20)
            {
                win1();
            }
        }

        public void Colitions(PictureBox ball)                                          //ball collitions
        {
            if(ball.Location.X < panel1.Location.X)
            {
                ball.Left += SPEED;
                if (ball == ball1) 
                {
                    mx1 = -mx1;
                }
                if (ball == ball2)
                {
                    mx2 = -mx2;
                }
                if (ball == ball3)
                {
                    mx3 = -mx3;
                }
                if (ball == ball4)
                {
                    mx4 = -mx4;
                }
                if (ball == ball5)
                {
                    mx5 = -mx5;
                }
            }
            if (ball.Location.Y < panel1.Location.Y)
            {
                ball.Top += SPEED;
                if (ball == ball1)
                {
                    my1 = -my1;
                }
                if (ball == ball2)
                {
                    my2 = -my2;
                }
                if (ball == ball3)
                {
                    my3 = -my3;
                }
                if (ball == ball4)
                {
                    my4 = -my4;
                }
                if (ball == ball5)
                {
                    my5 = -my5;
                }
            }
            if (ball.Location.X + ball.Width > panel1.Location.X + panel1.Width)
            {
                ball.Left -= SPEED;
                if (ball == ball1)
                {
                    mx1 = -mx1;
                }
                if (ball == ball2)
                {
                    mx2 = -mx2;
                }
                if (ball == ball3)
                {
                    mx3 = -mx3;
                }
                if (ball == ball4)
                {
                    mx4 = -mx4;
                }
                if (ball == ball5)
                {
                    mx5 = -mx5;
                }
            }
            if (ball.Location.Y + ball.Height > panel1.Location.Y + panel1.Height)
            {
                ball.Top -= SPEED;
                if (ball == ball1)
                {
                    my1 = -my1;
                }
                if (ball == ball2)
                {
                    my2 = -my2;
                }
                if (ball == ball3)
                {
                    my3 = -my3;
                }
                if (ball == ball4)
                {
                    my4 = -my4;
                }
                if (ball == ball5)
                {
                    my5 = -my5;
                }
            }

            if (player.Location.X < panel1.Location.X)                    //player colitions
            {
                player.Left += 10;
            }
            if (player.Location.Y < panel1.Location.Y)
            {
                player.Top += 10;
            }
            if (player.Location.X + player.Width > panel1.Location.X + panel1.Width)
            {
                player.Left -= 10;
            }
            if (player.Location.Y + player.Height > panel1.Location.Y + panel1.Height)
            {
                player.Top -= 10;
            }
                                                                            //player ball colitions
            if (player.Location.X > ball.Location.X && player.Location.X < ball.Location.X + ball.Width && player.Location.Y > ball.Location.Y && player.Location.Y < ball.Location.Y + ball.Height || ball.Location.X > player.Location.X && ball.Location.X < player.Location.X + player.Width && ball.Location.Y > player.Location.Y && ball.Location.Y < player.Location.Y + player.Height) 
            {
                Death();
            }
            if (player.Location.X + player.Width > ball.Location.X && player.Location.X + player.Width < ball.Location.X + ball.Width && player.Location.Y > ball.Location.Y && player.Location.Y < ball.Location.Y + ball.Height)
            {
                Death();
            }
            if (player.Location.X > ball.Location.X && player.Location.X < ball.Location.X + ball.Width && player.Location.Y + player.Height > ball.Location.Y && player.Location.Y + player.Height < ball.Location.Y + ball.Height)
            {
                Death();
            }
            if (player.Location.X + player.Width > ball.Location.X && player.Location.X + player.Width < ball.Location.X + ball.Width && player.Location.Y + player.Height > ball.Location.Y && player.Location.Y + player.Height < ball.Location.Y + ball.Height)
            {
                Death();
            }
        }

        public void win1() 
        {
            player.Height = 30;
            player.Width = 30;
            player.Location = new Point(699, 125);
            ball1.Location = new Point(649, 125);
            ball2.Location = new Point(634, 187);
            ball3.Location = new Point(714, 187);
            ball4.Location = new Point(661, 212);
            ball5.Location = new Point(688, 212);
            reset();
            lvlnum = 11;
            MessageBox.Show("You Win!! You beat levels 1-10. Press OK to continue 11-20");
            player.Location = new Point(rand.Next(20, 1000), rand.Next(20, 650));
            player.Height = 45;
            player.Width = 45;
            lvl.Start();
            GameTimer.Start();
        }

        public void Death() 
        {
            player.Location = new Point(rand.Next(20, 1000), rand.Next(20, 650));
            reset();
            MessageBox.Show("YOU DIED!!");
            lvl.Start();
            GameTimer.Start();
        }

        public void reset() 
        {
            
            GameTimer.Stop();
            lvl.Stop();
            lvlnum = 1;
            GameTimer.Interval = 30;
            ball1.Height = 30;
            ball1.Width = 30;
            ball2.Height = 30;
            ball2.Width = 30;
            ball3.Height = 30;
            ball3.Width = 30;
            ball4.Height = 30;
            ball4.Width = 30;
            ball5.Height = 30;
            ball5.Width = 30;
            mx1 = rand.Next(-SPEED, SPEED);
            my1 = rand.Next(-SPEED, SPEED);
            mx2 = rand.Next(-SPEED, SPEED);
            my2 = rand.Next(-SPEED, SPEED);
            mx3 = rand.Next(-SPEED, SPEED);
            my3 = rand.Next(-SPEED, SPEED);
            mx4 = rand.Next(-SPEED, SPEED);
            my4 = rand.Next(-SPEED, SPEED);
            mx5 = rand.Next(-SPEED, SPEED);
            my5 = rand.Next(-SPEED, SPEED);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) 
            {
                player.Top -= PS;
            }
            if (e.KeyCode == Keys.Down)
            {
                player.Top += PS;
            }
            if (e.KeyCode == Keys.Right)
            {
                player.Left += PS;
            }
            if (e.KeyCode == Keys.Left)
            {
                player.Left -= PS;
            }
        }
    }
}
