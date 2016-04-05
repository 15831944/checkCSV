using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;

namespace checkCSV
{
    static class csvFileReader
    {
        public static List<ArrayList> importCSV(string csvPath, string incastClass)
        {
            List<ArrayList> data = new List<ArrayList>();
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(File.OpenRead(csvPath));
                data = readCSV(reader, incastClass);
            }
            catch (IOException)
            {
                MessageBox.Show("Viga - 4a\n" + "csv on avatud teise programmi poolt?");
                
            }
            catch
            {
                MessageBox.Show("Viga - 4b");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return data;
        }

        public static List<ArrayList> readCSV(StreamReader reader, string incastClass)
        {
            List<ArrayList> data = new List<ArrayList>();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                ArrayList lineData = getDataFromLine(line, incastClass);
                if (lineData.Count > 0)
                {
                    data.Add(lineData);
                }
            }

            reader.Close();
            return data;
        }

        public static ArrayList getDataFromLine(string line, string incastClass)
        {
            ArrayList lineData = new ArrayList();

            line = line.Replace(" ", "");
            string[] fields = line.Split(';');
            int dummy;

            if (int.TryParse(fields[5], out dummy))
            {
                lineData.Add(true); //is mainPart
                lineData.Add(fields[2]); //is name
                lineData.Add(fields[3]); //is revision
                lineData.Add(fields[39]); //is hasDrawing
            }
            else if (fields[21] == incastClass)
            {
                lineData.Add(false); //is mainPart
                lineData.Add(fields[22]); //is name
                lineData.Add(""); //is revision
                lineData.Add(""); //is hasDrawing
            }

            return lineData;
        }

    }
}
