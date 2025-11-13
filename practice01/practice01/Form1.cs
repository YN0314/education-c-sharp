using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApppractice01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int stone = 0;
        int scissors = 1;
        int paper = 2;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(3);

            if(randomnumber == stone)
            {
                textBox1.Text = "グー";
                MessageBox.Show("あいこ", "勝敗");
            }

            else if (randomnumber == scissors)
            {
                textBox1.Text = "チョキ";
                MessageBox.Show("勝ち", "勝敗");
            }
            else if (randomnumber == paper)
            {
                textBox1.Text = "パー";
                MessageBox.Show("負け", "勝敗");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(3);

            if (randomnumber == scissors)
            {
                textBox1.Text = "チョキ";
                MessageBox.Show("あいこ", "勝敗");
            }

            else if (randomnumber == paper)
            {
                textBox1.Text = "パー";
                MessageBox.Show("勝ち", "勝敗");
            }
            else if (randomnumber == stone)
            {
                textBox1.Text = "グー";
                MessageBox.Show("負け", "勝敗");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(3);

            if (randomnumber == paper)
            {
                textBox1.Text = "パー";
                MessageBox.Show("あいこ", "勝敗");
            }

            else if (randomnumber == stone)
            {
                textBox1.Text = "グー";
                MessageBox.Show("勝ち", "勝敗");
            }
            else if (randomnumber == scissors)
            {
                textBox1.Text = "チョキ";
                MessageBox.Show("負け", "勝敗");
            }
        }
    }
}
