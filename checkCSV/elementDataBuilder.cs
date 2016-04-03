using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkCSV
{
    static class ElementDataBuilder
    {
        public static ElementDataGroup dataBuilder(List<ArrayList> raw)
        {
            ElementDataGroup dataGroup = new ElementDataGroup();

            foreach (ArrayList element in raw)
            {
                if ((bool) element[0] == true)
                {
                    ElementData part = new ElementData( (string)element[1], (string)element[2], (string)element[3] );
                    dataGroup.allMainParts.Add(part);
                    dataGroup.groupedParts.Add(part);
                }
                else
                {
                    ElementData part = new ElementData((string)element[1], (string)element[2], (string)element[3]);
                    bool found = false;

                    foreach (ElementData spec in dataGroup.allSpecialParts)
                    {
                        if (spec.name == (string)element[1])
                        {
                            part = spec;
                            found = true;
                            continue;
                        }
                    }

                    if (found == false)
                    {
                        dataGroup.allSpecialParts.Add(part);
                    }

                    dataGroup.groupedParts[dataGroup.groupedParts.Count - 1].addSpecialDetail(part);
                }
            }

            return dataGroup;
        }

        //if (checkForDrawingSpecial(element.fullName, drawings))
        //{
        //    element.status = 4;
        //}
        //else if (checkForDrawing(element.fullName, drawings))
        //{
        //    element.status = 1;
        //}
        //else
        //{
        //    if (element.set)
        //    {
        //        element.status = 2;
        //    }
        //    else
        //    {
        //        element.status = 3;
        //    }
        //}


        //if (element.specialDetails.Count > 0)
        //{
        //    analyzeData(element.specialDetails, drawings);
        //}

        public static bool checkForDrawing(string elementName, List<string> drawings)
        {
            if (drawings.Contains(elementName))
            {
                return true;
            }
            return false;
        }

    }
}
