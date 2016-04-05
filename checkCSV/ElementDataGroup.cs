using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace checkCSV
{
    class ElementDataGroup
    {
        public int total;
        public int status_ok;
        public int status_missing;
        public int status_not_set;
        public int status_not_set_has_drawing;

        public List<ElementData> allMainParts;
        public List<ElementData> allSpecialParts;
        public List<ElementData> allParts;
        public List<string> _drawings;

        public ElementDataGroup()
        {
            allMainParts = new List<ElementData>();
            allSpecialParts = new List<ElementData>();
            allParts = new List<ElementData>();
        }

        public void buildData(List<ArrayList> raw, List<string> drawings)
        {
            _drawings = drawings;

            foreach (ArrayList element in raw)
            {
                if ((bool)element[0] == true)
                {
                    ElementData part = new ElementData((string)element[1], (string)element[2], (string)element[3]);
                    this.allMainParts.Add(part);
                    this.allParts.Add(part);
                }
                else
                {
                    ElementData part;
                    bool found = false;

                    foreach (ElementData spec in this.allSpecialParts)
                    {
                        if (spec.name == (string)element[1])
                        {
                            part = spec; // known special part
                            part.addMainPart(this.allMainParts[this.allMainParts.Count - 1]); //add main part to special parts sublist
                            this.allMainParts[this.allMainParts.Count - 1].addSpecialDetail(part); //add special part to main parts sublist
                            found = true;
                            break;
                        }
                    }

                    if (found == false)
                    {
                        part = new ElementData((string)element[1], (string)element[2], (string)element[3]);
                        this.allSpecialParts.Add(part); //add new special part
                        part.addMainPart(this.allMainParts[this.allMainParts.Count - 1]); //add main part to special parts sublist
                        this.allMainParts[this.allMainParts.Count - 1].addSpecialDetail(part); //add special part to main parts sublist

                        this.allParts.Add(part); // add special part to "all" list

                    }
                }
            }
        }

        public void findDrawings()
        {
            total = allMainParts.Count + allSpecialParts.Count;
            status_ok = 0;
            status_missing = 0;
            status_not_set = 0;
            status_not_set_has_drawing = 0;

            foreach (ElementData main in allMainParts)
            {
                setStatusLogic(main);

                if (main.set == true)
                {
                    foreach (ElementData special in main.specialDetails)
                    {
                        special.set = true;
                    }
                }
            }

            foreach (ElementData special in allSpecialParts)
            {
                setStatusLogic(special);
            }
        }

        public void setStatusLogic(ElementData part)
        {
            foreach (string drawing in _drawings)
            {
                if (part.fullName == Path.GetFileNameWithoutExtension(drawing))
                {
                    if (part.set == true)
                    {
                        part.setStatus(1); status_ok++;
                    }
                    else
                    {
                        part.setStatus(4); status_not_set_has_drawing++;
                    }

                    part.setDrawing(drawing);
                    break;
                }
            }

            if (part.set == true)
            {
                if (part.status != 1)
                {
                    part.setStatus(2); status_missing++;
                }
            }
            else
            {
                if (part.status != 4)
                {
                    part.setStatus(3); status_not_set++;
                }
            }
        }
    }
} 
