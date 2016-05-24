using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;

namespace checkGA
{
    class csvFileReader
    {
        private string _csvPath;
        private int _nameRow;
        private int _revisionRow;
        private int _line;

        public csvFileReader(string csvPath, int row1, int row2, int line)
        {
            _csvPath = csvPath;
            _nameRow = row1;
            _revisionRow = row2;
            _line = line;
        }

        public List<ArrayList> importCSV()
        {
            List<ArrayList> data = new List<ArrayList>();
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(File.OpenRead(_csvPath));
                data = readCSV(reader);
            }
            catch (IOException)
            {
                MessageBox.Show("Viga - 4\n" + "csv peab olema kinni.");
                
            }
            catch
            {
                MessageBox.Show("Viga - 4\n" + "viga csv lugemisel");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return data;
        }

        private List<ArrayList> readCSV(StreamReader reader)
        {
            List<ArrayList> data = new List<ArrayList>();
            int lineCounter = 0;

            while (!reader.EndOfStream)
            {
                if (lineCounter >= _line)
                {
                    lineCounter++;
                    continue;
                }

                string line = reader.ReadLine();
                ArrayList lineData = getDataFromLine(line);
                if (lineData.Count > 0)
                {
                    data.Add(lineData);
                }

            }

            reader.Close();
            return data;
        }

        private ArrayList getDataFromLine(string line)
        {
            ArrayList lineData = new ArrayList();

            line = line.Replace(" ", "");

            if (line != String.Empty)
            {
                string[] fields = line.Split(';');
                lineData.Add(fields[_nameRow]);
                lineData.Add(fields[_revisionRow]);
            }

            return lineData;
        }

    }
}
