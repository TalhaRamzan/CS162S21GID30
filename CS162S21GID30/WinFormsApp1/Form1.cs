using System;
using System.Windows.Forms;

namespace WinFormsApp1
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* String a = textBox1.Text;
             String b = textBox2.Text;
             if (a == "Admin" && b == "Admin")
             {

                 if (radioButton1.Checked == true)
                 {
                     this.Hide();
                     Form2 f2 = new Form2(); //this is the change, code for redirect  
                     f2.ShowDialog();
                 }
                 else if (radioButton2.Checked == true)
                 {
                     this.Hide();
                     Form3 f3 = new Form3(); //this is the change, code for redirect  
                     f3.ShowDialog();

                 }

                 else if (radioButton3.Checked == true)
                 {
                     this.Hide();
                     Form4 f4 = new Form4(); //this is the change, code for redirect  
                     f4.ShowDialog();

                 }
                 else
                 {
                     MessageBox.Show("Please Select a User.","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

             }
           else if (a == "" || b == "")
             {
                 MessageBox.Show("Username or password cannot be left empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);                
             }
             else
             {
                 MessageBox.Show("Please enter username and password again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
            if (radioButton1.Checked == true)
            {
                this.Hide();
                Form2 f2 = new Form2(); //this is the change, code for redirect  
                f2.ShowDialog();
            }
            else if (radioButton2.Checked == true)
            {
                this.Hide();
                Form3 f3 = new Form3(); //this is the change, code for redirect  
                f3.ShowDialog();
            }
            else if (radioButton3.Checked == true)
            {
                this.Hide();
                Form4 f4 = new Form4(); //this is the change, code for redirect  
                f4.ShowDialog();

            }

        }

            private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zehan Pr Zor Daal.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
