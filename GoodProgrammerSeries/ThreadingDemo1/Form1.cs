namespace ThreadingDemo1
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
            MessageBox.Show("İşlem 1 çalıştı");
        }

        private void btnProccess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 2 çalıştı");

        }
    }
}