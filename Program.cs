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

        Console.WriteLine("Before adding 'G'");
        for(int i=0; i<tree.GetLength(); i++)
        {
            Console.WriteLine(tree.Get(i));
        }

        tree.AddSibling(1, 'G');

        Console.WriteLine("After adding 'G'");
        for(int i=0; i<tree.GetLength(); i++)
        {
            Console.WriteLine(tree.Get(i));
        }
    }
}