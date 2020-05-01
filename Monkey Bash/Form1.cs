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
        /// This method starts the timers with the normal monkey set in the 
        /// picture box and sets the text of the labels.
        /// </summary>
        private void startTimer(object sender, EventArgs e)
        {
            monkeyOnePictureBox.Image = Image.FromFile("Monkey.jpg");
            monkeyTwoPictureBox.Image = Image.FromFile("Monkey.jpg");
            monkeyThreePictureBox.Image = Image.FromFile("Monkey.jpg");
            monkeyFourPictureBox.Image = Image.FromFile("Monkey.jpg");
            monkeyFivePictureBox.Image = Image.FromFile("Monkey.jpg");
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
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
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }

        /// <summary>
        /// The next 5 methods adds one to the hit monkey score and then 
        /// changes all of the monkeys to an angry one and brings up a message
        /// box saying you have hit one of them.
        /// </summary>
        private void monkeyOneCaught(object sender, EventArgs e)
        {
            hitMonkey++;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            MessageBox.Show("HEY! You HIT One of us!");
            monkeyOnePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyTwoPictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyThreePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyFourPictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyFivePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
        }

        private void monkeyTwoCaught(object sender, EventArgs e)
        {
            hitMonkey++;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            MessageBox.Show("HEY! You HIT One of us!");
            monkeyOnePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyTwoPictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyThreePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyFourPictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyFivePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
        }

        private void monkeyThreeCaught(object sender, EventArgs e)
        {
            hitMonkey++;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            MessageBox.Show("HEY! You HIT One of us!");
            monkeyOnePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyTwoPictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyThreePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyFourPictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyFivePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
        }

        private void monkeyFourCaught(object sender, EventArgs e)
        {
            hitMonkey++;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            MessageBox.Show("HEY! You HIT One of us!");
            monkeyOnePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyTwoPictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyThreePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyFourPictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyFivePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
        }

        private void monkeyFiveCaught(object sender, EventArgs e)
        {
            hitMonkey++;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            MessageBox.Show("HEY! You HIT One of us!");
            monkeyOnePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyTwoPictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyThreePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyFourPictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
            monkeyFivePictureBox.Image = Image.FromFile("Angry_Monkey.jpg");
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
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            MessageBox.Show("You MISSED!");
            monkeyOnePictureBox.Image = Image.FromFile("Happy_Monkey.jpg");
            monkeyTwoPictureBox.Image = Image.FromFile("Happy_Monkey.jpg");
            monkeyThreePictureBox.Image = Image.FromFile("Happy_Monkey.jpg");
            monkeyFourPictureBox.Image = Image.FromFile("Happy_Monkey.jpg");
            monkeyFivePictureBox.Image = Image.FromFile("Happy_Monkey.jpg");
        }

        /// <summary>
        /// The next 5 methods set up a timer that changes the position of the
        /// monkeys as the timers ticks on.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = rand.Next(Width - 100);
            y = rand.Next(Height - 100);
            monkeyOnePictureBox.Left = x;
            monkeyOnePictureBox.Top = y;
            Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            x = rand.Next(Width - 100);
            y = rand.Next(Height - 100);
            monkeyTwoPictureBox.Left = x;
            monkeyTwoPictureBox.Top = y;
            Refresh();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            x = rand.Next(Width - 100);
            y = rand.Next(Height - 100);
            monkeyThreePictureBox.Left = x;
            monkeyThreePictureBox.Top = y;
            Refresh();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            x = rand.Next(Width - 100);
            y = rand.Next(Height - 100);
            monkeyFourPictureBox.Left = x;
            monkeyFourPictureBox.Top = y;
            Refresh();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            x = rand.Next(Width - 100);
            y = rand.Next(Height - 100);
            monkeyFivePictureBox.Left = x;
            monkeyFivePictureBox.Top = y;
            Refresh();
        }
    }
}
