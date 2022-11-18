using System.Text;

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"C:\Users\User\Desktop\");
            foreach(string file in files)
            {
                if(Path.GetExtension(file) == ".txt") comboBox1.Items.Add(file);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filename = comboBox1.Text;
            FileStream FS = File.OpenWrite(filename);
            byte[] mytext = new UTF8Encoding(true).GetBytes(textBox1.Text);
            FS.Write(mytext, 0, mytext.Length);
            FS.Close();
        }
    }
}