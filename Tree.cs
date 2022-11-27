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

    private Node<T> GetNode(int index, Node<T> startPtr = null, Node<T> parentPtr = null)
    {
        Node<T> ptr;
        if(startPtr == null)
        {
            ptr = this.root;
        }
        else
        {
            ptr = startPtr;
        }

        if(index > 0)
        {
            if(ptr.Child() != null)
            {
                return this.GetNode(index-1, ptr.Child(), ptr);
            }
            else if(ptr.Next() != null)
            {
                return this.GetNode(index-1, ptr.Next(), ptr);
            }
            else
            {
                return this.GetNode(index-1, ptr.Next());
            }
        }
        else
        {
            return ptr;
        }
    }
}