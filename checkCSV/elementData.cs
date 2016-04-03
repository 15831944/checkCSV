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

        private string drawing;

        private List<ElementData> specialDetails = new List<ElementData>();

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

        public override string ToString()
        {
            return fullName + "     " + status.ToString();
        }
    }
}
