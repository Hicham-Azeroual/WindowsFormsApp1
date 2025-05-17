using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
            label1.BackColor = Color.Yellow;
            string text = textBox1.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter some text.");
            }
            else
            {
                // disable the input box
                textBox2.Enabled = false;
                textBox2.Text = textBox1.Text;
                //  change the background color of the input box
                textBox2.BackColor = Color.LightBlue;
                textBox1.Text = "";

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter some text.");
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";

            }

        }

        private void label1_FontChanged(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
