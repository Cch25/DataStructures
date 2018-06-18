using System;

namespace SearchingAlgorithms
{
    public interface IAlgorithm
    {
        int Search(int[] array, int search);
    }
    public class JumpSearch : IAlgorithm
    {
        public int Search(int[] array, int search)
        {
            int n = array.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;
            while (array[Math.Min(step, n) - 1] < search)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n) return -1;
            }
            while (array[prev] < search)
            {
                prev++;
                if (prev == Math.Min(step, n))
                    return -1;
            }
            if (array[prev] == search)
                return prev;
            return -1;
        }
    }
   
    public class LinearSearch : IAlgorithm
    {

        public int Search(int[] array, int search)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == search)
                    return i;
            }
            return -1;
        }
    }
    public class BinarySearchAlgorithm : IAlgorithm
    {
        public int Search(int[] array, int search)
        {
            return BinarySearch(array, search, 0, array.Length);
        }

        private int BinarySearch(int[] array, int search, int min, int max)
        {
            if (search < array[0] || search > array[array.Length-1]) return -1;
            if (min > max) return -1;
            int mid = (min + max) / 2;
            if (array[mid] == search) return mid;
            else if (search < array[mid])
                return BinarySearch(array, search, min, mid - 1);
            else
                return BinarySearch(array, search, mid + 1, max);

        }
    }
}
