using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            textBox6.Enabled = false;
            textBox9.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            if (Person.Obj.flag == false)
            {
                textBox7.Enabled = true;
                textBox8.Enabled = true;

            }
            else
            {
                textBox6.Enabled = true;
                textBox9.Enabled = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("Changes have been successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Person.Obj.flag == true)
            {
                MessageBox.Show(" " + Person.Obj.ind);
                Student S = new Student();
                S.Name = textBox1.Text;
                S.DOB = Convert.ToDateTime(dateTimePicker1.Value);
                S.Gender = comboBox1.Text;
                S.Email = textBox5.Text;
                if (textBox4.Text == textBox2.Text)
                {
                    S.Password = textBox4.Text;

                }

                else
                { MessageBox.Show("Password Does not match", "Rewrite Password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning); }
                S.Rollno = textBox7.Text;
                S.Section = textBox8.Text;
                Student.Obj.getList().Insert(Person.Obj.ind, S);
            }
            if (Person.Obj.flag == false)
            {
                MessageBox.Show(" "+Person.Obj.ind);
                Teacher T = new Teacher();
                T.Name = textBox1.Text;
                T.DOB = Convert.ToDateTime(dateTimePicker1.Value);
                T.Gender = comboBox1.Text;
                T.Email = textBox5.Text;
                if (textBox4.Text == textBox2.Text)
                {
                    T.Password = textBox4.Text;

                }

                else
                { MessageBox.Show("Password Does not match", "Rewrite Password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning); }
                T.Subject = textBox6.Text;
                T.Qualifation = textBox9.Text;
    
                Teacher.TeacherObj.getList().Insert(Person.Obj.ind, T);
            }
        }

       
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
