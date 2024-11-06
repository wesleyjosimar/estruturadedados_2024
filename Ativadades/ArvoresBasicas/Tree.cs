namespace ArvoresBasicas
{
    public class Tree<T>
    {
        public Node<T>? Root { get; set; }
        public void PrintTree(Node<T> node)
        {
             int height = 1;
             Console.WriteLine($"Level: {height}");
             Console.WriteLine($"Node: {node.Data}");
             Console.WriteLine();
             if(node.Children!.Count() > 0) 
             {
                foreach(var i in node.Children!)
                PrintTree(i);
             }
        }

    }
}