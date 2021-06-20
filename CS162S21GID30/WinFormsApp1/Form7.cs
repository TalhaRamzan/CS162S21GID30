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
                try
                {
                    Boolean flag = false;
                    for (int i = 0; i < Teacher.TeacherObj.getList().Count; i++)
                    {
                        if (Teacher.TeacherObj.getList().ElementAt(i).Email == textBox1.Text)
                        {
                            flag = true;
                            Person.Obj.ind = i;
                            break;
                        }
                    }
                        if (flag == true)
                        {
                        DialogResult result = MessageBox.Show("Teacher Found", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Hide();
                            Form8 f8 = new Form8();
                            f8.ShowDialog();
                        }
                    if (flag == false)
                    {
                        MessageBox.Show("Teacher Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message);
                    MessageBox.Show("Something went wrong." +
                        "Enter data again", "CMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            if(radioButton2.Checked)
            { Person.Obj.flag = false;
                try
                {
                    Boolean flag = false;
                    for (int i = 0; i<Student.Obj.getList().Count; i++)
                    {
                        if (Student.Obj.getList().ElementAt(i).Rollno== textBox2.Text)
                        {
                            flag = true;
                            Person.Obj.ind = i;
                            break;
                        }
                    }
                    if (flag == true)
                    {

                       
                        DialogResult result = MessageBox.Show("Student Found", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        Form8 f8 = new Form8();
                        f8.ShowDialog();
                    }
                    if (flag == false)
                    {
                        MessageBox.Show("Student Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception t) {
                    MessageBox.Show(t.Message);
                    MessageBox.Show("Something went wrong." +
                            "Enter data again", "CMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
