using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FilePrinter : IPrinter
    {
        private string outputFileName;

        public FilePrinter(string outputFileName)
        {
            this.outputFileName = outputFileName;
        }

        public void Print(string message)
        {
            File.WriteAllText(outputFileName, message);
        }
    }
}
