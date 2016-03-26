using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;

namespace checkCSV
{
    static class defaults
    {
        public static bool readDefaultDirectorys(out string csv, out string workshop)
        {
            string fileName = @"checkCSV_settings.dat";

            if (File.Exists(fileName))
            {
                string[] readText = File.ReadAllLines(fileName);

                csv = readText[0];
                workshop = readText[1];

                return true;
            }
            else
            {
                csv = @"C:\Users\aleksandr.ess\Dropbox\CODE\UPB_csv\";
                workshop = @"C:\Users\aleksandr.ess\Dropbox\CODE\UPB_csv\";

                return false;
            }
        }

        public static void writeDefaultDirectorys(string csv, string workshop)
        {
            string fileName = @"checkCSV_settings.dat";
            string[] values = { csv, workshop};

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            File.WriteAllLines(fileName, values);
        }
    }
}
