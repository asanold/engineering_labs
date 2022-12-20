using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Template_Method
{
    abstract class DataMiner
    {
        public void mine()
        {
            Console.WriteLine(openFile());
            Console.WriteLine(extractData());
            Console.WriteLine(parseData());
            Console.WriteLine(closeFile());
        }

        public abstract string openFile();
        public abstract string extractData();
        public abstract string parseData();
        public abstract string closeFile();
    }
}
