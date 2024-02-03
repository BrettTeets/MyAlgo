namespace BAlgo;

public class Fibonacci{

    //This is my first thought.
    public static int Fib(int x){
        if(x < 2) return x;

        int a = 0;
        int b = 1;
        while(x > 0){
            int t = b;
            b = a + b;
            a = t;
            x--;
        }
        return a;
    }

    //The naive recursive definition
    public static int Fib2(int x){
        if(x < 2) return x;
        else{
            return Fib2(x - 1) + Fib2(x - 2);
        }
    }

    //Fib using fold.
    public static int Fib3(int x){
        IEnumerable<int> range = Enumerable.Range(0, x);
        return range.Aggregate(new { Current = 1, Prev = 1 }, (x, index) => new { Current = x.Prev + x.Current, Prev = x.Current }).Current;
    }
}