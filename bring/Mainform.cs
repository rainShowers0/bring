namespace bring
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            RegisterForm myform = new RegisterForm();
            myform.Show();
        }
    }
}
