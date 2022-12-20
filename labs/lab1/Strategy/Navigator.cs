using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Strategy
{
    class Navigator
    {
        private Strategies.IRouteStrategy routeStrategy;

        public Navigator(Strategies.IRouteStrategy routeStrategy)
        {
            this.routeStrategy = routeStrategy;
        }

        public void buildRoute(string A, string B)
        {
            Console.WriteLine(routeStrategy.BuildRoute(A, B));
        }
    }
}
