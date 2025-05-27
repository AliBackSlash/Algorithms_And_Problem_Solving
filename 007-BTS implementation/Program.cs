
class BinarySearchTreeNode<T> where T : IComparable<T>
{
    public T Value { get; set; }
    public BinarySearchTreeNode<T>? Left { get; set; }
    public BinarySearchTreeNode<T>? Right { get; set; }

    public BinarySearchTreeNode(T Value)
    {
        this.Value = Value;
        Left = null;
        Right = null;
    }

   
}

class BinarySearchTree<T> where T : IComparable<T>
{
    public BinarySearchTreeNode<T>? root {  get; private set; }
    public BinarySearchTree()
    {
        root = null;
    }

   
    public void Insert(T value)
    {
       root = Insert(root, value);
    }

    private BinarySearchTreeNode<T> Insert(BinarySearchTreeNode<T> node,T value)
    {
        if(node == null)
        {
           return new BinarySearchTreeNode<T>(value);
        }

        else if (value.CompareTo(node.Value) < 0)
            node.Left = Insert(node.Left!, value);

        else if (value.CompareTo(node.Value) > 0)
             node.Right = Insert(node.Right!, value);

        return node;
    }
    public bool Search(T value)
    {
        return Find(root, value) != null;
    }
    BinarySearchTreeNode<T>? Find(BinarySearchTreeNode<T>? node, T value)
    {
        if(node == null || value.Equals(node.Value))
            return node;

       if (value.CompareTo(node.Value) < 0)
            return Find(node.Left!, value);
        else
            return Find(node.Right!, value);
        
    }
    public void Print()
    {
        PrintTree(root, 0);
    }
    private void PrintTree(BinarySearchTreeNode<T>? root, int space)
    {
        int COUNT = 10;  // Distance between levels
        if (root == null)
            return;

        space += COUNT;
        PrintTree(root.Right, space);

        Console.WriteLine();
        for (int i = COUNT; i < space; i++)
            Console.Write(" ");
        Console.WriteLine(root.Value);
        PrintTree(root.Left, space);
    }

    void PreOrderTraversal(BinarySearchTreeNode<T>? node)
    {
        /*
          PreOrder Traversal visits the current node before its child nodes. 
          The process for PreOrder Traversal is as follows:

             - Visit the current node.
             - Recursively perform PreOrder Traversal of the left subtree.
             - Recursively perform PreOrder Traversal of the right subtree.
        */

        if (node != null)
        {
            Console.Write(node.Value + " ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }
    }

    public void PreOrder()
    {
        PreOrderTraversal(root);
        Console.WriteLine();
    }

    void PostOrderTraversal(BinarySearchTreeNode<T>? node)
    {
        if (node != null)
        {
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Value + " ");
        }
    }

    public void PostOrder()
    {
        PostOrderTraversal(root);
        Console.WriteLine();
    }
    void LevelOrderTraversal(BinarySearchTreeNode<T>? node)
    {
        if (node == null) return;

        Queue<BinarySearchTreeNode<T>> nodes = new Queue<BinarySearchTreeNode<T>>();
        nodes.Enqueue(node);

        while (nodes.Count > 0)
        {
            var CurrentNode = nodes.Dequeue();
            Console.Write(CurrentNode.Value + " ");

            if (CurrentNode.Left != null)
                nodes.Enqueue(CurrentNode.Left);

            if (CurrentNode.Right != null)
                nodes.Enqueue(CurrentNode.Right);
        }
    }

    public void LevelOrder()
    {
        LevelOrderTraversal(root);
        Console.WriteLine();
    }
    void InOrderTraversal(BinarySearchTreeNode<T>? node)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.Right);
        }
    }

    public void InOrder()
    {
        InOrderTraversal(root);
        Console.WriteLine();
    }

   
    
}
internal class Program
{
    private static void Main(string[] args)
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(45);
        bst.Insert(15);
        bst.Insert(79);
        bst.Insert(90);
        bst.Insert(10);
        bst.Insert(55);
        bst.Insert(12);
        bst.Insert(20);
        bst.Insert(50);
        bst.Print();

        if(bst.Search(10))
        {
            Console.WriteLine("Found");

        }
        else
            Console.WriteLine("Not Found");

        Console.WriteLine("\nInOrder Traversal:");
        bst.InOrder();

        Console.WriteLine("\nPreOrder Traversal:");
        bst.PreOrder();

        Console.WriteLine("\nPostOrder Traversal:");
        bst.PostOrder();
        
        Console.WriteLine("\nLevelOrder Traversal:");
        bst.LevelOrder();


    }
}
