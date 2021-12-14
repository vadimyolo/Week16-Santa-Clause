using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaClauseIsComingToTown
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int objectSpeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_Tick(object sender, EventArgs e)
        {
            santaFly.Top += gravity;
            tree.Left -= objectSpeed;
            snowFlake.Left -= objectSpeed;
            moon.Left -= objectSpeed;
            house.Left -= objectSpeed;
            scoreLabel.Text = $"score: {score}";

            if (snowFlake.Left < -140)
            {
                snowFlake.Left = 650;
                score++;
            }
            if(tree.Left < -140)
            {
                tree.Left = 720;
                score++;
            }
            if(house.Left < -140)
            {
                house.Left = 750;
            }
            if (santaFly.Top < -25)
            {
                gameOver();
            }
            if (santaFly.Bounds.IntersectsWith(snowFlake.Bounds) || santaFly.Bounds.IntersectsWith(tree.Bounds) || santaFly.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                gameOver();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void gameOver()
        {
            timer1_Tick.Stop();
            scoreLabel.Text = $"Game Over!";
            button1.Visible = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        
    }
}
