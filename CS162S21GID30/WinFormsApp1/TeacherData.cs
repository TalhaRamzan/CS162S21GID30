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
    class TeacherData
    {
        Teacher Stud = new Teacher();
        String path = "";
        _Application excel = new Excel.Application();
        Workbook wb;
        Worksheet ws;
        public TeacherData(String path, int sheet)
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
            Excel.Range last = ws.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range range = ws.get_Range("A1", last);

            int lastUsedRow = last.Row;
            int lastUsedColumn = last.Column;
       
            for (int row = 0; row < (lastUsedRow - 1); row++)
            {
                Stud = new Teacher();
                String Namee = ReadCell((row + 1), 0);

                Stud.Name = Namee;
           
                Stud.Gender = ReadCell((row + 1), 1);
                Stud.DOB = Convert.ToDateTime(ReadCell((row + 1), 2));

                Stud.Email = ReadCell((row + 1),3);
                Stud.Password = ReadCell((row + 1), 4);

                Stud.Subject = ReadCell((row + 1), 5);

                Stud.Qualifation = ReadCell((row + 1), 6);
                Teacher.TeacherObj.setlist(Stud);


            }

        }
    }
}
