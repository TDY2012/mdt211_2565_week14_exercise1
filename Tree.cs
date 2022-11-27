class Tree<T> where T : struct
{
    private Node<T> root = null;
    private int length = 0;

    public void AddSibling(int index, T value)
    {
        Node<T> node = new Node<T>(value);
        Node<T> ptr = this.GetNode(index);
        node.SetNext(ptr.Next());
        ptr.SetNext(node);
        this.length++;
    }

    public void AddChild(int index, T value)
    {
        Node<T> node = new Node<T>(value);
        if(index == -1)
        {
            node.SetChild(this.root);
            this.root = node;
        }
        else
        {
            Node<T> ptr = this.GetNode(index);
            node.SetChild(ptr.Child());
            ptr.SetChild(node);
        }
        this.length++;
    }

    public int GetLength()
    {
        return this.length;
    }

    public T Get(int index)
    {
        Node<T> ptr = this.GetNode(index);
        return ptr.GetValue();
    }

    private Node<T> GetNode(int index)
    {
        int traverseStep = index;
        return this.Traverse(this.root, ref traverseStep);
    }

    private Node<T> Traverse(Node<T> currentNode, ref int traverseStep)
    {
        Node<T> ptr = currentNode;

        if(traverseStep > 0 && currentNode.Child() != null)
        {
            traverseStep--;
            ptr = this.Traverse(currentNode.Child(), ref traverseStep);
        }

        if(traverseStep > 0 && currentNode.Next() != null)
        {
            traverseStep--;
            ptr = this.Traverse(currentNode.Next(), ref traverseStep);
        }

        return ptr;
    }
}