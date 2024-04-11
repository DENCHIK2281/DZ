using WinFormsApp5.classes;

namespace WinFormsApp5

{
    public partial class Form1 : Form
    {
        Govnas popo = new Govnas();
        public Form1()
        {
            InitializeComponent();
        }

        private void увеличить_Click(object sender, EventArgs e)
        {
            popo.увеличить();
            textBox1.Text = popo.Это_вот_это.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            popo.уменшить();
            textBox1.Text = popo.Это_вот_это.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            popo = new Govnas();
            textBox1.Text = popo.Это_вот_это.ToString();

        }
    }
}
