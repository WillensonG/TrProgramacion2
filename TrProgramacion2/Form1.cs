namespace TrProgramacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
          textBox1_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.DateChanged -= monthCalendar1_DateChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}