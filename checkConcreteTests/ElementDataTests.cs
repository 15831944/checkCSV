using Microsoft.VisualStudio.TestTools.UnitTesting;
using checkCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace checkCSV.Tests
{
    [TestClass()]
    public class ElementDataTests
    {
        [TestMethod()]
        public void setStatus_PDF_OK_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = true;
            tested.pdfPath = "ABC";
            tested.setStatus("PDF");

            int expected = 1;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_DWG_OK_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = true;
            tested.dwgPath = "ABC";
            tested.setStatus("DWG");

            int expected = 1;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_PDF_DWG_OK_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = true;
            tested.dwgPath = "ABC";
            tested.pdfPath = "ABC";
            tested.setStatus("PDF_DWG");

            int expected = 1;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_PDF_MISSING_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = true;
            tested.pdfPath = String.Empty;
            tested.setStatus("PDF_DWG");

            int expected = 2;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_PDF_MISSING_2_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = true;
            tested.pdfPath = String.Empty;
            tested.dwgPath = "ABC";
            tested.setStatus("PDF_DWG");

            int expected = 2;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_PDF_MISSING_3_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = true;
            tested.pdfPath = String.Empty;
            tested.dwgPath = "ABC";
            tested.setStatus("PDF");

            int expected = 2;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void setStatus_DWG_MISSING_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = true;
            tested.dwgPath = String.Empty;
            tested.setStatus("PDF_DWG");

            int expected = 2;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_DWG_MISSING_2_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = true;
            tested.dwgPath = String.Empty;
            tested.pdfPath = "ABC";
            tested.setStatus("PDF_DWG");

            int expected = 2;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_DWG_MISSING_3_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = true;
            tested.dwgPath = String.Empty;
            tested.pdfPath = "ABC";
            tested.setStatus("DWG");

            int expected = 2;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_PDF_DWG_MISSING_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = true;
            tested.dwgPath = String.Empty;
            tested.pdfPath = String.Empty;
            tested.setStatus("PDF_DWG");

            int expected = 2;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_HASCOPY_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = true;
            tested.hasCopy = true;
            tested.dwgPath = String.Empty;
            tested.pdfPath = String.Empty;
            tested.setStatus("PDF_DWG");

            int expected = 5;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_NOT_SET_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = false;
            tested.dwgPath = String.Empty;
            tested.pdfPath = String.Empty;
            tested.setStatus("PDF_DWG");

            int expected = 3;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_NOT_SET_HAS_DRAWING_PDF_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = false;
            tested.dwgPath = String.Empty;
            tested.pdfPath = "ABC";
            tested.setStatus("PDF_DWG");

            int expected = 4;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setStatus_NOT_SET_HAS_DRAWING_DWG_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = false;
            tested.dwgPath = "ABC";
            tested.pdfPath = String.Empty;
            tested.setStatus("PDF_DWG");

            int expected = 4;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void setStatus_NOT_SET_HAS_DRAWING_PDF_DWG_Test()
        {
            ElementData tested = new ElementData("a", "b", "c");
            tested.set = false;
            tested.dwgPath = "ABC";
            tested.pdfPath = "ABC";
            tested.setStatus("PDF_DWG");

            int expected = 4;
            int actual = tested.status;
            Assert.AreEqual(expected, actual);
        }
    }
}