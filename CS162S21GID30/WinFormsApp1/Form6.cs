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
            int index=0;
            int Sindex = 0;
           

            if (radioButton1.Checked)
            {
                
                try
                {
                    Boolean flag = false;
                    for (int i = 0; i < Teacher.TeacherObj.getList().Count; i++)
                    {
                        if (Teacher.TeacherObj.getList().ElementAt(i).Email == textBox1.Text)
                        {
                            index = i;
                            flag = true;
                            break;
                        }
                        

                        
                    }
                 
                    DialogResult result=DialogResult.No;
                    if (flag == true)
                    {
                           result=  MessageBox.Show("Teacher Found\nDo you want to delete it? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    if (result == DialogResult.Yes)
                    { 
                        Teacher.TeacherObj.getList().RemoveAt(index);
                        MessageBox.Show("ID has been successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Teacher not Deleted");                
                    }
                    if(flag==false)
                    { MessageBox.Show("Teacher Not Found", "Rewrite Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

                }catch(Exception t)
                {
                    MessageBox.Show(t.Message);
                    MessageBox.Show("Something went wrong." +
                           "Enter data again", "CMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (radioButton2.Checked)
            {
                try
                {
                    Boolean flag = false;
                    for (int i = 0; i < Student.Obj.getList().Count; i++)
                    {
                        if (Student.Obj.getList().ElementAt(i).Rollno == textBox2.Text)
                        {
                            Sindex = i;
                            flag = true;
                           
                            break;

                        }
                    }

                    DialogResult result = DialogResult.No;
                    if (flag == true)
                    {
                        result = MessageBox.Show("Student Found\nDo you want to delete it? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    if (result == DialogResult.Yes)
                    {
                       
                        Student.Obj.getList().RemoveAt(Sindex);
                        MessageBox.Show("ID has been successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Student not Deleted");
                    }
                    if (flag == false)
                    { MessageBox.Show("Student Not Found", "Rewrite Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message);
                    MessageBox.Show("Something went wrong." +
                         "Enter data again", "CMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
