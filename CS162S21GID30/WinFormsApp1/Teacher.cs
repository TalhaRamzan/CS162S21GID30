using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Teacher : Person
    {
        List<Teacher> list = new List<Teacher>();
        public static Teacher obj = null;



        public static Teacher Obj
        {
            get
            {
                if (obj == null)
                {
                    obj = new Teacher();
                }
                return obj;
            }

        }
        private string qualification;
        private string subject;
        public string Qualifation
        {
            get { return this.qualification; }
            set { this.qualification = value; }
        }
        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }
        public List<Teacher> getlist()
        {
            return list;
        }
        public void setlist(Teacher s)
        {
            list.Add(s);
        }

    }
}
