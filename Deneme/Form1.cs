namespace Deneme
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

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int h = Convert.ToInt32(textBox3.Text);
            int x = Convert.ToInt32(textBox4.Text);
            int volume = a * b * h;
            textBox5.Text = volume.ToString();
            int count = (h / x) * a * b;
            textBox6.Text = count.ToString();
        }
    }
}