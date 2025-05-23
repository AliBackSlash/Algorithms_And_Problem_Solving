internal class Program
{

    /*General Tree Implementation
     * 
     * public class TreeNode<T>
     {
         public T value;

         public List<TreeNode<T>> children;

         public TreeNode(T value)
         {
             this.value = value;
             children = new List<TreeNode<T>>();
         }

         public void AddChild(TreeNode<T> child)
         {
             this.children.Add(child);
         }

         public TreeNode<T>? Find(T value)
         {
             return FindNode(this,value);
         }

         public static TreeNode<T>? FindNode(TreeNode<T> node, T Value)
         {
             if (EqualityComparer<T>.Default.Equals(node.value, Value))
                 return node;

             foreach (var child in node.children)
             {
                var found =  child.Find(Value);

                 if (found != null) 
                     return found;
             }
             return null;
         }
     }

     public class  Tree<T>
     {
         public TreeNode<T> root;

         public Tree(T value)
         {
             root = new TreeNode<T>(value);

         }

         public void Print()
         {
             PrintTree(root);
         }

         public static void PrintTree(TreeNode<T> node,string intent = "")
         {
             Console.WriteLine(intent + node.value);
             foreach (var child in node.children)
             {
                 PrintTree(child, intent + "  ");
             }
         }

         public TreeNode<T>? Find(T value)
         {
             return root.Find(value);
         }

     }*/

    class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T>? Left { get; set; }
        public BinaryTreeNode<T>? Right { get; set; }

        public BinaryTreeNode(T Value)
        {
            this.Value = Value;
            Left = null;
            Right = null;
        }


    }

    class BinaryTree<T>
    {
        public BinaryTreeNode<T>? root;
        public BinaryTree()
        {
            root = null;
        }

        /// <summary>
        /// it will using insertion order strategy to insert elements
        /// </summary>
        public void Insert(T value)
        {
            var newNode = new BinaryTreeNode<T>(value);
            if (root == null)
            {
                root = newNode;
                return;
            }

            Queue<BinaryTreeNode<T>> QueueNodes = new Queue<BinaryTreeNode<T>>();
            QueueNodes.Enqueue(root);

            while (QueueNodes.Count > 0)
            {
                var currentNode = QueueNodes.Dequeue();

                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                    break;
                }
                else
                    QueueNodes.Enqueue(currentNode.Left);

                if (currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                    break;
                }
                else 
                    QueueNodes.Enqueue(currentNode.Right);
            }



        }

        void Print(BinaryTreeNode<T>? node, string indent, bool isLeft)
        {
            if (node == null) return;

            Console.WriteLine(indent + (isLeft ? "├── " : "└── ") + node.Value);
            indent += isLeft ? "│   " : "    ";
            if (node.Left != null || node.Right != null)
            {
                Print(node.Left, indent, true);
                Print(node.Right, indent, false);
            }
        }
        public void PrintTree()
        {

            if (root == null)
            {
                Console.WriteLine("<empty tree>");
                return;
            }
            Console.WriteLine(root.Value);
            Print(root.Left, "", true);
            Print(root.Right, "", false);
            // Replace the Print and PrintTree methods in BinaryTree<T> with the following:

            void PrintPyramid(BinaryTreeNode<T>? node, int level, int pos, Dictionary<int, List<(int, T)>> levels)
            {
                if (node == null) return;
                if (!levels.ContainsKey(level))
                    levels[level] = new List<(int, T)>();
                levels[level].Add((pos, node.Value));
                PrintPyramid(node.Left, level + 1, pos * 2, levels);
                PrintPyramid(node.Right, level + 1, pos * 2 + 1, levels);
            }

           
    }

        void PreOrderTraversal(BinaryTreeNode<T>? node)
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

        void PostOrderTraversal(BinaryTreeNode<T>? node)
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
        void LevelOrderTraversal(BinaryTreeNode<T>? node)
        {
           if(node == null) return;

           Queue<BinaryTreeNode<T>> nodes = new Queue<BinaryTreeNode<T>>();
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
        void InOrderTraversal(BinaryTreeNode<T>? node)
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


    private static void Main(string[] args)
    {
        /*//General Tree
         * var Child_1 = new TreeNode<string>("Mohammed"); 
        var Child_2 = new TreeNode<string>("Galal"); 
        var Child_3 = new TreeNode<string>("Adel"); 
        var Child_4 = new TreeNode<string>("Housni"); 
        var Child_5 = new TreeNode<string>("Elsaied");
        var Child_6 = new TreeNode<string>("Adria");
        var Child_7 = new TreeNode<string>("Karima");
        var Child_8 = new TreeNode<string>("Om-Mohammed");

        Tree<string> Root = new Tree<string>("Ali");

        Root.root.AddChild(Child_1);
        Root.root.AddChild(Child_2);
        Root.root.AddChild(Child_3);
        Root.root.AddChild(Child_4);
        Root.root.AddChild(Child_5);
        Root.root.AddChild(Child_6);
        Root.root.AddChild(Child_7);
        Root.root.AddChild(Child_8);

        Child_1.AddChild(new TreeNode<string>("Tarek"));
        Child_1.AddChild(new TreeNode<string>("Mohammed"));
        Child_1.AddChild(new TreeNode<string>("Zainb"));
        Child_1.AddChild(new TreeNode<string>("Adria"));
        Child_1.AddChild(new TreeNode<string>("Karima"));
        Child_1.AddChild(new TreeNode<string>("Rasha"));

        Child_3.AddChild(new TreeNode<string>("Ahmed"));
        Child_3.AddChild(new TreeNode<string>("Mohammed"));
        Child_3.AddChild(new TreeNode<string>("Amal"));

        Child_4.AddChild(new TreeNode<string>("Abdo"));
        Child_4.AddChild(new TreeNode<string>("Mohammed"));
        Child_4.AddChild(new TreeNode<string>("Eimaan"));
        
        Child_5.AddChild(new TreeNode<string>("Aya"));
        Child_5.AddChild(new TreeNode<string>("Ahmed"));
        Child_5.AddChild(new TreeNode<string>("Ali"));
        Child_5.AddChild(new TreeNode<string>("Remas"));
        Child_5.AddChild(new TreeNode<string>("Fares"));
        
        
        Child_8.AddChild(new TreeNode<string>("Noha"));
        Child_8.AddChild(new TreeNode<string>("Soha"));
        Child_8.AddChild(new TreeNode<string>("Ola"));
        Child_8.AddChild(new TreeNode<string>("Abdeldaim"));
        Child_8.AddChild(new TreeNode<string>("hamed"));


        Root.Print();

        if (Root.Find("Zainb") != null)
            Console.WriteLine("Found");
        else
            Console.WriteLine("Not Found");*/

        BinaryTree<int> root = new BinaryTree<int>();

        root.Insert(0);
        root.Insert(1);
        root.Insert(2);
        root.Insert(3);
        root.Insert(4);
        root.Insert(5);
        root.Insert(6);
        root.Insert(7);
        root.Insert(8);
        root.Insert(9);
        root.Insert(10);
        root.Insert(11);
        root.Insert(12);
        root.Insert(13);
        root.Insert(14);


        root.PrintTree();
        Console.WriteLine("Print in Pre-Order");
        root.PreOrder();

        Console.WriteLine("Print in Post Order");
        root.PostOrder();
        
        Console.WriteLine("Print in In Order");
        root.InOrder();
     
        Console.WriteLine("Print in Level Order");
        root.LevelOrder();
    }
   
}