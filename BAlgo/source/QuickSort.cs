using System.Security.Cryptography.X509Certificates;

namespace BAlgo;

public static class QuickSort<T> where T: IComparable
{
    private static int Partition(T[] array, int left, int right) {
        IComparable pivot = array[right];

        int swapIndex = left - 1;

        for(int currentIndex = left; currentIndex < right; currentIndex++){
            if(array[currentIndex].CompareTo(pivot) <= 0){
                swapIndex += 1;

                //Using tuples to do the swap. from c#7
                (array[currentIndex], array[swapIndex]) = (array[swapIndex], array[currentIndex]);
            }
        }

        swapIndex += 1;
        (array[right], array[swapIndex]) = (array[swapIndex], array[right]);
        return swapIndex;
    }

    public static void Sort(T[] array, int left, int right){
        if(left >= right || left < 0) return;

        int pivotIndex = Partition(array, left, right);

        Sort(array, left, pivotIndex-1);
        Sort(array, pivotIndex+1, right);
    }
}
