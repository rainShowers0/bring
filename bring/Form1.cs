namespace bring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path1 = Directory.GetCurrentDirectory() + "\\..\\..\\..\\test1.txt";
        string path2 = Directory.GetCurrentDirectory() + "\\..\\..\\..\\test2.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter sw1 = new StreamWriter(path1);
            sw1.Write("Qwertyuio qwertyu \n qwertyuiop asdjl Alkjsd.");
            sw1.Close();
            StreamWriter sw2 = new StreamWriter(path2);
            sw2.Write("Zxz,cmnm,bnbvnfj \n asjdklasdjlkj \n asdhwadwakjdwha.");
            sw2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path1);
            textBox1.Clear();
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path2);
            textBox1.Clear();
            while(sr.Peek() > -1)
            {
                textBox1.Text += sr.ReadLine();
                MessageBox.Show(sr.Peek().ToString());
            }
            sr.Close();
        }
    }
}