using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp1
{
    class Datahandling
    {
        String path = "";
        _Application excel = new Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Datahandling(String path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }
        public String ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j] != null)
            {
                Excel.Range range = (Excel.Range)ws.Cells[i, j];
                string cellValue = range.Value.ToString();
                return cellValue;
            }
            else { return ""; }

        }
        public void AddinList()
        {
            Student Stud = new Student();
            Excel.Range last = ws.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range range = ws.get_Range("A1", last);

            int lastUsedRow = last.Row;
            int lastUsedColumn = last.Column;
            MessageBox.Show(" " + lastUsedColumn);
            MessageBox.Show(" " + lastUsedRow);
            for (int row = 0; row < (lastUsedRow - 1); row++)
            {

             
                int f = 0;

                String Namee = ReadCell((row + 1), 0);

                Student.Obj.Name = Namee;
                //MessageBox.Show(Namee);
                Student.Obj.Gender = ReadCell((row + 1), 1);

                //  Stud.DOB = Convert.ToDateTime(ReadCell(i, j + 2))
                Student.Obj.Email = ReadCell((row + 1), 3);

                Student.Obj.Password = ReadCell((row + 1), 4);

                Student.Obj.Rollno = ReadCell((row + 1), 5);

                Student.Obj.Section = ReadCell((row + 1), 6);



                Student.Obj.setlist(Student.Obj);

            }
            
        }
    }
}
