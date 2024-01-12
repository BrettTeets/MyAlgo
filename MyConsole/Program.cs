using BAlgo;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Before: ");
        double[] array = [1.6, 1.9, 2.3, 8.4, 0.1, 3.2, 7.1, 6.4, 3.3, 9.9, 4.8, 4.2, 6.9, 3.1, 1.2, 7.7, 3.9];

        DebugArray(array);
        Console.WriteLine("After: ");

        QuickSort<double>.Sort(array, 0, array.Length-1);

        DebugArray(array);
    }

    private static void DebugArray<T>(T[] array){
        foreach(T o in array){
            if(o is not null) Console.Write(o.ToString() + " ");
        }
    }
}