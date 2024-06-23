using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM_TRY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = ""; // Set initial text
            textBox1.ForeColor = Color.Black; // Set initial text color to gray

            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;
        }
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter User ID")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black; // Change text color to black when user starts typing
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Enter User ID";
                textBox1.ForeColor = Color.Gray; // Change text color back to gray if no input
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}