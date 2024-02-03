using BAlgo;

internal class Program
{
    private static void Main(string[] args)
    {
        TreeNode<int> tree = new TreeNode<int>(1);
        tree.Add(2);
        tree.Add(3);
        tree.Add(4);
        tree.Add(5);
        tree.Add(6);
        tree.Add(7);
        tree.Add(8);
        tree.Add(9);

        Console.WriteLine(tree.ToString());
    }

    private static void DebugArray<T>(T[] array){
        foreach(T o in array){
            if(o is not null) Console.Write(o.ToString() + " ");
        }
    }
}