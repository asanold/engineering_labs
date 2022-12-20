using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iterator
            Iterator.Aggregate_C1 agg = new Iterator.Aggregate_C1(
                new int[3] { 1, 2, 3});
            Iterator.Reader reader = new Iterator.Reader();
            reader.Read<Iterator.Iterator1>(agg);

            Console.WriteLine();


            //Visitor
            Visitor.Boss boss = new Visitor.Boss(
                new List<Visitor.IElement>()
                {
                    new Visitor.ElementA("NameA"),
                    new Visitor.ElementB("NameB", "smthB"),
                }
                );
            Visitor.ConcreteVisitor1 visitor = new Visitor.ConcreteVisitor1();
            boss.Visit(visitor);

            Console.ReadKey();
            Console.ReadKey();


            //Iterator + Breadth-first iterator
            Iterator.Tree.Node tree = new Iterator.Tree.Node(1);
            tree.Child = new Iterator.Tree.Node(2);
            tree.Child.Child = new Iterator.Tree.Node(3);
            tree.Child.Child.Right = new Iterator.Tree.Node(4);
            tree.Child.Right = new Iterator.Tree.Node(5);
            tree.Child.Right.Child = new Iterator.Tree.Node(6);
            tree.Child.Right.Child.Right = new Iterator.Tree.Node(7);
            Iterator.Tree.BFI<int> bfi = new Iterator.Tree.BFI<int>(tree);

            Console.WriteLine("While\n");
            while (bfi.HasNext())
            {
                bfi.MoveNext();
                Console.WriteLine(((Iterator.Tree.Node)bfi.Current).Value);
            }

            Console.ReadKey();
        }
    }
}
