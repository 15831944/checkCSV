using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace checkCSV
{
    static class directoryImport
    {

        public static List<string> importDirFiles(string path, string ext, bool all)
        {
            List<string> files = new List<string>();

            if (String.IsNullOrEmpty(path))
            {
                return files;
            }

            try
            {
                if (all)
                {
                    files = importerer(path, ext);
                }
                else
                {
                    files = importer(path, ext);
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory Not Found");
            }
            catch
            {
                MessageBox.Show("Viga - 2");
            }

            files.Sort();

            return files;
        }

        private static List<string> importerer(string path, string ext)
        {
            List<string> files = new List<string>();

            if (System.IO.Directory.GetDirectories(path).Length > 0)
            {
                string[] subDir = Directory.GetDirectories(path);
                foreach (string newPath in subDir)
                {
                    files.AddRange(directoryImport.importerer(newPath, ext));
                }
            }

            files.AddRange(importer(path, ext));

            return files;
        }

        private static List<string> importer(string path, string extention)
        {
            List<string> files = new List<string>();

            string[] importFiles = Directory.GetFiles(path, extention);

            foreach (string file in importFiles)
            {
                files.Add(file);
            }

            return files;
        }
    }
}
