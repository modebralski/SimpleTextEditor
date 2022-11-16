namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void noweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void zakoñczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}