using CalculatorOfSylveon.Properties;

namespace CalculatorOfSylveon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalSylveon;
        int num1;
        int num2;
        string option;
        int result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            otchet.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(otchet.Text);
            otchet.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(otchet.Text);
            otchet.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(otchet.Text);
            otchet.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(otchet.Text);
            otchet.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (otchet.Text == "")
            {
                otchet.Clear();
            }
            else
            {
                num2 = int.Parse(otchet.Text);
            }


            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            otchet.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            otchet.Text = otchet.Text + btn1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            otchet.Text = otchet.Text + btn2.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            otchet.Text = otchet.Text + btn3.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            otchet.Text = otchet.Text + btn4.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            otchet.Text = otchet.Text + btn5.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            otchet.Text = otchet.Text + btn6.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            otchet.Text = otchet.Text + btn7.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            otchet.Text = otchet.Text + btn8.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            otchet.Text = otchet.Text + btn9.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            otchet.Text = otchet.Text + btn0.Text;
        }

        private void sylveonspack_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.sylveon__1_;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.sylveon__1_1;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.sylveon__10_;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.sylveon__10_1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labeltime.Text = DateTime.Now.ToString();
        }

        System.Diagnostics.Stopwatch StopWatch = new System.Diagnostics.Stopwatch();

        private void steamtime_Tick(object sender, EventArgs e)
        {
            this.StopWatch.Start();
            TimeSpan elapsed = this.StopWatch.Elapsed;
            labelsteam.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelsteamtimeall_Click(object sender, EventArgs e)
        {
            ;
        }

        private void steamtimeall_Tick(object sender, EventArgs e)
        {

        }
    }
}