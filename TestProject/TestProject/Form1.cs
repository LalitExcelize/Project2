namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message 1");
            
            //Branch 1
            MessageBox.Show("Message 1"); // New Message in Branch 1

            // Branch 2
            MessageBox.Show("Message 2"); // New Message in Branch 2
            MessageBox.Show("Message 3"); // New Message in Branch 2
            MessageBox.Show("Message 4"); // New Message in Branch 2
        }
    }
}
