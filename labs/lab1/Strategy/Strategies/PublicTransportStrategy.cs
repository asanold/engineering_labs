using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Strategy.Strategies
{
    class PublicTransportStrategy : IRouteStrategy
    {
        string type = "Public Transport";

        public string BuildRoute(string A, string B)
        {
            return type + " " + A + " " + B;
        }
    }
}
