using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class Teacher : Person
    {
        Excel.Application xlApp = new Excel.Application();
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
        public void saveTeacherData()
        {
            // try
            //{
            Excel.Workbook xlWorkBook;

            Excel.Worksheet xlWorkSheet;

            object misValue = System.Reflection.Missing.Value;



            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);



            xlWorkSheet.Cells[1, 1] = "Name";
            xlWorkSheet.Cells[1, 2] = "Gender";
            xlWorkSheet.Cells[1, 3] = "DOB";
            xlWorkSheet.Cells[1, 4] = "Email";
            xlWorkSheet.Cells[1, 5] = "Password";
            xlWorkSheet.Cells[1, 6] = "Subject";
            xlWorkSheet.Cells[1, 7] = "Qualification";


            for (int i = 0; i < teacherlist.Count; i++)
            {
                for (int j = 0; j < teacherlist.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, 1] = Teacher.TeacherObj.getList().ElementAt(i).Name;
                    xlWorkSheet.Cells[i + 2, 2] = Teacher.TeacherObj.getList().ElementAt(i).Gender;
                    xlWorkSheet.Cells[i + 2, 3] = Teacher.TeacherObj.getList().ElementAt(i).DOB;
                    xlWorkSheet.Cells[i + 2, 4] = Teacher.TeacherObj.getList().ElementAt(i).Email;
                    xlWorkSheet.Cells[i + 2, 5] = Teacher.TeacherObj.getList().ElementAt(i).Password;
                    xlWorkSheet.Cells[i + 2, 6] = Teacher.TeacherObj.getList().ElementAt(i).Subject;
                    xlWorkSheet.Cells[i + 2, 7] = Teacher.TeacherObj.getList().ElementAt(i).Qualifation;
                }

            }

            MessageBox.Show("File have been saved.");

            xlWorkBook.SaveAs(@"D:\TData.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);

            xlApp.Quit();



            Marshal.ReleaseComObject(xlWorkSheet);

            Marshal.ReleaseComObject(xlWorkBook);

            Marshal.ReleaseComObject(xlApp);
            //}
            /* catch(Exception e)
             {
                 MessageBox.Show("Your data is not been handled");
             }*/

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
