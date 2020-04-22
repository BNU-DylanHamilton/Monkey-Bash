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
            this.monkeyPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monkeyHitLabel = new System.Windows.Forms.Label();
            this.monkeyMissedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monkeyPictureBox
            // 
            this.monkeyPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("monkeyPictureBox.BackgroundImage")));
            this.monkeyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monkeyPictureBox.Location = new System.Drawing.Point(92, 102);
            this.monkeyPictureBox.Name = "monkeyPictureBox";
            this.monkeyPictureBox.Size = new System.Drawing.Size(91, 111);
            this.monkeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyPictureBox.TabIndex = 0;
            this.monkeyPictureBox.TabStop = false;
            this.monkeyPictureBox.Click += new System.EventHandler(this.monkeyCaught);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(40, 388);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(104, 31);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startTimer);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(208, 388);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(104, 31);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopTimer);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(374, 388);
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
            this.groupBox1.Location = new System.Drawing.Point(665, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monkey Missed:";
            // 
            // monkeyHitLabel
            // 
            this.monkeyHitLabel.AutoSize = true;
            this.monkeyHitLabel.Location = new System.Drawing.Point(19, 48);
            this.monkeyHitLabel.Name = "monkeyHitLabel";
            this.monkeyHitLabel.Size = new System.Drawing.Size(46, 17);
            this.monkeyHitLabel.TabIndex = 2;
            this.monkeyHitLabel.Text = "label3";
            // 
            // monkeyMissedLabel
            // 
            this.monkeyMissedLabel.AutoSize = true;
            this.monkeyMissedLabel.Location = new System.Drawing.Point(19, 107);
            this.monkeyMissedLabel.Name = "monkeyMissedLabel";
            this.monkeyMissedLabel.Size = new System.Drawing.Size(46, 17);
            this.monkeyMissedLabel.TabIndex = 3;
            this.monkeyMissedLabel.Text = "label4";
            // 
            // monkeyBashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.monkeyPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "monkeyBashForm";
            this.Text = "Monkey Bash: Detecting Mouse Clicks";
            this.Click += new System.EventHandler(this.monkeyMissed);
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox monkeyPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label monkeyMissedLabel;
        private System.Windows.Forms.Label monkeyHitLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

