namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            pacman = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox20 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox22 = new PictureBox();
            pictureBox23 = new PictureBox();
            pictureBox24 = new PictureBox();
            pictureBox25 = new PictureBox();
            pictureBox26 = new PictureBox();
            pictureBox27 = new PictureBox();
            coin = new PictureBox();
            coin4 = new PictureBox();
            coin3 = new PictureBox();
            coin2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pacman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 426);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // pacman
            // 
            pacman.BackColor = SystemColors.ControlText;
            pacman.Image = Properties.Resources.pacman;
            pacman.Location = new Point(365, 377);
            pacman.Name = "pacman";
            pacman.Size = new Size(22, 27);
            pacman.SizeMode = PictureBoxSizeMode.Zoom;
            pacman.TabIndex = 2;
            pacman.TabStop = false;
            pacman.Click += pacman_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlText;
            pictureBox2.Image = Properties.Resources.blue;
            pictureBox2.Location = new Point(382, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlText;
            pictureBox3.Image = Properties.Resources.yellow;
            pictureBox3.Location = new Point(415, 216);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ControlText;
            pictureBox5.Image = Properties.Resources.red;
            pictureBox5.Location = new Point(322, 216);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.Desktop;
            pictureBox4.Location = new Point(12, 27);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(776, 396);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(75, 74);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(59, 23);
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(270, 249);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(220, 23);
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(137, 249);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(49, 23);
            pictureBox8.TabIndex = 10;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(75, 249);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(25, 105);
            pictureBox9.TabIndex = 11;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(75, 350);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(59, 23);
            pictureBox10.TabIndex = 12;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = SystemColors.Highlight;
            pictureBox11.Location = new Point(466, 176);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(24, 87);
            pictureBox11.TabIndex = 13;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(75, 94);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(25, 105);
            pictureBox12.TabIndex = 14;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(137, 176);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(49, 23);
            pictureBox13.TabIndex = 15;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(162, 27);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(24, 85);
            pictureBox14.TabIndex = 16;
            pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.Location = new Point(162, 338);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(24, 85);
            pictureBox15.TabIndex = 17;
            pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Location = new Point(288, 306);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(180, 23);
            pictureBox16.TabIndex = 18;
            pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.Location = new Point(270, 176);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(24, 87);
            pictureBox17.TabIndex = 19;
            pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.BackColor = SystemColors.HotTrack;
            pictureBox18.Location = new Point(270, 176);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(49, 23);
            pictureBox18.TabIndex = 20;
            pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.BackColor = SystemColors.Highlight;
            pictureBox19.Location = new Point(441, 176);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(49, 23);
            pictureBox19.TabIndex = 21;
            pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            pictureBox20.Location = new Point(589, 27);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(24, 85);
            pictureBox20.TabIndex = 22;
            pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            pictureBox21.Location = new Point(647, 74);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(59, 23);
            pictureBox21.TabIndex = 23;
            pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            pictureBox22.Location = new Point(681, 94);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(25, 105);
            pictureBox22.TabIndex = 24;
            pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            pictureBox23.Location = new Point(589, 176);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(49, 23);
            pictureBox23.TabIndex = 25;
            pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            pictureBox24.Location = new Point(589, 249);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(49, 23);
            pictureBox24.TabIndex = 26;
            pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            pictureBox25.Location = new Point(681, 249);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(25, 105);
            pictureBox25.TabIndex = 27;
            pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            pictureBox26.Location = new Point(647, 350);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(59, 23);
            pictureBox26.TabIndex = 28;
            pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            pictureBox27.Location = new Point(589, 338);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(24, 85);
            pictureBox27.TabIndex = 29;
            pictureBox27.TabStop = false;
            // 
            // coin
            // 
            coin.BackColor = SystemColors.ControlText;
            coin.Image = Properties.Resources.dollar;
            coin.Location = new Point(27, 48);
            coin.Name = "coin";
            coin.Size = new Size(22, 21);
            coin.SizeMode = PictureBoxSizeMode.Zoom;
            coin.TabIndex = 30;
            coin.TabStop = false;
            // 
            // coin4
            // 
            coin4.BackColor = SystemColors.ControlText;
            coin4.Image = Properties.Resources.dollar;
            coin4.Location = new Point(754, 377);
            coin4.Name = "coin4";
            coin4.Size = new Size(22, 21);
            coin4.SizeMode = PictureBoxSizeMode.Zoom;
            coin4.TabIndex = 44;
            coin4.TabStop = false;
            // 
            // coin3
            // 
            coin3.BackColor = SystemColors.ControlText;
            coin3.Image = Properties.Resources.dollar;
            coin3.Location = new Point(753, 48);
            coin3.Name = "coin3";
            coin3.Size = new Size(22, 21);
            coin3.SizeMode = PictureBoxSizeMode.Zoom;
            coin3.TabIndex = 45;
            coin3.TabStop = false;
            // 
            // coin2
            // 
            coin2.BackColor = SystemColors.ControlText;
            coin2.Image = Properties.Resources.dollar;
            coin2.Location = new Point(32, 377);
            coin2.Name = "coin2";
            coin2.Size = new Size(22, 21);
            coin2.SizeMode = PictureBoxSizeMode.Zoom;
            coin2.TabIndex = 46;
            coin2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(pacman);
            Controls.Add(coin2);
            Controls.Add(coin3);
            Controls.Add(coin4);
            Controls.Add(coin);
            Controls.Add(pictureBox27);
            Controls.Add(pictureBox26);
            Controls.Add(pictureBox25);
            Controls.Add(pictureBox24);
            Controls.Add(pictureBox23);
            Controls.Add(pictureBox22);
            Controls.Add(pictureBox21);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pacman).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin4).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pacman;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox coin;
        private PictureBox coin4;
        private PictureBox coin3;
        private PictureBox coin2;
        private System.Windows.Forms.Timer timer1;
    }
}