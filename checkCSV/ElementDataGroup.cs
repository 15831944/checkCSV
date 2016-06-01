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
        public List<string> _rawPDF;
        public List<string> _rawDWG;

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
            _rawPDF = pdf;
            _rawDWG = dwg;

            _pdfNotFound = new List<string>();
            _pdfFound = new List<string>();
            _dwgNotFound = new List<string>();
            _dwgFound = new List<string>();
        }

        public ElementDataGroup()
        {
            allMainParts = new List<ElementData>();
            allSpecialParts = new List<ElementData>();
            allParts = new List<ElementData>();

            _raw = new List<ArrayList>();
            _rawPDF = new List<string>();
            _rawDWG = new List<string>();

            _pdfNotFound = new List<string>();
            _pdfFound = new List<string>();
            _dwgNotFound = new List<string>();
            _dwgFound = new List<string>();
        }


        public string findNewerPath(string newPath, string oldPath)
        {
            DateTime oldTime = File.GetCreationTime(oldPath);
            DateTime newTime = File.GetCreationTime(newPath);

            if (newTime > oldTime)
            {
                return newPath;
            }
            else
            {
                return oldPath;
            }
        }

        public bool uniquePath(string path, List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (Path.GetFileNameWithoutExtension(path) == Path.GetFileNameWithoutExtension(list[i]))
                {
                    list[i] = findNewerPath(list[i], path);
                    return false;
                }
            }

            return true;
        }

        public void buildData()
        {
            foreach (string rawPath in _rawPDF)
            {
                bool unique = uniquePath(rawPath, _pdfNotFound);
                if (unique)
                {
                    _pdfNotFound.Add(rawPath);
                }
            }

            foreach (string rawPath in _rawDWG)
            {
                bool unique = uniquePath(rawPath, _dwgNotFound);
                if (unique)
                {
                    _dwgNotFound.Add(rawPath);
                }
            }

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

        public void findDrawingHandler(string drawingType)
        {
            foreach (ElementData main in allMainParts)
            {
                findDrawings(main, drawingType);
            }

            foreach (ElementData special in allSpecialParts)
            {
                findDrawings(special, drawingType);
            }

            foreach (ElementData part in allParts)
            {
                part.setStatus(drawingType);
            }

            if (drawingType.Contains("PDF"))
            {
                foreach (string path in _pdfNotFound)
                {
                    ElementData drawingNotFound = new ElementData(path);
                    allParts.Add(drawingNotFound);
                    allMainParts.Add(drawingNotFound);
                }
            }

            else if (drawingType.Contains("DWG"))
            {
                foreach (string path in _dwgNotFound)
                {
                    ElementData drawingNotFound = new ElementData(path);
                    allParts.Add(drawingNotFound);
                    allMainParts.Add(drawingNotFound);
                }
            }

        }

        public void findDrawings(ElementData part, string drawingType)
        {
            if (drawingType.Contains("PDF"))
            {
                findDrawingLogic(part, ref _pdfNotFound, ref _pdfFound);
            }
            if (drawingType.Contains("DWG"))
            {
                findDrawingLogic(part, ref _dwgNotFound, ref _dwgFound);
            }

        }

        public void findDrawingLogic(ElementData part, ref List<string> NotFound, ref List<string> Found)
        {
            bool found = findDrawingLoopLogic(part, ref NotFound, ref Found);

            if (found == false)
            {
                List<String> empty = new List<string>();
                bool foundCopy = findDrawingLoopLogic(part, ref Found, ref empty, false);
                if (foundCopy == true)
                {
                    part.hasCopy = true;
                }
            }
        }

        public bool findDrawingLoopLogic(ElementData part, ref List<string> NotFound, ref List<string> Found, bool remove = true)
        {
            for (int i = NotFound.Count - 1; i >= 0; i--)
            {
                if (part.fullName == Path.GetFileNameWithoutExtension(NotFound[i]))
                {
                    string drawing = NotFound[i];
                    part.setDrawing(drawing);
                    Found.Add(drawing);
                    if (remove) NotFound.RemoveAt(i);

                    return true;
                }
            }

            return false;
        }
    }
}
;