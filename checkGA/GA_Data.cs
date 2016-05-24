using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace checkGA
{
    class GA_Data
    {
        public string name;
        public string fullName;

        public int status;
        public string statusMessage = String.Empty;

        public string pdfPath = String.Empty;
        public string dwgPath = String.Empty;

        public GA_Data(string mark, string revFormat, string rev)
        {
            name = mark;

            fullName = mark;
            if (rev != String.Empty) fullName = fullName + revFormat + rev;
        }

        public void setStatus(string drawingType)
        {
            if (drawingType == "PDF_DWG" && hasDrawing(pdfPath) && hasDrawing(dwgPath))
            {
                status = 1;
                statusMessage = "[OK]";
            }
            else if (drawingType == "PDF" && hasDrawing(pdfPath))
            {
                status = 1;
                statusMessage = "[OK]";
            }
            else if (drawingType == "DWG" && hasDrawing(dwgPath))
            {
                status = 1;
                statusMessage = "[OK]";
            }
            else
            {
                status = 2;
                statusMessage = "Missing ";
                if (drawingType.Contains("PDF") && !hasDrawing(pdfPath))
                {
                    statusMessage += "PDF ";
                }
                if (drawingType.Contains("DWG") && !hasDrawing(dwgPath))
                {
                    statusMessage += "DWG ";
                }
            }
        }        

        public void setPDF(string path)
        {
            if (pdfPath == String.Empty)
            {
                pdfPath = path;
            }
            else
            {
                DateTime currentPath = File.GetCreationTime(pdfPath);
                DateTime newPath = File.GetCreationTime(path);

                if (newPath > currentPath)
                {
                    pdfPath = path;
                }
            }
        }

        public void setDWG(string path)
        {
            if (dwgPath == String.Empty)
            {
                dwgPath = path;
            }
            else
            {
                DateTime currentPath = File.GetCreationTime(dwgPath);
                DateTime newPath = File.GetCreationTime(path);

                if (newPath > currentPath)
                {
                    dwgPath = path;
                }
            }
        }

        public bool hasDrawing(string path)
        {
            return !(path == String.Empty);
        }

        public override string ToString()
        {
            return fullName;
        }
    }
}
