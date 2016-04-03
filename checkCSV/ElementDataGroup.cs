using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkCSV
{
    class ElementDataGroup
    {
        public List<ElementData> allMainParts;
        public List<ElementData> allSpecialParts;
        public List<ElementData> groupedParts;

        public ElementDataGroup()
        {
            allMainParts = new List<ElementData>();
            allSpecialParts = new List<ElementData>();
            groupedParts = new List<ElementData>();
        }

    }

}
