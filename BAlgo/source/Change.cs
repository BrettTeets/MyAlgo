namespace BAlgo;

public static class Change{

    public static ChangeT MakeChange1(long x){
        ChangeT change = new(0,0,0,0);
        while (x > 0){
            if(x >= 25){
                x -= 25;
                change = change.AddTwentyFive();
                continue;
            }
            else if(x >= 10){
                x -= 10;
                change = change.AddTen();
                continue;
            }
            else if(x >= 5){
                x -= 5;
                change = change.AddFive();
                continue;
            }
            else{
                x -= 1;
                change = change.AddOne();
                continue;
            }
        }
        return change;
    }

    public static ChangeT? MakeChange2(long x){
        if(x < 0){
            return null;
        }
        if (x == 0){
            return new ChangeT(0, 0, 0, 0);
        }
        ChangeT? tryQuarter = MakeChange2(x - 25)?.AddTwentyFive();
        ChangeT? tryDime = MakeChange2(x - 10)?.AddTen();
        ChangeT? tryNickle = MakeChange2(x - 5)?.AddFive();
        ChangeT? tryPenny = MakeChange2(x - 1)?.AddOne();

        List<ChangeT> Correct = new();
        if(tryQuarter?.Total() == x) Correct.Add(tryQuarter);
        if(tryDime?.Total() == x) Correct.Add(tryDime);
        if(tryNickle?.Total() == x) Correct.Add(tryNickle);
        if(tryPenny?.Total() == x) Correct.Add(tryPenny);

        long c = Correct.Min(y => y.Count());
        foreach(var t in Correct){
            if (t.Count() == c){
                return t;
            }
        }
        throw new Exception();
    }

    public class ChangeT{
        long One;
        long Five;
        long Ten;
        long TwentyFive;

        public ChangeT(long one, long five, long ten, long twentyFive){
            One = one;
            Five = five;
            Ten = ten;
            TwentyFive = twentyFive;

        }

        public ChangeT AddOne() {
            return new ChangeT(One + 1, Five, Ten, TwentyFive);
        }

        public ChangeT AddFive() {
            return new ChangeT(One, Five + 1, Ten, TwentyFive);
        }

        public ChangeT AddTen() {
            return new ChangeT(One, Five, Ten + 1, TwentyFive);
        }

        public ChangeT AddTwentyFive() {
            return new ChangeT(One, Five, Ten, TwentyFive + 1);
        }

        public long Count(){
            return One + Five + Ten + TwentyFive;
        }

        public long Total(){
            return One + Five * 5 + Ten * 10 + TwentyFive * 25;
        }

    }

}
