using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkCSV
{
    class exportModule
    {
        string _path;
        List<ElementData> _parts;

        public exportModule(string path, List<ElementData> parts)
        {
            _path = path;
            _parts = parts;
        }
    }
}
