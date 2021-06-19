using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            textBox2.Enabled = false;
            textBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Person.Obj.flag = true;
                if (Teacher.Obj.getList().ElementAt(0).Email == textBox1.Text)
                {

                    this.Hide();
                    Form8 f8 = new Form8();
                    f8.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Teacher Not Found", "Rewrite Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            if(radioButton2.Checked)
            { Person.Obj.flag = false;
            if (Student.Obj.getList().ElementAt(0).Rollno == textBox2.Text)
                {

                    this.Hide();
                    Form8 f8 = new Form8();
                    f8.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Student Not Found", "Rewrite Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
                textBox1.Enabled = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
