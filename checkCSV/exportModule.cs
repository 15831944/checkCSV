using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;

namespace checkCSV
{
    class exportModule
    {
        string _path;
        string _elementType;

        public exportModule(string path, string type)
        {
            _path = path;
            _elementType = type;
        }

        public void main(List<ElementData> parts)
        {
            try
            {
                doStuff(parts);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void doStuff(List<ElementData> parts)
        {
            foreach (ElementData part in parts)
            {
                string sourceFile = part.drawingPath;
                string fileName = Path.GetFileName(part.drawingPath);

                string prefix = part.fullName.Split('-')[0];
                string targetLocation = _path + _elementType + @"\" + prefix + @"\pdf\";

                string targetFile = System.IO.Path.Combine(targetLocation, fileName);

                if (!System.IO.Directory.Exists(targetLocation))
                {
                    System.IO.Directory.CreateDirectory(targetLocation);
                }

                if (!File.Exists(targetFile))
                {
                    System.IO.File.Copy(sourceFile, targetFile, false);
                }
            }
        }
    }
}
