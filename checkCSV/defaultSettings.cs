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
        public static bool readDefaultDirectorys(out string csv, out string pdf, out string dwg, out string incastClass)
        {
            string fileName = @"checkCSV_settings.dat";
            csv = null;
            pdf = null;
            dwg = null;
            incastClass = "891";

            if (File.Exists(fileName))
            {
                try
                {
                    string[] readText = File.ReadAllLines(fileName);

                    csv = readText[0];
                    pdf = readText[1];
                    dwg = readText[2];
                    incastClass = readText[3];

                    return true;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }

        public static string writeDefaultDirectorys(string csv, string pdf, string dwg, string incastClass)
        {
            try
            {
                string fileName = @"checkCSV_settings.dat";
                string[] values = { csv, pdf, dwg, incastClass };

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                File.WriteAllLines(fileName, values);

                return "Settings file saved";
            }
            catch
            {
                return "ERROR";
            }
        }
    }
}
