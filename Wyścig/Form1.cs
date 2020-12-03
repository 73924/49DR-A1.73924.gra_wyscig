using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            Moveline(gamespeed);
        }

        void Moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }


        }


        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if (jellowCar.Left>13)
                jellowCar.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (jellowCar.Right < 420)
                    jellowCar.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }
            if (e.KeyCode == Keys.Down)

            {
                if (gamespeed > 0)
                { gamespeed--; }
            }
            
        }
    }
}
