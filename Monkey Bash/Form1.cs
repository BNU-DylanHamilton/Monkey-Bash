using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monkey_Bash
{
    public partial class monkeyBashForm : Form
    {
        private int x, y, hitMonkey, missedMonkey;
        private Random rand = new Random();

        public monkeyBashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method starts the timer with the normal monkey set in the 
        /// picture box and sets the text of the labels.
        /// </summary>
        private void startTimer(object sender, EventArgs e)
        {
            monkeyPictureBox.Image = Image.FromFile("Monkey.jpg");
            timer1.Enabled = true;
            monkeyHitLabel.Text = Convert.ToString(hitMonkey);
            monkeyMissedLabel.Text = Convert.ToString(missedMonkey);
        }

        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stopTimer(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        /// <summary>
        /// This method adds one to the hit monkey score and then 
        /// changes the monkey to an angry one and brings up a message
        /// box saying you have hit him.
        /// </summary>
        private void monkeyCaught(object sender, EventArgs e)
        {
            hitMonkey++;
            timer1.Enabled = false;
            MessageBox.Show("Ouch! You HIT Me!");
            monkeyPictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
        }

        /// <summary>
        /// This method adds one to the missed monkey score and then
        /// changes the monkey to a happy monkey and brings up a message
        /// box saying you have missed him.
        /// </summary>
        private void monkeyMissed(object sender, EventArgs e)
        {
            missedMonkey++;
            timer1.Enabled = false;
            MessageBox.Show("You MISSED!");
            monkeyPictureBox.Image = Image.FromFile("Happy_Monkey.jpg");

        }

        /// <summary>
        /// This method sets up a timer that changes the position of the
        /// monkey as the timers ticks on.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = rand.Next(Width - 100);
            y = rand.Next(Height - 100);
            monkeyPictureBox.Left = x;
            monkeyPictureBox.Top = y;
            Refresh();
        }
    }
}
