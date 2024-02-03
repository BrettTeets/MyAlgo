namespace BAlgo;

public class TreeNode<T> where T: IComparable{
    T data;
    TreeNode<T>? Left;
    TreeNode<T>? Right;

    public TreeNode(T a){
        data = a;
        Left = null;
        Right = null;
    }

    public void Add(T x){
        if(x.CompareTo(data) < 0){
            if(Left is not null){
                Left.Add(x);
            }
            else{
                Left = new TreeNode<T>(x);
            }
        }
        else{
            if(Right is not null){
                Right.Add(x);
            }
            else{
                Right = new TreeNode<T>(x);
            }
        }
    }

    public override string ToString()
    {
        if(Left is null && Right is null) {
            return $"{data}";
        } 
        else if(Right is null){
            return $"{Left}, {data}";
        }
        else if(Left is null){
            return $"{data}, {Right}";
        }
        else{
            return $"{Left}, {data}, {Right}";
        }
    }
}
