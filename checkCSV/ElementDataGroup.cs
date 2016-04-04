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

        public List<ElementData> allMainParts;
        public List<ElementData> allSpecialParts;
        public List<ElementData> allParts;

        public ElementDataGroup()
        {
            allMainParts = new List<ElementData>();
            allSpecialParts = new List<ElementData>();
            allParts = new List<ElementData>();
        }

        public void buildData(List<ArrayList> raw)
        {
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

        public void findDrawings(List<string> drawings)
        {
            total = allMainParts.Count + allSpecialParts.Count;
            status_ok = 0;
            status_missing = 0;
            status_not_set = 0;

            foreach (ElementData main in allMainParts)
            {
                foreach (string drawing in drawings)
                {
                    if (main.fullName == Path.GetFileNameWithoutExtension(drawing))
                    {
                        if (main.set == true)
                        {
                            main.setStatus(1); status_ok++;
                        }

                        main.setDrawing(drawing);
                        break;
                    }
                }

                if (main.set == true)
                {
                    foreach (ElementData special in main.specialDetails)
                    {
                        special.set = true;
                    }

                    if (main.status != 1)
                    {
                        main.setStatus(2); status_missing++;
                    }
                }
                else
                {
                    main.setStatus(3); status_not_set++;
                }
            }

            foreach (ElementData special in allSpecialParts)
            {
                foreach (string drawing in drawings)
                {
                    if (special.fullName == Path.GetFileNameWithoutExtension(drawing))
                    {
                        if (special.set == true)
                        {
                            special.setStatus(1); status_ok++;
                        }
                        special.setDrawing(drawing);
                        break;
                    }
                }

                if (special.set == true)
                {
                    if (special.status != 1)
                    {
                        special.setStatus(2); status_missing++;
                    }
                }
                else
                {
                    special.setStatus(3); status_not_set++;
                }
            }
        }

        public bool checkForDrawing(string elementName, List<string> drawings)
        {
            if (drawings.Contains(elementName))
            {
                return true;
            }
            return false;
        }
    }
} 
