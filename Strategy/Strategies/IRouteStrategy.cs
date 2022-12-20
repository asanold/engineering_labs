using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Strategy.Strategies
{
    interface IRouteStrategy
    {
        string BuildRoute(string A, string B);
    }
}
