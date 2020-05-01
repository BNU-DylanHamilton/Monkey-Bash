namespace Monkey_Bash
{
    partial class monkeyBashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monkeyBashForm));
            this.monkeyOnePictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monkeyMissedLabel = new System.Windows.Forms.Label();
            this.monkeyHitLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monkeyTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.monkeyThreePictureBox = new System.Windows.Forms.PictureBox();
            this.monkeyFourPictureBox = new System.Windows.Forms.PictureBox();
            this.monkeyFivePictureBox = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.monkeyOnePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyThreePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyFourPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyFivePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // monkeyOnePictureBox
            // 
            this.monkeyOnePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("monkeyOnePictureBox.BackgroundImage")));
            this.monkeyOnePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monkeyOnePictureBox.Location = new System.Drawing.Point(24, 12);
            this.monkeyOnePictureBox.Name = "monkeyOnePictureBox";
            this.monkeyOnePictureBox.Size = new System.Drawing.Size(91, 111);
            this.monkeyOnePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyOnePictureBox.TabIndex = 0;
            this.monkeyOnePictureBox.TabStop = false;
            this.monkeyOnePictureBox.Click += new System.EventHandler(this.monkeyOneCaught);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(40, 466);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(104, 31);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startTimer);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(208, 466);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(104, 31);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopTimer);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(373, 466);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(104, 31);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.closeApplication);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monkeyMissedLabel);
            this.groupBox1.Controls.Add(this.monkeyHitLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(728, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // monkeyMissedLabel
            // 
            this.monkeyMissedLabel.Location = new System.Drawing.Point(19, 100);
            this.monkeyMissedLabel.Name = "monkeyMissedLabel";
            this.monkeyMissedLabel.Size = new System.Drawing.Size(59, 31);
            this.monkeyMissedLabel.TabIndex = 3;
            // 
            // monkeyHitLabel
            // 
            this.monkeyHitLabel.Location = new System.Drawing.Point(19, 43);
            this.monkeyHitLabel.Name = "monkeyHitLabel";
            this.monkeyHitLabel.Size = new System.Drawing.Size(59, 27);
            this.monkeyHitLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monkey Missed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monkey Hit:";
            // 
            // monkeyTwoPictureBox
            // 
            this.monkeyTwoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("monkeyTwoPictureBox.BackgroundImage")));
            this.monkeyTwoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monkeyTwoPictureBox.Location = new System.Drawing.Point(187, 159);
            this.monkeyTwoPictureBox.Name = "monkeyTwoPictureBox";
            this.monkeyTwoPictureBox.Size = new System.Drawing.Size(91, 111);
            this.monkeyTwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyTwoPictureBox.TabIndex = 5;
            this.monkeyTwoPictureBox.TabStop = false;
            this.monkeyTwoPictureBox.Click += new System.EventHandler(this.monkeyTwoCaught);
            // 
            // monkeyThreePictureBox
            // 
            this.monkeyThreePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("monkeyThreePictureBox.BackgroundImage")));
            this.monkeyThreePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monkeyThreePictureBox.Location = new System.Drawing.Point(532, 80);
            this.monkeyThreePictureBox.Name = "monkeyThreePictureBox";
            this.monkeyThreePictureBox.Size = new System.Drawing.Size(91, 111);
            this.monkeyThreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyThreePictureBox.TabIndex = 6;
            this.monkeyThreePictureBox.TabStop = false;
            this.monkeyThreePictureBox.Click += new System.EventHandler(this.monkeyThreeCaught);
            // 
            // monkeyFourPictureBox
            // 
            this.monkeyFourPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("monkeyFourPictureBox.BackgroundImage")));
            this.monkeyFourPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monkeyFourPictureBox.Location = new System.Drawing.Point(352, 298);
            this.monkeyFourPictureBox.Name = "monkeyFourPictureBox";
            this.monkeyFourPictureBox.Size = new System.Drawing.Size(91, 111);
            this.monkeyFourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyFourPictureBox.TabIndex = 7;
            this.monkeyFourPictureBox.TabStop = false;
            this.monkeyFourPictureBox.Click += new System.EventHandler(this.monkeyFourCaught);
            // 
            // monkeyFivePictureBox
            // 
            this.monkeyFivePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("monkeyFivePictureBox.BackgroundImage")));
            this.monkeyFivePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monkeyFivePictureBox.Location = new System.Drawing.Point(587, 253);
            this.monkeyFivePictureBox.Name = "monkeyFivePictureBox";
            this.monkeyFivePictureBox.Size = new System.Drawing.Size(91, 111);
            this.monkeyFivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyFivePictureBox.TabIndex = 8;
            this.monkeyFivePictureBox.TabStop = false;
            this.monkeyFivePictureBox.Click += new System.EventHandler(this.monkeyFiveCaught);
            // 
            // timer2
            // 
            this.timer2.Interval = 250;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 650;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 575;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // monkeyBashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 519);
            this.Controls.Add(this.monkeyFivePictureBox);
            this.Controls.Add(this.monkeyFourPictureBox);
            this.Controls.Add(this.monkeyThreePictureBox);
            this.Controls.Add(this.monkeyTwoPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.monkeyOnePictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "monkeyBashForm";
            this.Text = "Monkey Bash: Detecting Mouse Clicks";
            this.Click += new System.EventHandler(this.monkeyMissed);
            ((System.ComponentModel.ISupportInitialize)(this.monkeyOnePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyTwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyThreePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyFourPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyFivePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox monkeyOnePictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label monkeyMissedLabel;
        private System.Windows.Forms.Label monkeyHitLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox monkeyTwoPictureBox;
        private System.Windows.Forms.PictureBox monkeyThreePictureBox;
        private System.Windows.Forms.PictureBox monkeyFourPictureBox;
        private System.Windows.Forms.PictureBox monkeyFivePictureBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
    }
}

