using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetCharacters("H", "ح");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GetCharacters("I", "ا");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetCharacters("A", "ا");
           // textBox1.Text = "A";
            //textBox2.Text = "ا";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetCharacters("B", "ب");
           // textBox1.Text = "B";
            //textBox2.Text = "ب";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetCharacters("C", "ث");
           // textBox1.Text = "C";
            //textBox2.Text = "ث";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetCharacters("D", "د");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetCharacters("E", "ی");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetCharacters("F", "ف");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetCharacters("G", "گ");

        }

        private void button18_Click(object sender, EventArgs e)
        {
            GetCharacters("J", "ج");

        }

        private void button17_Click(object sender, EventArgs e)
        {
            GetCharacters("K", "ک");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            GetCharacters("L", "ل");

        }

        private void button16_Click(object sender, EventArgs e)
        {
            GetCharacters("M", "م");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            GetCharacters("N", "ن");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            GetCharacters("O", "او");

        }

        private void button13_Click(object sender, EventArgs e)
        {
            GetCharacters("P", "پ");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            GetCharacters("Q", "ق");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            GetCharacters("R", "ر");

        }

        private void button27_Click(object sender, EventArgs e)
        {
            GetCharacters("S", "س");

        }

        private void button26_Click(object sender, EventArgs e)
        {
            GetCharacters("T", "ٹ");

        }

        private void button24_Click(object sender, EventArgs e)
        {
            GetCharacters("U", "یو");

        }

        private void button25_Click(object sender, EventArgs e)
        {
            GetCharacters("V", "وی");

        }

        private void button20_Click(object sender, EventArgs e)
        {
            GetCharacters("W", "و");

        }

        private void button21_Click(object sender, EventArgs e)
        {
            GetCharacters("X", "ایکس");

        }

        private void button22_Click(object sender, EventArgs e)
        {
            GetCharacters("Y", "ی");

        }

        private void button23_Click(object sender, EventArgs e)
        {
            GetCharacters("Z", "ذ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void GetCharacters(string englishChar,string urduChar)
        {
            textBox1.Text += englishChar;
            textBox2.Text +=urduChar;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
