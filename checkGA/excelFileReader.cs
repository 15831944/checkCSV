using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Excel;
using System.Runtime.InteropServices;

using System.IO;

namespace checkGA
{
    class excelFileReader
    {
        string _xlsxPath;
        int _nameRow;
        int _revisionRow;
        int _line;

        public excelFileReader(string xlsxPath, int row1, int row2, int line)
        {
            _xlsxPath = xlsxPath;
            _nameRow = row1;
            _revisionRow = row2;
            _line = line;
        }

        public List<ArrayList> importXSLS()
        {
            List<ArrayList> data = new List<ArrayList>();

            try
            {
                Excel.Application _excelApp = new Excel.Application();

                Workbook workBook = _excelApp.Workbooks.Open(_xlsxPath,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                data = readXLSX(workBook);

                workBook.Close(false, _xlsxPath, null);
                Marshal.ReleaseComObject(workBook);
            }
            catch
            {
                MessageBox.Show("Viga - 5\n" + "viga xlsx-i lugemisel");
            }

            return data;
        }

        private List<ArrayList> readXLSX(Workbook workBookIn)
        {
            List<ArrayList> data = new List<ArrayList>();

            Worksheet sheet = workBookIn.Sheets[1] as Worksheet;
            int i = _line;
            int breaker = 0;

            while (true)
            {
                try
                {
                    ArrayList lineData = getDataFromLine(sheet, i);
                    
                    if (lineData == null)
                    {
                        breaker++;
                        if (breaker > 10)
                        {
                            break;
                        }
                    }
                    else
                    {
                        breaker = 0;
                        data.Add(lineData);
                    }
                    
                }
                catch (COMException)
                {

                }

                i++;
            }

            return data;
        }

        private ArrayList getDataFromLine(Worksheet sheet, int i)
        {
            ArrayList lineData = new ArrayList();

            string name = (sheet.Cells[i, _nameRow] as Excel.Range).Value as string;
            string rev = (sheet.Cells[i, _revisionRow] as Excel.Range).Value as string;

            if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(rev))
            {
                return null;
            }

            lineData.Add(parseCellData(name));
            lineData.Add(parseCellData(rev));

            return lineData;
        }

        private string parseCellData(string cell)
        {
            string parsed;

            if (String.IsNullOrEmpty(cell))
            {
                parsed = "";
            }
            else
            {
                parsed = cell.Replace(" ", "");
            }
            

            return parsed;
        }
    }
}
