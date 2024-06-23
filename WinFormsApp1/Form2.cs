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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = ""; // Set initial text
            textBox1.ForeColor = Color.Black; // Set initial text color to gray

            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;

            textBox2.Text = ""; // Set initial text
            textBox1.ForeColor = Color.Black; // Set initial text color to gray

            textBox2.Enter += TextBox2_Enter;
            textBox2.Leave += TextBox2_Leave;

        }
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Last Name...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black; // Change text color to black when user starts typing
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Last Name...";
                textBox1.ForeColor = Color.Gray; // Change text color back to gray if no input
            }
        }
        private void TextBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Frist Name...")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black; // Change text color to black when user starts typing
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "First Name...";
                textBox2.ForeColor = Color.Gray; // Change text color back to gray if no input
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GUEST_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}