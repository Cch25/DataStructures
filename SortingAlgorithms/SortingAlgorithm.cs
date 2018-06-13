using System;
using System.Linq;
using System.Threading;

namespace SortingAlgorithms
{
    public class SortingAlgorithm
    {
        #region Bubble Sort
        public int[] BubbleSort(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        Swap(ref myArray[i], ref myArray[j]);
                    }
                }
            }
            return myArray;
        }

        #endregion

        #region Bogo Sort
        private bool IsSorted(int[] myArray)
        {
            for (int i = 0; i < myArray.Length - 1; i++)
                if (myArray[i] > myArray[i + 1])
                    return false;
            return true;
        }

        private void Shuffle(int[] myArray)
        {
            var rnd = new Random();
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                //change index with a random value position
                Swap(myArray, i, rnd.Next(0, myArray.Length - 1));
            }
        }
        public void BogoSort(int[] myArray)
        {
            int loopCount = 0;
            while (!IsSorted(myArray))
            {
                ++loopCount;
                Shuffle(myArray);
            }
            Console.WriteLine($"Steps took for bogo sort {loopCount}");
            Traverse(myArray);
        }

        #endregion

        #region Sleep Sort
        public void SleepSort(int[] myArray)
        {
            myArray
                .AsParallel()
                .WithDegreeOfParallelism(myArray.Length)
                .ForAll(x =>
                {
                    Thread.Sleep(x * 100);
                    Console.Write($"{x} ");
                });
            Console.WriteLine();
        }
        #endregion

        #region Selection Sort
        public void SelectionSort(int[] myarray)
        {
            for (int i = 0; i < myarray.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < myarray.Length; j++)
                {
                    if (myarray[j] < myarray[i])
                        index = j;
                }
                if (index != i)
                    Swap(myarray, i, index);
            }
            Traverse(myarray);
        }
        #endregion

        #region Insertion Sort
        public void InsertionSort(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; ++i)
            {
                int j = i;
                while (j > 0 && (myArray[j - 1] > myArray[j]))
                {
                    Swap(myArray, j, j - 1);
                    --j;
                }
            }
            Traverse(myArray);
        }
        #endregion
        
        #region Shell Sort
        public void ShellSort(int[] myArray)
        {
            for (int gap = myArray.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < myArray.Length; i++)
                {
                    int j = i;
                    while (j > 0 && myArray[j - 1] > myArray[j])
                    {
                        Swap(myArray, j, j - gap);
                        j = j - gap;
                    }
                }
            }
            Traverse(myArray);
        }
        #endregion

        #region Quick Sort

        #endregion

        #region Merge Sort

        #endregion

        #region Counting Sort

        #endregion

        #region Radix Sort

        #endregion

        #region Helper methods
        private void Swap(ref int x, ref int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }
        private void Swap(int[] myArray, int i, int j)
        {
            int temp = myArray[i];
            myArray[i] = myArray[j];
            myArray[j] = temp;
        }
        public void Traverse(int[] sortedArray)
        {
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
