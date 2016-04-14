using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace checkCSV
{
    class ElementData
    {
        public string name;
        public string fullName;

        public bool set;

        public int status;
        public string statusMessage = "";

        public string pdfPath = "";
        public string dwgPath = "";

        public List<ElementData> specialDetails = new List<ElementData>();
        public List<ElementData> mainParts = new List<ElementData>();

        public ElementData(string mark, string rev, string hasDrawing)
        {
            name = mark;

            fullName = mark;
            if (rev.Length > 0) fullName = fullName + "_Rev" + rev;

            set = false;
            if (hasDrawing == "1") set = true;
        }


        public void addSpecialDetail(ElementData part)
        {
            specialDetails.Add(part);
        }

        public void addMainPart(ElementData part)
        {
            mainParts.Add(part);
        }

        public void setStatus(string drawingType)
        {
            if (set == true)
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
            else
            {
                status = 3;
                statusMessage = "[Not set]";

                if (drawingType == "PDF" && hasDrawing(pdfPath))
                {
                    status = 4;
                    statusMessage += " Found PDF";
                }

                if (drawingType == "DWG" && hasDrawing(dwgPath))
                {
                    status = 4;
                    statusMessage += " Found DWG";
                }

                if (drawingType == "PDF_DWG")
                {
                    if (hasDrawing(pdfPath))
                    {
                        status = 4;
                        statusMessage += " Found PDF";
                    }
                    if (hasDrawing(dwgPath))
                    {
                        status = 4;
                        statusMessage += " Found DWG";
                    }
                }
            }
        }

        public void setPDF(string path)
        {
            if (String.IsNullOrEmpty(pdfPath))
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
            if (String.IsNullOrEmpty(dwgPath))
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
            return !(String.IsNullOrEmpty(path));
        }

        public override string ToString()
        {
            if (mainParts.Count == 0)
            {
                return fullName;
            }
            else
            {
                return "    -    " + fullName;
            }
            
        }
    }
}
