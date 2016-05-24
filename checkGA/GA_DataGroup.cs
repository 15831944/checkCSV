using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace checkGA
{
    class GA_DataGroup
    {
        public List<GA_Data> _allDrawings;

        public List<ArrayList> _raw;
        public List<string> _pdf;
        public List<string> _dwg;

        public GA_DataGroup(List<ArrayList> raw, List<string> pdf, List<string> dwg)
        {
            _allDrawings = new List<GA_Data>();
            _raw = raw;
            _pdf = pdf;
            _dwg = dwg;
        }

        public GA_DataGroup()
        {
            _allDrawings = new List<GA_Data>();
            _raw = new List<ArrayList>();
            _pdf = new List<string>();
            _dwg = new List<string>();
        }

        public void buildData(string revFormat)
        {
            foreach (ArrayList element in _raw)
            {
                GA_Data ga = new GA_Data((string)element[0], revFormat, (string)element[1]);
                this._allDrawings.Add(ga);
            }
        }

        public void findDrawings(string drawingType)
        {
            foreach (GA_Data ga in _allDrawings)
            {
                setStatusLogic(ga, drawingType);
                ga.setStatus(drawingType);
            }
        }

        public void setStatusLogic(GA_Data ga, string drawingType)
        {
            if (drawingType.Contains("PDF"))
            {
                for (int i = _pdf.Count - 1; i >= 0; i--)
                {
                    if (ga.fullName == Path.GetFileNameWithoutExtension(_pdf[i]))
                    {
                        ga.setPDF(_pdf[i]);
                        _pdf.RemoveAt(i);
                    }
                }
            }

            if (drawingType.Contains("DWG"))
            {
                for (int i = _dwg.Count - 1; i >= 0; i--)
                {
                    if (ga.fullName == Path.GetFileNameWithoutExtension(_dwg[i]))
                    {
                        ga.setDWG(_dwg[i]);
                        _dwg.RemoveAt(i);
                    }
                }
            }
        }
    }
} 
