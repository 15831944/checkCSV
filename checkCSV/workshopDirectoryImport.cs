using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace checkCSV
{
    static class workshopDirectoryImport
    {
        public static List<string> importPDF(string path)
        {
            List<string> fileNames = new List<string>();

            if (System.IO.Directory.GetDirectories(path).Length > 0)
            {
                string[] subDir = Directory.GetDirectories(path);
                foreach (string newPath in subDir)
                {
                    fileNames.AddRange(workshopDirectoryImport.importPDF(newPath));
                }
            }

            string[] importFiles = Directory.GetFiles(path, "*.PDF");

            foreach (string file in importFiles)
            {
                string name = Path.GetFileNameWithoutExtension(file);
                fileNames.Add(name);
            }

            return fileNames;
        }
    }
}
