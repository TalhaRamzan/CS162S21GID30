using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox6.Enabled = false;
            textBox9.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                textBox6.Enabled=true;
                textBox9.Enabled = true;

            }
            else
            {
                textBox6.Enabled = false;
                textBox9.Enabled = false;

            }
            if (radioButton2.Checked)
            {
                textBox7.Enabled = true;
                textBox8.Enabled = true;

            }
            else
            {
                textBox7.Enabled = false;
                textBox8.Enabled = false;

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
