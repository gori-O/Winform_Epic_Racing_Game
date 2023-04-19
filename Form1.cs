using System;
using System.Drawing;
using System.Windows.Forms;

namespace racingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int carSpeed = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(carSpeed);
            TNTmove(carSpeed);
            coins(carSpeed);
            coincollect();
            gameOver();
            lbl_speed.Text = "speed : " + carSpeed.ToString();
        }
        void deleteStartImage()
        {
            pBox_start.Visible= false;
        }
        void moveline(int speed)
        {
            resetTop(pictureBox1);
            resetTop(pictureBox2);
            resetTop(pictureBox3);
            resetTop(pictureBox4);
            pictureBox1.Top += speed;
            pictureBox2.Top += speed;
            pictureBox3.Top += speed;
            pictureBox4.Top += speed;
        }
        void resetTop(PictureBox box)
        {
            if (box.Top >= 450)
                box.Top = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox_car.Left > 10)
                    pictureBox_car.Left += -10;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox_car.Right < 260)
                    pictureBox_car.Left += 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (carSpeed < 15)
                    carSpeed++;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (carSpeed > 0)
                    carSpeed--;
            }
            deleteStartImage();
        }

        Random rand = new Random();
        int x;
        void TNTmove(int speed)
        {
            if (TNT.Top >= 500)
            {
                x = rand.Next(0, 260);
                TNT.Location = new Point(x, 0);
            }
            else
            {
                TNT.Top += speed;
            }
        }
        void gameOver()
        {
            if(pictureBox_car.Bounds.IntersectsWith(TNT.Bounds))
            {
                timer1.Enabled = false;
                lblgameover.Visible = true;
                lbl_myscore.Visible = true;
                lbl_myscore.Text = "당신의 점수는 : " + collect + " 점!!";
            }
        }
        int collect = 0;
        void coincollect()
        {
            if(pictureBox_car.Bounds.IntersectsWith(pictureBox_coin.Bounds))
            {
                collect++;
                lblscore.Text = "Score : " + collect;
                x = rand.Next(0, 250);
                pictureBox_coin.Location = new Point(x, 0);
            }
        }
        void coins(int speed)
        {
            if (pictureBox_coin.Top >= 500)
            {
                x = rand.Next(0, 250);
                pictureBox_coin.Location = new Point(x, 0);
            }
            else
                pictureBox_coin.Top+= speed;
        }

    }
}