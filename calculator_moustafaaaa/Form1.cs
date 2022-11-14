namespace calculator_moustafaaaa
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

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void reminder_Click(object sender, EventArgs e)
        {
            sign.Text = "%";
        }

        private void seven_Click(object sender, EventArgs e)
        {

        }

        private void minas_Click(object sender, EventArgs e)
        {
            sign.Text = "-";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            sign.Text = "*";
        }

        private void dot_Click(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                input_one.Text += '1';
            }
            else
            {
                input_two.Text += '1';
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                input_one.Text += '9';
            }
            else
            {
                input_two.Text += '9';
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                input_one.Text += '4';
            }
            else
            {
                input_two.Text += '4';
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                input_one.Text += '0';
            }
            else
            {
                input_two.Text += '0';
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                input_one.Text += '3';
            }
            else
            {
                input_two.Text += '3';
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                input_one.Text += '2';
            }
            else
            {
                input_two.Text += '2';
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                input_one.Text += '6';
            }
            else
            {
                input_two.Text += '6';
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                input_one.Text += '5';
            }
            else
            {
                input_two.Text += '5';
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (sign.Text == " ")
            {
                input_one.Text += '8';
            }
            else
            {
                input_two.Text += '8';
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            sign.Text = "+";
        }

        private void input_one_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_two_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void on_Click(object sender, EventArgs e)
        {
            sign.Text =" ";
        }

        private void divid_Click(object sender, EventArgs e)
        {
            sign.Text = "/";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            input_two.Text = "";
            input_one.Text = "";
            sign.Text = "";
        }
    }
}