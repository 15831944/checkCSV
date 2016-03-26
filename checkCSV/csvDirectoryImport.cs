using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace checkCSV
{
    static class csvDirectoryImport
    {
        public static List<string> importCSVdir(string csvPath)
        {
            List<string> csvFiles = new List<string>();
            try
            {
                string[] importFiles = Directory.GetFiles(csvPath, "*.csv");

                foreach (string file in importFiles)
                {
                    string name = Path.GetFileNameWithoutExtension(file);
                    csvFiles.Add(name);
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory Not Found");
            }

            return csvFiles;
        }
    }
}
