using SortingAlgorithms;

namespace T107.DataStructuresAndAlgorithms
{
    public static class HelperMethods
    {
        public enum SortAlgorithm
        {
            BubbleSort, BogoSort, SleepSort, SelectionSort, InsertionSort, ShellSort
        }
        public static void Sort(this int[] myArray, SortAlgorithm sa)
        {
            var sortType = new SortingAlgorithm();
            switch (sa)
            {
                case SortAlgorithm.BubbleSort:
                    var arr = sortType.BubbleSort(myArray);
                    sortType.Traverse(arr);
                    break;
                case SortAlgorithm.BogoSort:
                    sortType.BogoSort(myArray);
                    break;
                case SortAlgorithm.SleepSort:
                    sortType.SleepSort(myArray);
                    break;
                case SortAlgorithm.SelectionSort:
                    sortType.SelectionSort(myArray);
                    break;
                case SortAlgorithm.InsertionSort:
                    sortType.InsertionSort(myArray);
                    break;
                case SortAlgorithm.ShellSort:
                    sortType.SelectionSort(myArray);
                    break;
            }
        }
    }

}