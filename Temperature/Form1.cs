namespace Temperature
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

        private float farenheit(float number)
        {
            float f = (number * 9f / 5f) + 32;
            return f;
        }

        private float celcius(float number)
        {
            float c = (number - 32) * 5f / 9f;
            return c;
        }

        private void buttonf_Click(object sender, EventArgs e)
        {
            tbFar.Text = celcius(float.Parse(tbCel.Text)).ToString();
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            tbCel.Text = farenheit(float.Parse(tbFar.Text)).ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbCel.Text = "";
            tbFar.Text = "";
        }

    }
}
