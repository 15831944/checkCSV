using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;

namespace checkCSV
{
    static class defaultSettings
    {
        public static bool readDefaultDirectorys(out string csv, out string pdf, out string incastClass)
        {
            string fileName = @"checkCSV_settings.dat";

            if (File.Exists(fileName))
            {
                try
                {
                    string[] readText = File.ReadAllLines(fileName);

                    csv = readText[0];
                    pdf = readText[1];
                    incastClass = readText[2];

                    return true;
                }
                catch
                {
                    csv = @"C:\Users\aleksandr.ess\Dropbox\CODE\UPB_csv\";
                    pdf = @"C:\Users\aleksandr.ess\Dropbox\CODE\UPB_csv\";
                    incastClass = "891";

                    return false;
                }

            }
            else
            {
                csv = @"C:\Users\aleksandr.ess\Dropbox\CODE\UPB_csv\";
                pdf = @"C:\Users\aleksandr.ess\Dropbox\CODE\UPB_csv\";
                incastClass = "891";

                return false;
            }
        }

        public static void writeDefaultDirectorys(string csv, string pdf, string incastClass)
        {
            try
            {
                string fileName = @"checkCSV_settings.dat";
                string[] values = { csv, pdf, incastClass };

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                File.WriteAllLines(fileName, values);

                MessageBox.Show("Settings file saved");
            }
            catch
            {
                MessageBox.Show("Viga - 3");
            }
        }
    }
}
