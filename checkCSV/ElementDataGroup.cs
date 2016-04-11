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
        public List<string> _pdf;

        public ElementDataGroup()
        {
            allMainParts = new List<ElementData>();
            allSpecialParts = new List<ElementData>();
            allParts = new List<ElementData>();
        }

        public void buildData(List<ArrayList> raw, List<string> pdf)
        {
            _pdf = pdf;

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
            //SEDA V6IKS 2RA KAOTADA!
            total = allParts.Count;
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
            foreach (string pdf in _pdf)
            {
                if (part.fullName == Path.GetFileNameWithoutExtension(pdf))
                {
                    part.setDrawing(pdf);
                }
            }

            //SEDA V6IKS LIIGUTADA ELEMENTDATA ALLA
            if (part.set == true && part.hasDrawing())
            {
                part.setStatus(1); status_ok++;
            }
            else if (part.set == false && part.hasDrawing())
            {
                part.setStatus(4);  status_not_set_has_drawing++;
            }
            else if (part.set == true)
            {
                part.setStatus(2); status_missing++;
            }
            else
            {
                part.setStatus(3); status_not_set++;
            }
        }
    }
} 
