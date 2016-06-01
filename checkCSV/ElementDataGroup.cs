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
        public List<string> _pdfNotFound;
        public List<string> _pdfFound;
        public List<string> _dwgNotFound;
        public List<string> _dwgFound;

        public ElementDataGroup(List<ArrayList> raw, List<string> pdf, List<string> dwg)
        {
            allMainParts = new List<ElementData>();
            allSpecialParts = new List<ElementData>();
            allParts = new List<ElementData>();

            _raw = raw;
            _pdfNotFound = pdf;
            _pdfFound = new List<string>();
            _dwgNotFound = dwg;
            _dwgFound = new List<string>();
        }

        public ElementDataGroup()
        {
            allMainParts = new List<ElementData>();
            allSpecialParts = new List<ElementData>();
            allParts = new List<ElementData>();

            _raw = new List<ArrayList>();
            _pdfNotFound = new List<string>();
            _pdfFound = new List<string>();
            _dwgNotFound = new List<string>();
            _dwgFound = new List<string>();
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
                    bool knownSpecialPart = false;

                    foreach (ElementData spec in this.allSpecialParts)
                    {
                        if (spec.name == (string)element[1]) // dublicate special part
                        {
                            part = spec;
                            part.addMainPart(this.allMainParts[this.allMainParts.Count - 1]); //add main part to special parts sublist
                            this.allMainParts[this.allMainParts.Count - 1].addSpecialDetail(part); //add special part to main parts sublist
                            knownSpecialPart = true;
                            break;
                        }
                    }

                    if (knownSpecialPart == false) // dublicate special part
                    {
                        part = new ElementData((string)element[1], (string)element[2], (string)element[3]);
                        this.allSpecialParts.Add(part); //add new special part
                        part.addMainPart(this.allMainParts[this.allMainParts.Count - 1]); //add main part to special parts sublist
                        this.allMainParts[this.allMainParts.Count - 1].addSpecialDetail(part); //add special part to main parts sublist

                        this.allParts.Add(part); // add special part to "all" list
                    }
                }
            }

            foreach (ElementData main in allMainParts)
            {
                if (main.set == true)
                {
                    foreach (ElementData special in main.specialDetails)
                    {
                        special.set = true;
                    }
                }
            }
        }

        public void findDrawings(string drawingType)
        {
            foreach (ElementData main in allMainParts)
            {
                findDrawingLogic(main, drawingType);
            }

            foreach (ElementData special in allSpecialParts)
            {
                findDrawingLogic(special, drawingType);
            }

            foreach (ElementData part in allParts)
            {
                part.setStatus(drawingType);
            }
        }

        public void findDrawingLogic(ElementData part, string drawingType)
        {
            if (drawingType.Contains("PDF"))
            {
                bool found = findDrawingLoopLogic(part, ref _pdfNotFound, ref _pdfFound);
                if (found == false)
                {
                    List<String> empty = new List<string>();
                    bool foundCopy = findDrawingLoopLogic(part, ref _pdfFound, ref empty);
                    if (foundCopy == true)
                    {
                        part.hasCopy = true;
                    }
                }
            }
            if (drawingType.Contains("DWG"))
            {
                bool found = findDrawingLoopLogic(part, ref _dwgNotFound, ref _dwgFound);
                if (found == false)
                {
                    List<String> empty = new List<string>();
                    bool foundCopy = findDrawingLoopLogic(part, ref _dwgFound, ref empty);
                    if (foundCopy == true)
                    {
                        part.hasCopy = true;
                    }
                }
            }
        }

        public bool findDrawingLoopLogic(ElementData part, ref List<string> NotFound, ref List<string> Found)
        {
            for (int i = NotFound.Count - 1; i >= 0; i--)
            {
                if (part.fullName == Path.GetFileNameWithoutExtension(NotFound[i]))
                {
                    string drawing = NotFound[i];
                    part.setDrawing(drawing);
                    Found.Add(drawing);
                    NotFound.RemoveAt(i);

                    return true;
                }
            }

            return false;
        }
    }
}
;