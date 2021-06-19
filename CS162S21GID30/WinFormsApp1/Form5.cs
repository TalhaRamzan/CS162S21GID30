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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                String na = textBox1.Text;
                String dob = dateTimePicker1.Text;
                String gender = comboBox1.Text;
                String email = textBox5.Text;
                String password = textBox4.Text;
                String cpassword = textBox2.Text;
                String rnum = textBox7.Text;
                String section = textBox8.Text;
                Student S = new Student();
                S.Name = na;
                S.DOB = Convert.ToDateTime(dob);
                S.Gender = gender;
                S.Email = email;
                if (password == cpassword)
                {
                    S.Password = password;
                  
                }

                else
                { MessageBox.Show("Password Does not match","Rewrite Password",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning); }
                S.Rollno = rnum;
                S.Section = section;
                Student.Obj.setlist(S);
             //   MessageBox.Show(Student.Obj.getList().ElementAt(0).Rollno);//Checking List 

            }
            if (radioButton1.Checked)
            {

                String na = textBox1.Text;
                String dob = dateTimePicker1.Text;
                String gender = comboBox1.Text;
                String email = textBox5.Text;
                String password = textBox4.Text;
                String cpassword = textBox2.Text;
                String tsub = textBox6.Text;
                String Qual = textBox9.Text;
                Teacher T= new Teacher();
                T.Name = na;
                T.DOB = Convert.ToDateTime(dob);
                T.Gender = gender;
                T.Email = email;
                if (password == cpassword)
                {
                    T.Password = password;
                }

                else
                { MessageBox.Show("Password Does not match", "Rewrite Password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning); }
                T.Qualifation = Qual;
                T.Subject = tsub;
                Teacher.Obj.setlist(T);
             //   MessageBox.Show(Teacher.Obj.getList().ElementAt(0).Subject); //Checking List 
            }

                //MessageBox.Show("ID has been successfully saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
