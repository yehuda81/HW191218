using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW191218
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Debug.WriteLine("clear");
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            listBox1.Items.Add(a + b);
        }

        private void lessBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Debug.WriteLine("clear");
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            listBox1.Items.Add(a - b);
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Debug.WriteLine("clear");
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            listBox1.Items.Add(a * b);
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Debug.WriteLine("clear");
            double a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox2.Text);
            if (b == 0)
            {
               this.BackColor = Color.Red;
            }
            else
            {
                listBox1.Items.Add(a / b);
            }
        }

        private void powBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Debug.WriteLine("clear");
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            listBox1.Items.Add (Math.Pow (a , b));
        }

        private void rootBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Debug.WriteLine("clear");
            double a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox2.Text);          
            listBox1.Items.Add(Math.Pow (a ,1/b));
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            Random numrandom = new Random();
            textBox1.Text = ($"{numrandom.Next(0, 100)}");
            textBox2.Text = ($"{numrandom.Next(0, 100)}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
