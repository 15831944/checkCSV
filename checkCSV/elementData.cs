using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkCSV
{
    class ElementData
    {
        private string _mark;
        private string _revision;
        private string _hasDrawing;
        private List<string> specialDetails = new List<string>();

        private string _fullName;
        private bool _set;

        public ElementData(string mark, string revision, string hasDrawing)
        {
            _mark = mark;
            _revision = revision;
            _hasDrawing = hasDrawing;

            analyse();

        }

        public void analyse()
        {
            if (_revision.Length > 0)
            {
                _fullName = _mark + "_Rev" + _revision;
            }

            if (_hasDrawing == "1")
                _set = true;
            else
                _set = false;
        }

        public void addSpecialDetail(string name)
        {
            specialDetails.Add(name);
        }
    }
}
