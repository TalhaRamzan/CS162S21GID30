﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class Student : Person
    {
        Excel.Application xlApp = new Excel.Application();
        List<Student> list = new List<Student>();
        public static Student obj = null;
        public void saveData()
        {
            try
            {
                Excel.Workbook xlWorkBook;

                Excel.Worksheet xlWorkSheet;

                object misValue = System.Reflection.Missing.Value;



                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);



                xlWorkSheet.Cells[1, 1] = "Student Name";
                xlWorkSheet.Cells[1, 2] = "Student Gender";
                xlWorkSheet.Cells[1, 3] = "Student DOB";
                xlWorkSheet.Cells[1, 4] = "Student Email";
                xlWorkSheet.Cells[1, 5] = "Student Password";
                xlWorkSheet.Cells[1, 6] = "Student RollNumber";
                xlWorkSheet.Cells[1, 7] = "Student Section";


                for (int i = 0; i < list.Count; i++)
                {
                    MessageBox.Show("File have been saved first .");
                    for (int j = 0; j < list.Count; j++)
                    {
                        MessageBox.Show("File have been saved second.");
                        xlWorkSheet.Cells[i + 2, 1] = Student.Obj.getList().ElementAt(j).Name;
                        xlWorkSheet.Cells[i + 2, 2] = Student.Obj.getList().ElementAt(j).Gender;
                        xlWorkSheet.Cells[i + 2, 3] = Student.Obj.getList().ElementAt(j).DOB;
                        xlWorkSheet.Cells[i + 2, 4] = Student.Obj.getList().ElementAt(j).Email;
                        xlWorkSheet.Cells[i + 2, 5] = Student.Obj.getList().ElementAt(j).Password;
                        xlWorkSheet.Cells[i + 2, 6] = Student.Obj.getList().ElementAt(j).Rollno;
                        xlWorkSheet.Cells[i + 2, 7] = Student.Obj.getList().ElementAt(j).Section;
                    }

                }





                MessageBox.Show("File have been saved.");

                xlWorkBook.SaveAs(@"C:\Student.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                xlWorkBook.Close(true, misValue, misValue);

                xlApp.Quit();



                Marshal.ReleaseComObject(xlWorkSheet);

                Marshal.ReleaseComObject(xlWorkBook);

                Marshal.ReleaseComObject(xlApp);
            }
            catch(Exception e)
            {
                MessageBox.Show("Your data is not been handled");
            }
            
        }

        private object ElementAt(int j)
        {
            throw new NotImplementedException();
        }

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
