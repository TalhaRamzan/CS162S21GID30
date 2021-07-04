using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WinFormsApp1
{
    public partial class Form15 : Form
    {
        int index = 0;
        public Form15()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Enabled = true;

            }
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Searchemail();

        }
        public void Searchemail()
        {
            if (radioButton1.Checked)
            {
                 index = 0;
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
                if (flag == true)
                {
                    MessageBox.Show("Teacher Found ", "Confirmation");
                    String Pass= Teacher.TeacherObj.getList().ElementAt(index).Password;
                    Sendpassword(Pass);

                }
                else
                {
                    MessageBox.Show("Teacher not Found ", "Confirmation");
                }
            }
            if (radioButton2.Checked)
            {
                index = 0;
                Boolean flag = false;
                for (int i = 0; i < Student.Obj.getList().Count; i++)
                {
                    if (Student.Obj.getList().ElementAt(i).Email == textBox1.Text)
                    {
                        index = i;
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    MessageBox.Show("Student Found ", "Confirmation");
                   String a= Student.Obj.getList().ElementAt(index).Email;
                    Sendpassword(a);
                }
                else
                {
                    MessageBox.Show("Student not Found ", "Confirmation");
                }
            }




        }
        public void Sendpassword(String Pass)
        {
            try
            {
                MailMessage msg = new MailMessage();
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("coursemanagement27@gmail.com", "Course123");

                msg.To.Add(textBox1.Text);
                msg.From = new MailAddress("coursemanagement27@gmail.com");
                msg.Subject = "Password";
                msg.Body = "Your Password is " + Pass;
                client.Send(msg);
                MessageBox.Show("Email sent Successfully", "Mail Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR 404 Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
