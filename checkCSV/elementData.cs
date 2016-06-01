using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace checkCSV
{
    public class ElementData
    {
        public string name;
        public string fullName;

        public bool set;

        public int status;
        public string statusMessage = "";

        public string pdfPath = "";
        public string dwgPath = "";
        public bool hasCopy = false;

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
            if (hasCopy == true)
            {
                status = 5;
                statusMessage = "[HAS COPY]";
                return;
            }

            if (set == true)
            {

                if (drawingType.Contains("PDF") && hasDrawing(pdfPath))
                {
                    status = 1;
                    statusMessage += "[PDF OK] ";
                }

                if (drawingType.Contains("DWG") && hasDrawing(dwgPath))
                {
                    status = 1;
                    statusMessage += "[DWG OK] ";
                }

                if (drawingType.Contains("PDF") && !hasDrawing(pdfPath))
                {
                    status = 2;
                    statusMessage += "[PDF MISSING] ";
                }

                if (drawingType.Contains("DWG") && !hasDrawing(dwgPath))
                {
                    status = 2;
                    statusMessage += "[DWG MISSING] ";
                }
                
            }
            else
            {
                status = 3;
                statusMessage = "[NOT SET] ";

                if (drawingType.Contains("PDF") && hasDrawing(pdfPath))
                {
                    status = 4;
                    statusMessage += "[PDF FOUND] ";
                }

                if (drawingType.Contains("DWG") && hasDrawing(dwgPath))
                {
                    status = 4;
                    statusMessage += "[DWG FOUND] ";
                }
            }
        }

        public void setDrawing(string path)
        {
            if (Path.GetExtension(path) == ".pdf")
            {
                pdfPath = findNewerPath(path, pdfPath);
            }
            else if (Path.GetExtension(path) == ".dwg")
            {
                dwgPath = findNewerPath(path, dwgPath);
            }

        }

        public string findNewerPath(string newPath, string oldPath)
        {
            if (String.IsNullOrEmpty(oldPath))
            {
                return newPath;
            }
            else
            {
                DateTime oldTime = File.GetCreationTime(oldPath);
                DateTime newTime = File.GetCreationTime(newPath);

                if (newTime > oldTime)
                {
                    return newPath;
                }
                else
                {
                    return oldPath;
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
