namespace bring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("хэрэглэгчийн нэр оруулна уу");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("нууц үгээ оруулна уу");
            }
            else
            {
                StreamReader sr = new StreamReader(@"..\..\..\txtfiles\myUser.txt");
                string username;
                string password;
                bool isMyUser = false;
                while (sr.Peek() > -1)
                {
                    username = sr.ReadLine();
                    password = sr.ReadLine();
                    if (username == textBox1.Text.Trim() && password == textBox2.Text.Trim())
                    {
                        isMyUser = true;
                        Mainform myForm = new Mainform();
                        myForm.Show();
                        this.Hide();
                    }
                }
                sr.Close();
                if (isMyUser == false)
                {
                    MessageBox.Show("buruu");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}