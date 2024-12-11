using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Sentence_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void anyButton_Click(object sender, EventArgs e)
        {
            // Cast sender to Button type to access its properties.
            Button clickedButton = (Button)sender;
            string word = clickedButton.Text;

            // Check if the clicked button is the (Space) button.
            if (word == "(Space)")
            {
                // Add a space to the label's text.
                label1.Text += " ";
            }
            // Check if it's punctuation.
            else if (word == "!" || word == "." || word == "?")
            {
                label1.Text += word;
            }
            else
            {
                // Append the word to the label followed by a space.
                label1.Text += word + " ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
