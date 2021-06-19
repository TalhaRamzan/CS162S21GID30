using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Teacher : Person
    {
        List<Teacher> teacherlist = new List<Teacher>();
        public static Teacher teacherObj = null;



        public static Teacher TeacherObj
        {
            get
            {
                if (teacherObj == null)
                {
                    teacherObj = new Teacher();
                }
                return teacherObj;
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
        public List<Teacher> getList()
        {
            return teacherlist;
        }
        public void setlist(Teacher s)
        {
            teacherlist.Add(s);
        }

    }
}
