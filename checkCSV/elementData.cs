using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkCSV
{
    class ElementData
    {
        public string name;
        public string fullName;

        public bool set;

        public int status;

        public string drawingPath;

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

        public override string ToString()
        {
            return fullName;
        }

        public void setStatus(int i)
        {
            status = i;
        }

        public void setDrawing(string path)
        {
            drawingPath = path;
        }
    }
}
