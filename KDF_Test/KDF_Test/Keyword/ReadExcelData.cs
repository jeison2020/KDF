using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KDF_Test.Utility;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace KDF_Test.Keyword
{
    public class ReadExcelData
    {

        public List<string> ReadExcelDataSheet(int colNo)
        {
            string filePath = Path.GetDirectoryName(
                      System.Reflection.Assembly.GetExecutingAssembly().Location) + Constants.filePath;

            // Create an object of file class and pass filePath as an input parameter to its constructor. 
            FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            // Create an object of XSSFWorkbook class and pass file as parameter to its.
            XSSFWorkbook wb = new XSSFWorkbook(file);
            XSSFSheet sheet = (XSSFSheet)wb.GetSheet("Test Cases");

            IEnumerator<IRow> row = (IEnumerator<IRow>)sheet.GetRowEnumerator();
            row.MoveNext();
            List<string> ar = new List<string>();

            while (row.MoveNext())
            {
                // Moving cursor to next Row using reference variable row. 
                IRow r = row.Current;

                // Moving cursor to the cell by getting cell number. 
                ICell c = r.GetCell(colNo);

                // Read the value of the cell using getStringCellValue() method. 
                string data = c.StringCellValue;

                // Adding the value of the cells in the List by passing 'data'. 
                ar.Add(data);
            }

            Console.WriteLine("List: " + string.Join(",", ar));

            // Return the data to the List method. 
            return ar;
        }
    }
}
