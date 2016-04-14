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
        public List<ElementData> allMainParts;
        public List<ElementData> allSpecialParts;
        public List<ElementData> allParts;

        public List<ArrayList> _raw;
        public List<string> _pdf;
        public List<string> _dwg;

        public ElementDataGroup(List<ArrayList> raw, List<string> pdf, List<string> dwg)
        {
            allMainParts = new List<ElementData>();
            allSpecialParts = new List<ElementData>();
            allParts = new List<ElementData>();

            _raw = raw;
            _pdf = pdf;
            _dwg = dwg;
        }

        public ElementDataGroup()
        {
            allMainParts = new List<ElementData>();
            allSpecialParts = new List<ElementData>();
            allParts = new List<ElementData>();

            _raw = new List<ArrayList>();
            _pdf = new List<string>();
            _dwg = new List<string>();
        }

        public void buildData()
        {
            foreach (ArrayList element in _raw)
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

        public void findDrawings(string drawingType)
        {
            foreach (ElementData main in allMainParts)
            {
                setStatusLogic(main, drawingType);

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
                setStatusLogic(special, drawingType);
            }

            foreach (ElementData part in allParts)
            {
                part.setStatus(drawingType);
            }
        }

        public void setStatusLogic(ElementData part, string drawingType)
        {
            if (drawingType.Contains("PDF"))
            {
                for (int i = _pdf.Count - 1; i >= 0; i--)
                {
                    if (part.fullName == Path.GetFileNameWithoutExtension(_pdf[i]))
                    {
                        part.setPDF(_pdf[i]);
                        _pdf.RemoveAt(i);
                    }
                }
            }

            if (drawingType.Contains("DWG"))
            {
                for (int i = _dwg.Count - 1; i >= 0; i--)
                {
                    if (part.fullName == Path.GetFileNameWithoutExtension(_dwg[i]))
                    {
                        part.setDWG(_dwg[i]);
                        _dwg.RemoveAt(i);
                    }
                }
            }
        }
    }
} 
