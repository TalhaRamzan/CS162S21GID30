using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DialogResult result = DialogResult.No;
            result = MessageBox.Show("Do you want to fetch data of Teacher and Student from file? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenFile();
            }
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

            String a = textBox1.Text;
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
                    MessageBox.Show("Please Select a User.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (a == "" || b == "")
            {
                MessageBox.Show("Username or password cannot be left empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please enter username and password again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if (radioButton1.Checked == true)
            //{
            //    this.Hide();
            //    Form2 f2 = new Form2(); //this is the change, code for redirect  
            //    f2.ShowDialog();
            //}
            //else if (radioButton2.Checked == true)
            //{
            //    this.Hide();
            //    Form3 f3 = new Form3(); //this is the change, code for redirect  
            //    f3.ShowDialog();
            //}
            //else if (radioButton3.Checked == true)
            //{
            //    this.Hide();
            //    Form4 f4 = new Form4(); //this is the change, code for redirect  
            //    f4.ShowDialog();

            //}

        }

            private void button2_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            this.Hide();
            f15.ShowDialog();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void OpenFile()
        {
<<<<<<< HEAD
            Datahandling h = new Datahandling(@"D:\Dataa.xls", 1);
            h.AddinList();
            TeacherData Teach = new TeacherData(@"D:\TData.xls", 1);
            Teach.AddinList();
=======
            Datahandling h = new Datahandling(@"C:\Dataa.xls", 1);
            MessageBox.Show(h.ReadCell(1,0),"Yehi ha");
            h.AddinList();
>>>>>>> e32ad4f2a8ec1edfe1301f4312419380d79ce38a
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
