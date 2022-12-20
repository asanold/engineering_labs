using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Template_Method
{
    class PDFDataMiner : DataMiner
    {
        public override string openFile()
        {
            return "openFile";
        }

        public override string extractData()
        {
            return "extractData";
        }

        public override string parseData()
        {
            return "parseData";
        }

        public override string closeFile()
        {
            return "closeFile";
        } 
    }
}
