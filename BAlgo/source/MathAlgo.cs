namespace BAlgo;

public static class MathAlgo{
    
    //Calculates the greatest common divisor of two numbers.
    public static int EuclidsAlogrithm(int a, int b){
        int r = a % b;
        if(r == 0){
            return b;
        }
        else{
            return EuclidsAlogrithm(b, r);
        }
    }

    public static HashSet<int> DixonsFactors(int x){
        int[] factorBase= [2, 3, 5, 7];

        int start = (int)Math.Sqrt(x);

        List<int []> pairs = new();

        int length = factorBase.Length;
        for(int i = start; i < x; i++){
            for(int j = 0; j < factorBase.Length; j++){
                int lhs = ((int) Math.Pow(i, 2)) % x;
                int rhs = ((int)Math.Pow(factorBase[j], 2)) % x;

                if(lhs == rhs){
                    pairs.Add([i, factorBase[j]]);
                }


            }
        }

        List<int> newvec = new();
        for(int i = 0; i < pairs.Count; i++){
            int factor = EuclidsAlogrithm(pairs[i][0] - pairs[i][1], x);

            if(factor != 1){
                newvec.Add(factor);
            }
        }

        HashSet<int> s = [.. newvec];

        return s;
    }

    
}
