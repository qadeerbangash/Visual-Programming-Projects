using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ageCalculator
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
            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            int age = to.Year - from.Year;
            if(to.Month>from.Month||to.Month==from.Month||to.Day>from.Day)
            {
                textBox1.Text = age.ToString();

            }
            else
            { 
                age--;
                textBox1.Text = age.ToString();
            }
        }
    }
}
