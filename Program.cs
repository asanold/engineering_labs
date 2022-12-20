using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strategy
            Strategy.Navigator nav1 = new Strategy.Navigator(new Strategy.Strategies.PublicTransportStrategy());
            Strategy.Navigator nav2 = new Strategy.Navigator(new Strategy.Strategies.RoadStrategy());
            Strategy.Navigator nav3 = new Strategy.Navigator(new Strategy.Strategies.WalkingStrategy());
            nav1.buildRoute("A", "B");
            nav2.buildRoute("A", "B");
            nav3.buildRoute("A", "B");

            Console.WriteLine();

            //Template Method
            Template_Method.DataMiner dataMiner = new Template_Method.PDFDataMiner();
            dataMiner.mine();

            Console.ReadKey();
        }
    }
}
