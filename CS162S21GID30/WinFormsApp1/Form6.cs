﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            textBox2.Enabled = false;
            textBox1.Enabled = false;
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {

        }

       
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // DialogResult d;
            //d = MessageBox.Show("Are you sure you want to delete this ID?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (d == DialogResult.Yes)
            //{
            //  MessageBox.Show("ID has been successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            if (radioButton1.Checked)
            {
                
                if (Teacher.TeacherObj.getList().ElementAt(0).Email == textBox1.Text)
                {

                    MessageBox.Show("In Teacher delete");
                }
                else
                {
                    MessageBox.Show("Teacher Not Found", "Rewrite Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            if (radioButton2.Checked)
            {
              
                if (Student.Obj.getList().ElementAt(0).Rollno == textBox2.Text)
                {
                    MessageBox.Show("In Student delete");

                }
                else
                {
                    MessageBox.Show("Student Not Found", "Rewrite Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
                textBox1.Enabled = false;
            }

        }
    }
}
