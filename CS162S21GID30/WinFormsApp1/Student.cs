using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Student : Person
    {
        List<Student> list = new List<Student>();
        public static Student obj = null;



        public static Student Obj
        {
            get
            {
                if (obj == null)
                {
                    obj=new Student();
                }
                return obj;
            }

        }


        private string rollno; 
        private string section;
        public string Rollno
        {
            get { return this.rollno; }
            set { this.rollno = value; }
        }
        public string Section
        {
            get { return this.section; }
            set { this.section = value; }
        }
        public List<Student> getList()
        {
            return list;
        }
        public void setlist(Student s)
        {
            list.Add(s);
        }

    }
}
