namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;
        int score = 0;
        bool iscoin = false;
        bool iscoin2 = false;
        bool iscoin3 = false;
        bool iscoin4 = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e, Keys keys)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Up:
                    up = true;
                    break;
                case Keys.Down:
                    down = true;
                    break;
                case Keys.Right:
                    right = true;
                    break;
                case Keys.Left:
                    left = true;
                    break;



            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (up && pacman.Location.Y > 27)
            {
                pacman.Top -= 10;
                down = left = right = false;
                pacman.Image = Image.FromFile("pacmanup.png");
            }
            else
            {
                up = false;
            }
            if (down && pacman.Location.Y < 377)
            {
                pacman.Top += 10;
                up = left = right = false;
                pacman.Image = Image.FromFile("pacmandown.png");
            }
            else
            {
                down = false;
            }
            if (left && pacman.Location.X > 24)
            {
                pacman.Left -= 10;
                up = down = right = false;
                pacman.Image = Image.FromFile("pacmanleft.png");
            }
            else
            {
                left = false;
            }
            if (right && pacman.Location.X < 745)
            {
                pacman.Left += 10;
                up = down = left = false;
                pacman.Image = Image.FromFile("pacman.png");
            }
            else
            {
                right = false;
            }
           
            if (pacman.Bounds.IntersectsWith(coin.Bounds))
            {
                coin.Visible = false;
                coin.Enabled = false;
                if (!iscoin)
                {
                    score = score + 1;
                    iscoin = true;
                }
            }
            if (pacman.Bounds.IntersectsWith(coin2.Bounds))
            {
                coin2.Visible = false;
                coin2.Enabled = false;
                if (!iscoin2)
                {
                    score = score + 1;
                    iscoin2 = true;
                }
            }
            if (pacman.Bounds.IntersectsWith(coin3.Bounds))
            {
                coin3.Visible = false;
                coin3.Enabled = false;
                if (!iscoin3)
                {
                    score = score + 1;
                    iscoin3 = true;
                }
            }
            if (pacman.Bounds.IntersectsWith(coin4.Bounds))
            {
                coin4.Visible = false;
                coin4.Enabled = false;
                if (!iscoin4)
                {
                    score = score + 1;
                    iscoin4 = true;
                }
            }
            label1.Text = "score" + score;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Enabled = true;
        }

        private void pacman_Click(object sender, EventArgs e)
        {

        }
    }
}