namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_one_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(label_one.Text =="mostafa"&&label_two.Text == "123456")
            {
                using(Form2 a=new Form2())
                {
                    a.ShowDialog();
                }
            }
            else
            {

                MessageBox.Show("invalid information");
            }
        }
    }
}