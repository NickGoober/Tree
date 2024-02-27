namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.Add(10);
            tree.Add(15);
            tree.Add(23);
            tree.Add(3);
            tree.Add(6);
            Console.WriteLine(tree.root.data);
            tree.InOrder();
        }
    }
}