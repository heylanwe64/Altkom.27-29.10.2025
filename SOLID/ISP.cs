using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    interface IExcelExporter
    {
        void ToExcel();
    }
    interface IPdfExporter
    {
        void ToPdf();
    }

    class Report : IExcelExporter, IPdfExporter
    {
        public void ToExcel()
        {
            // Implementacja eksportu do Excela
        }
        public void ToPdf()
        {
            // Implementacja eksportu do PDF
        }
    }

    class Poem : IPdfExporter
    {
        public void ToPdf()
        {
            // Implementacja eksportu do PDF
        }
    }
}
