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
        string _drawingType;
        int _exportType;
        string _elementType;

        public exportModule(string path, string drawing, int type, string elements)
        {
            _path = path;
            _drawingType = drawing;
            _exportType = type;
            _elementType = elements;
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
                doStuff2(part);
            }
        }

        private void doStuff2(ElementData part)
        {
            string prefix = part.fullName.Split('-')[0];

            if (_drawingType.Contains("PDF"))
            {
                string sourceFile = part.pdfPath;
                doStuff3(sourceFile, prefix, @"\PDF\");
            }

            if (_drawingType.Contains("DWG"))
            {
                string sourceFile = part.dwgPath;
                doStuff3(sourceFile, prefix, @"\DWG\");
            }

        }

        private void doStuff3(string sourceFile, string prefix , string suffix)
        {
            string fileName = Path.GetFileName(sourceFile);
            string targetLocation = _path + @"\" + _elementType + @"\" + prefix + suffix;
            string targetFile = System.IO.Path.Combine(targetLocation, fileName);


            if (!System.IO.Directory.Exists(targetLocation))
            {
                System.IO.Directory.CreateDirectory(targetLocation);
            }

            if (_exportType == 0)
            {
                if (!File.Exists(targetFile))
                {
                    System.IO.File.Copy(sourceFile, targetFile, false);
                }
            }
            else if (_exportType == 1)
            {
                if (File.Exists(targetFile))
                {
                    FileInfo old = new FileInfo(targetFile);
                    FileInfo source = new FileInfo(sourceFile);

                    if (source.LastWriteTime > old.LastWriteTime)
                    {
                        System.IO.File.Copy(sourceFile, targetFile, true);
                    }
                }
                else
                {
                    System.IO.File.Copy(sourceFile, targetFile, false);
                }
            }
            else if (_exportType == 2)
            {
                System.IO.File.Copy(sourceFile, targetFile, true);
            }

        }
    }
}
