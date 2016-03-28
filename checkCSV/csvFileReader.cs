using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;

namespace checkCSV
{
    public class csvFileReader
    {
        private string _csvPath;
        private string _incastClass;
        private List<ElementData> _data;

        public csvFileReader(string csvPath, string incastClass)
        {
            _csvPath = csvPath;
            _incastClass = incastClass;
            _data = new List<ElementData>();
        }

        public void importCSV()
        {
            try
            {
                readCSV();
            }
            catch
            {
                MessageBox.Show("Viga - 4");
            }
        }

        public void readCSV()
        {
            StreamReader reader = new StreamReader(File.OpenRead(_csvPath));

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                readLine(line);
            }

            reader.Close();
        }

        public void readLine(string line)
        {
            line = line.Replace(" ", "");
            string[] fields = line.Split(';');

            if (fields.Length > 39)
            {
                if (fields[2] != "")
                {
                    _data.Add(new ElementData(fields[2], fields[3], fields[39]));
                }
                else if (fields[21] == _incastClass)
                {
                    _data[_data.Count - 1].addSpecialDetail(fields[22]);
                }
            }
        }

    }
}
