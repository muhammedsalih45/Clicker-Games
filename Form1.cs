namespace Clicker_Games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hit = 20;
        int altin = 0; 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            altin += hit;
            label2.Text = altin.ToString();

            if (progressBar1.Value <= hit)
            {
                MessageBox.Show("Tebrikler düþmaný yendiniz");
                Application.Exit();
            }
            else
            {
                progressBar1.Value -= hit;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "1000 Altýn";
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "2000 Altýn";
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "3000 Altýn";
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "4000 Altýn";
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "5000 Altýn";
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "6000 Altýn";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (altin >= 1000)
            {
                altin -= 1000;
                hit = 60;
                label2.Text = altin.ToString();
                pictureBox2.BackColor = Color.Green;
                pictureBox2.Enabled = false;
            }
            else
            {
                label3.Text = "Para yetersiz";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (altin >= 2000)
            {
                altin -= 2000;
                hit = 100;
                label2.Text = altin.ToString();
                pictureBox3.BackColor = Color.Green;
                pictureBox3.Enabled = false;
            }
            else
            {
                label3.Text = "Para yetersiz";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            altin++;
            label2.Text = altin.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (altin >= 3000)
            {
                altin -= 3000;
                hit = 160;
                label2.Text = altin.ToString();
                pictureBox4.Enabled = false;
                pictureBox4.BackColor = Color.Green;
            }
            else
            {
                label3.Text = "Para yetersiz";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (altin >= 4000)
            {
                altin -= 4000;
                hit = 200;
                label2.Text = altin.ToString();
                pictureBox5.Enabled = false;
                pictureBox5.BackColor = Color.Green;
            }
            else
            {
                label3.Text = "Para yetersiz";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (altin >= 5000)
            {
                altin -= 5000;
                hit = 260;
                label2.Text = altin.ToString();
                pictureBox6.BackColor = Color.Green;
                pictureBox6.Enabled = false;
            }
            else
            {
                label3.Text = "Para yetersiz";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (altin >= 6000)
            {
                altin -= 6000;
                hit = 300;
                label2.Text = altin.ToString();
                pictureBox7.Enabled = false;
                pictureBox7.BackColor = Color.Green;
            }
            else
            {
                label3.Text = "Para yetersiz";
            }
        }
    }
}
