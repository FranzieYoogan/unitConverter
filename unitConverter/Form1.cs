namespace unitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            unit.Text = "inches";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unit.Text = "cm";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            meters.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            meters.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            meters.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            meters.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            meters.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            meters.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            meters.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            meters.Text += button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            meters.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            meters.Text += button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            meters.Text += button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (unit.Text == "inches")
            {
                double result = double.Parse(meters.Text) * 39.37;

                results.Text = result.ToString();

            }
            else if (unit.Text == "cm")
            {
                double result = double.Parse(meters.Text) * 100;

                results.Text = result.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            results.Text = "RESULT";
            unit.Text = "UNIT";
            meters.Text = "";
        }
    }
}
