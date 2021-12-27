using System;

namespace ChristmasTree
{
    public class ChristmasTree<T> : IAbstractBinarySearchTree<T> where T : IComparable
    {
    public ChristmasTree() { }

    public ChristmasTree(Node<T> root)
    {
        this.Root = root;
        this.LChild = root.LChild;
        this.RChild = root.RChild;
    }
    public Node<T> Root { get; private set; }
    public Node<T>LChild { get; private set; }
    public Node<T>RChild { get; private set; }
    

    }
}
