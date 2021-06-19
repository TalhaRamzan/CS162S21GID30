using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Person
    {
        List<Person> list = new List<Person>();
        public static Person obj = null;



        public static Person Obj
        {
            get
            {
                if (obj == null)
                {
                    obj = new Person();
                }
                return obj;
            }
        }
        public Boolean flag=false;
        private string name;
        private DateTime dOB;
        private string password;
        private string email;
        private string gender;
        public string Name
        { 
            get  { return this.name; }
            set { this.name = value; }
        }
        public DateTime DOB
        {
            get { return this.dOB; }
            set { this.dOB = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public List<Person> getlist()
        {
            return list;
        }


    }
}
