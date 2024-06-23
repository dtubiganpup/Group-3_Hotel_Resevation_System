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

            InitializeTextBox(textBox1, "Last Name...");
            InitializeTextBox(textBox2, "First Name...");
            InitializeTextBox(textBox3, "Middle Name...");
            InitializeTextBox(textBox4, "Contact No...");
            InitializeTextBox(textBox7, "Email Address...");
            InitializeTextBox(textBox5, "Address...");
            InitializeTextBox(textBox6, "mm/dd/yyyy");
            InitializeTextBox(textBox8, "mm/dd/yyyy");
            InitializeTextBox(textBox9, "Room No...");
            InitializeComboBox(comboBox1, "Month");
            InitializeComboBox(comboBox2, "Day");
            InitializeComboBox(comboBox3, "Year");
            InitializeComboBox(comboBox4, "ID Type");
            InitializeComboBox(comboBox5, "Gender");
            InitializeComboBox(comboBox6, "Nationality");
            InitializeComboBox(comboBox7, "Hr.");
            InitializeComboBox(comboBox8, "Min.");
            InitializeComboBox(comboBox9, "PM");
            InitializeComboBox(comboBox10, "PM");
            InitializeComboBox(comboBox12, "Hr.");
            InitializeComboBox(comboBox11, "Min.");
            InitializeComboBox(comboBox13, "Room Type");

        }
        private void InitializeComboBox(ComboBox comboBox, string initialText)
        {
            comboBox.Text = initialText;
            comboBox.ForeColor = Color.Gray;
            comboBox.Tag = initialText; // Store the initial text in the Tag property

            comboBox.Enter += ComboBox_Enter;
            comboBox.Leave += ComboBox_Leave;
        }

        private void ComboBox_Enter(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.ForeColor == Color.Gray)
            {
                comboBox.Text = "";
                comboBox.ForeColor = Color.Black; // Change text color to black when user starts typing
            }
        }

        private void ComboBox_Leave(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && string.IsNullOrWhiteSpace(comboBox.Text))
            {
                // Set the initial text based on the Tag property
                comboBox.Text = comboBox.Tag.ToString();
                comboBox.ForeColor = Color.Gray; // Change text color back to gray if no input
            }
        }


        private void InitializeTextBox(TextBox textBox, string initialText)
        {
            textBox.Text = initialText;
            textBox.ForeColor = Color.Gray;
            textBox.Tag = initialText; // Store the initial text in the Tag property

            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black; // Change text color to black when user starts typing
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                // Set the initial text based on the Tag property
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.Gray; // Change text color back to gray if no input
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}