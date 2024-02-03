using System.Diagnostics;
using BAlgo;

internal class Program
{
    private static void Main(string[] args)
    {

        Stopwatch watch = new Stopwatch();
        watch.Start();
        for(int x = 0; x < 36; x++){
            Console.WriteLine(Fibonacci.Fib(x));
        }
        watch.Stop();
        Console.WriteLine(watch.Elapsed);

        watch = new Stopwatch();
        watch.Start();
        for(int x = 0; x < 36; x++){
            Console.WriteLine(Fibonacci.Fib2(x));
        }
        watch.Stop();
        Console.WriteLine(watch.Elapsed);

        watch = new Stopwatch();
        watch.Start();
        for(int x = 0; x < 36; x++){
            Console.WriteLine(Fibonacci.Fib3(x));
        }
        watch.Stop();
        Console.WriteLine(watch.Elapsed);
    }

    private static void DebugArray<T>(T[] array){
        foreach(T o in array){
            if(o is not null) Console.Write(o.ToString() + " ");
        }
    }
}