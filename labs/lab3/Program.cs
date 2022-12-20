using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstarct Factory
            AbstractFactory.AlienHollywoodF fab1 = new AbstractFactory.AlienHollywoodF();
            AbstractFactory.DanFabricus fab2 = new AbstractFactory.DanFabricus();
            AbstractFactory.Hero hero1 = new AbstractFactory.Hero(fab1);
            AbstractFactory.Hero hero2 = new AbstractFactory.Hero(fab2);

            hero1.Shoot();
            hero1.Cast();

            hero2.Shoot();
            hero2.Cast();


            //Builder
            Console.WriteLine();
            Builder.CarpenterBrut carpenter = new Builder.CarpenterBrut();

            Builder.ChairBuilder builder1 = new Builder.WhiteChairBuilder();
            Builder.ChairBuilder builder2 = new Builder.LeatherChairBuilder();

            Builder.Chair chair1 = carpenter.Build(builder1);
            Console.WriteLine(chair1.ToString());
            Builder.Chair chair2 = carpenter.Build(builder2);
            Console.WriteLine(chair2.ToString());



            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
