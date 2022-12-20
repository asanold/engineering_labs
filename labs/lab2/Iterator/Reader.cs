using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Iterator
{
    class Reader
    {
        public void Read<T>(IAggregate agg) where T : IIterator
        {
            IIterator iter = agg.CreateIterator<T>();
            while (iter.hasNext())
            {
                int item = (int)iter.Next();
                Console.WriteLine(item);
            }
        }
    }
}
