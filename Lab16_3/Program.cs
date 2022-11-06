using System.ComponentModel.Design;
using System.IO.Compression;

namespace Lab16_3
{
    internal class Programs
    {
        public static void Main(string[] args)
        {
            var tree = new Node<int>(11);
            // tree.AddElem(new MenuElem("aame1", 31));
            // tree.AddElem(new MenuElem("bame1", 51));
            // tree.AddElem(new MenuElem("came1", 21));
            tree.AddElem(6);
            tree.AddElem(4);
            tree.AddElem(2);
            Del<int>.DeleteRoot(tree);
            tree.PrintTree();
        }
    }
}