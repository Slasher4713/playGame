using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace playGame
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
       

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Bell1);
                sp.Play();

            startingInLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            startingInLabel.Text = "Starting in: 2";
            Refresh();
            Thread.Sleep(1000);
            startingInLabel.Text = "Starting in: 1";
            Refresh();
            Thread.Sleep(1000);
            startingInLabel.Text = "GO!";
            Refresh();
            this.BackColor = Color.Green;
            startButton.Visible = false;

            SoundPlayer ps = new SoundPlayer(Properties.Resources.Gun);
            ps.Play();
            Refresh();
            Thread.Sleep(1000);
            SoundPlayer wi = new SoundPlayer(Properties.Resources.Wind);
            wi.Play();  
           
        }

        private void startButton_MouseHover(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Red;

        }

        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.BackColor = Color.White;
        }

        private void startButton_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            Refresh();
            SoundPlayer ps = new SoundPlayer(Properties.Resources.Gun);
            ps.Play();
        }
    }
}
