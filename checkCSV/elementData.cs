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

        public string drawingPath = "";

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

        public void setStatus()
        {
            if (set == true && hasDrawing())
            {
                status = 1;
            }
            else if (set == false && hasDrawing())
            {
                status = 4;
            }
            else if (set == true)
            {
                status = 2;
            }
            else
            {
                status = 3;
            }
        }

        public void setDrawing(string path)
        {
            if (String.IsNullOrEmpty(drawingPath))
            {
                drawingPath = path;
            }
            else
            {
                DateTime currentPath = File.GetCreationTime(drawingPath);
                DateTime newPath = File.GetCreationTime(path);

                if (newPath > currentPath)
                {
                    drawingPath = path;
                }
            }
        }

        public bool hasDrawing()
        {
            return !(String.IsNullOrEmpty(drawingPath));
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
