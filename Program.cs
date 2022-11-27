using System;

class Program
{
    static void Main(string[] args)
    {
        Tree<char> tree = new Tree<char>();
        tree.AddChild(-1, 'A');
        tree.AddChild(0, 'B');
        tree.AddSibling(1, 'C');
        tree.AddSibling(2, 'D');
        tree.AddChild(1, 'E');
        tree.AddChild(2, 'F');

        for(int i=0; i<tree.GetLength(); i++)
        {
            Console.WriteLine(tree.Get(i));
        }
    }
}