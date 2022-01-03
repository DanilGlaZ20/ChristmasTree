using System;
using System.Collections.Generic;

namespace ChristmasTree
{
    public class ChristmasTree<T> 
    {
        private T Value;
        private ChristmasTree<T> parent;
        
        private  List<ChristmasTree<T>> predok;
        private readonly List<ChristmasTree<T>> children;

        public ChristmasTree(T value, params ChristmasTree<T>[] children)
        {
            this.Value = value;
            this.children = new List<ChristmasTree<T>>();
            foreach(ChristmasTree<T> child in children)
            {
                this.children.Add(child);
            }
        }

        


        public ICollection<T> OrderBFS()
    {
        
        var result = new List<T>();
        var q = new Queue<ChristmasTree<T>>();
        q.Enqueue(this);
        while (q.Count > 0)
        {
            ChristmasTree<T> subtree = q.Dequeue();
            result.Add(subtree.Value);
            foreach(ChristmasTree<T> child in subtree.children){ q.Enqueue(child);}
        }
        return result;
    }

    public void DisplayBFS()
    {
       ChristmasTree<int> fir =
        new ChristmasTree<int>(1,
            new ChristmasTree<int>(2,
                new ChristmasTree<int>(6),
                new ChristmasTree<int>(7,
                   new ChristmasTree<int>(22),
                   new ChristmasTree<int>(23)),
                new ChristmasTree<int>(8,
                    new ChristmasTree<int>(24),
                    new ChristmasTree<int>(25),
                    new ChristmasTree<int>(26)),
                new ChristmasTree<int>(9)),
            new ChristmasTree<int>(3,
                new ChristmasTree<int>(10),
                new ChristmasTree<int>(11),
                new ChristmasTree<int>(12),
                new ChristmasTree<int>(13)),
            new ChristmasTree<int>(4,
                new ChristmasTree<int>(14),
                new ChristmasTree<int>(15,
                    new ChristmasTree<int>(27),
                    new ChristmasTree<int>(28),
                    new ChristmasTree<int>(29)),
                new ChristmasTree<int>(16,
                    new ChristmasTree<int>(30),
                    new ChristmasTree<int>(31), 
                    new ChristmasTree<int>(32)),
                new ChristmasTree<int>(17)),
            new ChristmasTree<int>(5,
                new ChristmasTree<int>(18),
                new ChristmasTree<int>(19,
                    new ChristmasTree<int>(33),
                    new ChristmasTree<int>(34),
                    new ChristmasTree<int>(35)),
                new ChristmasTree<int>(20),
                new ChristmasTree<int>(21 ,
                    new ChristmasTree<int>(36),
                    new ChristmasTree<int>(37),
                    new ChristmasTree<int>(38),
                    new ChristmasTree<int>(39),
                    new ChristmasTree<int>(40),
                    new ChristmasTree<int>(41)))
        );
        Console.Write("Поиск в ширину: ");
        foreach (var val in fir.OrderBFS())
        {
            Console.Write(Convert.ToString(val) + " ");
        }
    }
    
    }
}
